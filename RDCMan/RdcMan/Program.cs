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
	// Token: 0x02000091 RID: 145
	internal class Program
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00019140 File Offset: 0x00017340
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00019148 File Offset: 0x00017348
		internal static MainForm TheForm { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00019150 File Offset: 0x00017350
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00019158 File Offset: 0x00017358
		internal static Preferences Preferences { get; private set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00019160 File Offset: 0x00017360
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00019168 File Offset: 0x00017368
		internal static ManualResetEvent InitializedEvent { get; private set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00019170 File Offset: 0x00017370
		internal static IEnumerable<IBuiltInVirtualGroup> BuiltInVirtualGroups
		{
			get
			{
				return Program._builtInVirtualGroups;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00019178 File Offset: 0x00017378
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00019180 File Offset: 0x00017380
		private static Dictionary<string, Program.PluginConfig> Plugins { get; set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00019188 File Offset: 0x00017388
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00019190 File Offset: 0x00017390
		private static PluginContext PluginContext { get; set; }

		// Token: 0x06000549 RID: 1353 RVA: 0x00019198 File Offset: 0x00017398
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

		// Token: 0x0600054A RID: 1354 RVA: 0x000191D4 File Offset: 0x000173D4
		[STAThread]
		internal static void Main(params string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
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

		// Token: 0x0600054B RID: 1355 RVA: 0x000193C8 File Offset: 0x000175C8
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

		// Token: 0x0600054C RID: 1356 RVA: 0x00019534 File Offset: 0x00017734
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

		// Token: 0x0600054D RID: 1357 RVA: 0x000195A0 File Offset: 0x000177A0
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

		// Token: 0x0600054E RID: 1358 RVA: 0x000198C4 File Offset: 0x00017AC4
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

		// Token: 0x0600054F RID: 1359 RVA: 0x00019948 File Offset: 0x00017B48
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

		// Token: 0x06000550 RID: 1360 RVA: 0x000199A8 File Offset: 0x00017BA8
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

		// Token: 0x06000551 RID: 1361 RVA: 0x000199E0 File Offset: 0x00017BE0
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

		// Token: 0x06000552 RID: 1362 RVA: 0x00019AB8 File Offset: 0x00017CB8
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

		// Token: 0x06000553 RID: 1363 RVA: 0x00019C1C File Offset: 0x00017E1C
		internal static void Usage()
		{
			Process.Start("https://sysinternals.com/downloads/rdcman");
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00019C2C File Offset: 0x00017E2C
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

		// Token: 0x06000555 RID: 1365 RVA: 0x00019C84 File Offset: 0x00017E84
		internal static void ShowForm(Form form)
		{
			Program._appContext.MainForm.Invoke(new Program.ShowFormDelegate(Program.ShowFormWorker), new object[]
			{
				form
			});
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00019CBC File Offset: 0x00017EBC
		private static void ShowFormWorker(Form form)
		{
			form.Show();
			form.BringToFront();
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00019CCC File Offset: 0x00017ECC
		private static void CheckForUpdate()
		{
			try
			{
				Program.<>c__DisplayClass46_0 CS$<>8__locals1 = new Program.<>c__DisplayClass46_0();
				Program.<>c__DisplayClass46_0 CS$<>8__locals2 = CS$<>8__locals1;
				RdcManSection rdcManSection = Current.RdcManSection;
				CS$<>8__locals2.updateElement = ((rdcManSection != null) ? rdcManSection.ProgramUpdate : null);
				ProgramUpdateElement updateElement = CS$<>8__locals1.updateElement;
				if (!string.IsNullOrEmpty((updateElement != null) ? updateElement.VersionPath : null) && !string.IsNullOrEmpty(CS$<>8__locals1.updateElement.UpdateUrl))
				{
					DateTime value;
					if (!DateTime.TryParse(Program.Preferences.LastUpdateCheckTimeUtc, out value) || DateTime.UtcNow.Subtract(value).TotalDays < 1.0)
					{
						Log.Write("Last checked for update on {0}, not checking until tomorrow", new object[]
						{
							value.ToString("s")
						});
					}
					else
					{
						Program.Preferences.LastUpdateCheckTimeUtc = DateTime.UtcNow.ToString("u");
						string input = File.ReadAllText(CS$<>8__locals1.updateElement.VersionPath);
						Version version;
						if (Version.TryParse(input, out version))
						{
							Assembly executingAssembly = Assembly.GetExecutingAssembly();
							AssemblyName name = executingAssembly.GetName();
							Log.Write("Latest version = {0}", new object[]
							{
								version
							});
							if (name.Version < version)
							{
								Program.TheForm.Invoke(new MethodInvoker(delegate()
								{
									FormTools.InformationDialog("There is a new version of RDCMan available from {0}".InvariantFormat(new object[]
									{
										CS$<>8__locals1.updateElement.UpdateUrl
									}));
								}));
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x040001F3 RID: 499
		internal static CredentialsStore CredentialsProfiles = new CredentialsStore();

		// Token: 0x040001F5 RID: 501
		private static ApplicationContext _appContext;

		// Token: 0x040001F6 RID: 502
		public static bool ResetPreferences = false;

		// Token: 0x040001F7 RID: 503
		private static bool _openFiles = true;

		// Token: 0x040001F8 RID: 504
		private static ReconnectServerOptions _reconnectServersAtStart = ReconnectServerOptions.Ask;

		// Token: 0x040001F9 RID: 505
		private static readonly List<string> _filesToOpen = new List<string>();

		// Token: 0x040001FA RID: 506
		private static string[] _serversToConnect = null;

		// Token: 0x040001FB RID: 507
		private static readonly List<IBuiltInVirtualGroup> _builtInVirtualGroups = new List<IBuiltInVirtualGroup>();

		// Token: 0x040001FE RID: 510
		private const string PluginPattern = "Plugin.*.dll";

		// Token: 0x02000280 RID: 640
		// (Invoke) Token: 0x060056E4 RID: 22244
		private delegate void ShowFormDelegate(Form form);

		// Token: 0x02000281 RID: 641
		private class PluginConfig
		{
			// Token: 0x17002144 RID: 8516
			// (get) Token: 0x060056E7 RID: 22247 RVA: 0x0005EC98 File Offset: 0x0005CE98
			// (set) Token: 0x060056E8 RID: 22248 RVA: 0x0005ECA0 File Offset: 0x0005CEA0
			public IPlugin Plugin { get; set; }

			// Token: 0x17002145 RID: 8517
			// (get) Token: 0x060056E9 RID: 22249 RVA: 0x0005ECAC File Offset: 0x0005CEAC
			// (set) Token: 0x060056EA RID: 22250 RVA: 0x0005ECB4 File Offset: 0x0005CEB4
			public string Name { get; set; }

			// Token: 0x17002146 RID: 8518
			// (get) Token: 0x060056EB RID: 22251 RVA: 0x0005ECC0 File Offset: 0x0005CEC0
			// (set) Token: 0x060056EC RID: 22252 RVA: 0x0005ECC8 File Offset: 0x0005CEC8
			public XmlNode SettingsNode { get; set; }
		}
	}
}
