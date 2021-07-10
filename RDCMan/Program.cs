using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using RdcMan.Configuration;

namespace RdcMan
{
	// Token: 0x020000F8 RID: 248
	internal class Program
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00006145 File Offset: 0x00004345
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x0000614C File Offset: 0x0000434C
		internal static MainForm TheForm { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00006154 File Offset: 0x00004354
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x0000615B File Offset: 0x0000435B
		internal static Preferences Preferences { get; private set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00006163 File Offset: 0x00004363
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x0000616A File Offset: 0x0000436A
		internal static ManualResetEvent InitializedEvent { get; private set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00006172 File Offset: 0x00004372
		internal static IEnumerable<IBuiltInVirtualGroup> BuiltInVirtualGroups
		{
			get
			{
				return Program._builtInVirtualGroups;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00006179 File Offset: 0x00004379
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00006180 File Offset: 0x00004380
		private static Dictionary<string, Program.PluginConfig> Plugins { get; set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00006188 File Offset: 0x00004388
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x0000618F File Offset: 0x0000438F
		private static PluginContext PluginContext { get; set; }

		// Token: 0x0600067D RID: 1661 RVA: 0x0001B2EC File Offset: 0x000194EC
		public static void PluginAction(Action<IPlugin> action)
		{
			Program.Plugins.Values.ForEach(delegate(Program.PluginConfig v)
			{
				IPlugin plugin = v.Plugin;
				if (plugin != null)
				{
					action(plugin);
				}
			});
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001B324 File Offset: 0x00019524
		[STAThread]
		internal static void Main(params string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			AppDomain.CurrentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs eventArgs)
			{
				string resourceName = new AssemblyName(eventArgs.Name).Name + ".dll";
				string name = Array.Find<string>(typeof(Program).Assembly.GetManifestResourceNames(), (string element) => element.EndsWith(resourceName));
				Assembly result;
				using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
				{
					byte[] array = new byte[manifestResourceStream.Length];
					manifestResourceStream.Read(array, 0, array.Length);
					result = Assembly.Load(array);
				}
				return result;
			};
			Policies.Read();
			using (Helpers.Timer("parsing command line", Array.Empty<object>()))
			{
				Program.ParseCommandLine();
			}
			try
			{
				Current.Read();
			}
			catch (Exception ex)
			{
				FormTools.ErrorDialog("Error reading RDCMan configuration file: {0} The program may not be unstable and/or not fully functional.".InvariantFormat(new object[]
				{
					ex.Message
				}));
			}
			using (CompositionContainer compositionContainer = new CompositionContainer(new AssemblyCatalog(Assembly.GetCallingAssembly()), Array.Empty<ExportProvider>()))
			{
				Program._builtInVirtualGroups.AddRange(compositionContainer.GetExportedValues<IBuiltInVirtualGroup>());
				Program._builtInVirtualGroups.Sort((IBuiltInVirtualGroup a, IBuiltInVirtualGroup b) => a.Text.CompareTo(b.Text));
			}
			using (Helpers.Timer("reading preferences", Array.Empty<object>()))
			{
				Program.Preferences = Preferences.Load();
				if (Program.Preferences == null)
				{
					Environment.Exit(1);
				}
			}
			Thread thread;
			using (Helpers.Timer("starting message loop thread", Array.Empty<object>()))
			{
				Program.InitializedEvent = new ManualResetEvent(false);
				thread = new Thread(new ThreadStart(Program.StartMessageLoop))
				{
					IsBackground = true
				};
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				Program.InitializedEvent.WaitOne();
			}
			if (Program.TheForm == null)
			{
				Environment.Exit(1);
			}
			Program.TheForm.Invoke(new MethodInvoker(Program.CompleteInitialization));
			thread.Join();
			Log.Write("Exiting", Array.Empty<object>());
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001B518 File Offset: 0x00019718
		private static void CompleteInitialization()
		{
			Program.InstantiatePlugins();
			if (Program._filesToOpen.Count > 0)
			{
				Program.Preferences.FilesToOpen = Program._filesToOpen;
			}
			else if (!Program._openFiles)
			{
				Program.Preferences.FilesToOpen = null;
			}
			List<ServerBase> connectedServers = new List<ServerBase>();
			ServerTree.Instance.Operation(OperationBehavior.SuspendSort, delegate
			{
				foreach (IBuiltInVirtualGroup builtInVirtualGroup in from @group in Program.BuiltInVirtualGroups
				where @group.IsVisibilityConfigurable
				select @group)
				{
					builtInVirtualGroup.IsInTree = Program.Preferences.GetBuiltInGroupVisibility(builtInVirtualGroup);
				}
			});
			Program.OpenFiles();
			ServerTree.Instance.Operation(OperationBehavior.SuspendGroupChanged, delegate
			{
				Program.Preferences.LoadBuiltInGroups();
				ConnectedGroup.Instance.Nodes.ForEach(delegate(TreeNode n)
				{
					connectedServers.Add(((ServerRef)n).ServerNode);
				});
				ConnectedGroup.Instance.RemoveChildren();
				ServerTree.Instance.SortBuiltinGroups();
			});
			ServerTree.Instance.Show();
			ServerTree.Instance.Focus();
			bool isFirstConnection = Program.ReconnectAtStartup(connectedServers);
			if (Program._serversToConnect != null)
			{
				Program.ConnectNamedServers(Program._serversToConnect, isFirstConnection);
			}
			if (Program.Preferences.ServerTreeVisibility != ControlVisibility.Dock)
			{
				ServerTree.Instance.Hide();
			}
			Program.PluginAction(delegate(IPlugin p)
			{
				p.PostLoad(Program.PluginContext);
			});
			Program.Preferences.NeedToSave = false;
			Program.TheForm.UpdateAutoSaveTimer();
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				Program.CheckForUpdate();
			});
			Log.Write("Startup completed", Array.Empty<object>());
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001B668 File Offset: 0x00019868
		private static bool ReconnectAtStartup(List<ServerBase> connectedServers)
		{
			IEnumerable<ServerBase> reconnectServers = Enumerable.Empty<ServerBase>();
			switch (Program._reconnectServersAtStart)
			{
			case ReconnectServerOptions.Ask:
				if (Program.Preferences.ReconnectOnStartup && connectedServers.Any<ServerBase>())
				{
					reconnectServers = new List<ServerBase>(Program.ConnectServersDialog(connectedServers));
				}
				break;
			case ReconnectServerOptions.All:
				reconnectServers = connectedServers;
				break;
			case ReconnectServerOptions.None:
				return false;
			}
			return Program.ConnectServers(reconnectServers, true);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001B6C4 File Offset: 0x000198C4
		private static void InstantiatePlugins()
		{
			Program.PluginContext = new PluginContext();
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			DirectoryCatalog catalog = new DirectoryCatalog(Path.GetDirectoryName(callingAssembly.Location), "Plugin.*.dll");
			CompositionContainer compositionContainer = new CompositionContainer(catalog, Array.Empty<ExportProvider>());
			Program.Plugins = new Dictionary<string, Program.PluginConfig>(StringComparer.OrdinalIgnoreCase);
			StringBuilder stringBuilder = new StringBuilder();
			XmlNode value = Program.Preferences.Settings.PluginSettings.Value;
			if (value != null)
			{
				foreach (object obj in value.SelectNodes("//plugin"))
				{
					XmlNode xmlNode = (XmlNode)obj;
					try
					{
						string value2 = xmlNode.Attributes["path"].Value;
						if (!string.IsNullOrEmpty(value2))
						{
							Program.PluginConfig value3 = new Program.PluginConfig
							{
								Name = value2,
								SettingsNode = xmlNode
							};
							Program.Plugins[value2] = value3;
						}
					}
					catch
					{
					}
				}
			}
			foreach (IPlugin plugin in from e in compositionContainer.GetExports<IPlugin>()
			select e.Value)
			{
				string name = plugin.GetType().Assembly.GetName().Name;
				Program.PluginConfig pluginConfig;
				if (!Program.Plugins.TryGetValue(name, out pluginConfig))
				{
					pluginConfig = new Program.PluginConfig
					{
						Name = name
					};
					Program.Plugins[name] = pluginConfig;
				}
				try
				{
					plugin.PreLoad(Program.PluginContext, pluginConfig.SettingsNode);
					pluginConfig.Plugin = plugin;
				}
				catch (Exception ex)
				{
					stringBuilder.AppendLine("Error loading '{0}': {1}".InvariantFormat(new object[]
					{
						name,
						ex.Message
					}));
				}
			}
			foreach (Program.PluginConfig pluginConfig2 in from c in Program.Plugins.Values
			where c.Plugin == null
			select c)
			{
				stringBuilder.AppendLine("'{0}' was previously used but is not loaded now".InvariantFormat(new object[]
				{
					pluginConfig2.Name
				}));
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.AppendLine().Append("Click Cancel to exit");
				string text = "Some plugins have not been loaded. RDCMan may not function as you expect.{0}{0}".InvariantFormat(new object[]
				{
					Environment.NewLine
				}) + stringBuilder.ToString();
				if (FormTools.ExclamationDialog(text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					Environment.Exit(1);
				}
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001B9B4 File Offset: 0x00019BB4
		private static void OpenFiles()
		{
			List<string> filesToOpen = Program.Preferences.FilesToOpen;
			if (filesToOpen != null)
			{
				bool flag = true;
				foreach (string filename in filesToOpen)
				{
					FileGroup fileGroup = RdgFile.OpenFile(filename);
					if (fileGroup != null && flag)
					{
						flag = false;
						ServerTree.Instance.SelectedNode = fileGroup;
					}
				}
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001BA2C File Offset: 0x00019C2C
		internal static IEnumerable<ServerBase> ConnectServersDialog(IEnumerable<ServerBase> servers)
		{
			IEnumerable<ServerBase> result;
			using (ConnectServersDialog connectServersDialog = new ConnectServersDialog(servers))
			{
				if (connectServersDialog.ShowDialog(Program.TheForm) == DialogResult.OK)
				{
					result = connectServersDialog.SelectedServers.ToList<ServerBase>();
				}
				else
				{
					result = new ServerBase[0];
				}
			}
			return result;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001BA80 File Offset: 0x00019C80
		internal static bool ConnectServers(IEnumerable<ServerBase> reconnectServers, bool isFirstConnection)
		{
			NodeHelper.ThrottledConnect(reconnectServers, delegate(ServerBase server)
			{
				if (isFirstConnection)
				{
					ServerTree.Instance.SelectedNode = server;
					server.Focus();
					isFirstConnection = false;
				}
			});
			return isFirstConnection;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		private static bool ConnectNamedServers(ICollection<string> serverNames, bool isFirstConnection)
		{
			HashSet<string> nameHash = new HashSet<string>(serverNames, StringComparer.OrdinalIgnoreCase);
			List<ServerBase> serversToConnect = new List<ServerBase>();
			ServerTree.Instance.Nodes.VisitNodes(delegate(RdcTreeNode node)
			{
				Server server = node as Server;
				if (server != null && nameHash.Contains(server.ServerName))
				{
					if (!server.IsConnected)
					{
						serversToConnect.Add(server);
					}
					nameHash.Remove(server.ServerName);
				}
			});
			isFirstConnection = Program.ConnectServers(serversToConnect, isFirstConnection);
			if (nameHash.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder("The following servers were not found and could not be connected:").AppendLine().AppendLine();
				foreach (string value in nameHash)
				{
					stringBuilder.AppendLine(value);
				}
				FormTools.InformationDialog(stringBuilder.ToString());
			}
			return isFirstConnection;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001BB84 File Offset: 0x00019D84
		private static void ParseCommandLine()
		{
			ArgumentParser argumentParser = new ArgumentParser();
			argumentParser.AddSwitch("?", false);
			argumentParser.AddSwitch("h", false);
			argumentParser.AddSwitch("reset", false);
			argumentParser.AddSwitch("noopen", false);
			argumentParser.AddSwitch("noconnect", false);
			argumentParser.AddSwitch("reconnect", false);
			argumentParser.AddSwitch("c", true);
			try
			{
				argumentParser.Parse();
			}
			catch (ArgumentException ex)
			{
				FormTools.ErrorDialog(ex.Message);
				Environment.Exit(1);
			}
			if (argumentParser.HasSwitch("?") || argumentParser.HasSwitch("h"))
			{
				Program.Usage();
				Environment.Exit(0);
			}
			if (argumentParser.HasSwitch("reset"))
			{
				Program.ResetPreferences = true;
			}
			if (argumentParser.HasSwitch("noopen"))
			{
				Program._openFiles = false;
			}
			if (argumentParser.HasSwitch("noconnect"))
			{
				Program._reconnectServersAtStart = ReconnectServerOptions.None;
			}
			if (argumentParser.HasSwitch("reconnect"))
			{
				Program._reconnectServersAtStart = ReconnectServerOptions.All;
			}
			if (argumentParser.HasSwitch("c"))
			{
				Program._serversToConnect = argumentParser.SwitchValues["c"].Split(new char[]
				{
					','
				}, StringSplitOptions.RemoveEmptyEntries);
			}
			Program._filesToOpen.AddRange(argumentParser.PlainArgs);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001BCCC File Offset: 0x00019ECC
		internal static void Usage()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string text = Path.Combine(Path.GetDirectoryName(executingAssembly.Location), "Resources\\help.htm");
			text = text.Replace('\\', '/');
			Process.Start("IExplore.exe", text);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001BD0C File Offset: 0x00019F0C
		private static void StartMessageLoop()
		{
			try
			{
				if (MainForm.Create() != null)
				{
					Log.Init();
					Program._appContext = new ApplicationContext(Program.TheForm);
					Application.Run(Program._appContext);
				}
			}
			finally
			{
				Program.InitializedEvent.Set();
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00006197 File Offset: 0x00004397
		internal static void ShowForm(Form form)
		{
			Program._appContext.MainForm.Invoke(new Program.ShowFormDelegate(Program.ShowFormWorker), new object[]
			{
				form
			});
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000061BF File Offset: 0x000043BF
		private static void ShowFormWorker(Form form)
		{
			form.Show();
			form.BringToFront();
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001BD5C File Offset: 0x00019F5C
		private static void CheckForUpdate()
		{
//          FormTools.InformationDialog("CheckForUpdate(): Currently not implemented");
		}

		// Token: 0x040004A5 RID: 1189
		internal static CredentialsStore CredentialsProfiles = new CredentialsStore();

		// Token: 0x040004A7 RID: 1191
		private static ApplicationContext _appContext;

		// Token: 0x040004A8 RID: 1192
		public static bool ResetPreferences = false;

		// Token: 0x040004A9 RID: 1193
		private static bool _openFiles = true;

		// Token: 0x040004AA RID: 1194
		private static ReconnectServerOptions _reconnectServersAtStart = ReconnectServerOptions.Ask;

		// Token: 0x040004AB RID: 1195
		private static readonly List<string> _filesToOpen = new List<string>();

		// Token: 0x040004AC RID: 1196
		private static string[] _serversToConnect = null;

		// Token: 0x040004AD RID: 1197
		private static readonly List<IBuiltInVirtualGroup> _builtInVirtualGroups = new List<IBuiltInVirtualGroup>();

		// Token: 0x040004B0 RID: 1200
		private const string PluginPattern = "Plugin.*.dll";

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x0600068F RID: 1679
		private delegate void ShowFormDelegate(Form form);

		// Token: 0x020000FA RID: 250
		private class PluginConfig
		{
			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000692 RID: 1682 RVA: 0x00006205 File Offset: 0x00004405
			// (set) Token: 0x06000693 RID: 1683 RVA: 0x0000620D File Offset: 0x0000440D
			public IPlugin Plugin { get; set; }

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000694 RID: 1684 RVA: 0x00006216 File Offset: 0x00004416
			// (set) Token: 0x06000695 RID: 1685 RVA: 0x0000621E File Offset: 0x0000441E
			public string Name { get; set; }

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000696 RID: 1686 RVA: 0x00006227 File Offset: 0x00004427
			// (set) Token: 0x06000697 RID: 1687 RVA: 0x0000622F File Offset: 0x0000442F
			public XmlNode SettingsNode { get; set; }
		}
	}
}
