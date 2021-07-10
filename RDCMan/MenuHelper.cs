using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MSTSCLib;

namespace RdcMan
{
	// Token: 0x020000A5 RID: 165
	public static class MenuHelper
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00015C0C File Offset: 0x00013E0C
		public static void AddSessionMenuItems(ContextMenuStrip menu, ServerBase server)
		{
			bool isConnected = server.IsConnected;
			ToolStripMenuItem toolStripMenuItem = new DelegateMenuItem("&Connect server", MenuNames.SessionConnect, new Action(server.Connect));
			toolStripMenuItem.Enabled = !isConnected;
			menu.Items.Add(toolStripMenuItem);
			toolStripMenuItem = new DelegateMenuItem("Connect server &as...", MenuNames.SessionConnectAs, new Action(server.DoConnectAs));
			toolStripMenuItem.Enabled = !isConnected;
			menu.Items.Add(toolStripMenuItem);
			toolStripMenuItem = new DelegateMenuItem("R&econnect server", MenuNames.SessionReconnect, new Action(server.Reconnect));
			toolStripMenuItem.Enabled = isConnected;
			menu.Items.Add(toolStripMenuItem);
			menu.Items.Add("-");
			toolStripMenuItem = menu.Items.Add("Send keys", MenuNames.SessionSendKeys);
			toolStripMenuItem.Enabled = isConnected;
			MenuHelper.AddSendKeysMenuItems(toolStripMenuItem, () => server);
			if (RdpClient.SupportsRemoteSessionActions)
			{
				toolStripMenuItem = menu.Items.Add("Remote actions", MenuNames.SessionRemoteActions);
				toolStripMenuItem.Enabled = isConnected;
				MenuHelper.AddRemoteActionsMenuItems(toolStripMenuItem, () => server);
			}
			menu.Items.Add("-");
			toolStripMenuItem = new DelegateMenuItem("&Disconnect server", MenuNames.SessionDisconnect, new Action(server.Disconnect));
			toolStripMenuItem.Enabled = isConnected;
			menu.Items.Add(toolStripMenuItem);
			menu.Items.Add("-");
			toolStripMenuItem = new DelegateMenuItem("Log off server", MenuNames.SessionLogOff, new Action(server.LogOff));
			toolStripMenuItem.Enabled = (!Policies.DisableLogOff && isConnected);
			menu.Items.Add(toolStripMenuItem);
			menu.Items.Add(new DelegateMenuItem("&List sessions", MenuNames.SessionListSessions, delegate()
			{
				Program.ShowForm(new ListSessionsForm(server));
			}));
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00015DF8 File Offset: 0x00013FF8
		public static void AddSendKeysMenuItems(ToolStripMenuItem parentItem, Func<ServerBase> getServer)
		{
			SendKeysMenuItem[] array = new SendKeysMenuItem[4];
			int num = 0;
			string name = "Security dialog";
			Keys[] array2 = new Keys[3];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.B1242C57228406E2CEFF310176D81A494643AC385EE9339A9A2B4DB9D7F1526B).FieldHandle);
			array[num] = new SendKeysMenuItem(name, array2);
			array[1] = new SendKeysMenuItem("Window menu", new Keys[]
			{
				Keys.Menu,
				Keys.Space
			});
			int num2 = 2;
			string name2 = "Task manager";
			Keys[] array3 = new Keys[3];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.0470975A181C713726C6F5F47B9B884D930E36BABFD0D47B55921BD011AB0198).FieldHandle);
			array[num2] = new SendKeysMenuItem(name2, array3);
			array[3] = new SendKeysMenuItem("Start menu", new Keys[]
			{
				Keys.ControlKey,
				Keys.Escape
			});
			List<SendKeysMenuItem> list = new List<SendKeysMenuItem>(array);
			EventHandler <>9__0;
			foreach (SendKeysMenuItem sendKeysMenuItem in list)
			{
				ToolStripItem toolStripItem = sendKeysMenuItem;
				EventHandler value;
				if ((value = <>9__0) == null)
				{
					value = (<>9__0 = delegate(object sender, EventArgs e)
					{
						SendKeys.Send((sender as SendKeysMenuItem).KeyCodes, getServer());
					});
				}
				toolStripItem.Click += value;
				parentItem.DropDownItems.Add(sendKeysMenuItem);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00015F04 File Offset: 0x00014104
		public static void AddRemoteActionsMenuItems(ToolStripMenuItem parentItem, Func<ServerBase> getServer)
		{
			List<ToolStripMenuItem> list = new List<ToolStripMenuItem>(new ToolStripMenuItem[]
			{
				new ToolStripMenuItem("App commands")
				{
					Tag = 1
				},
				new ToolStripMenuItem("Charms")
				{
					Tag = 0
				},
				new ToolStripMenuItem("Snap")
				{
					Tag = 2
				},
				new ToolStripMenuItem("Switch apps")
				{
					Tag = 4
				},
				new ToolStripMenuItem("Start")
				{
					Tag = 3
				}
			});
			EventHandler <>9__0;
			foreach (ToolStripMenuItem toolStripMenuItem in list)
			{
				ToolStripItem toolStripItem = toolStripMenuItem;
				EventHandler value;
				if ((value = <>9__0) == null)
				{
					value = (<>9__0 = delegate(object sender, EventArgs e)
					{
						getServer().ServerNode.SendRemoteAction((RemoteSessionActionType)(sender as ToolStripMenuItem).Tag);
					});
				}
				toolStripItem.Click += value;
				parentItem.DropDownItems.Add(toolStripMenuItem);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00016018 File Offset: 0x00014218
		public static void AddDockingMenuItems(ContextMenuStrip menu, ServerBase server)
		{
			bool isConnected = server.IsConnected;
			bool isClientFullScreen = server.IsClientFullScreen;
			ToolStripMenuItem toolStripMenuItem = new DelegateMenuItem("&Full screen", MenuNames.SessionFullScreen, delegate()
			{
				ServerTree.Instance.SelectedNode = server;
				server.GoFullScreen();
			});
			toolStripMenuItem.Enabled = (isConnected && !isClientFullScreen);
			menu.Items.Add(toolStripMenuItem);
			toolStripMenuItem = new DelegateMenuItem("&Undock", MenuNames.SessionUndock, new Action(server.Undock));
			toolStripMenuItem.Enabled = (server.IsClientDocked && !isClientFullScreen);
			menu.Items.Add(toolStripMenuItem);
			toolStripMenuItem = new DelegateMenuItem("Undoc&k and connect", MenuNames.SessionUndockAndConnect, delegate()
			{
				server.Undock();
				server.Connect();
			});
			toolStripMenuItem.Enabled = (server.IsClientDocked && !isConnected && !isClientFullScreen);
			menu.Items.Add(toolStripMenuItem);
			toolStripMenuItem = new DelegateMenuItem("D&ock", MenuNames.SessionDock, new Action(server.Dock));
			toolStripMenuItem.Enabled = server.IsClientUndocked;
			menu.Items.Add(toolStripMenuItem);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00016148 File Offset: 0x00014348
		public static void AddMaintenanceMenuItems(ContextMenuStrip menu, ServerBase server)
		{
			ToolStripMenuItem toolStripMenuItem = new DelegateMenuItem("Remo&ve server", MenuNames.EditRemove, delegate()
			{
				ServerTree.Instance.ConfirmRemove(server, true);
			});
			toolStripMenuItem.Enabled = server.CanRemove(false);
			menu.Items.Add(toolStripMenuItem);
			menu.Items.Add("-");
			toolStripMenuItem = new DelegateMenuItem("Add to favorites", MenuNames.EditAddToFavorites, delegate()
			{
				FavoritesGroup.Instance.AddReference(server);
			});
			toolStripMenuItem.Enabled = server.AllowEdit(false);
			menu.Items.Add(toolStripMenuItem);
			menu.Items.Add("-");
			toolStripMenuItem = new DelegateMenuItem("P&roperties", MenuNames.EditProperties, delegate()
			{
				server.DoPropertiesDialog();
			});
			toolStripMenuItem.Enabled = server.HasProperties;
			menu.Items.Add(toolStripMenuItem);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001622C File Offset: 0x0001442C
		public static void ConnectTo()
		{
			using (ConnectToDialog connectToDialog = ConnectToDialog.NewConnectToDialog(Program.TheForm))
			{
				if (connectToDialog.ShowDialog() == DialogResult.OK)
				{
					Server server = TemporaryServer.Create(connectToDialog);
					server.Connect();
					ServerTree.Instance.SelectedNode = server;
				}
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00016284 File Offset: 0x00014484
		public static void FindServers()
		{
			using (FindServersDialog findServersDialog = new FindServersDialog())
			{
				if (findServersDialog.ShowDialog() == DialogResult.OK)
				{
					ServerBase serverBase = findServersDialog.SelectedServers.FirstOrDefault<ServerBase>();
					if (serverBase != null)
					{
						ServerTree.Instance.SelectedNode = serverBase;
					}
				}
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000162D8 File Offset: 0x000144D8
		public static void AddFavorite(RdcTreeNode node)
		{
			ServerBase serverBase = node as ServerBase;
			if (serverBase != null)
			{
				FavoritesGroup.Instance.AddReference(serverBase);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000162FC File Offset: 0x000144FC
		public static void ShowGlobalOptionsDialog()
		{
			using (GlobalOptionsDialog globalOptionsDialog = GlobalOptionsDialog.New())
			{
				if (globalOptionsDialog.ShowDialog() == DialogResult.OK)
				{
					globalOptionsDialog.UpdatePreferences();
					Program.Preferences.NeedToSave = true;
					Program.Preferences.Save();
					Program.TheForm.LockWindowSize();
					Program.TheForm.SetMainMenuVisibility();
					ServerTree.Instance.UpdateColors();
					ServerTree.Instance.SortAllNodes();
					ServerTree.Instance.OnGroupChanged(ServerTree.Instance.RootNode, ChangeType.PropertyChanged);
					Program.TheForm.UpdateAutoSaveTimer();
				}
			}
		}
	}
}
