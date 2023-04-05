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
	internal class Program
	{
		internal static MainForm TheForm { get; set; }

		internal static Preferences Preferences { get; private set; }

		internal static ManualResetEvent InitializedEvent { get; private set; }

		internal static IEnumerable<IBuiltInVirtualGroup> BuiltInVirtualGroups
		{
			get
			{
				return Program._builtInVirtualGroups;
			}
		}

		private static Dictionary<string, Program.PluginConfig> Plugins { get; set; }

		private static PluginContext PluginContext { get; set; }

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

		internal static void Usage()
		{
			Process.Start("https://sysinternals.com/downloads/rdcman");
		}

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

		internal static void ShowForm(Form form)
		{
			Program._appContext.MainForm.Invoke(new Program.ShowFormDelegate(Program.ShowFormWorker), new object[]
			{
				form
			});
		}

		private static void ShowFormWorker(Form form)
		{
			form.Show();
			form.BringToFront();
		}

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

		internal static CredentialsStore CredentialsProfiles = new CredentialsStore();

		private static ApplicationContext _appContext;

		public static bool ResetPreferences = false;

		private static bool _openFiles = true;

		private static ReconnectServerOptions _reconnectServersAtStart = ReconnectServerOptions.Ask;

		private static readonly List<string> _filesToOpen = new List<string>();

		private static string[] _serversToConnect = null;

		private static readonly List<IBuiltInVirtualGroup> _builtInVirtualGroups = new List<IBuiltInVirtualGroup>();

		private const string PluginPattern = "Plugin.*.dll";

		private delegate void ShowFormDelegate(Form form);

		private class PluginConfig
		{
			public IPlugin Plugin { get; set; }

			public string Name { get; set; }

			public XmlNode SettingsNode { get; set; }
		}
	}
}
