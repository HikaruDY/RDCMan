using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000B9 RID: 185
	internal partial class ServerForm : RdcBaseForm, IUndockedServerForm
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
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

		// Token: 0x0600064C RID: 1612 RVA: 0x0001E790 File Offset: 0x0001C990
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

		// Token: 0x0600064D RID: 1613 RVA: 0x0001E81C File Offset: 0x0001CA1C
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

		// Token: 0x0600064E RID: 1614 RVA: 0x0001E88C File Offset: 0x0001CA8C
		private static void UpdateFromServerSettings()
		{
			ServerForm.ServerForms.ForEach(delegate(ServerForm f)
			{
				f._server.InheritSettings();
				f._server.SetClientSizeProperties();
				f.SetTitle();
			});
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0001E8BC File Offset: 0x0001CABC
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

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001E98C File Offset: 0x0001CB8C
		MenuStrip IUndockedServerForm.MainMenuStrip
		{
			get
			{
				return this._menuStrip;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001E994 File Offset: 0x0001CB94
		ServerBase IUndockedServerForm.Server
		{
			get
			{
				return this._server;
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0001E99C File Offset: 0x0001CB9C
		private static void UpdateFromGlobalSettings()
		{
			ServerForm.ServerForms.ForEach(delegate(ServerForm f)
			{
				f.SetMainMenuVisibility();
				f.SetClientSize(f._clientSize);
			});
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0001E9CC File Offset: 0x0001CBCC
		public override void SetClientSize(Size size)
		{
			int num = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			base.ClientSize = new Size(size.Width, size.Height + num);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0001EA1C File Offset: 0x0001CC1C
		public override Size GetClientSize()
		{
			return this._clientSize;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001EA24 File Offset: 0x0001CC24
		protected override void OnShown(EventArgs e)
		{
			this._server.Client.Control.Show();
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001EA3C File Offset: 0x0001CC3C
		protected override void OnClosed(EventArgs e)
		{
			ServerForm.ServerForms.Remove(this);
			this._server.LeaveFullScreen();
			base.Controls.Remove(this._server.Client.Control);
			this._server.Dock();
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0001EA8C File Offset: 0x0001CC8C
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			int num = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			if (this._clientSize.Width != 0 && this._clientSize.Height != -num)
			{
				this._savedClientSize = this._clientSize;
			}
			this._clientSize = new Size(base.ClientSize.Width, base.ClientSize.Height - num);
			this.LayoutContent();
			if (this._clientSize.Width != 0 && this._clientSize.Height != -num && (this._savedClientSize.Width != this._clientSize.Width || this._savedClientSize.Height != this._clientSize.Height))
			{
				this._server.Size = this._clientSize;
				this._server.Resize();
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0001EB98 File Offset: 0x0001CD98
		protected override void LayoutContent()
		{
			int y = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			this._server.Client.Control.Bounds = new Rectangle(0, y, this._clientSize.Width, this._clientSize.Height);
			this._menuPanel.Width = base.ClientSize.Width;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001EC18 File Offset: 0x0001CE18
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

		// Token: 0x0600065A RID: 1626 RVA: 0x0001EC5C File Offset: 0x0001CE5C
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

		// Token: 0x0600065B RID: 1627 RVA: 0x0001EF5C File Offset: 0x0001D15C
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

		// Token: 0x0600065C RID: 1628 RVA: 0x0001EFFC File Offset: 0x0001D1FC
		private void SetTitle()
		{
			this.Text = this._server.GetQualifiedNameForUI();
		}

		// Token: 0x04000280 RID: 640
		private static readonly Dictionary<Keys, Action<ServerForm>> Shortcuts;

		// Token: 0x04000281 RID: 641
		private static readonly List<ServerForm> ServerForms = new List<ServerForm>();

		// Token: 0x04000282 RID: 642
		private ToolStripMenuItem _sessionConnectServerMenuItem;

		// Token: 0x04000283 RID: 643
		private ToolStripMenuItem _sessionConnectServerAsMenuItem;

		// Token: 0x04000284 RID: 644
		private ToolStripMenuItem _sessionReconnectServerMenuItem;

		// Token: 0x04000285 RID: 645
		private ToolStripMenuItem _sessionSendKeysMenuItem;

		// Token: 0x04000286 RID: 646
		private ToolStripMenuItem _sessionRemoteActionsMenuItem;

		// Token: 0x04000287 RID: 647
		private ToolStripMenuItem _sessionDisconnectServerMenuItem;

		// Token: 0x04000288 RID: 648
		private ToolStripMenuItem _sessionFullScreenMenuItem;

		// Token: 0x04000289 RID: 649
		private ToolStripMenuItem _sessionScreenCaptureMenuItem;

		// Token: 0x0400028A RID: 650
		private Size _clientSize;

		// Token: 0x0400028B RID: 651
		private Size _savedClientSize;

		// Token: 0x0400028C RID: 652
		private readonly Server _server;
	}
}
