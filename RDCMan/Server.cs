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
	// Token: 0x020000D7 RID: 215
	public class Server : ServerBase
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x000182A8 File Offset: 0x000164A8
		static Server()
		{
			ServerTree.Instance.ServerChanged += Server.OnServerChanged;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00004E40 File Offset: 0x00003040
		protected Server()
		{
			this._serverRefList = new List<ServerRef>();
			this.ChangeImageIndex(ImageConstants.DisconnectedServer);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00018764 File Offset: 0x00016964
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

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000504 RID: 1284 RVA: 0x000187C0 File Offset: 0x000169C0
		// (remove) Token: 0x06000505 RID: 1285 RVA: 0x000187F4 File Offset: 0x000169F4
		public static event Action<ConnectionStateChangedEventArgs> ConnectionStateChanged;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000506 RID: 1286 RVA: 0x00018828 File Offset: 0x00016A28
		// (remove) Token: 0x06000507 RID: 1287 RVA: 0x0001885C File Offset: 0x00016A5C
		public static event Action<Server> FocusReceived;

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00004E70 File Offset: 0x00003070
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00018890 File Offset: 0x00016A90
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00004E78 File Offset: 0x00003078
		public override Server ServerNode
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00004E7B File Offset: 0x0000307B
		public override string RemoveTypeDescription
		{
			get
			{
				return "server";
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00004E82 File Offset: 0x00003082
		public override ServerSettings Properties
		{
			get
			{
				return base.Properties as ServerSettings;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00004E8F File Offset: 0x0000308F
		public override CommonDisplaySettings DisplaySettings
		{
			get
			{
				return base.DisplaySettings;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00004E97 File Offset: 0x00003097
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004E9F File Offset: 0x0000309F
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00004EC1 File Offset: 0x000030C1
		public override bool IsClientDocked
		{
			get
			{
				return !this.IsClientInitialized || this.ServerForm == null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00004ED6 File Offset: 0x000030D6
		public override bool IsClientUndocked
		{
			get
			{
				return this.IsClientInitialized && this.ServerForm != null;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00004EEB File Offset: 0x000030EB
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00004F02 File Offset: 0x00003102
		private ServerForm ServerForm
		{
			get
			{
				return this.Client.Control.Parent as ServerForm;
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00004F19 File Offset: 0x00003119
		public void SuspendFullScreenBehavior()
		{
			Interlocked.Increment(ref this._noFullScreenBehavior);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00004F27 File Offset: 0x00003127
		public void ResumeFullScreenBehavior()
		{
			Interlocked.Decrement(ref this._noFullScreenBehavior);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00004F35 File Offset: 0x00003135
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004F5B File Offset: 0x0000315B
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00004F82 File Offset: 0x00003182
		private bool IsClientInPanel
		{
			get
			{
				return this.IsClientInitialized && this.IsClientDocked;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00004F94 File Offset: 0x00003194
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00004FBA File Offset: 0x000031BA
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

		// Token: 0x0600051B RID: 1307 RVA: 0x000188CC File Offset: 0x00016ACC
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00004FE1 File Offset: 0x000031E1
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00005001 File Offset: 0x00003201
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00018910 File Offset: 0x00016B10
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

		// Token: 0x0600051F RID: 1311 RVA: 0x00005021 File Offset: 0x00003221
		private void SetText()
		{
			this._serverBox.SetText();
			if (this.IsClientInitialized)
			{
				this._client.SetText();
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00018998 File Offset: 0x00016B98
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

		// Token: 0x06000521 RID: 1313 RVA: 0x00005041 File Offset: 0x00003241
		protected override void InitSettings()
		{
			base.Properties = new ServerSettings();
			base.DisplaySettings = new ServerDisplaySettings();
			base.InitSettings();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000505F File Offset: 0x0000325F
		internal override void Focus()
		{
			if (!this.IsClientUndocked && this.UseServerBox)
			{
				this._serverBox.Focus();
				return;
			}
			this._client.Control.Focus();
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000508F File Offset: 0x0000328F
		internal override void FocusConnectedClient()
		{
			if (this.IsConnected && this.IsClientInitialized)
			{
				this._client.Control.Focus();
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000050B2 File Offset: 0x000032B2
		internal void SetNormalView()
		{
			this.DisplayState = ServerBase.DisplayStates.Normal;
			this.Size = Program.TheForm.GetClientSize();
			this.Location = new Point(0, 0);
			this.EnableDisableClient();
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000050DE File Offset: 0x000032DE
		internal void SetThumbnailView(int left, int top, int width, int height)
		{
			this.DisplayState = ServerBase.DisplayStates.Thumbnail;
			this.Size = new Size(width, height);
			this.Location = new Point(left, top);
			this.EnableDisableClient();
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000189DC File Offset: 0x00016BDC
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00005108 File Offset: 0x00003308
		internal RdpClient Client
		{
			get
			{
				return this._client;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00005110 File Offset: 0x00003310
		private bool IsClientInitialized
		{
			get
			{
				return this.Client != null;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000511B File Offset: 0x0000331B
		protected void InitRequiredForDisplay()
		{
			this._serverBox = new ServerBox(this);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00005129 File Offset: 0x00003329
		private void AddToClientPanel()
		{
			if (this._serverBox.Parent == null)
			{
				Program.TheForm.AddToClientPanel(this._serverBox);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00005148 File Offset: 0x00003348
		private void RemoveFromClientPanel()
		{
			if (this._serverBox.Parent != null)
			{
				Program.TheForm.RemoveFromClientPanel(this._serverBox);
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00018A90 File Offset: 0x00016C90
		private void InitClient()
		{
			if (this.IsClientInitialized)
			{
				return;
			}
			this._client = RdpClient.AllocClient(this, Program.TheForm);
			this._client.ConnectConnectionHandlers(new EventHandler(this.OnConnected), new EventHandler(this.OnConnecting), new IMsTscAxEvents_OnDisconnectedEventHandler(this.OnDisconnected), new IMsTscAxEvents_OnAutoReconnectingEventHandler(this.OnAutoReconnecting), new IMsTscAxEvents_OnAutoReconnecting2EventHandler(this.OnAutoReconnecting2), new EventHandler(this.OnAutoReconnected), new IMsTscAxEvents_OnFocusReleasedEventHandler(this.OnFocusReleased));
			this._client.ConnectContainerHandlers(new EventHandler(this.OnRequestGoFullScreen), new EventHandler(this.OnRequestLeaveFullScreen), new EventHandler(this.OnRequestContainerMinimize), new IMsTscAxEvents_OnConfirmCloseEventHandler(this.OnConfirmClose), new IMsTscAxEvents_OnFatalErrorEventHandler(this.OnFatalError));
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

		// Token: 0x0600052D RID: 1325 RVA: 0x00018C10 File Offset: 0x00016E10
		private void DestroyClient()
		{
			if (!this.IsClientInitialized)
			{
				return;
			}
			this._client.DisconnectConnectionHandlers(new EventHandler(this.OnConnected), new EventHandler(this.OnConnecting), new IMsTscAxEvents_OnDisconnectedEventHandler(this.OnDisconnected), new IMsTscAxEvents_OnAutoReconnectingEventHandler(this.OnAutoReconnecting), new IMsTscAxEvents_OnAutoReconnecting2EventHandler(this.OnAutoReconnecting2), new EventHandler(this.OnAutoReconnected), new IMsTscAxEvents_OnFocusReleasedEventHandler(this.OnFocusReleased));
			this._client.DisconnectContainerHandlers(new EventHandler(this.OnRequestGoFullScreen), new EventHandler(this.OnRequestLeaveFullScreen), new EventHandler(this.OnRequestContainerMinimize), new IMsTscAxEvents_OnConfirmCloseEventHandler(this.OnConfirmClose), new IMsTscAxEvents_OnFatalErrorEventHandler(this.OnFatalError));
			RdpClient client = this._client;
			this._client = null;
			RdpClient.ReleaseClient(client);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00005167 File Offset: 0x00003367
		internal static Server CreateForAddDialog()
		{
			return new Server();
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00018CE0 File Offset: 0x00016EE0
		public static Server Create(string serverName, string displayName, GroupBase group)
		{
			Server server = new Server();
			server.Properties.ServerName.Value = serverName;
			server.Properties.DisplayName.Value = displayName;
			server.FinishConstruction(group);
			return server;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00018D20 File Offset: 0x00016F20
		internal static Server Create(ServerPropertiesDialog dlg)
		{
			Server server = dlg.AssociatedNode as Server;
			server.FinishConstruction(dlg.PropertiesPage.ParentGroup);
			return server;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00018D4C File Offset: 0x00016F4C
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

		// Token: 0x06000532 RID: 1330 RVA: 0x00018DA8 File Offset: 0x00016FA8
		internal static Server Create(XmlNode xmlNode, GroupBase group, ICollection<string> errors)
		{
			Server server = new Server();
			server.ReadXml(xmlNode, errors);
			server.FinishConstruction(group);
			return server;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00018DCC File Offset: 0x00016FCC
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

		// Token: 0x06000534 RID: 1332 RVA: 0x0000516E File Offset: 0x0000336E
		private void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(Server.PropertyActions, xmlNode, errors);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00018E1C File Offset: 0x0001701C
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0000517D File Offset: 0x0000337D
		private bool UseServerBox
		{
			get
			{
				return !this.IsClientInPanel || (base.IsThumbnail && !(this.ServerNode.Parent as GroupBase).DisplaySettings.SessionThumbnailPreview.Value);
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000051B5 File Offset: 0x000033B5
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

		// Token: 0x06000538 RID: 1336 RVA: 0x000051E1 File Offset: 0x000033E1
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

		// Token: 0x06000539 RID: 1337 RVA: 0x00004989 File Offset: 0x00002B89
		public override void Connect()
		{
			this.ConnectAs(null, null);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00018E8C File Offset: 0x0001708C
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
							advancedSettings2.AuthenticationLevel = 0u;
							advancedSettings2.AuthenticationServiceClass = "Microsoft Virtual Console Service";
							advancedSettings2.EnableCredSspSupport = true;
							advancedSettings3.NegotiateSecurityLayer = false;
						}
						else
						{
							str = "port";
							advancedSettings.RDPPort = value;
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
								for (uint num = 0u; num < driveCollection.DriveCount; num += 1u)
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

		// Token: 0x0600053B RID: 1339 RVA: 0x00019614 File Offset: 0x00017814
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

		// Token: 0x0600053C RID: 1340 RVA: 0x00019664 File Offset: 0x00017864
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

		// Token: 0x0600053D RID: 1341 RVA: 0x000196A8 File Offset: 0x000178A8
		private void ConfigureGateway()
		{
			IMsRdpClientTransportSettings transportSettings = this._client.TransportSettings;
			if (base.GatewaySettings.UseGatewayServer.Value)
			{
				uint gatewayUsageMethod = base.GatewaySettings.BypassGatewayForLocalAddresses.Value ? 2u : 1u;
				transportSettings.GatewayProfileUsageMethod = 1u;
				transportSettings.GatewayUsageMethod = gatewayUsageMethod;
				uint value = (uint)base.GatewaySettings.LogonMethod.Value;
				transportSettings.GatewayCredsSource = value;
				transportSettings.GatewayHostname = base.GatewaySettings.HostName.Value;
				IMsRdpClientTransportSettings2 transportSettings2 = this._client.TransportSettings2;
				if (transportSettings2 != null)
				{
					transportSettings2.GatewayCredSharing = (base.GatewaySettings.CredentialSharing.Value ? 1u : 0u);
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
				transportSettings.GatewayProfileUsageMethod = 0u;
				transportSettings.GatewayUsageMethod = 0u;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000197B8 File Offset: 0x000179B8
		public override void Reconnect()
		{
			Log.Write("Begin reconnect to {0}", new object[]
			{
				base.DisplayName
			});
			ReconnectServerRef reconnectServerRef = ReconnectGroup.Instance.AddReference(this);
			reconnectServerRef.Start(true);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000197F4 File Offset: 0x000179F4
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

		// Token: 0x06000540 RID: 1344 RVA: 0x0000521B File Offset: 0x0000341B
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

		// Token: 0x06000541 RID: 1345 RVA: 0x0001987C File Offset: 0x00017A7C
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

		// Token: 0x06000542 RID: 1346 RVA: 0x00005252 File Offset: 0x00003452
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0000528C File Offset: 0x0000348C
		public override bool IsConnected
		{
			get
			{
				return this.ConnectionState > RdpClient.ConnectionState.Disconnected;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00005297 File Offset: 0x00003497
		public override bool IsClientFullScreen
		{
			get
			{
				return this.IsClientInitialized && this.Client.MsRdpClient.FullScreen;
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00019A54 File Offset: 0x00017C54
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

		// Token: 0x06000546 RID: 1350 RVA: 0x00019AB0 File Offset: 0x00017CB0
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

		// Token: 0x06000547 RID: 1351 RVA: 0x00019B54 File Offset: 0x00017D54
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
				if (this._client.MsRdpClient.ExtendedDisconnectReason != null)
				{
					disconnectionReason = Server.ExtendedDisconnectionReasons.SingleOrDefault((Server.DisconnectionReason r) => r.Code == this._client.MsRdpClient.ExtendedDisconnectReason);
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

		// Token: 0x06000548 RID: 1352 RVA: 0x000052B3 File Offset: 0x000034B3
		private void OnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			Log.Write("OnAutoReconnecting {0}: disconnectReason={1} attemptCount={2}", new object[]
			{
				base.DisplayName,
				e.disconnectReason,
				e.attemptCount
			});
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00019D08 File Offset: 0x00017F08
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

		// Token: 0x0600054A RID: 1354 RVA: 0x000052EA File Offset: 0x000034EA
		private void OnAutoReconnected(object sender, EventArgs e)
		{
			Log.Write("OnAutoReconnected {0}", new object[]
			{
				base.DisplayName
			});
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00019D68 File Offset: 0x00017F68
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

		// Token: 0x0600054C RID: 1356 RVA: 0x00005305 File Offset: 0x00003505
		private void OnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			Log.Write("OnFocusReleased {0}: direction={1}", new object[]
			{
				base.DisplayName,
				e.iDirection
			});
			NodeHelper.SelectNewActiveConnection(e.iDirection == -1);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000533C File Offset: 0x0000353C
		private void OnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			e.pfAllowClose = true;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00005345 File Offset: 0x00003545
		private void OnRequestContainerMinimize(object sender, EventArgs e)
		{
			Log.Write("OnRequestContainerMinimize {0}", new object[]
			{
				base.DisplayName
			});
			this.ParentForm.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000536C File Offset: 0x0000356C
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

		// Token: 0x06000550 RID: 1360 RVA: 0x00019DD8 File Offset: 0x00017FD8
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
				this.Client.AdvancedSettings2.SmartSizing = (base.IsThumbnail | this.DisplaySettings.SmartSizeDockedWindow.Value);
				return;
			}
			if (this.IsClientInitialized)
			{
				this.Client.AdvancedSettings2.SmartSizing = this.DisplaySettings.SmartSizeUndockedWindow.Value;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000053A7 File Offset: 0x000035A7
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

		// Token: 0x06000552 RID: 1362 RVA: 0x000053E6 File Offset: 0x000035E6
		private void OnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			Log.Write("OnFatalError {0}: errorCode={1}", new object[]
			{
				base.DisplayName,
				e.errorCode
			});
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000540F File Offset: 0x0000360F
		public void AddServerRef(ServerRef serverRef)
		{
			this._serverRefList.Add(serverRef);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000541D File Offset: 0x0000361D
		public TServerRef FindServerRef<TServerRef>() where TServerRef : ServerRef
		{
			return this._serverRefList.FirstOrDefault((ServerRef r) => r is TServerRef) as TServerRef;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00019E60 File Offset: 0x00018060
		public TServerRef FindServerRef<TServerRef>(GroupBase parent) where TServerRef : ServerRef
		{
			return this._serverRefList.FirstOrDefault((ServerRef r) => r is TServerRef && r.Parent == parent) as TServerRef;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00005453 File Offset: 0x00003653
		public void RemoveServerRef(ServerRef serverRef)
		{
			this._serverRefList.Remove(serverRef);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00019E9C File Offset: 0x0001809C
		public void VisitServerRefs(Action<ServerRef> action)
		{
			ServerRef[] array = new ServerRef[this._serverRefList.Count];
			this._serverRefList.CopyTo(array);
			array.ForEach(action);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00019ED0 File Offset: 0x000180D0
		public override void ChangeImageIndex(ImageConstants index)
		{
			base.ChangeImageIndex(index);
			this.VisitServerRefs(delegate(ServerRef r)
			{
				r.ChangeImageIndex(index);
			});
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00019F08 File Offset: 0x00018108
		public void SendRemoteAction(RemoteSessionActionType action)
		{
			IMsRdpClient8 msRdpClient = this._client.MsRdpClient8;
			msRdpClient.SendRemoteAction(action);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00019F28 File Offset: 0x00018128
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

		// Token: 0x0600055B RID: 1371 RVA: 0x00005462 File Offset: 0x00003662
		internal void UpdateFromTemplate(Server template)
		{
			base.CopySettings(template, typeof(ServerSettings));
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00019F74 File Offset: 0x00018174
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

		// Token: 0x0600055D RID: 1373 RVA: 0x00019FE0 File Offset: 0x000181E0
		public override void CollectNodesToInvalidate(bool recurseChildren, HashSet<RdcTreeNode> set)
		{
			set.Add(this);
			this._serverRefList.ForEach(delegate(ServerRef r)
			{
				r.CollectNodesToInvalidate(recurseChildren, set);
			});
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00005475 File Offset: 0x00003675
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("server");
			base.WriteXmlSettingsGroups(tw);
			tw.WriteEndElement();
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001A028 File Offset: 0x00018228
		public override bool CanDropOnTarget(RdcTreeNode targetNode)
		{
			GroupBase groupBase = (targetNode as GroupBase) ?? (targetNode.Parent as GroupBase);
			return groupBase != null && groupBase.CanDropServers() && (groupBase.DropBehavior() == DragDropEffects.Copy || this.AllowEdit(false));
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000548F File Offset: 0x0000368F
		public override bool ConfirmRemove(bool askUser)
		{
			if (this.IsConnected)
			{
				FormTools.InformationDialog("There is an active session on " + base.Text + ". Disconnect it before removing the server.");
				return false;
			}
			return base.ConfirmRemove(askUser);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001A06C File Offset: 0x0001826C
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

		// Token: 0x06000562 RID: 1378 RVA: 0x0001A0E0 File Offset: 0x000182E0
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

		// Token: 0x06000563 RID: 1379 RVA: 0x0001A118 File Offset: 0x00018318
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

		// Token: 0x06000564 RID: 1380 RVA: 0x0001A144 File Offset: 0x00018344
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

		// Token: 0x06000565 RID: 1381 RVA: 0x0001A1E0 File Offset: 0x000183E0
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

		// Token: 0x06000566 RID: 1382 RVA: 0x0001A2A4 File Offset: 0x000184A4
		private void ClientGotFocus(object sender, EventArgs args)
		{
			Action<Server> focusReceived = Server.FocusReceived;
			if (focusReceived != null)
			{
				focusReceived(this);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001A2C4 File Offset: 0x000184C4
		internal void EnableDisableClient()
		{
			if (this.IsClientInitialized && this.IsClientDocked)
			{
				GroupBase groupBase = base.Parent as GroupBase;
				groupBase.InheritSettings();
				this.Client.Control.Enabled = (!base.IsThumbnail || groupBase.DisplaySettings.AllowThumbnailSessionInteraction.Value);
			}
		}

		// Token: 0x0400045A RID: 1114
		public const string XmlNodeName = "server";

		// Token: 0x0400045B RID: 1115
		internal const string XmlDisplayNameTag = "displayName";

		// Token: 0x0400045C RID: 1116
		internal const string XmlServerNameTag = "name";

		// Token: 0x0400045D RID: 1117
		internal const string XmlCommentTag = "comment";

		// Token: 0x0400045E RID: 1118
		internal const string ConnectionTypeTag = "connectionType";

		// Token: 0x0400045F RID: 1119
		internal const string VirtualMachineIdTag = "vmId";

		// Token: 0x04000462 RID: 1122
		private RdpClient.ConnectionState _connectionState;

		// Token: 0x04000463 RID: 1123
		private const bool SimulateConnections = false;

		// Token: 0x04000464 RID: 1124
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

		// Token: 0x04000465 RID: 1125
		private RdpClient _client;

		// Token: 0x04000466 RID: 1126
		private ServerBox _serverBox;

		// Token: 0x04000467 RID: 1127
		private readonly List<ServerRef> _serverRefList;

		// Token: 0x04000468 RID: 1128
		private ServerBase.DisplayStates _displayState;

		// Token: 0x04000469 RID: 1129
		private string _disconnectionReason = string.Empty;

		// Token: 0x0400046A RID: 1130
		private readonly object _connectionStateLock = new object();

		// Token: 0x0400046B RID: 1131
		private int _noFullScreenBehavior;

		// Token: 0x0400046C RID: 1132
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

		// Token: 0x0400046D RID: 1133
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

		// Token: 0x020000D8 RID: 216
		private class DisconnectionReason
		{
			// Token: 0x06000569 RID: 1385 RVA: 0x000054CA File Offset: 0x000036CA
			public DisconnectionReason(int code, string text)
			{
				this.Code = code;
				this.Text = text;
			}

			// Token: 0x0400046E RID: 1134
			public readonly int Code;

			// Token: 0x0400046F RID: 1135
			public readonly string Text;
		}
	}
}
