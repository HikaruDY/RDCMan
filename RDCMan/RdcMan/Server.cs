using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using AxMSTSCLib;
using MSTSCLib;
using Win32;

namespace RdcMan
{
	public class Server : ServerBase
	{
		static Server()
		{
			ServerTree.Instance.ServerChanged += Server.OnServerChanged;
		}

		protected Server()
		{
			this._serverRefList = new List<ServerRef>();
			this.ChangeImageIndex(ImageConstants.DisconnectedServer);
		}

		private static void OnServerChanged(ServerChangedEventArgs e)
		{
			if (e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				Server server = e.Server as Server;
				if (server != null)
				{
					server.VisitServerRefs(delegate(ServerRef r)
					{
						GroupBase group = r.Parent as GroupBase;
						if (ServerTree.Instance.SortGroup(group))
						{
							ServerTree.Instance.OnGroupChanged(group, ChangeType.InvalidateUI);
						}
					});
				}
			}
		}

		public static event Action<ConnectionStateChangedEventArgs> ConnectionStateChanged;

		public static event Action<Server> FocusReceived;

		public RdpClient.ConnectionState ConnectionState
		{
			get
			{
				return this._connectionState;
			}
			private set
			{
				if (this._connectionState != value)
				{
					this._connectionState = value;
					Action<ConnectionStateChangedEventArgs> connectionStateChanged = Server.ConnectionStateChanged;
					if (connectionStateChanged != null)
					{
						ConnectionStateChangedEventArgs obj = new ConnectionStateChangedEventArgs(this, this._connectionState);
						connectionStateChanged(obj);
					}
				}
			}
		}

		public override Server ServerNode
		{
			get
			{
				return this;
			}
		}

		public override string RemoveTypeDescription
		{
			get
			{
				return "server";
			}
		}

		public override ServerSettings Properties
		{
			get
			{
				return base.Properties as ServerSettings;
			}
		}

		public override CommonDisplaySettings DisplaySettings
		{
			get
			{
				return base.DisplaySettings;
			}
		}

		public override ServerBase.DisplayStates DisplayState
		{
			get
			{
				return this._displayState;
			}
			set
			{
				if (value == this._displayState)
				{
					return;
				}
				this._displayState = value;
				if (value != ServerBase.DisplayStates.Invalid)
				{
					this.SetText();
					this.SetClientSizeProperties();
				}
			}
		}

		public override bool IsClientDocked
		{
			get
			{
				return !this.IsClientInitialized || this.ServerForm == null;
			}
		}

		public override bool IsClientUndocked
		{
			get
			{
				return this.IsClientInitialized && this.ServerForm != null;
			}
		}

		public override RdcBaseForm ParentForm
		{
			get
			{
				if (this.IsClientUndocked)
				{
					return this.ServerForm;
				}
				return base.ParentForm;
			}
		}

		private ServerForm ServerForm
		{
			get
			{
				return this.Client.Control.Parent as ServerForm;
			}
		}

		public void SuspendFullScreenBehavior()
		{
			Interlocked.Increment(ref this._noFullScreenBehavior);
		}

		public void ResumeFullScreenBehavior()
		{
			Interlocked.Decrement(ref this._noFullScreenBehavior);
		}

		public override Size Size
		{
			get
			{
				if (!this.UseServerBox)
				{
					return this._client.Control.Size;
				}
				return this._serverBox.Size;
			}
			set
			{
				if (!this.UseServerBox)
				{
					this._client.Control.Size = value;
				}
				this._serverBox.Size = value;
			}
		}

		private bool IsClientInPanel
		{
			get
			{
				return this.IsClientInitialized && this.IsClientDocked;
			}
		}

		public override Point Location
		{
			get
			{
				if (!this.UseServerBox)
				{
					return this._client.Control.Location;
				}
				return this._serverBox.Location;
			}
			set
			{
				if (!this.UseServerBox)
				{
					this._client.Control.Location = value;
				}
				this._serverBox.Location = value;
			}
		}

		public string GetQualifiedNameForUI()
		{
			string text;
			int num;
			Server.SplitName(base.ServerName, out text, out num);
			if (base.DisplayName.Equals(text, StringComparison.OrdinalIgnoreCase))
			{
				return base.DisplayName;
			}
			return string.Format("{0} ({1})", base.DisplayName, text);
		}

		public string ConnectedText
		{
			get
			{
				if (base.IsThumbnail)
				{
					return "Connected";
				}
				return "Connected to " + this.GetQualifiedNameForUI();
			}
		}

		public string ConnectingText
		{
			get
			{
				if (base.IsThumbnail)
				{
					return "Connecting";
				}
				return "Connecting to " + this.GetQualifiedNameForUI();
			}
		}

		public string DisconnectedText
		{
			get
			{
				string text;
				if (base.IsThumbnail)
				{
					text = "Disconnected";
					if (!string.IsNullOrEmpty(this._disconnectionReason))
					{
						text += " [error]";
					}
				}
				else
				{
					text = "Disconnected from " + this.GetQualifiedNameForUI();
					if (!string.IsNullOrEmpty(this._disconnectionReason))
					{
						text = string.Concat(new string[]
						{
							text,
							Environment.NewLine,
							"[",
							this._disconnectionReason,
							"]"
						});
					}
				}
				return text;
			}
		}

		private void SetText()
		{
			this._serverBox.SetText();
			if (this.IsClientInitialized)
			{
				this._client.SetText();
			}
		}

		public string GetConnectionStateText()
		{
			switch (this.ConnectionState)
			{
			case RdpClient.ConnectionState.Disconnected:
				return this.DisconnectedText;
			case RdpClient.ConnectionState.Connecting:
				return this.ConnectingText;
			case RdpClient.ConnectionState.Connected:
				return this.ConnectedText;
			default:
				return "<GetText error>";
			}
		}

		protected override void InitSettings()
		{
			base.Properties = new ServerSettings();
			base.DisplaySettings = new ServerDisplaySettings();
			base.InitSettings();
		}

		internal override void Focus()
		{
			if (!this.IsClientUndocked && this.UseServerBox)
			{
				this._serverBox.Focus();
				return;
			}
			this._client.Control.Focus();
		}

		internal override void FocusConnectedClient()
		{
			if (this.IsConnected && this.IsClientInitialized)
			{
				this._client.Control.Focus();
			}
		}

		internal void SetNormalView()
		{
			this.DisplayState = ServerBase.DisplayStates.Normal;
			this.Size = Program.TheForm.GetClientSize();
			this.Location = new Point(0, 0);
			this.EnableDisableClient();
		}

		internal bool Resize()
		{
			bool flag = (this.IsClientDocked && this.DisplaySettings.SmartSizeDockedWindow.Value == RdpClient.SmartSizeMethod.Reconnect) || (!this.IsClientDocked && this.DisplaySettings.SmartSizeUndockedWindow.Value == RdpClient.SmartSizeMethod.Reconnect);
			return this.IsClientInitialized && flag && this._client.Resize((uint)this.Size.Width, (uint)this.Size.Height);
		}

		internal void SetThumbnailView(int left, int top, int width, int height)
		{
			this.DisplayState = ServerBase.DisplayStates.Thumbnail;
			this.Size = new Size(width, height);
			this.Location = new Point(left, top);
			this.EnableDisableClient();
		}

		internal override void ScreenCapture()
		{
			Control control = this.Client.Control;
			Graphics graphics = null;
			try
			{
				Point point = control.PointToScreen(control.Location);
				Size size = control.Size;
				Bitmap bitmap = new Bitmap(size.Width, size.Height);
				graphics = Graphics.FromImage(bitmap);
				graphics.CopyFromScreen(point.X, point.Y, 0, 0, bitmap.Size);
				Clipboard.SetDataObject(bitmap);
			}
			catch (Exception ex)
			{
				FormTools.ErrorDialog("Error capturing session screen: " + ex.Message);
			}
			finally
			{
				if (graphics != null)
				{
					graphics.Dispose();
				}
			}
		}

		internal RdpClient Client
		{
			get
			{
				return this._client;
			}
		}

		private bool IsClientInitialized
		{
			get
			{
				return this.Client != null;
			}
		}

		protected void InitRequiredForDisplay()
		{
			this._serverBox = new ServerBox(this);
		}

		private void AddToClientPanel()
		{
			if (this._serverBox.Parent == null)
			{
				Program.TheForm.AddToClientPanel(this._serverBox);
			}
		}

		private void RemoveFromClientPanel()
		{
			if (this._serverBox.Parent != null)
			{
				Program.TheForm.RemoveFromClientPanel(this._serverBox);
			}
		}

		private void InitClient()
		{
			if (this.IsClientInitialized)
			{
				return;
			}
			this._client = RdpClient.AllocClient(this, Program.TheForm);
			this._client.ConnectConnectionHandlers(new EventHandler(this.OnConnected), new EventHandler(this.OnConnecting), new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.OnDisconnected), new AxMSTSCLib.IMsTscAxEvents_OnAutoReconnectingEventHandler(this.OnAutoReconnecting), new AxMSTSCLib.IMsTscAxEvents_OnAutoReconnecting2EventHandler(this.OnAutoReconnecting2), new EventHandler(this.OnAutoReconnected), new AxMSTSCLib.IMsTscAxEvents_OnFocusReleasedEventHandler(this.OnFocusReleased));
			this._client.ConnectContainerHandlers(new EventHandler(this.OnRequestGoFullScreen), new EventHandler(this.OnRequestLeaveFullScreen), new EventHandler(this.OnRequestContainerMinimize), new AxMSTSCLib.IMsTscAxEvents_OnConfirmCloseEventHandler(this.OnConfirmClose), new AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEventHandler(this.OnFatalError));
			this._client.Control.GotFocus += this.ClientGotFocus;
			this._client.AdvancedSettings2.ContainerHandledFullScreen = 1;
			this._client.AdvancedSettings2.allowBackgroundInput = 1;
			this._client.Control.Size = this._serverBox.Size;
			this._client.Control.Location = this._serverBox.Location;
			this.SetClientSizeProperties();
			this.SetText();
			if (!this.UseServerBox && this._serverBox.Visible)
			{
				this._client.Control.Show();
				this._serverBox.Hide();
			}
		}

		private void DestroyClient()
		{
			if (!this.IsClientInitialized)
			{
				return;
			}
			this._client.DisconnectConnectionHandlers(new EventHandler(this.OnConnected), new EventHandler(this.OnConnecting), new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.OnDisconnected), new AxMSTSCLib.IMsTscAxEvents_OnAutoReconnectingEventHandler(this.OnAutoReconnecting), new AxMSTSCLib.IMsTscAxEvents_OnAutoReconnecting2EventHandler(this.OnAutoReconnecting2), new EventHandler(this.OnAutoReconnected), new AxMSTSCLib.IMsTscAxEvents_OnFocusReleasedEventHandler(this.OnFocusReleased));
			this._client.DisconnectContainerHandlers(new EventHandler(this.OnRequestGoFullScreen), new EventHandler(this.OnRequestLeaveFullScreen), new EventHandler(this.OnRequestContainerMinimize), new AxMSTSCLib.IMsTscAxEvents_OnConfirmCloseEventHandler(this.OnConfirmClose), new AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEventHandler(this.OnFatalError));
			RdpClient client = this._client;
			this._client = null;
			RdpClient.ReleaseClient(client);
		}

		internal static Server CreateForAddDialog()
		{
			return new Server();
		}

		public static Server Create(string serverName, string displayName, GroupBase group)
		{
			Server server = new Server();
			server.Properties.ServerName.Value = serverName;
			server.Properties.DisplayName.Value = displayName;
			server.FinishConstruction(group);
			return server;
		}

		internal static Server Create(ServerPropertiesDialog dlg)
		{
			Server server = dlg.AssociatedNode as Server;
			server.FinishConstruction(dlg.PropertiesPage.ParentGroup);
			return server;
		}

		internal static Server Create(string name, ServerPropertiesDialog dlg)
		{
			Server node = dlg.AssociatedNode as Server;
			Server server = new Server();
			server.CopySettings(node, null);
			server.Properties.ServerName.Value = name;
			server.Properties.DisplayName.Value = name;
			server.FinishConstruction(dlg.PropertiesPage.ParentGroup);
			return server;
		}

		internal static Server Create(XmlNode xmlNode, GroupBase group, ICollection<string> errors)
		{
			Server server = new Server();
			server.ReadXml(xmlNode, errors);
			server.FinishConstruction(group);
			return server;
		}

		protected void FinishConstruction(GroupBase group)
		{
			if (string.IsNullOrEmpty(base.DisplayName))
			{
				this.Properties.DisplayName.Value = base.ServerName;
			}
			base.Text = base.DisplayName;
			this.InitRequiredForDisplay();
			ServerTree.Instance.AddNode(this, group);
		}

		private void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(Server.PropertyActions, xmlNode, errors);
		}

		public override void OnRemoving()
		{
			this.VisitServerRefs(delegate(ServerRef r)
			{
				r.OnRemoveServer();
			});
			this._serverRefList.Clear();
			if (this.IsClientUndocked)
			{
				this.ServerForm.Close();
			}
			this.Hide();
			this._serverBox.Dispose();
			this._serverBox = null;
			this.DestroyClient();
		}

		private bool UseServerBox
		{
			get
			{
				return !this.IsClientInPanel || (base.IsThumbnail && !(this.ServerNode.Parent as GroupBase).DisplaySettings.SessionThumbnailPreview.Value);
			}
		}

		internal override void Show()
		{
			this.AddToClientPanel();
			if (this.UseServerBox)
			{
				this._serverBox.Show();
				return;
			}
			this._client.Control.Show();
		}

		internal override void Hide()
		{
			if (this.DisplayState != ServerBase.DisplayStates.Invalid)
			{
				this.DisplayState = ServerBase.DisplayStates.Invalid;
				this._serverBox.Hide();
				this.RemoveFromClientPanel();
				if (this.IsClientInPanel)
				{
					this._client.Control.Hide();
				}
			}
		}

		public override void Connect()
		{
			this.ConnectAs(null, null);
		}

		public override void ConnectAs(LogonCredentials logonCredentials, ConnectionSettings connectionSettings)
		{
			this.InitClient();
			object connectionStateLock = this._connectionStateLock;
			lock (connectionStateLock)
			{
				if (!this.IsConnected)
				{
					base.InheritSettings();
					base.ResolveCredentials();
					if (logonCredentials == null)
					{
						logonCredentials = base.LogonCredentials;
					}
					else
					{
						base.ResolveCredentials(logonCredentials);
					}
					if (connectionSettings == null)
					{
						connectionSettings = base.ConnectionSettings;
					}
					string str = "{none}";
					try
					{
						IMsRdpClientAdvancedSettings advancedSettings = this._client.AdvancedSettings2;
						IMsRdpClientAdvancedSettings6 advancedSettings2 = this._client.AdvancedSettings7;
						IMsRdpClientAdvancedSettings7 advancedSettings3 = this._client.AdvancedSettings8;
						IMsRdpClientNonScriptable4 msRdpClientNonScriptable = (IMsRdpClientNonScriptable4)this._client.GetOcx();
						string server;
						int value;
						Server.SplitName(base.ServerName, out server, out value);
						if (value == -1)
						{
							value = base.ConnectionSettings.Port.Value;
						}
						str = "server name";
						this._client.MsRdpClient.Server = server;
						string userName = CredentialsUI.GetUserName(logonCredentials.UserName.Value);
						string value2 = logonCredentials.Domain.Value;
						if (!string.IsNullOrEmpty(userName))
						{
							str = "user name";
							this._client.MsRdpClient.UserName = userName;
						}
						else
						{
							this._client.MsRdpClient.UserName = null;
						}
						if (!string.IsNullOrEmpty(value2))
						{
							str = "domain";
							if (value2.Equals("[server]", StringComparison.OrdinalIgnoreCase))
							{
								this._client.MsRdpClient.Domain = base.ServerName;
							}
							else if (value2.Equals("[display]", StringComparison.OrdinalIgnoreCase))
							{
								this._client.MsRdpClient.Domain = base.DisplayName;
							}
							else
							{
								this._client.MsRdpClient.Domain = value2;
							}
						}
						else
						{
							this._client.MsRdpClient.Domain = null;
						}
						str = "password";
						if (logonCredentials.Password.IsDecrypted && !string.IsNullOrEmpty(logonCredentials.Password.Value))
						{
							advancedSettings.ClearTextPassword = logonCredentials.Password.Value;
						}
						advancedSettings.keepAliveInterval = 60000;
						advancedSettings2.HotKeyAltEsc = (int)Program.Preferences.HotKeyAltEsc;
						advancedSettings2.HotKeyAltSpace = (int)Program.Preferences.HotKeyAltSpace;
						advancedSettings2.HotKeyAltShiftTab = (int)Program.Preferences.HotKeyAltShiftTab;
						advancedSettings2.HotKeyAltTab = (int)Program.Preferences.HotKeyAltTab;
						advancedSettings2.HotKeyCtrlEsc = (int)Program.Preferences.HotKeyCtrlEsc;
						advancedSettings2.HotKeyCtrlAltDel = (int)Program.Preferences.HotKeyCtrlAltDel;
						advancedSettings2.HotKeyFocusReleaseLeft = (int)Program.Preferences.HotKeyFocusReleaseLeft;
						advancedSettings2.HotKeyFocusReleaseRight = (int)Program.Preferences.HotKeyFocusReleaseRight;
						advancedSettings2.HotKeyFullScreen = (int)Program.Preferences.HotKeyFullScreen;
						this._client.SecuredSettings2.KeyboardHookMode = (int)base.LocalResourceSettings.KeyboardHookMode.Value;
						RdpClient.ConnectionBarState connectionBarState = Program.Preferences.ConnectionBarState;
						if (connectionBarState == RdpClient.ConnectionBarState.Off)
						{
							advancedSettings.DisplayConnectionBar = false;
						}
						else
						{
							advancedSettings.DisplayConnectionBar = true;
							advancedSettings.PinConnectionBar = (connectionBarState == RdpClient.ConnectionBarState.Pinned);
						}
						this._client.MsRdpClient.FullScreen = false;
						advancedSettings.PerformanceFlags = Program.Preferences.PerformanceFlags;
						advancedSettings.GrabFocusOnConnect = false;
						str = "gateway settings";
						this.ConfigureGateway();
						if (this.Properties.ConnectionType.Value == ConnectionType.VirtualMachineConsoleConnect)
						{
							advancedSettings3.PCB = this.Properties.VirtualMachineId.Value;
							advancedSettings.RDPPort = 2179;
							advancedSettings.ConnectToServerConsole = true;
							advancedSettings2.AuthenticationLevel = 0U;
							advancedSettings2.AuthenticationServiceClass = "Microsoft Virtual Console Service";
							advancedSettings2.EnableCredSspSupport = true;
							advancedSettings3.NegotiateSecurityLayer = false;
						}
						else
						{
							str = "port";
							advancedSettings.RDPPort = value;
							advancedSettings.BitmapPeristence = (Program.Preferences.PersistentBitmapCaching ? 1 : 0);
							str = "loadBalanceInfo";
							string text = base.ConnectionSettings.LoadBalanceInfo.Value;
							if (!string.IsNullOrEmpty(text))
							{
								if (text.Length % 2 == 1)
								{
									text += " ";
								}
								text += Environment.NewLine;
								byte[] bytes = Encoding.UTF8.GetBytes(text);
								advancedSettings.LoadBalanceInfo = Encoding.Unicode.GetString(bytes);
							}
							str = "connect to console";
							if (advancedSettings2 != null)
							{
								advancedSettings2.ConnectToAdministerServer = connectionSettings.ConnectToConsole.Value;
							}
							advancedSettings.ConnectToServerConsole = connectionSettings.ConnectToConsole.Value;
							str = "start program";
							this._client.SecuredSettings.StartProgram = base.ConnectionSettings.StartProgram.Value;
							this._client.SecuredSettings.WorkDir = base.ConnectionSettings.WorkingDir.Value;
							this._client.AdvancedSettings5.EnableAutoReconnect = true;
							this._client.AdvancedSettings5.MaxReconnectAttempts = 20;
							advancedSettings.EnableWindowsKey = 1;
							str = "local resources";
							this._client.SecuredSettings2.AudioRedirectionMode = (int)base.LocalResourceSettings.AudioRedirectionMode.Value;
							if (advancedSettings3 != null)
							{
								advancedSettings3.AudioQualityMode = (uint)base.LocalResourceSettings.AudioRedirectionQuality.Value;
								advancedSettings3.AudioCaptureRedirectionMode = (base.LocalResourceSettings.AudioCaptureRedirectionMode.Value == RdpClient.AudioCaptureRedirectionMode.Record);
								if (RdpClient.SupportsPanning)
								{
									advancedSettings3.EnableSuperPan = Program.Preferences.EnablePanning;
									advancedSettings3.SuperPanAccelerationFactor = (uint)Program.Preferences.PanningAcceleration;
								}
							}
							if (RdpClient.SupportsFineGrainedRedirection)
							{
								IMsRdpDriveCollection driveCollection = this._client.ClientNonScriptable3.DriveCollection;
								for (uint num = 0U; num < driveCollection.DriveCount; num += 1U)
								{
									IMsRdpDrive msRdpDrive = driveCollection.get_DriveByIndex(num);
									string item = msRdpDrive.Name.Substring(0, msRdpDrive.Name.Length - 1);
									msRdpDrive.RedirectionState = base.LocalResourceSettings.RedirectDrivesList.Value.Contains(item);
								}
							}
							else
							{
								advancedSettings.RedirectDrives = base.LocalResourceSettings.RedirectDrives.Value;
							}
							advancedSettings.RedirectPorts = base.LocalResourceSettings.RedirectPorts.Value;
							advancedSettings.RedirectPrinters = base.LocalResourceSettings.RedirectPrinters.Value;
							advancedSettings.RedirectSmartCards = base.LocalResourceSettings.RedirectSmartCards.Value;
							this._client.AdvancedSettings6.RedirectClipboard = base.LocalResourceSettings.RedirectClipboard.Value;
							this._client.AdvancedSettings6.RedirectDevices = base.LocalResourceSettings.RedirectPnpDevices.Value;
							str = "remote desktop attributes";
							this._client.DesktopSize = this.GetRemoteDesktopSize();
							this._client.MsRdpClient.ColorDepth = base.RemoteDesktopSettings.ColorDepth.Value;
							str = "security settings";
							this._client.AdvancedSettings5.AuthenticationLevel = (uint)base.SecuritySettings.AuthenticationLevel.Value;
							if (advancedSettings2 != null)
							{
								advancedSettings2.EnableCredSspSupport = true;
								msRdpClientNonScriptable.PromptForCredentials = false;
								msRdpClientNonScriptable.NegotiateSecurityLayer = true;
								if (base.SecuritySettings.RemoteGuard.Value)
								{
									str = "security settings - remote guard";
									IMsRdpExtendedSettings msRdpExtendedSettings = (IMsRdpExtendedSettings)this._client.GetOcx();
									IMsRdpExtendedSettings msRdpExtendedSettings2 = msRdpExtendedSettings;
									string bstrPropertyName = "RedirectedAuthentication";
									object obj = true;
									msRdpExtendedSettings2.set_Property(bstrPropertyName, ref obj);
									IMsRdpExtendedSettings msRdpExtendedSettings3 = msRdpExtendedSettings;
									string bstrPropertyName2 = "DisableCredentialsDelegation";
									obj = true;
									msRdpExtendedSettings3.set_Property(bstrPropertyName2, ref obj);
								}
								else if (base.SecuritySettings.RestrictedAdmin.Value)
								{
									str = "security settings - restricted admin";
									IMsRdpExtendedSettings msRdpExtendedSettings4 = (IMsRdpExtendedSettings)this._client.GetOcx();
									IMsRdpExtendedSettings msRdpExtendedSettings5 = msRdpExtendedSettings4;
									string bstrPropertyName3 = "RestrictedLogon";
									object obj = true;
									msRdpExtendedSettings5.set_Property(bstrPropertyName3, ref obj);
									IMsRdpExtendedSettings msRdpExtendedSettings6 = msRdpExtendedSettings4;
									string bstrPropertyName4 = "DisableCredentialsDelegation";
									obj = true;
									msRdpExtendedSettings6.set_Property(bstrPropertyName4, ref obj);
								}
							}
						}
						str = "client connection";
						this._disconnectionReason = string.Empty;
						using (Helpers.Timer("invoking connect on {0} client", new object[]
						{
							base.DisplayName
						}))
						{
							this._client.MsRdpClient.Connect();
						}
					}
					catch (Exception ex)
					{
						this.ConnectionState = RdpClient.ConnectionState.Disconnected;
						this._disconnectionReason = "Error setting up connection properties";
						FormTools.ErrorDialog("Error possibly involving '" + str + "':\n" + ex.Message);
						Log.Write("Error({1}) connecting to {0}", new object[]
						{
							base.DisplayName,
							ex.Message
						});
					}
				}
			}
		}

		internal void DumpSessionState()
		{
			using (Helpers.Timer("dumping session state of {0}", new object[]
			{
				base.DisplayName
			}))
			{
				this._client.Dump();
			}
		}

		internal static void SplitName(string qualifiedName, out string serverName, out int port)
		{
			string[] array = qualifiedName.Split(new char[]
			{
				':'
			}, StringSplitOptions.RemoveEmptyEntries);
			serverName = ((array.Length != 0) ? array[0] : string.Empty);
			if (array.Length != 2 || !int.TryParse(array[1], out port))
			{
				port = -1;
			}
		}

		private void ConfigureGateway()
		{
			IMsRdpClientTransportSettings transportSettings = this._client.TransportSettings;
			if (base.GatewaySettings.UseGatewayServer.Value)
			{
				uint gatewayUsageMethod = base.GatewaySettings.BypassGatewayForLocalAddresses.Value ? 2U : 1U;
				transportSettings.GatewayProfileUsageMethod = 1U;
				transportSettings.GatewayUsageMethod = gatewayUsageMethod;
				uint value = (uint)base.GatewaySettings.LogonMethod.Value;
				transportSettings.GatewayCredsSource = value;
				transportSettings.GatewayHostname = base.GatewaySettings.HostName.Value;
				IMsRdpClientTransportSettings2 transportSettings2 = this._client.TransportSettings2;
				if (transportSettings2 != null)
				{
					transportSettings2.GatewayCredSharing = (base.GatewaySettings.CredentialSharing.Value ? 1U : 0U);
					if (base.GatewaySettings.LogonMethod.Value == RdpClient.GatewayLogonMethod.NTLM)
					{
						transportSettings2.GatewayUsername = base.GatewaySettings.UserName.Value;
						transportSettings2.GatewayDomain = base.GatewaySettings.Domain.Value;
						transportSettings2.GatewayPassword = base.GatewaySettings.Password.Value;
						return;
					}
				}
			}
			else
			{
				transportSettings.GatewayProfileUsageMethod = 0U;
				transportSettings.GatewayUsageMethod = 0U;
			}
		}

		public override void Reconnect()
		{
			Log.Write("Begin reconnect to {0}", new object[]
			{
				base.DisplayName
			});
			ReconnectServerRef reconnectServerRef = ReconnectGroup.Instance.AddReference(this);
			reconnectServerRef.Start(true);
		}

		public override void Disconnect()
		{
			using (Helpers.Timer("invoking disconnect on the {0} client", new object[]
			{
				base.DisplayName
			}))
			{
				if (this.IsConnected)
				{
					try
					{
						this._client.MsRdpClient.Disconnect();
					}
					catch (Exception ex)
					{
						Log.Write("Error disconnection: {0}", new object[]
						{
							ex.Message
						});
					}
				}
			}
		}

		public override void LogOff()
		{
			Log.Write("Begin logoff from {0}", new object[]
			{
				base.DisplayName
			});
			if (!this.IsConnected)
			{
				return;
			}
			ThreadPool.QueueUserWorkItem(new WaitCallback(Server.LogOffWorkerProc), this);
		}

		private static void LogOffWorkerProc(object o)
		{
			Server server = o as Server;
			RemoteSessions remoteSessions = new RemoteSessions(server);
			bool success = true;
			string reason = string.Empty;
			try
			{
				if (!remoteSessions.OpenServer())
				{
					success = false;
					reason = "Unable to access remote sessions";
				}
				else
				{
					IList<RemoteSessionInfo> list = remoteSessions.QuerySessions();
					if (list == null)
					{
						success = false;
						reason = "Unable to enumerate remote sessions";
					}
					else
					{
						int num = -1;
						foreach (RemoteSessionInfo remoteSessionInfo in list)
						{
							if (remoteSessionInfo.State == Wts.ConnectstateClass.Active && remoteSessionInfo.ClientName.Equals(Environment.MachineName, StringComparison.OrdinalIgnoreCase) && remoteSessionInfo.UserName.Equals(server._client.MsRdpClient.UserName, StringComparison.OrdinalIgnoreCase) && remoteSessionInfo.DomainName.Equals(server._client.MsRdpClient.Domain, StringComparison.OrdinalIgnoreCase))
							{
								if (num != -1)
								{
									success = false;
									reason = "Multiple active sessions, couldn't determine which to log off";
									return;
								}
								num = remoteSessionInfo.SessionId;
							}
						}
						if (success)
						{
							success = remoteSessions.LogOffSession(num);
							reason = "Log off session API failed";
						}
					}
				}
			}
			catch
			{
				success = false;
				reason = "Internal error";
			}
			finally
			{
				remoteSessions.CloseServer();
				Program.TheForm.Invoke(new MethodInvoker(delegate()
				{
					server.LogOffResultCallback(success, reason);
				}));
			}
		}

		private void LogOffResultCallback(bool success, string text)
		{
			Log.Write("End logoff from {0}", new object[]
			{
				base.DisplayName
			});
			if (success)
			{
				return;
			}
			FormTools.ErrorDialog("Unable to log off from " + base.DisplayName + "\r\nReason: " + text);
		}

		public override bool IsConnected
		{
			get
			{
				return this.ConnectionState > RdpClient.ConnectionState.Disconnected;
			}
		}

		public override bool IsClientFullScreen
		{
			get
			{
				return this.IsClientInitialized && this.Client.MsRdpClient.FullScreen;
			}
		}

		private void OnConnecting(object sender, EventArgs e)
		{
			object connectionStateLock = this._connectionStateLock;
			lock (connectionStateLock)
			{
				Log.Write("OnConnecting {0}", new object[]
				{
					base.DisplayName
				});
				this.UpdateOnConnectionStateChange(ImageConstants.ConnectingServer, RdpClient.ConnectionState.Connecting);
			}
		}

		private void OnConnected(object sender, EventArgs e)
		{
			object connectionStateLock = this._connectionStateLock;
			lock (connectionStateLock)
			{
				Log.Write("OnConnected {0}", new object[]
				{
					base.DisplayName
				});
				this.Location = new Point(this.Location.X, this.Location.Y);
				this.UpdateOnConnectionStateChange(ImageConstants.ConnectedServer, RdpClient.ConnectionState.Connected);
				ServerBase serverBase = ServerTree.Instance.SelectedNode as ServerBase;
				if (serverBase != null && serverBase.ServerNode == this)
				{
					this.Focus();
				}
			}
		}

		private void OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			object connectionStateLock = this._connectionStateLock;
			lock (connectionStateLock)
			{
				Log.Write("OnDisconnected {0}: discReason={1} extendedDisconnectReason={2}", new object[]
				{
					base.DisplayName,
					e.discReason,
					this._client.MsRdpClient.ExtendedDisconnectReason
				});
				this._disconnectionReason = string.Empty;
				Server.DisconnectionReason disconnectionReason = null;
				if (this._client.MsRdpClient.ExtendedDisconnectReason != ExtendedDisconnectReasonCode.exDiscReasonNoInfo)
				{
					disconnectionReason = Server.ExtendedDisconnectionReasons.SingleOrDefault((Server.DisconnectionReason r) => r.Code == (int)this._client.MsRdpClient.ExtendedDisconnectReason);
					if (disconnectionReason == null)
					{
						this._disconnectionReason = string.Format("Unknown extended disconnection reason {0}", this._client.MsRdpClient.ExtendedDisconnectReason);
					}
				}
				else if (e != null)
				{
					disconnectionReason = Server.DisconnectionReasons.SingleOrDefault((Server.DisconnectionReason r) => r.Code == e.discReason);
					if (disconnectionReason == null)
					{
						this._disconnectionReason = string.Format("Unknown disconnection reason {0}", e.discReason);
					}
				}
				if (disconnectionReason != null)
				{
					this._disconnectionReason = disconnectionReason.Text;
				}
				if (this._client.MsRdpClient.FullScreen)
				{
					this.ParentForm.LeaveFullScreenClient(this);
					this._client.MsRdpClient.FullScreen = false;
				}
				if (this.IsClientDocked)
				{
					if (this._client.Control.Visible)
					{
						this._serverBox.Show();
					}
					this.DestroyClient();
				}
				this.UpdateOnConnectionStateChange(ImageConstants.DisconnectedServer, RdpClient.ConnectionState.Disconnected);
			}
		}

		private void OnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			Log.Write("OnAutoReconnecting {0}: disconnectReason={1} attemptCount={2}", new object[]
			{
				base.DisplayName,
				e.disconnectReason,
				e.attemptCount
			});
		}

		private void OnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			Log.Write("OnAutoReconnecting2 {0}: disconnectReason={1} networkAvailable={2} attemptCount={3} maxAttemptCount={4}", new object[]
			{
				base.DisplayName,
				e.disconnectReason,
				e.networkAvailable,
				e.attemptCount,
				e.maxAttemptCount
			});
		}

		private void OnAutoReconnected(object sender, EventArgs e)
		{
			Log.Write("OnAutoReconnected {0}", new object[]
			{
				base.DisplayName
			});
		}

		private void UpdateOnConnectionStateChange(ImageConstants image, RdpClient.ConnectionState state)
		{
			using (Helpers.Timer("changing connection state of {0} to {1}", new object[]
			{
				base.DisplayName,
				state
			}))
			{
				this.ChangeImageIndex(image);
				this.ConnectionState = state;
				if (this._serverBox != null)
				{
					this._serverBox.SetText();
				}
			}
		}

		private void OnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			Log.Write("OnFocusReleased {0}: direction={1}", new object[]
			{
				base.DisplayName,
				e.iDirection
			});
			NodeHelper.SelectNewActiveConnection(e.iDirection == -1);
		}

		private void OnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			e.pfAllowClose = true;
		}

		private void OnRequestContainerMinimize(object sender, EventArgs e)
		{
			Log.Write("OnRequestContainerMinimize {0}", new object[]
			{
				base.DisplayName
			});
			this.ParentForm.WindowState = FormWindowState.Minimized;
		}

		private void OnRequestGoFullScreen(object sender, EventArgs e)
		{
			Log.Write("OnRequestGoFullScreen {0}", new object[]
			{
				base.DisplayName
			});
			if (this._noFullScreenBehavior > 0)
			{
				return;
			}
			this.ParentForm.GoFullScreenClient(this, Program.Preferences.FullScreenWindowIsTopMost);
		}

		public void SetClientSizeProperties()
		{
			if (this.IsClientFullScreen)
			{
				this.Client.AdvancedSettings2.SmartSizing = false;
				return;
			}
			base.InheritSettings();
			if (this.IsClientInPanel)
			{
				this.Client.AdvancedSettings2.SmartSizing = (base.IsThumbnail || this.DisplaySettings.SmartSizeDockedWindow.Value == RdpClient.SmartSizeMethod.Scale);
				return;
			}
			if (this.IsClientInitialized)
			{
				this.Client.AdvancedSettings2.SmartSizing = (this.DisplaySettings.SmartSizeUndockedWindow.Value == RdpClient.SmartSizeMethod.Scale);
			}
		}

		private void OnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			Log.Write("OnRequestLeaveFullScreen {0}", new object[]
			{
				base.DisplayName
			});
			if (this._noFullScreenBehavior > 0)
			{
				return;
			}
			this.ParentForm.LeaveFullScreenClient(this);
			if (!base.IsThumbnail)
			{
				this.SetNormalView();
			}
		}

		private void OnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			Log.Write("OnFatalError {0}: errorCode={1}", new object[]
			{
				base.DisplayName,
				e.errorCode
			});
		}

		public void AddServerRef(ServerRef serverRef)
		{
			this._serverRefList.Add(serverRef);
		}

		public TServerRef FindServerRef<TServerRef>() where TServerRef : ServerRef
		{
			return this._serverRefList.FirstOrDefault((ServerRef r) => r is TServerRef) as TServerRef;
		}

		public TServerRef FindServerRef<TServerRef>(GroupBase parent) where TServerRef : ServerRef
		{
			return this._serverRefList.FirstOrDefault((ServerRef r) => r is TServerRef && r.Parent == parent) as TServerRef;
		}

		public void RemoveServerRef(ServerRef serverRef)
		{
			this._serverRefList.Remove(serverRef);
		}

		public void VisitServerRefs(Action<ServerRef> action)
		{
			ServerRef[] array = new ServerRef[this._serverRefList.Count];
			this._serverRefList.CopyTo(array);
			array.ForEach(action);
		}

		public override void ChangeImageIndex(ImageConstants index)
		{
			base.ChangeImageIndex(index);
			this.VisitServerRefs(delegate(ServerRef r)
			{
				r.ChangeImageIndex(index);
			});
		}

		public void SendRemoteAction(RemoteSessionActionType action)
		{
			IMsRdpClient8 msRdpClient = this._client.MsRdpClient8;
			msRdpClient.SendRemoteAction(action);
		}

		internal override void UpdateSettings(NodePropertiesDialog nodeDialog)
		{
			base.UpdateSettings(nodeDialog);
			ServerPropertiesDialog serverPropertiesDialog = nodeDialog as ServerPropertiesDialog;
			if (serverPropertiesDialog != null)
			{
				base.Text = base.DisplayName;
				if (base.TreeView != null)
				{
					this.SetText();
					this.VisitServerRefs(delegate(ServerRef r)
					{
						r.Text = base.Text;
					});
				}
			}
		}

		internal void UpdateFromTemplate(Server template)
		{
			base.CopySettings(template, typeof(ServerSettings));
		}

		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			using (ServerPropertiesDialog serverPropertiesDialog = ServerPropertiesDialog.NewPropertiesDialog(this, parentForm))
			{
				serverPropertiesDialog.SetActiveTab(activeTabName);
				if (serverPropertiesDialog.ShowDialog() == DialogResult.OK)
				{
					this.UpdateSettings(serverPropertiesDialog);
					ServerTree.Instance.OnNodeChanged(this, ChangeType.PropertyChanged);
					ServerTree.Instance.OnGroupChanged(base.Parent as GroupBase, ChangeType.InvalidateUI);
				}
			}
		}

		public override void CollectNodesToInvalidate(bool recurseChildren, HashSet<RdcTreeNode> set)
		{
			set.Add(this);
			this._serverRefList.ForEach(delegate(ServerRef r)
			{
				r.CollectNodesToInvalidate(recurseChildren, set);
			});
		}

		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("server");
			base.WriteXmlSettingsGroups(tw);
			tw.WriteEndElement();
		}

		public override bool CanDropOnTarget(RdcTreeNode targetNode)
		{
			GroupBase groupBase = (targetNode as GroupBase) ?? (targetNode.Parent as GroupBase);
			return groupBase != null && groupBase.CanDropServers() && (groupBase.DropBehavior() == DragDropEffects.Copy || this.AllowEdit(false));
		}

		public override bool ConfirmRemove(bool askUser)
		{
			if (this.IsConnected)
			{
				FormTools.InformationDialog("There is an active session on " + base.Text + ". Disconnect it before removing the server.");
				return false;
			}
			return base.ConfirmRemove(askUser);
		}

		private Size GetRemoteDesktopSize()
		{
			if (base.RemoteDesktopSettings.DesktopSizeSameAsClientAreaSize.Value)
			{
				if (this.IsClientDocked)
				{
					return Program.TheForm.GetClientSize();
				}
				return this.ServerForm.ClientSize;
			}
			else
			{
				if (base.RemoteDesktopSettings.DesktopSizeFullScreen.Value)
				{
					return Screen.GetBounds(this.ParentForm).Size;
				}
				return base.RemoteDesktopSettings.DesktopSize.Value;
			}
		}

		internal override void GoFullScreen()
		{
			if (this.IsConnected)
			{
				RdpClient client = this.Client;
				if (client != null)
				{
					client.Control.Enabled = true;
					client.MsRdpClient.FullScreen = true;
				}
			}
		}

		internal override void LeaveFullScreen()
		{
			if (this.IsConnected)
			{
				RdpClient client = this.Client;
				if (client != null)
				{
					client.MsRdpClient.FullScreen = false;
				}
			}
		}

		internal override void Undock()
		{
			if (this.IsClientDocked)
			{
				this.InitClient();
				Program.TheForm.RemoveFromClientPanel(this._client.Control);
				bool visible = this._client.Control.Visible;
				this._client.Control.Enabled = true;
				ServerForm form = new ServerForm(this);
				Program.PluginAction(delegate(IPlugin p)
				{
					p.OnUndockServer(form);
				});
				Program.ShowForm(form);
				this._serverBox.SetText();
				if (visible)
				{
					this._serverBox.Show();
				}
			}
		}

		internal override void Dock()
		{
			if (this.IsClientUndocked)
			{
				this.ServerForm.Close();
				return;
			}
			this._serverBox.SetText();
			if (!this.IsConnected)
			{
				this.DestroyClient();
				return;
			}
			Program.TheForm.AddToClientPanel(this._client.Control);
			this.SetClientSizeProperties();
			if (this._serverBox.Visible && !this.UseServerBox)
			{
				this._client.Control.Size = this._serverBox.Size;
				this._client.Control.Location = this._serverBox.Location;
				this._serverBox.Hide();
			}
			else
			{
				this._client.Control.Hide();
			}
			this.EnableDisableClient();
		}

		private void ClientGotFocus(object sender, EventArgs args)
		{
			Action<Server> focusReceived = Server.FocusReceived;
			if (focusReceived != null)
			{
				focusReceived(this);
			}
		}

		internal void EnableDisableClient()
		{
			if (this.IsClientInitialized && this.IsClientDocked)
			{
				GroupBase groupBase = base.Parent as GroupBase;
				groupBase.InheritSettings();
				this.Client.Control.Enabled = (!base.IsThumbnail || groupBase.DisplaySettings.AllowThumbnailSessionInteraction.Value);
			}
		}

		public const string XmlNodeName = "server";

		internal const string XmlDisplayNameTag = "displayName";

		internal const string XmlServerNameTag = "name";

		internal const string XmlCommentTag = "comment";

		internal const string ConnectionTypeTag = "connectionType";

		internal const string VirtualMachineIdTag = "vmId";

		private RdpClient.ConnectionState _connectionState;

		private const bool SimulateConnections = false;

		private static readonly Dictionary<string, Helpers.ReadXmlDelegate> PropertyActions = new Dictionary<string, Helpers.ReadXmlDelegate>
		{
			{
				"name",
				delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
				{
					(node as Server).Properties.ServerName.Value = childNode.InnerText;
				}
			},
			{
				"connectionType",
				delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
				{
					ConnectionType value;
					Enum.TryParse<ConnectionType>(childNode.InnerText, out value);
					(node as Server).Properties.ConnectionType.Value = value;
				}
			},
			{
				"vmId",
				delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
				{
					(node as Server).Properties.VirtualMachineId.Value = childNode.InnerText;
				}
			},
			{
				"displayName",
				delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
				{
					(node as Server).Properties.DisplayName.Value = childNode.InnerText;
				}
			},
			{
				"comment",
				delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
				{
					XmlNode firstChild = childNode.FirstChild;
					if (firstChild != null)
					{
						(node as Server).Properties.Comment.Value = childNode.InnerText;
					}
				}
			}
		};

		private RdpClient _client;

		private ServerBox _serverBox;

		private readonly List<ServerRef> _serverRefList;

		private ServerBase.DisplayStates _displayState;

		private string _disconnectionReason = string.Empty;

		private readonly object _connectionStateLock = new object();

		private int _noFullScreenBehavior;

		private static readonly Server.DisconnectionReason[] DisconnectionReasons = new Server.DisconnectionReason[]
		{
			new Server.DisconnectionReason(1, ""),
			new Server.DisconnectionReason(2, ""),
			new Server.DisconnectionReason(3, ""),
			new Server.DisconnectionReason(260, "DNS name lookup failure"),
			new Server.DisconnectionReason(263, "Authentication failure"),
			new Server.DisconnectionReason(264, "Connection timed out"),
			new Server.DisconnectionReason(516, "Unable to establish a connection"),
			new Server.DisconnectionReason(522, "Smart card reader not detected"),
			new Server.DisconnectionReason(1289, "Server does not support authentication"),
			new Server.DisconnectionReason(1800, "You already have a console session in progress"),
			new Server.DisconnectionReason(2052, "Bad IP address specified"),
			new Server.DisconnectionReason(2055, "Login failed"),
			new Server.DisconnectionReason(2056, "Server has no sessions available"),
			new Server.DisconnectionReason(2308, "Socket closed"),
			new Server.DisconnectionReason(2567, "The specified user has no account"),
			new Server.DisconnectionReason(2824, "Session connected by other client"),
			new Server.DisconnectionReason(2825, "Server authentication failure"),
			new Server.DisconnectionReason(3847, "The password is expired"),
			new Server.DisconnectionReason(4615, "The user password must be changed before logging on for the first time"),
			new Server.DisconnectionReason(7175, "An incorrect PIN was presented to the smart card"),
			new Server.DisconnectionReason(7943, "No credentials entered"),
			new Server.DisconnectionReason(8711, "The smart card is blocked"),
			new Server.DisconnectionReason(50331655, "Gateway authentication failure"),
			new Server.DisconnectionReason(50331656, "Server not found"),
			new Server.DisconnectionReason(50331660, "Unable to connect to gateway"),
			new Server.DisconnectionReason(50331669, "Smartcard authentication failure"),
			new Server.DisconnectionReason(50331670, "Server not found"),
			new Server.DisconnectionReason(50331676, "Your user or computer account is not authorized to access the gateway server"),
			new Server.DisconnectionReason(50331677, "No gateway credentials entered"),
			new Server.DisconnectionReason(50331678, ""),
			new Server.DisconnectionReason(50331686, "No smartcard PIN entered")
		};

		private static readonly Server.DisconnectionReason[] ExtendedDisconnectionReasons = new Server.DisconnectionReason[]
		{
			new Server.DisconnectionReason(0, "No additional information is available"),
			new Server.DisconnectionReason(1, ""),
			new Server.DisconnectionReason(2, ""),
			new Server.DisconnectionReason(3, "The server has disconnected the client because the client has been idle for a period of time longer than the designated time-out period"),
			new Server.DisconnectionReason(4, "The server has disconnected the client because the client has exceeded the period designated for connection"),
			new Server.DisconnectionReason(5, "The client's connection was replaced by another connection"),
			new Server.DisconnectionReason(6, "No memory is available"),
			new Server.DisconnectionReason(7, "The server denied the connection"),
			new Server.DisconnectionReason(8, "The server denied the connection for security reasons"),
			new Server.DisconnectionReason(9, "The user account is not authorized for remote login"),
			new Server.DisconnectionReason(10, "The user account credentials must be reentered"),
			new Server.DisconnectionReason(11, "The client was remotely disconnected"),
			new Server.DisconnectionReason(12, "The connection was lost"),
			new Server.DisconnectionReason(256, "Internal licensing error"),
			new Server.DisconnectionReason(257, "No license server was available"),
			new Server.DisconnectionReason(258, "No valid software license was available"),
			new Server.DisconnectionReason(259, "The remote computer received a licensing message that was not valid"),
			new Server.DisconnectionReason(260, "The hardware ID does not match the one designated on the software license"),
			new Server.DisconnectionReason(261, "Client license error"),
			new Server.DisconnectionReason(262, "Network problems occurred during the licensing protocol"),
			new Server.DisconnectionReason(263, "The client ended the licensing protocol prematurely"),
			new Server.DisconnectionReason(264, "A licensing message was encrypted incorrectly"),
			new Server.DisconnectionReason(265, "The local computer's client access license could not be upgraded or renewed"),
			new Server.DisconnectionReason(266, "The remote computer is not licensed to accept remote connections"),
			new Server.DisconnectionReason(267, ""),
			new Server.DisconnectionReason(768, "")
		};

		private class DisconnectionReason
		{
			public DisconnectionReason(int code, string text)
			{
				this.Code = code;
				this.Text = text;
			}

			public readonly int Code;

			public readonly string Text;
		}
	}
}
