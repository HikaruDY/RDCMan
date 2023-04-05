using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class ServerForm : RdcBaseForm, IUndockedServerForm
	{
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

		private static void UpdateFromServerSettings()
		{
			ServerForm.ServerForms.ForEach(delegate(ServerForm f)
			{
				f._server.InheritSettings();
				f._server.SetClientSizeProperties();
				f.SetTitle();
			});
		}

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

		MenuStrip IUndockedServerForm.MainMenuStrip
		{
			get
			{
				return this._menuStrip;
			}
		}

		ServerBase IUndockedServerForm.Server
		{
			get
			{
				return this._server;
			}
		}

		private static void UpdateFromGlobalSettings()
		{
			ServerForm.ServerForms.ForEach(delegate(ServerForm f)
			{
				f.SetMainMenuVisibility();
				f.SetClientSize(f._clientSize);
			});
		}

		public override void SetClientSize(Size size)
		{
			int num = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			base.ClientSize = new Size(size.Width, size.Height + num);
		}

		public override Size GetClientSize()
		{
			return this._clientSize;
		}

		protected override void OnShown(EventArgs e)
		{
			this._server.Client.Control.Show();
		}

		protected override void OnClosed(EventArgs e)
		{
			ServerForm.ServerForms.Remove(this);
			this._server.LeaveFullScreen();
			base.Controls.Remove(this._server.Client.Control);
			this._server.Dock();
		}

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

		protected override void LayoutContent()
		{
			int y = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			this._server.Client.Control.Bounds = new Rectangle(0, y, this._clientSize.Width, this._clientSize.Height);
			this._menuPanel.Width = base.ClientSize.Width;
		}

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

		private void SetTitle()
		{
			this.Text = this._server.GetQualifiedNameForUI();
		}

		private static readonly Dictionary<Keys, Action<ServerForm>> Shortcuts;

		private static readonly List<ServerForm> ServerForms = new List<ServerForm>();

		private ToolStripMenuItem _sessionConnectServerMenuItem;

		private ToolStripMenuItem _sessionConnectServerAsMenuItem;

		private ToolStripMenuItem _sessionReconnectServerMenuItem;

		private ToolStripMenuItem _sessionSendKeysMenuItem;

		private ToolStripMenuItem _sessionRemoteActionsMenuItem;

		private ToolStripMenuItem _sessionDisconnectServerMenuItem;

		private ToolStripMenuItem _sessionFullScreenMenuItem;

		private ToolStripMenuItem _sessionScreenCaptureMenuItem;

		private Size _clientSize;

		private Size _savedClientSize;

		private readonly Server _server;
	}
}
