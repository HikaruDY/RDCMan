using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000142 RID: 322
	internal partial class ServerForm : RdcBaseForm, IUndockedServerForm
	{
		// Token: 0x060007C1 RID: 1985 RVA: 0x0001F120 File Offset: 0x0001D320
		static ServerForm()
		{
			ServerForm.Shortcuts = new Dictionary<Keys, Action<ServerForm>>
			{
				{
					Keys.Return,
					delegate(ServerForm f)
					{
						f._server.Connect();
					}
				},
				{
					Keys.LButton | Keys.MButton | Keys.Back | Keys.Shift,
					delegate(ServerForm f)
					{
						f._server.DoConnectAs();
					}
				},
				{
					Keys.LButton | Keys.MButton | Keys.Back | Keys.Alt,
					delegate(ServerForm f)
					{
						f._server.DoPropertiesDialog();
					}
				}
			};
			ServerTree.Instance.GroupChanged += ServerForm.OnGroupChanged;
			ServerTree.Instance.ServerChanged += ServerForm.OnServerChanged;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0001F1BC File Offset: 0x0001D3BC
		private static void OnGroupChanged(GroupChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			using (Helpers.Timer("updating server form settings from group {0}", new object[]
			{
				e.Group.Text
			}))
			{
				if (e.Group == ServerTree.Instance.RootNode)
				{
					ServerForm.UpdateFromGlobalSettings();
				}
				ServerForm.UpdateFromServerSettings();
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0001F23C File Offset: 0x0001D43C
		private static void OnServerChanged(ServerChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			using (Helpers.Timer("updating server form settings from server {0}", new object[]
			{
				e.Server.DisplayName
			}))
			{
				ServerForm.UpdateFromServerSettings();
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00006E5B File Offset: 0x0000505B
		private static void UpdateFromServerSettings()
		{
			ServerForm.ServerForms.ForEach(delegate(ServerForm f)
			{
				f._server.InheritSettings();
				f._server.SetClientSizeProperties();
				f.SetTitle();
			});
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
		public ServerForm(Server server)
		{
			this._server = server;
			server.InheritSettings();
			base.Icon = Program.TheForm.Icon;
			this.SetTitle();
			Size clientSize;
			if (server.RemoteDesktopSettings.DesktopSizeSameAsClientAreaSize.Value || server.RemoteDesktopSettings.DesktopSizeFullScreen.Value)
			{
				clientSize = Program.TheForm.GetClientSize();
			}
			else
			{
				clientSize = server.RemoteDesktopSettings.DesktopSize.Value;
			}
			this.CreateMainMenu();
			base.SetMainMenuVisibility();
			this.SetClientSize(clientSize);
			this.ScaleAndLayout();
			base.Controls.Add(this._server.Client.Control);
			this._server.SetClientSizeProperties();
			ServerForm.ServerForms.Add(this);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00003EA7 File Offset: 0x000020A7
		MenuStrip IUndockedServerForm.MainMenuStrip
		{
			get
			{
				return this._menuStrip;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00006E86 File Offset: 0x00005086
		ServerBase IUndockedServerForm.Server
		{
			get
			{
				return this._server;
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00006E8E File Offset: 0x0000508E
		private static void UpdateFromGlobalSettings()
		{
			ServerForm.ServerForms.ForEach(delegate(ServerForm f)
			{
				f.SetMainMenuVisibility();
				f.SetClientSize(f._clientSize);
			});
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0001F368 File Offset: 0x0001D568
		public override void SetClientSize(Size size)
		{
			int num = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			base.ClientSize = new Size(size.Width, size.Height + num);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00006EB9 File Offset: 0x000050B9
		public override Size GetClientSize()
		{
			return this._clientSize;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00006EC1 File Offset: 0x000050C1
		protected override void OnShown(EventArgs e)
		{
			this._server.Client.Control.Show();
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00006ED8 File Offset: 0x000050D8
		protected override void OnClosed(EventArgs e)
		{
			ServerForm.ServerForms.Remove(this);
			this._server.LeaveFullScreen();
			base.Controls.Remove(this._server.Client.Control);
			this._server.Dock();
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			int num = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			this._clientSize = new Size(base.ClientSize.Width, base.ClientSize.Height - num);
			this.LayoutContent();
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0001F40C File Offset: 0x0001D60C
		protected override void LayoutContent()
		{
			int y = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			this._server.Client.Control.Bounds = new Rectangle(0, y, this._clientSize.Width, this._clientSize.Height);
			this._menuPanel.Width = base.ClientSize.Width;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0001F480 File Offset: 0x0001D680
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			Action<ServerForm> action;
			if (!this._menuStrip.IsActive && ServerForm.Shortcuts.TryGetValue(keyData, out action))
			{
				action(this);
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001F4BC File Offset: 0x0001D6BC
		protected void CreateMainMenu()
		{
			this._sessionConnectServerMenuItem = new DelegateMenuItem("&Connect server", MenuNames.SessionConnect, "Enter", delegate()
			{
				this._server.Connect();
			});
			this._sessionConnectServerAsMenuItem = new DelegateMenuItem("Connect server &as...", MenuNames.SessionConnectAs, "Shift+Enter", delegate()
			{
				this._server.DoConnectAs();
			});
			this._sessionReconnectServerMenuItem = new DelegateMenuItem("R&econnect server", MenuNames.SessionReconnect, delegate()
			{
				this._server.Reconnect();
			});
			this._sessionDisconnectServerMenuItem = new DelegateMenuItem("&Disconnect server", MenuNames.SessionDisconnect, delegate()
			{
				this._server.Disconnect();
			});
			this._sessionFullScreenMenuItem = new DelegateMenuItem("&Full screen", MenuNames.SessionFullScreen, delegate()
			{
				this._server.Client.MsRdpClient.FullScreen = true;
			});
			DelegateMenuItem value = new DelegateMenuItem("Doc&k", MenuNames.SessionDock, delegate()
			{
				base.Close();
			});
			this._sessionScreenCaptureMenuItem = new DelegateMenuItem("Screen capture", MenuNames.SessionScreenCapture, delegate()
			{
				this._server.ScreenCapture();
			});
			DelegateMenuItem value2 = new DelegateMenuItem("P&roperties", MenuNames.EditProperties, "Alt+Enter", delegate()
			{
				this._server.DoPropertiesDialog();
			});
			ToolStripMenuItem toolStripMenuItem = this._menuStrip.Add("&Session", MenuNames.Session);
			toolStripMenuItem.DropDownItems.Add(this._sessionConnectServerMenuItem);
			toolStripMenuItem.DropDownItems.Add(this._sessionConnectServerAsMenuItem);
			toolStripMenuItem.DropDownItems.Add(this._sessionReconnectServerMenuItem);
			toolStripMenuItem.DropDownItems.Add("-");
			this._sessionSendKeysMenuItem = toolStripMenuItem.DropDownItems.Add("Send keys", MenuNames.SessionSendKeys);
			MenuHelper.AddSendKeysMenuItems(this._sessionSendKeysMenuItem, () => this._server);
			if (RdpClient.SupportsRemoteSessionActions)
			{
				this._sessionRemoteActionsMenuItem = toolStripMenuItem.DropDownItems.Add("Remote actions", MenuNames.SessionRemoteActions);
				MenuHelper.AddRemoteActionsMenuItems(this._sessionRemoteActionsMenuItem, () => this._server);
			}
			toolStripMenuItem.DropDownItems.Add("-");
			toolStripMenuItem.DropDownItems.Add(this._sessionDisconnectServerMenuItem);
			toolStripMenuItem.DropDownItems.Add("-");
			toolStripMenuItem.DropDownItems.Add(this._sessionFullScreenMenuItem);
			toolStripMenuItem.DropDownItems.Add(value);
			toolStripMenuItem.DropDownItems.Add("-");
			toolStripMenuItem.DropDownItems.Add(this._sessionScreenCaptureMenuItem);
			toolStripMenuItem.DropDownItems.Add("-");
			toolStripMenuItem.DropDownItems.Add(value2);
			ToolStripMenuItem toolStripMenuItem2 = this._menuStrip.Add("&View", MenuNames.View);
			ToolStripMenuItem toolStripMenuItem3 = toolStripMenuItem2.DropDownItems.Add("&Client size", MenuNames.ViewClientSize);
			foreach (Size size in SizeHelper.StockSizes)
			{
				ClientSizeCheckedMenuItem value3 = new ClientSizeCheckedMenuItem(this, size);
				toolStripMenuItem3.DropDownItems.Add(value3);
			}
			toolStripMenuItem3.DropDownItems.Add(new CustomClientSizeCheckedMenuItem(this, "&Custom"));
			toolStripMenuItem3.DropDownItems.Add(new ToolStripMenuItem("From remote desktop size", null, delegate(object s, EventArgs e)
			{
				this.SetClientSize(this._server.IsConnected ? this._server.Client.DesktopSize : this._server.RemoteDesktopSettings.DesktopSize.Value);
			}));
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001F7B4 File Offset: 0x0001D9B4
		protected override void UpdateMainMenu()
		{
			base.UpdateMenuItems(this._menuStrip.Items);
			bool isConnected = this._server.IsConnected;
			this._sessionConnectServerMenuItem.Enabled = !isConnected;
			this._sessionConnectServerAsMenuItem.Enabled = !isConnected;
			this._sessionReconnectServerMenuItem.Enabled = isConnected;
			this._sessionSendKeysMenuItem.Enabled = isConnected;
			if (RdpClient.SupportsRemoteSessionActions)
			{
				this._sessionRemoteActionsMenuItem.Enabled = isConnected;
			}
			this._sessionDisconnectServerMenuItem.Enabled = isConnected;
			this._sessionFullScreenMenuItem.Enabled = isConnected;
			this._sessionScreenCaptureMenuItem.Enabled = isConnected;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00006F17 File Offset: 0x00005117
		private void SetTitle()
		{
			this.Text = this._server.GetQualifiedNameForUI();
		}

		// Token: 0x0400058B RID: 1419
		private static readonly Dictionary<Keys, Action<ServerForm>> Shortcuts;

		// Token: 0x0400058C RID: 1420
		private static readonly List<ServerForm> ServerForms = new List<ServerForm>();

		// Token: 0x0400058D RID: 1421
		private ToolStripMenuItem _sessionConnectServerMenuItem;

		// Token: 0x0400058E RID: 1422
		private ToolStripMenuItem _sessionConnectServerAsMenuItem;

		// Token: 0x0400058F RID: 1423
		private ToolStripMenuItem _sessionReconnectServerMenuItem;

		// Token: 0x04000590 RID: 1424
		private ToolStripMenuItem _sessionSendKeysMenuItem;

		// Token: 0x04000591 RID: 1425
		private ToolStripMenuItem _sessionRemoteActionsMenuItem;

		// Token: 0x04000592 RID: 1426
		private ToolStripMenuItem _sessionDisconnectServerMenuItem;

		// Token: 0x04000593 RID: 1427
		private ToolStripMenuItem _sessionFullScreenMenuItem;

		// Token: 0x04000594 RID: 1428
		private ToolStripMenuItem _sessionScreenCaptureMenuItem;

		// Token: 0x04000595 RID: 1429
		private Size _clientSize;

		// Token: 0x04000596 RID: 1430
		private readonly Server _server;
	}
}
