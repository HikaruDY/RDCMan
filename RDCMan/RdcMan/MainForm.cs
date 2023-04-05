using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x02000067 RID: 103
	internal partial class MainForm : RdcBaseForm, IMainForm
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x0000F2E0 File Offset: 0x0000D4E0
		private MainForm()
		{
			Dictionary<Keys, Action> dictionary = new Dictionary<Keys, Action>();
			dictionary.Add((Keys)131150, delegate
			{
				this.OnFileNew();
			});
			dictionary.Add((Keys)131151, delegate
			{
				this.OnFileOpen();
			});
			dictionary.Add((Keys)131155, delegate
			{
				this.OnFileSave();
			});
			dictionary.Add((Keys)131137, delegate
			{
				AddNodeDialogHelper.AddServersDialog();
			});
			dictionary.Add((Keys)131143, delegate
			{
				AddNodeDialogHelper.AddGroupDialog();
			});
			dictionary.Add((Keys)131142, delegate
			{
				MenuHelper.FindServers();
			});
			dictionary.Add((Keys)131153, delegate
			{
				MenuHelper.ConnectTo();
			});
			this.Shortcuts = dictionary;
			Dictionary<Keys, Action<RdcTreeNode>> dictionary2 = new Dictionary<Keys, Action<RdcTreeNode>>();
			dictionary2.Add(Keys.Delete, delegate(RdcTreeNode node)
			{
				ServerTree.Instance.ConfirmRemove(node, true);
			});
			dictionary2.Add(Keys.RButton | Keys.MButton | Keys.Back | Keys.Space | Keys.Shift, delegate(RdcTreeNode node)
			{
				ServerTree.Instance.ConfirmRemove(node, false);
			});
			dictionary2.Add(Keys.Return, delegate(RdcTreeNode node)
			{
				node.Connect();
			});
			dictionary2.Add(Keys.LButton | Keys.MButton | Keys.Back | Keys.Shift, delegate(RdcTreeNode node)
			{
				ServerBase serverBase = node as ServerBase;
				bool isConnected;
				if (serverBase != null)
				{
					isConnected = serverBase.IsConnected;
				}
				else
				{
					bool flag;
					(node as GroupBase).AnyOrAllConnected(out flag, out isConnected);
				}
				if (!isConnected)
				{
					node.DoConnectAs();
				}
			});
			dictionary2.Add(Keys.LButton | Keys.MButton | Keys.Back | Keys.Alt, delegate(RdcTreeNode node)
			{
				if (node.HasProperties)
				{
					node.DoPropertiesDialog();
				}
			});
			dictionary2.Add((Keys)131140, delegate(RdcTreeNode node)
			{
				MenuHelper.AddFavorite(node);
			});
			this.SelectedNodeShortcuts = dictionary2;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000F510 File Offset: 0x0000D710
		public static MainForm Create()
		{
			MainForm mainForm = new MainForm();
			Program.TheForm = mainForm;
			if (mainForm.Initialize())
			{
				return mainForm;
			}
			return null;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000F53C File Offset: 0x0000D73C
		public bool IsFullScreen
		{
			get
			{
				return this._fullScreenServer != null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000F548 File Offset: 0x0000D748
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000F550 File Offset: 0x0000D750
		public string DescriptionText { get; private set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000F55C File Offset: 0x0000D75C
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000F564 File Offset: 0x0000D764
		public string VersionText { get; private set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000F570 File Offset: 0x0000D770
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000F578 File Offset: 0x0000D778
		public string BuildText { get; private set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000F584 File Offset: 0x0000D784
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000F58C File Offset: 0x0000D78C
		public bool IsInternalVersion { get; private set; }

		// Token: 0x060002AD RID: 685 RVA: 0x0000F598 File Offset: 0x0000D798
		private bool Initialize()
		{
			this._allowSizeChanged = true;
			base.SuspendLayout();
			this.InitComp();
			try
			{
				RdpClient.Initialize(this);
			}
			catch
			{
				FormTools.ErrorDialog("RDCMan encountered an error during initialization. There are two likely causes for this: an incompatible version of mstscax.dll is registered or it is not registered at all. Please see the help file for details.");
				return false;
			}
			this.CreateMainMenu();
			base.SetMainMenuVisibility();
			this.SetTitle();
			base.VisibleChanged += this.OnVisibleChanged;
			this.ScaleAndLayout();
			return true;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000F614 File Offset: 0x0000D814
		protected override void OnResizeBegin(EventArgs e)
		{
			this._clientPanel.Resizing = true;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000F624 File Offset: 0x0000D824
		protected override void OnResizeEnd(EventArgs e)
		{
			this._clientPanel.Resizing = false;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000F634 File Offset: 0x0000D834
		public void SetTitle()
		{
			TreeNode selectedNode = ServerTree.Instance.SelectedNode;
			string text = this.DescriptionText + " - Sysinternals: www.sysinternals.com";
			if (selectedNode != null)
			{
				ServerBase serverBase = selectedNode as ServerBase;
				string str;
				if (serverBase != null)
				{
					Server serverNode = serverBase.ServerNode;
					str = serverNode.GetQualifiedNameForUI();
				}
				else
				{
					str = selectedNode.Text;
				}
				text = str + " - " + text;
			}
			this.Text = text;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		public void RecordLastFocusedServerLabel(ServerLabel label)
		{
			this._clientPanel.RecordLastFocusedServerLabel(label);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
		public void AddToClientPanel(Control client)
		{
			this._clientPanel.Controls.Add(client);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		public void RemoveFromClientPanel(Control client)
		{
			this._clientPanel.Controls.Remove(client);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
		public void GoToServerTree()
		{
			Program.TheForm.LeaveFullScreen();
			Program.TheForm.EnsureServerTreeVisible();
			ServerTree.Instance.Focus();
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000F704 File Offset: 0x0000D904
		public override void GoFullScreenClient(Server server, bool isTopMostWindow)
		{
			if (this.IsFullScreen)
			{
				return;
			}
			this.LockWindowSize(false);
			this._fullScreenServer = server;
			this.RemoveFromClientPanel(server.Client.Control);
			this._savedControls = new Control[base.Controls.Count];
			base.Controls.CopyTo(this._savedControls, 0);
			base.Controls.Clear();
			base.Controls.Add(server.Client.Control);
			base.GoFullScreenClient(server, isTopMostWindow);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000F794 File Offset: 0x0000D994
		public override bool SwitchFullScreenClient(Server server)
		{
			if (!this.IsFullScreen || !server.IsClientDocked)
			{
				return false;
			}
			if (server == this._fullScreenServer)
			{
				return true;
			}
			RdpClient client = this._fullScreenServer.Client;
			RdpClient client2 = server.Client;
			this._fullScreenServer.SuspendFullScreenBehavior();
			client.MsRdpClient.FullScreen = false;
			this._fullScreenServer.ResumeFullScreenBehavior();
			server.SuspendFullScreenBehavior();
			server.SetNormalView();
			this.RemoveFromClientPanel(client2.Control);
			base.Controls.Add(client2.Control);
			client2.MsRdpClient.FullScreen = true;
			server.ResumeFullScreenBehavior();
			client2.Control.Bounds = new Rectangle(0, 0, client.Control.Width, client.Control.Height);
			server.GoFullScreen();
			client2.Control.Show();
			client.Control.Hide();
			this._fullScreenServer.LeaveFullScreen();
			base.Controls.Remove(client.Control);
			this.AddToClientPanel(client.Control);
			this._fullScreenServer = server;
			return true;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000F8B0 File Offset: 0x0000DAB0
		public void LeaveFullScreen()
		{
			if (this._fullScreenServer != null)
			{
				this._fullScreenServer.LeaveFullScreen();
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000F8C8 File Offset: 0x0000DAC8
		public override void LeaveFullScreenClient(Server server)
		{
			if (!this.IsFullScreen)
			{
				return;
			}
			base.Controls.Clear();
			base.Controls.AddRange(this._savedControls);
			this._savedControls = null;
			this.AddToClientPanel(server.Client.Control);
			base.LeaveFullScreenClient(server);
			this._fullScreenServer = null;
			this.LockWindowSize();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000F930 File Offset: 0x0000DB30
		public void EnsureServerTreeVisible()
		{
			this.UpdateServerTreeVisibility(ControlVisibility.Dock);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000F93C File Offset: 0x0000DB3C
		private void InitComp()
		{
			bool lockWindowSize = Program.Preferences.LockWindowSize;
			Program.Preferences.LockWindowSize = false;
			this._remoteDesktopPanel = new Panel
			{
				Dock = DockStyle.None
			};
			ServerTree.Instance.HideSelection = false;
			ServerTree.Instance.Name = "ServerTree";
			ServerTree.Instance.TabIndex = 0;
			ServerTree.Instance.MouseLeave += this.SetAutoHideServerTreeTimer;
			ServerTree.Instance.Leave += this.SetAutoHideServerTreeTimer;
			ServerTree.Instance.LostFocus += this.AutoHideServerTree;
			ServerTree.Instance.AfterSelect += this.ServerTree_AfterSelect;
			Server.ConnectionStateChanged += this.Server_ConnectionStateChange;
			this._treeSplitter = new Splitter
			{
				Dock = DockStyle.Left,
				Width = 4,
				MinSize = 10,
				MinExtra = 100
			};
			this._treeSplitter.MouseHover += this.SetAutoShowServerTreeTimer;
			this._treeSplitter.MouseLeave += this.DisableAutoShowTimer;
			this._clientPanel = new ClientPanel();
			this._remoteDesktopPanel.Controls.Add(new Control[]
			{
				ServerTree.Instance,
				this._treeSplitter,
				this._clientPanel
			});
			this._autoSaveTimer = new Timer();
			this._autoSaveTimer.Tick += this.AutoSaveTimerTickHandler;
			base.SetMainMenuVisibility();
			if (Program.Preferences.ServerTreeWidth > Screen.PrimaryScreen.Bounds.Width)
			{
				ServerTree.Instance.Width = 200;
			}
			else
			{
				ServerTree.Instance.Width = Program.Preferences.ServerTreeWidth;
			}
			this.ServerTreeLocation = Program.Preferences.ServerTreeLocation;
			this.ServerTreeVisibility = Program.Preferences.ServerTreeVisibility;
			if (!Program.Preferences.WindowPosition.IsEmpty)
			{
				Screen screen = Screen.FromPoint(Program.Preferences.WindowPosition);
				if (screen.Bounds.Contains(Program.Preferences.WindowPosition))
				{
					base.StartPosition = FormStartPosition.Manual;
					base.Location = Program.Preferences.WindowPosition;
				}
			}
			base.Controls.Add(this._remoteDesktopPanel);
			base.Size = Program.Preferences.WindowSize;
			if (Program.Preferences.WindowIsMaximized)
			{
				base.WindowState = FormWindowState.Maximized;
			}
			Program.Preferences.LockWindowSize = lockWindowSize;
			this.LockWindowSize();
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			base.Icon = new Icon(executingAssembly.GetManifestResourceStream("RdcMan.Resources.app.ico"));
			AssemblyName name = executingAssembly.GetName();
			this.VersionText = name.Version.Major.ToString() + "." + name.Version.Minor.ToString();
			this.BuildText = name.Version.Build.ToString() + "." + name.Version.Revision.ToString();
			if (!WinTrust.VerifyEmbeddedSignature(executingAssembly.Location))
			{
				this.BuildText += "    FOR INTERNAL MICROSOFT USE ONLY";
				this.IsInternalVersion = true;
			}
			object[] customAttributes = executingAssembly.GetCustomAttributes(typeof(AssemblyConfigurationAttribute), false);
			if (customAttributes.Length != 0)
			{
				this.VersionText += (customAttributes[0] as AssemblyConfigurationAttribute).Configuration;
			}
			customAttributes = executingAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
			this.DescriptionText = (customAttributes[0] as AssemblyDescriptionAttribute).Description;
			ServerTree.Instance.Init(executingAssembly);
			this._serverTreeAutoHideTimer = new Timer();
			this._serverTreeAutoHideTimer.Tick += this.ServerTreeAutoHideTimerTick;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000FD24 File Offset: 0x0000DF24
		private void Server_ConnectionStateChange(ConnectionStateChangedEventArgs args)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000FD28 File Offset: 0x0000DF28
		private void ServerTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000FD2C File Offset: 0x0000DF2C
		protected override void LayoutContent()
		{
			int width = base.ClientSize.Width;
			int num = base.ClientSize.Height;
			int num2 = Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height;
			this._menuPanel.Width = width;
			num -= num2;
			ServerTree.Instance.Height = num;
			this._remoteDesktopPanel.Bounds = new Rectangle(0, num2, width, num);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		private void AutoSaveTimerTickHandler(object sender, EventArgs e)
		{
			if (this._areShuttingDown)
			{
				return;
			}
			RdgFile.AutoSave();
			Program.Preferences.Save();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000FDCC File Offset: 0x0000DFCC
		private void ServerTreeAutoHideTimerTick(object sender, EventArgs e)
		{
			if (Program.Preferences.ServerTreeVisibility != ControlVisibility.AutoHide)
			{
				this._serverTreeAutoHideTimer.Stop();
				return;
			}
			if (!ServerTree.Instance.Visible)
			{
				this._serverTreeAutoHideTimer.Stop();
				this.UpdateServerTreeVisibility(ControlVisibility.Dock);
				return;
			}
			Rectangle rectangle = ServerTree.Instance.RectangleToScreen(ServerTree.Instance.ClientRectangle);
			rectangle.Inflate(48, 48);
			if (rectangle.Contains(Control.MousePosition))
			{
				return;
			}
			this._serverTreeAutoHideTimer.Stop();
			this.UpdateServerTreeVisibility(ControlVisibility.Hide);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000FE60 File Offset: 0x0000E060
		private void AutoHideServerTree(object sender, EventArgs e)
		{
			if (Program.Preferences.ServerTreeVisibility != ControlVisibility.Dock && ServerTree.Instance.Visible)
			{
				this._serverTreeAutoHideTimer.Stop();
				this.UpdateServerTreeVisibility(ControlVisibility.Hide);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000FE94 File Offset: 0x0000E094
		private void SetAutoShowServerTreeTimer(object sender, EventArgs e)
		{
			if (Program.Preferences.ServerTreeVisibility == ControlVisibility.AutoHide && !ServerTree.Instance.Visible)
			{
				this._serverTreeAutoHideTimer.Interval = Program.Preferences.ServerTreeAutoHidePopUpDelay + 1;
				this._serverTreeAutoHideTimer.Start();
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		private void DisableAutoShowTimer(object sender, EventArgs e)
		{
			if (Program.Preferences.ServerTreeVisibility == ControlVisibility.AutoHide && !ServerTree.Instance.Visible)
			{
				this._serverTreeAutoHideTimer.Stop();
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000FF14 File Offset: 0x0000E114
		private void SetAutoHideServerTreeTimer(object sender, EventArgs e)
		{
			if (Program.Preferences.ServerTreeVisibility == ControlVisibility.AutoHide && ServerTree.Instance.Visible)
			{
				this._serverTreeAutoHideTimer.Interval = 250;
				this._serverTreeAutoHideTimer.Start();
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000FF50 File Offset: 0x0000E150
		protected void CreateMainMenu()
		{
			ToolStripMenuItem toolStripMenuItem = this._menuStrip.Add("&File", MenuNames.File);
			toolStripMenuItem.DropDownItems.Add(new DelegateMenuItem("&New...", MenuNames.FileNew, "Ctrl+N", delegate()
			{
				this.OnFileNew();
			}));
			toolStripMenuItem.DropDownItems.Add(new DelegateMenuItem("&Open...", MenuNames.FileOpen, "Ctrl+O", delegate()
			{
				this.OnFileOpen();
			}));
			toolStripMenuItem.DropDownItems.Add("-");
			this._fileSaveMenuItem = new DelegateMenuItem("", MenuNames.FileSave, "Ctrl+S", delegate()
			{
				this.OnFileSave();
			});
			toolStripMenuItem.DropDownItems.Add(this._fileSaveMenuItem);
			this._fileSaveAsMenuItem = new DelegateMenuItem("", MenuNames.FileSaveAs, delegate()
			{
				this.OnFileSaveAs();
			});
			toolStripMenuItem.DropDownItems.Add(this._fileSaveAsMenuItem);
			toolStripMenuItem.DropDownItems.Add(new DelegateMenuItem("Save A&ll", MenuNames.FileSaveAll, delegate()
			{
				RdgFile.SaveAll();
			}));
			toolStripMenuItem.DropDownItems.Add("-");
			this._fileCloseMenuItem = new DelegateMenuItem("", MenuNames.FileClose, delegate()
			{
				this.OnFileClose();
			});
			toolStripMenuItem.DropDownItems.Add(this._fileCloseMenuItem);
			toolStripMenuItem.DropDownItems.Add("-");
			toolStripMenuItem.DropDownItems.Add(new DelegateMenuItem("E&xit", MenuNames.FileExit, "Alt+F4", delegate()
			{
				Program.TheForm.Close();
			}));
			ToolStripMenuItem toolStripMenuItem2 = this._menuStrip.Add("&Edit", MenuNames.Edit);
			toolStripMenuItem2.DropDownItems.Add(new FileRequiredMenuItem("&Add server...", MenuNames.EditAddServer, "Ctrl+A", delegate()
			{
				AddNodeDialogHelper.AddServersDialog();
			}));
			toolStripMenuItem2.DropDownItems.Add(new FileRequiredMenuItem("&Import servers...", MenuNames.EditImportServers, delegate()
			{
				AddNodeDialogHelper.ImportServersDialog();
			}));
			toolStripMenuItem2.DropDownItems.Add(new FileRequiredMenuItem("Add &group...", MenuNames.EditAddGroup, "Ctrl+G", delegate()
			{
				AddNodeDialogHelper.AddGroupDialog();
			}));
			toolStripMenuItem2.DropDownItems.Add(new FileRequiredMenuItem("Add s&mart group...", MenuNames.EditAddSmartGroup, delegate()
			{
				AddNodeDialogHelper.AddSmartGroupDialog();
			}));
			toolStripMenuItem2.DropDownItems.Add("-");
			toolStripMenuItem2.DropDownItems.Add(new SelectedNodeMenuItem("Remo&ve server/group...", MenuNames.EditRemove, "Delete", delegate(RdcTreeNode node)
			{
				ServerTree.Instance.ConfirmRemove(node, true);
			}));
			toolStripMenuItem2.DropDownItems.Add("-");
			toolStripMenuItem2.DropDownItems.Add(new FileRequiredMenuItem("&Find...", MenuNames.EditFind, "Ctrl+F", delegate()
			{
				MenuHelper.FindServers();
			}));
			toolStripMenuItem2.DropDownItems.Add("-");
			toolStripMenuItem2.DropDownItems.Add(new SelectedNodeMenuItem<ServerBase>("A&dd to favorites", MenuNames.EditAddToFavorites, "Ctrl+D", delegate(ServerBase <p0>)
			{
				MenuHelper.AddFavorite(ServerTree.Instance.SelectedNode as RdcTreeNode);
			}));
			toolStripMenuItem2.DropDownItems.Add("-");
			this._editPropertiesMenuItem = new SelectedNodeMenuItem("P&roperties", MenuNames.EditProperties, "Alt+Enter", delegate(RdcTreeNode node)
			{
				node.DoPropertiesDialog();
			});
			toolStripMenuItem2.DropDownItems.Add(this._editPropertiesMenuItem);
			ToolStripMenuItem toolStripMenuItem3 = this._menuStrip.Add("&Session", MenuNames.Session);
			this._sessionConnectMenuItem = new SelectedNodeMenuItem("&Connect", MenuNames.SessionConnect, "Enter", delegate(RdcTreeNode node)
			{
				node.Connect();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionConnectMenuItem);
			this._sessionConnectAsMenuItem = new SelectedNodeMenuItem("Connect &as...", MenuNames.SessionConnectAs, "Shift+Enter", delegate(RdcTreeNode node)
			{
				node.DoConnectAs();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionConnectAsMenuItem);
			this._sessionReconnectMenuItem = new SelectedNodeMenuItem("R&econnect", MenuNames.SessionReconnect, delegate(RdcTreeNode node)
			{
				node.Reconnect();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionReconnectMenuItem);
			toolStripMenuItem3.DropDownItems.Add("-");
			this._sessionSendKeysMenuItem = toolStripMenuItem3.DropDownItems.Add("Send keys", MenuNames.SessionSendKeys);
			MenuHelper.AddSendKeysMenuItems(this._sessionSendKeysMenuItem, () => ServerTree.Instance.SelectedNode as ServerBase);
			if (RdpClient.SupportsRemoteSessionActions)
			{
				this._sessionRemoteActionsMenuItem = toolStripMenuItem3.DropDownItems.Add("Remote actions", MenuNames.SessionRemoteActions);
				MenuHelper.AddRemoteActionsMenuItems(this._sessionRemoteActionsMenuItem, () => ServerTree.Instance.SelectedNode as ServerBase);
				toolStripMenuItem3.DropDownItems.Add(this._sessionRemoteActionsMenuItem);
			}
			toolStripMenuItem3.DropDownItems.Add("-");
			this._sessionDisconnectMenuItem = new SelectedNodeMenuItem("&Disconnect", MenuNames.SessionDisconnect, delegate(RdcTreeNode node)
			{
				node.Disconnect();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionDisconnectMenuItem);
			toolStripMenuItem3.DropDownItems.Add("-");
			this._sessionLogOffMenuItem = new SelectedNodeMenuItem("Log off", MenuNames.SessionLogOff, delegate(RdcTreeNode node)
			{
				node.LogOff();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionLogOffMenuItem);
			this._sessionListSessionsMenuItem = new SelectedNodeMenuItem<ServerBase>("&List sessions", MenuNames.SessionListSessions, delegate(ServerBase server)
			{
				Program.ShowForm(new ListSessionsForm(server));
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionListSessionsMenuItem);
			toolStripMenuItem3.DropDownItems.Add("-");
			this._sessionFullScreenMenuItem = new SelectedNodeMenuItem<ServerBase>("&Full screen", MenuNames.SessionFullScreen, delegate(ServerBase server)
			{
				server.GoFullScreen();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionFullScreenMenuItem);
			this._sessionUndockMenuItem = new SelectedNodeMenuItem<ServerBase>("&Undock", MenuNames.SessionUndock, delegate(ServerBase server)
			{
				server.Undock();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionUndockMenuItem);
			this._sessionUndockAndConnectMenuItem = new SelectedNodeMenuItem<ServerBase>("Undoc&k and connect", MenuNames.SessionUndockAndConnect, delegate(ServerBase server)
			{
				server.Undock();
				server.Connect();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionUndockAndConnectMenuItem);
			this._sessionDockMenuItem = new SelectedNodeMenuItem<ServerBase>("&Dock", MenuNames.SessionDock, delegate(ServerBase server)
			{
				server.Dock();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionDockMenuItem);
			toolStripMenuItem3.DropDownItems.Add("-");
			toolStripMenuItem3.DropDownItems.Add(new DelegateMenuItem("Connect to...", MenuNames.SessionConnectTo, "Ctrl+Q", delegate()
			{
				MenuHelper.ConnectTo();
			}));
			toolStripMenuItem3.DropDownItems.Add("-");
			this._sessionScreenCaptureMenuItem = new SelectedNodeMenuItem<ServerBase>("Screen capture", MenuNames.SessionScreenCapture, delegate(ServerBase server)
			{
				server.ScreenCapture();
			});
			toolStripMenuItem3.DropDownItems.Add(this._sessionScreenCaptureMenuItem);
			ToolStripMenuItem toolStripMenuItem4 = this._menuStrip.Add("&View", MenuNames.View);
			ToolStripMenuItem toolStripMenuItem5 = toolStripMenuItem4.DropDownItems.Add("&Sort order", MenuNames.ViewSortOrder);
			ToolStripMenuItem toolStripMenuItem6 = toolStripMenuItem5.DropDownItems.Add("&Groups", MenuNames.None);
			toolStripMenuItem6.DropDownItems.Add(new SortGroupsCheckedMenuItem("&Name", SortOrder.ByName));
			toolStripMenuItem6.DropDownItems.Add(new SortGroupsCheckedMenuItem("N&o sorting", SortOrder.None));
			ToolStripMenuItem toolStripMenuItem7 = toolStripMenuItem5.DropDownItems.Add("&Servers", MenuNames.None);
			toolStripMenuItem7.DropDownItems.Add(new SortServersCheckedMenuItem("&Status.Name", SortOrder.ByStatus));
			toolStripMenuItem7.DropDownItems.Add(new SortServersCheckedMenuItem("&Name", SortOrder.ByName));
			toolStripMenuItem7.DropDownItems.Add(new SortServersCheckedMenuItem("N&o sorting", SortOrder.None));
			ToolStripMenuItem toolStripMenuItem8 = toolStripMenuItem4.DropDownItems.Add("Server tree location", MenuNames.ViewServerTreeLocation);
			toolStripMenuItem8.DropDownItems.Add(new ServerTreeLocationMenuItem("&Left", DockStyle.Left));
			toolStripMenuItem8.DropDownItems.Add(new ServerTreeLocationMenuItem("&Right", DockStyle.Right));
			ToolStripMenuItem toolStripMenuItem9 = toolStripMenuItem4.DropDownItems.Add("Server tree visibility", MenuNames.ViewServerTreeVisibility);
			toolStripMenuItem9.DropDownItems.Add(new ServerTreeVisibilityMenuItem("&Dock", ControlVisibility.Dock));
			toolStripMenuItem9.DropDownItems.Add(new ServerTreeVisibilityMenuItem("&Auto hide", ControlVisibility.AutoHide));
			toolStripMenuItem9.DropDownItems.Add(new ServerTreeVisibilityMenuItem("&Hide", ControlVisibility.Hide));
			toolStripMenuItem4.DropDownItems.Add("-");
			ToolStripMenuItem toolStripMenuItem10 = toolStripMenuItem4.DropDownItems.Add("Built-in groups", MenuNames.ViewBuiltInGroups);
			foreach (IBuiltInVirtualGroup builtInVirtualGroup in Program.BuiltInVirtualGroups)
			{
				if (builtInVirtualGroup.IsVisibilityConfigurable)
				{
					toolStripMenuItem10.DropDownItems.Add(new BuiltInVirtualGroupCheckedMenuItem(builtInVirtualGroup));
				}
			}
			toolStripMenuItem4.DropDownItems.Add("-");
			toolStripMenuItem4.DropDownItems.Add(new DelegateCheckedMenuItem("&Lock window size", MenuNames.ViewLockWindowSize, () => Program.Preferences.LockWindowSize, delegate(bool isChecked)
			{
				Program.Preferences.LockWindowSize = isChecked;
				this.LockWindowSize();
			}));
			ToolStripMenuItem toolStripMenuItem11 = new ToolStripMenuItem("&Client size");
			foreach (Size size in SizeHelper.StockSizes)
			{
				ClientSizeCheckedMenuItem value = new ClientSizeCheckedMenuItem(this, size);
				toolStripMenuItem11.DropDownItems.Add(value);
			}
			toolStripMenuItem11.DropDownItems.Add(new CustomClientSizeCheckedMenuItem(this, "&Custom"));
			toolStripMenuItem11.DropDownItems.Add(new SelectedNodeMenuItem<ServerBase>("From remote desktop size", MenuNames.None, delegate(ServerBase node)
			{
				this.SetClientSize(node.IsConnected ? node.ServerNode.Client.DesktopSize : node.RemoteDesktopSettings.DesktopSize.Value);
			}));
			toolStripMenuItem4.DropDownItems.Add(toolStripMenuItem11);
			RemoteDesktopsMenuItem value2 = new RemoteDesktopsMenuItem();
			this._menuStrip.Items.Add(value2);
			ToolStripMenuItem toolStripMenuItem12 = this._menuStrip.Add("&Tools", MenuNames.Tools);
			toolStripMenuItem12.DropDownItems.Add(new DelegateMenuItem("&Options", MenuNames.ToolsOptions, delegate()
			{
				MenuHelper.ShowGlobalOptionsDialog();
			}));
			ToolStripMenuItem toolStripMenuItem13 = this._menuStrip.Add("&Help", MenuNames.Help);
			toolStripMenuItem13.DropDownItems.Add(new DelegateMenuItem("&Usage", MenuNames.HelpUsage, delegate()
			{
				Program.Usage();
			}));
			toolStripMenuItem13.DropDownItems.Add("-");
			toolStripMenuItem13.DropDownItems.Add(new DelegateMenuItem("&About...", MenuNames.HelpAbout, delegate()
			{
				this.OnHelpAbout();
			}));
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00010B88 File Offset: 0x0000ED88
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (!this._menuStrip.IsActive)
			{
				Action action;
				if (this.Shortcuts.TryGetValue(keyData, out action))
				{
					action();
					return true;
				}
				RdcTreeNode selectedNode = this.GetSelectedNode();
				Action<RdcTreeNode> action2;
				if (selectedNode != null && this.SelectedNodeShortcuts.TryGetValue(keyData, out action2))
				{
					action2(selectedNode);
					return true;
				}
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public RdcTreeNode GetSelectedNode()
		{
			return this._clientPanel.GetSelectedNode(base.ActiveControl) ?? (ServerTree.Instance.SelectedNode as RdcTreeNode);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00010C24 File Offset: 0x0000EE24
		public override Size GetClientSize()
		{
			Size result = new Size(this._clientPanel.Width, base.ClientSize.Height);
			result.Height -= (Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height);
			return result;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00010C84 File Offset: 0x0000EE84
		public void ShowGroup(GroupBase group)
		{
			this._clientPanel.ShowGroup(group);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00010C94 File Offset: 0x0000EE94
		public void HideGroup(GroupBase group)
		{
			this._clientPanel.HideGroup(group);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00010CA4 File Offset: 0x0000EEA4
		private bool AnyActive()
		{
			return ConnectedGroup.Instance.Nodes.Count > 0 && FormTools.YesNoDialog("There are active connections. Are you sure?") != DialogResult.Yes;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00010CD0 File Offset: 0x0000EED0
		private SaveResult DoExit()
		{
			if (this._areShuttingDown)
			{
				return SaveResult.Save;
			}
			if (this.AnyActive())
			{
				return SaveResult.Cancel;
			}
			foreach (object obj in ServerTree.Instance.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				FileGroup fileGroup = treeNode as FileGroup;
				if (fileGroup != null)
				{
					SaveResult saveResult = RdgFile.ShouldSaveFile(fileGroup);
					if (saveResult == SaveResult.Cancel)
					{
						return saveResult;
					}
					if (saveResult != SaveResult.NoSave && RdgFile.DoSaveWithRetry(fileGroup) == SaveResult.Cancel)
					{
						return SaveResult.Cancel;
					}
				}
			}
			this._areShuttingDown = true;
			this._serverTreeAutoHideTimer.Stop();
			this._autoSaveTimer.Stop();
			base.Hide();
			Program.Preferences.WindowIsMaximized = (base.WindowState == FormWindowState.Maximized);
			Rectangle rectangle = (base.WindowState == FormWindowState.Normal) ? base.Bounds : base.RestoreBounds;
			Program.Preferences.WindowPosition = new Point(rectangle.Left, rectangle.Top);
			Program.Preferences.WindowSize = new Size(rectangle.Width, rectangle.Height);
			Program.Preferences.ServerTreeWidth = ServerTree.Instance.Width;
			Program.Preferences.NeedToSave = true;
			Program.Preferences.Save();
			Program.PluginAction(delegate(IPlugin p)
			{
				p.Shutdown();
			});
			using (Helpers.Timer("destroying sessions", Array.Empty<object>()))
			{
				ServerTree.Instance.SelectedNode = null;
				ServerTree.Instance.Operation(OperationBehavior.SuspendSelect | OperationBehavior.SuspendSort | OperationBehavior.SuspendUpdate | OperationBehavior.SuspendGroupChanged, delegate
				{
					ServerTree.Instance.Nodes.VisitNodes(delegate(RdcTreeNode node)
					{
						try
						{
							Server server = node as Server;
							if (server != null)
							{
								server.OnRemoving();
							}
						}
						catch
						{
						}
					});
					ServerTree.Instance.Nodes.Clear();
				});
			}
			return SaveResult.Save;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		public override void SetClientSize(Size size)
		{
			this.LockWindowSize(false);
			int num = size.Width;
			int num2 = size.Height;
			if (this.ServerTreeVisibility == ControlVisibility.Dock)
			{
				num += ServerTree.Instance.Width + this._treeSplitter.Width;
			}
			else if (this.ServerTreeVisibility == ControlVisibility.AutoHide)
			{
				num += this._treeSplitter.Width;
			}
			num2 += (Program.Preferences.HideMainMenu ? 0 : this._menuPanel.Height);
			base.ClientSize = new Size(num, num2);
			this.LockWindowSize();
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00010F7C File Offset: 0x0000F17C
		public void LockWindowSize()
		{
			this.LockWindowSize(Program.Preferences.LockWindowSize);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00010F90 File Offset: 0x0000F190
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (this._allowSizeChanged)
			{
				this.LayoutContent();
				Program.Preferences.NeedToSave = true;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00010FB8 File Offset: 0x0000F1B8
		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = (this.DoExit() == SaveResult.Cancel);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00010FCC File Offset: 0x0000F1CC
		private void OnFileNew()
		{
			FileGroup fileGroup = RdgFile.NewFile();
			if (fileGroup != null)
			{
				ServerTree.Instance.SelectedNode = fileGroup;
				Program.Preferences.NeedToSave = true;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00011000 File Offset: 0x0000F200
		private void OnFileClose()
		{
			FileGroup selectedFile = ServerTree.Instance.GetSelectedFile();
			if (selectedFile == null)
			{
				return;
			}
			this.DoFileClose(selectedFile);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001102C File Offset: 0x0000F22C
		public void DoFileClose(FileGroup file)
		{
			RdgFile.CloseFileGroup(file);
			Program.Preferences.NeedToSave = true;
			Program.Preferences.Save();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001104C File Offset: 0x0000F24C
		private void OnFileOpen()
		{
			FileGroup fileGroup = RdgFile.OpenFile();
			if (fileGroup != null)
			{
				ServerTree.Instance.SelectedNode = fileGroup;
				Program.Preferences.NeedToSave = true;
				Program.Preferences.Save();
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001108C File Offset: 0x0000F28C
		private void OnFileSave()
		{
			FileGroup selectedFile = ServerTree.Instance.GetSelectedFile();
			if (selectedFile == null)
			{
				return;
			}
			this.DoFileSave(selectedFile);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000110B8 File Offset: 0x0000F2B8
		public void DoFileSave(FileGroup file)
		{
			RdgFile.SaveFileGroup(file);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000110C4 File Offset: 0x0000F2C4
		private void OnFileSaveAs()
		{
			FileGroup selectedFile = ServerTree.Instance.GetSelectedFile();
			if (selectedFile == null)
			{
				return;
			}
			RdgFile.SaveAs(selectedFile);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000110F0 File Offset: 0x0000F2F0
		protected override void UpdateMainMenu()
		{
			base.UpdateMenuItems(this._menuStrip.Items);
			RdcTreeNode selectedNode = this.GetSelectedNode();
			FileGroup fileGroup = (selectedNode != null && !(selectedNode is ServerRef)) ? selectedNode.FileGroup : null;
			if (fileGroup == null)
			{
				this._fileSaveMenuItem.Text = "&Save";
				this._fileSaveMenuItem.Enabled = false;
				this._fileSaveAsMenuItem.Text = "Save &as...";
				this._fileSaveAsMenuItem.Enabled = false;
				this._fileCloseMenuItem.Text = "&Close";
				this._fileCloseMenuItem.Enabled = false;
			}
			else
			{
				this._fileSaveMenuItem.Text = "&Save " + fileGroup.GetFilename();
				this._fileSaveMenuItem.Enabled = true;
				this._fileSaveAsMenuItem.Text = "Save " + fileGroup.GetFilename() + " &as...";
				this._fileSaveAsMenuItem.Enabled = true;
				this._fileCloseMenuItem.Text = "&Close " + fileGroup.GetFilename();
				this._fileCloseMenuItem.Enabled = true;
			}
			this._editPropertiesMenuItem.Enabled = (selectedNode != null && selectedNode.HasProperties);
			ServerBase serverBase = selectedNode as ServerBase;
			if (serverBase != null)
			{
				bool isConnected = serverBase.IsConnected;
				bool isClientFullScreen = serverBase.IsClientFullScreen;
				this._sessionConnectMenuItem.Enabled = !isConnected;
				this._sessionConnectAsMenuItem.Enabled = !isConnected;
				this._sessionReconnectMenuItem.Enabled = isConnected;
				this._sessionDisconnectMenuItem.Enabled = isConnected;
				this._sessionLogOffMenuItem.Enabled = (!Policies.DisableLogOff && isConnected);
				this._sessionSendKeysMenuItem.Enabled = isConnected;
				if (RdpClient.SupportsRemoteSessionActions)
				{
					this._sessionRemoteActionsMenuItem.Enabled = isConnected;
				}
				this._sessionListSessionsMenuItem.Enabled = true;
				this._sessionFullScreenMenuItem.Enabled = (isConnected && !isClientFullScreen);
				this._sessionUndockMenuItem.Enabled = (serverBase.IsClientDocked && !isClientFullScreen);
				this._sessionUndockAndConnectMenuItem.Enabled = (serverBase.IsClientDocked && !isClientFullScreen && !isConnected);
				this._sessionDockMenuItem.Enabled = serverBase.IsClientUndocked;
				Server serverNode = serverBase.ServerNode;
				this._sessionScreenCaptureMenuItem.Enabled = (serverNode.ConnectionState == RdpClient.ConnectionState.Connected && serverNode.IsClientDocked && serverNode.Client.Control.Visible);
				return;
			}
			GroupBase groupBase = selectedNode as GroupBase;
			if (groupBase != null)
			{
				bool flag;
				bool flag2;
				groupBase.AnyOrAllConnected(out flag, out flag2);
				this._sessionConnectMenuItem.Enabled = !flag2;
				this._sessionConnectAsMenuItem.Enabled = !flag2;
				this._sessionReconnectMenuItem.Enabled = flag;
				this._sessionDisconnectMenuItem.Enabled = flag;
				this._sessionLogOffMenuItem.Enabled = (!Policies.DisableLogOff && flag);
			}
			else
			{
				this._sessionConnectMenuItem.Enabled = false;
				this._sessionConnectAsMenuItem.Enabled = false;
				this._sessionReconnectMenuItem.Enabled = false;
				this._sessionDisconnectMenuItem.Enabled = false;
				this._sessionLogOffMenuItem.Enabled = false;
			}
			this._sessionSendKeysMenuItem.Enabled = false;
			if (RdpClient.SupportsRemoteSessionActions)
			{
				this._sessionRemoteActionsMenuItem.Enabled = false;
			}
			this._sessionListSessionsMenuItem.Enabled = false;
			this._sessionFullScreenMenuItem.Enabled = false;
			this._sessionUndockMenuItem.Enabled = false;
			this._sessionUndockAndConnectMenuItem.Enabled = false;
			this._sessionDockMenuItem.Enabled = false;
			this._sessionScreenCaptureMenuItem.Enabled = false;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00011490 File Offset: 0x0000F690
		private void LockWindowSize(bool isLocked)
		{
			if (isLocked)
			{
				this.MinimumSize = base.Size;
				this.MaximumSize = base.Size;
				return;
			}
			this.MinimumSize = new Size(400, 300);
			this.MaximumSize = new Size(0, 0);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000114E4 File Offset: 0x0000F6E4
		private void OnHelpAbout()
		{
			using (About about = new About(this.IsInternalVersion))
			{
				about.ShowDialog();
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00011528 File Offset: 0x0000F728
		public void UpdateAutoSaveTimer()
		{
			if (Program.Preferences.AutoSaveFiles && Program.Preferences.AutoSaveInterval > 0)
			{
				this._autoSaveTimer.Interval = Program.Preferences.AutoSaveInterval * 60 * 1000;
				this._autoSaveTimer.Start();
				return;
			}
			this._autoSaveTimer.Stop();
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00011590 File Offset: 0x0000F790
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0001159C File Offset: 0x0000F79C
		public DockStyle ServerTreeLocation
		{
			get
			{
				return Program.Preferences.ServerTreeLocation;
			}
			set
			{
				Program.Preferences.ServerTreeLocation = value;
				this._treeSplitter.Dock = value;
				ServerTree.Instance.Dock = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002DD RID: 733 RVA: 0x000115C0 File Offset: 0x0000F7C0
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000115CC File Offset: 0x0000F7CC
		public ControlVisibility ServerTreeVisibility
		{
			get
			{
				return Program.Preferences.ServerTreeVisibility;
			}
			set
			{
				Program.Preferences.ServerTreeVisibility = value;
				Size clientSize = this.GetClientSize();
				this.UpdateServerTreeVisibility(value);
				this.SetClientSize(clientSize);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00011600 File Offset: 0x0000F800
		private void UpdateServerTreeVisibility(ControlVisibility value)
		{
			base.SuspendLayout();
			if (value == ControlVisibility.Dock)
			{
				ServerTree.Instance.Enabled = true;
				ServerTree.Instance.Show();
				if (Program.Preferences.ServerTreeVisibility != ControlVisibility.Dock)
				{
					ServerTree.Instance.BringToFront();
					if (Program.Preferences.ServerTreeLocation == DockStyle.Right)
					{
						this._treeSplitter.Hide();
					}
				}
				else
				{
					this._treeSplitter.SendToBack();
					ServerTree.Instance.SendToBack();
					this._treeSplitter.Show();
				}
			}
			else
			{
				ServerTree.Instance.Hide();
				ServerTree.Instance.Enabled = false;
				if (Program.Preferences.ServerTreeVisibility != ControlVisibility.AutoHide)
				{
					this._treeSplitter.Hide();
				}
				else
				{
					this._treeSplitter.Show();
				}
			}
			base.ResumeLayout();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000116D8 File Offset: 0x0000F8D8
		private void OnVisibleChanged(object sender, EventArgs e)
		{
			Program.InitializedEvent.Set();
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000116E8 File Offset: 0x0000F8E8
		MenuStrip IMainForm.MainMenuStrip
		{
			get
			{
				return this._menuStrip;
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000116F0 File Offset: 0x0000F8F0
		bool IMainForm.RegisterShortcut(Keys shortcutKey, Action action)
		{
			bool result;
			try
			{
				this.Shortcuts.Add(shortcutKey, action);
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0400015B RID: 347
		private const int MinimumRemoteDesktopPanelHeight = 200;

		// Token: 0x0400015C RID: 348
		private const int AutoHideIntervalInMilliseconds = 250;

		// Token: 0x0400015D RID: 349
		private readonly Dictionary<Keys, Action> Shortcuts;

		// Token: 0x0400015E RID: 350
		private readonly Dictionary<Keys, Action<RdcTreeNode>> SelectedNodeShortcuts;

		// Token: 0x0400015F RID: 351
		private ToolStripMenuItem _fileSaveMenuItem;

		// Token: 0x04000160 RID: 352
		private ToolStripMenuItem _fileSaveAsMenuItem;

		// Token: 0x04000161 RID: 353
		private ToolStripMenuItem _fileCloseMenuItem;

		// Token: 0x04000162 RID: 354
		private ToolStripMenuItem _editPropertiesMenuItem;

		// Token: 0x04000163 RID: 355
		private ToolStripMenuItem _sessionConnectMenuItem;

		// Token: 0x04000164 RID: 356
		private ToolStripMenuItem _sessionConnectAsMenuItem;

		// Token: 0x04000165 RID: 357
		private ToolStripMenuItem _sessionReconnectMenuItem;

		// Token: 0x04000166 RID: 358
		private ToolStripMenuItem _sessionSendKeysMenuItem;

		// Token: 0x04000167 RID: 359
		private ToolStripMenuItem _sessionRemoteActionsMenuItem;

		// Token: 0x04000168 RID: 360
		private ToolStripMenuItem _sessionDisconnectMenuItem;

		// Token: 0x04000169 RID: 361
		private ToolStripMenuItem _sessionLogOffMenuItem;

		// Token: 0x0400016A RID: 362
		private ToolStripMenuItem _sessionListSessionsMenuItem;

		// Token: 0x0400016B RID: 363
		private ToolStripMenuItem _sessionFullScreenMenuItem;

		// Token: 0x0400016C RID: 364
		private ToolStripMenuItem _sessionUndockMenuItem;

		// Token: 0x0400016D RID: 365
		private ToolStripMenuItem _sessionUndockAndConnectMenuItem;

		// Token: 0x0400016E RID: 366
		private ToolStripMenuItem _sessionDockMenuItem;

		// Token: 0x0400016F RID: 367
		private ToolStripMenuItem _sessionScreenCaptureMenuItem;

		// Token: 0x04000170 RID: 368
		private Splitter _treeSplitter;

		// Token: 0x04000171 RID: 369
		private bool _allowSizeChanged;

		// Token: 0x04000172 RID: 370
		private Panel _remoteDesktopPanel;

		// Token: 0x04000173 RID: 371
		private Timer _autoSaveTimer;

		// Token: 0x04000174 RID: 372
		private ClientPanel _clientPanel;

		// Token: 0x04000175 RID: 373
		private Server _fullScreenServer;

		// Token: 0x04000176 RID: 374
		private Control[] _savedControls;

		// Token: 0x04000177 RID: 375
		private bool _areShuttingDown;

		// Token: 0x04000178 RID: 376
		private Timer _serverTreeAutoHideTimer;
	}
}
