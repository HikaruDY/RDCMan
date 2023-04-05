using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000BE RID: 190
	internal class ServerTree : TreeView, IServerTree
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000678 RID: 1656 RVA: 0x0001F3C4 File Offset: 0x0001D5C4
		// (remove) Token: 0x06000679 RID: 1657 RVA: 0x0001F400 File Offset: 0x0001D600
		internal event Action<ServerChangedEventArgs> ServerChanged;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600067A RID: 1658 RVA: 0x0001F43C File Offset: 0x0001D63C
		// (remove) Token: 0x0600067B RID: 1659 RVA: 0x0001F478 File Offset: 0x0001D678
		internal event Action<GroupChangedEventArgs> GroupChanged;

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x0001F4BC File Offset: 0x0001D6BC
		internal static ServerTree Instance { get; private set; }

		// Token: 0x0600067E RID: 1662 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		static ServerTree()
		{
			foreach (ImageConstants imageConstants in Helpers.EnumValues<ImageConstants>())
			{
				ServerTree.ImageConstantLookup[0, (int)imageConstants] = imageConstants;
				ServerTree.ImageConstantLookup[1, (int)imageConstants] = imageConstants;
			}
			ServerTree.ImageConstantLookup[0, 4] = ImageConstants.ConnectedServer;
			ServerTree.ImageConstantLookup[0, 2] = ImageConstants.ConnectingServer;
			ServerTree.ImageConstantLookup[1, 3] = ImageConstants.ConnectedSelectedServer;
			ServerTree.ImageConstantLookup[1, 1] = ImageConstants.ConnectingSelectedServer;
			ServerTree.Instance = new ServerTree();
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001F5A0 File Offset: 0x0001D7A0
		private ServerTree()
		{
			base.BorderStyle = BorderStyle.None;
			this.AllowDrop = true;
			base.Scrollable = true;
			base.HideSelection = false;
			this._delayedFocusTimer = new System.Threading.Timer(delegate(object o)
			{
				this.CheckDelayedFocusServer();
			}, null, -1, -1);
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001F604 File Offset: 0x0001D804
		public GroupBase RootNode
		{
			get
			{
				return this._rootNode;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0001F60C File Offset: 0x0001D80C
		internal bool SuppressSorting
		{
			get
			{
				return this._noSortCounter > 0;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001F618 File Offset: 0x0001D818
		internal FileGroup GetSelectedFile()
		{
			FileGroup result = null;
			TreeNode selectedNode = base.SelectedNode;
			if (selectedNode != null)
			{
				result = (selectedNode as RdcTreeNode).FileGroup;
			}
			return result;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001F648 File Offset: 0x0001D848
		internal void Operation(OperationBehavior behavior, Action operation)
		{
			RdcTreeNode selectedNode = base.SelectedNode as RdcTreeNode;
			try
			{
				if (behavior.HasFlag(OperationBehavior.SuspendUpdate))
				{
					base.BeginUpdate();
				}
				if (behavior.HasFlag(OperationBehavior.SuspendSort))
				{
					this.SuspendSort();
				}
				if (behavior.HasFlag(OperationBehavior.SuspendSelect))
				{
					this.SuspendSelect();
				}
				if (behavior.HasFlag(OperationBehavior.SuspendGroupChanged))
				{
					this.SuspendGroupChanged();
				}
				if (behavior.HasFlag(OperationBehavior.RestoreSelected))
				{
					base.SelectedNode = null;
				}
				operation();
			}
			finally
			{
				if (behavior.HasFlag(OperationBehavior.RestoreSelected))
				{
					base.SelectedNode = selectedNode;
					Program.TheForm.SetTitle();
				}
				if (behavior.HasFlag(OperationBehavior.SuspendGroupChanged))
				{
					this.ResumeGroupChanged();
				}
				if (behavior.HasFlag(OperationBehavior.SuspendSelect))
				{
					this.ResumeSelect();
				}
				if (behavior.HasFlag(OperationBehavior.SuspendSort))
				{
					this.ResumeSort();
				}
				if (behavior.HasFlag(OperationBehavior.SuspendUpdate))
				{
					base.EndUpdate();
				}
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001F7A4 File Offset: 0x0001D9A4
		internal void UpdateColors()
		{
			if (!Program.Preferences.DimNodesWhenInactive)
			{
				this.ForeColor = ServerTree.FocusedForeColor;
				this.BackColor = ServerTree.FocusedBackColor;
				return;
			}
			if (this.Focused)
			{
				this.ForeColor = ServerTree.FocusedForeColor;
				this.BackColor = ServerTree.FocusedBackColor;
				return;
			}
			this.ForeColor = ServerTree.NotFocusedForeColor;
			this.BackColor = ServerTree.NotFocusedBackColor;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001F814 File Offset: 0x0001DA14
		internal void Init(Assembly myAssembly)
		{
			base.ImageList = new ImageList();
			base.ImageList.ColorDepth = ColorDepth.Depth32Bit;
			base.ImageList.ImageSize = new Size(16, 16);
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.disconnected.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.connecting.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.connectingselected.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.connected.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.connectedselected.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.group.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.smartgroup.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.default.ico")));
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.Opening += this.OnContextMenu;
			this.ContextMenuStrip = contextMenuStrip;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001F970 File Offset: 0x0001DB70
		public void AddNode(RdcTreeNode node, GroupBase parent)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			if (!(node is ServerBase) && !(node is GroupBase))
			{
				throw new ArgumentOutOfRangeException("node", "Node must derive from ServerBase or GroupBase");
			}
			if (parent == null)
			{
				throw new ArgumentNullException("parent");
			}
			if (parent == this.RootNode)
			{
				base.Nodes.Add(node);
			}
			else
			{
				parent.Nodes.Add(node);
				this.SortGroup(parent);
			}
			this.OnGroupChanged(parent, ChangeType.TreeChanged);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001FA04 File Offset: 0x0001DC04
		public void RemoveNode(RdcTreeNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			TreeNode treeNode = base.SelectedNode;
			TreeNodeCollection parentNodes = (node.Parent != null) ? node.Parent.Nodes : base.Nodes;
			if (treeNode != null)
			{
				bool inSelectedPath = false;
				(treeNode as RdcTreeNode).VisitNodeAndParents(delegate(RdcTreeNode n)
				{
					if (n == node)
					{
						inSelectedPath = true;
					}
				});
				if (inSelectedPath)
				{
					(treeNode as RdcTreeNode).Hide();
					node.Hide();
					if (node.Index > 0)
					{
						treeNode = parentNodes[node.Index - 1];
					}
					else if (node.Index < parentNodes.Count - 1)
					{
						treeNode = parentNodes[node.Index + 1];
					}
					else
					{
						treeNode = node.Parent;
					}
					base.SelectedNode = null;
				}
			}
			this.Operation(OperationBehavior.RestoreSelected, delegate
			{
				GroupBase groupBase = node.Parent as GroupBase;
				node.OnRemoving();
				parentNodes.Remove(node);
				if (groupBase != null)
				{
					this.OnGroupChanged(groupBase, ChangeType.TreeChanged);
				}
			});
			base.SelectedNode = treeNode;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001FB90 File Offset: 0x0001DD90
		private void CheckDelayedFocusServer()
		{
			object delayedFocusSyncObject = this._delayedFocusSyncObject;
			lock (delayedFocusSyncObject)
			{
				if (this._delayedFocusServer != null)
				{
					Program.TheForm.Invoke(new MethodInvoker(delegate()
					{
						this._delayedFocusServer.FocusConnectedClient();
					}));
				}
				this._delayedFocusServer = null;
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001FBFC File Offset: 0x0001DDFC
		private void SetDelayedFocusServer(ServerBase server)
		{
			object delayedFocusSyncObject = this._delayedFocusSyncObject;
			lock (delayedFocusSyncObject)
			{
				this._delayedFocusServer = server;
				this._delayedFocusTimer.Change(100, -1);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001FC54 File Offset: 0x0001DE54
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.UpdateColors();
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001FC64 File Offset: 0x0001DE64
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.UpdateColors();
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001FC74 File Offset: 0x0001DE74
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this._contextViaMouse = true;
				return;
			}
			base.OnMouseDown(e);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001FC98 File Offset: 0x0001DE98
		protected override void OnBeforeSelect(TreeViewCancelEventArgs e)
		{
			base.OnBeforeSelect(e);
			if (this._noSelectCounter > 0)
			{
				return;
			}
			if (base.SelectedNode != null)
			{
				RdcTreeNode rdcTreeNode = base.SelectedNode as RdcTreeNode;
				ServerBase serverBase = rdcTreeNode as ServerBase;
				if (serverBase == null || serverBase.IsClientUndocked || !serverBase.IsClientFullScreen)
				{
					rdcTreeNode.Hide();
				}
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001FD00 File Offset: 0x0001DF00
		protected override void OnAfterSelect(TreeViewEventArgs e)
		{
			if (this._noSelectCounter > 0)
			{
				return;
			}
			RdcTreeNode rdcTreeNode = base.SelectedNode as RdcTreeNode;
			if (rdcTreeNode != null)
			{
				ServerBase serverBase = rdcTreeNode as ServerBase;
				if (serverBase != null)
				{
					if (serverBase.IsClientUndocked || !serverBase.IsClientFullScreen)
					{
						serverBase.ServerNode.SetNormalView();
					}
					if (!Helpers.IsControlKeyPressed && Program.Preferences.FocusOnClick && e.Action == TreeViewAction.ByMouse && serverBase.IsConnected)
					{
						this.SetDelayedFocusServer(serverBase);
					}
				}
				if (!rdcTreeNode.IsVisible)
				{
					rdcTreeNode.EnsureVisible();
				}
				rdcTreeNode.Show();
			}
			Program.TheForm.SetTitle();
			base.OnAfterSelect(e);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
		private void OnContextMenu(object sender, CancelEventArgs e)
		{
			RdcTreeNode contextNode = base.SelectedNode as RdcTreeNode;
			if (this._contextViaMouse)
			{
				Point point = base.PointToClient(Control.MousePosition);
				contextNode = (base.GetNodeAt(point.X, point.Y) as RdcTreeNode);
				this._contextViaMouse = false;
			}
			this.PopulateNodeContextMenu(this.ContextMenuStrip, contextNode);
			Program.PluginAction(delegate(IPlugin p)
			{
				p.OnContextMenu(this.ContextMenuStrip, contextNode);
			});
			e.Cancel = false;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001FE58 File Offset: 0x0001E058
		private void PopulateNodeContextMenu(ContextMenuStrip menu, RdcTreeNode node)
		{
			menu.Items.Clear();
			if (node == null)
			{
				if (this.AnyOpenedEditableFiles())
				{
					menu.Items.Add(new DelegateMenuItem("&Add server...", MenuNames.EditAddServer, new Action(AddNodeDialogHelper.AddServersDialog)));
					menu.Items.Add(new DelegateMenuItem("&Import servers...", MenuNames.EditImportServers, new Action(AddNodeDialogHelper.ImportServersDialog)));
					menu.Items.Add("-");
					menu.Items.Add(new DelegateMenuItem("Add &group...", MenuNames.EditAddGroup, new Action(AddNodeDialogHelper.AddGroupDialog)));
					return;
				}
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("Please open or create a file");
				toolStripMenuItem.Enabled = false;
				menu.Items.Add(toolStripMenuItem);
				return;
			}
			else
			{
				GroupBase groupBase = node as GroupBase;
				if (groupBase != null)
				{
					bool flag;
					bool flag2;
					groupBase.AnyOrAllConnected(out flag, out flag2);
					ToolStripMenuItem toolStripMenuItem = new DelegateMenuItem("&Connect group", MenuNames.SessionConnect, new Action(groupBase.Connect));
					toolStripMenuItem.Enabled = !flag2;
					menu.Items.Add(toolStripMenuItem);
					toolStripMenuItem = new DelegateMenuItem("&Connect group as...", MenuNames.SessionConnectAs, new Action(groupBase.DoConnectAs));
					toolStripMenuItem.Enabled = !flag2;
					menu.Items.Add(toolStripMenuItem);
					toolStripMenuItem = new DelegateMenuItem("R&econnect group", MenuNames.SessionReconnect, new Action(groupBase.Reconnect));
					toolStripMenuItem.Enabled = flag;
					menu.Items.Add(toolStripMenuItem);
					menu.Items.Add("-");
					toolStripMenuItem = new DelegateMenuItem("&Disconnect group", MenuNames.SessionDisconnect, new Action(groupBase.Disconnect));
					toolStripMenuItem.Enabled = flag;
					menu.Items.Add(toolStripMenuItem);
					menu.Items.Add("-");
					toolStripMenuItem = new DelegateMenuItem("Log off group", MenuNames.SessionLogOff, new Action(groupBase.LogOff));
					toolStripMenuItem.Enabled = (!Policies.DisableLogOff && flag);
					menu.Items.Add(toolStripMenuItem);
					menu.Items.Add("-");
					toolStripMenuItem = new DelegateMenuItem("&Add server...", MenuNames.EditAddServer, delegate()
					{
						AddNodeDialogHelper.AddServersDialog(node);
					});
					toolStripMenuItem.Enabled = groupBase.CanAddServers();
					menu.Items.Add(toolStripMenuItem);
					toolStripMenuItem = new DelegateMenuItem("Add &group...", MenuNames.EditAddGroup, delegate()
					{
						AddNodeDialogHelper.AddGroupDialog(node);
					});
					toolStripMenuItem.Enabled = groupBase.CanAddGroups();
					menu.Items.Add(toolStripMenuItem);
					toolStripMenuItem = new DelegateMenuItem("Add smart group...", MenuNames.EditAddSmartGroup, delegate()
					{
						AddNodeDialogHelper.AddSmartGroupDialog(node);
					});
					toolStripMenuItem.Enabled = groupBase.CanAddGroups();
					menu.Items.Add(toolStripMenuItem);
					menu.Items.Add("-");
					FileGroup file = node as FileGroup;
					if (file != null)
					{
						toolStripMenuItem = new DelegateMenuItem("Save " + file.GetFilename(), MenuNames.FileSave, delegate()
						{
							Program.TheForm.DoFileSave(file);
						});
						toolStripMenuItem.Enabled = file.AllowEdit(false);
						menu.Items.Add(toolStripMenuItem);
						menu.Items.Add(new DelegateMenuItem("Close " + file.GetFilename(), MenuNames.FileClose, delegate()
						{
							Program.TheForm.DoFileClose(file);
						}));
					}
					else
					{
						toolStripMenuItem = new DelegateMenuItem("Remo&ve servers", MenuNames.EditRemoveServers, delegate()
						{
							this.DoRemoveChildren(node);
						});
						toolStripMenuItem.Enabled = groupBase.CanRemoveChildren();
						menu.Items.Add(toolStripMenuItem);
						toolStripMenuItem = new DelegateMenuItem("Remove group", MenuNames.EditRemove, delegate()
						{
							this.ConfirmRemove(node, true);
						});
						toolStripMenuItem.Enabled = node.CanRemove(false);
						menu.Items.Add(toolStripMenuItem);
					}
					menu.Items.Add("-");
					toolStripMenuItem = new DelegateMenuItem("P&roperties", MenuNames.EditProperties, new Action(node.DoPropertiesDialog));
					toolStripMenuItem.Enabled = node.HasProperties;
					menu.Items.Add(toolStripMenuItem);
					return;
				}
				ServerBase server = node as ServerBase;
				MenuHelper.AddSessionMenuItems(menu, server);
				menu.Items.Add("-");
				MenuHelper.AddDockingMenuItems(menu, server);
				menu.Items.Add("-");
				MenuHelper.AddMaintenanceMenuItems(menu, server);
				return;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000202CC File Offset: 0x0001E4CC
		public bool AnyOpenedEditableFiles()
		{
			return base.Nodes.OfType<FileGroup>().Any((FileGroup file) => file.AllowEdit(false));
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00020300 File Offset: 0x0001E500
		private TreeNode FindNodeInList(TreeNodeCollection nodes, string name)
		{
			return (from TreeNode node in nodes
			where node.Text == name
			select node).FirstOrDefault<TreeNode>();
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0002033C File Offset: 0x0001E53C
		public TreeNode FindNodeByName(string name)
		{
			if (name == this.RootNode.Text)
			{
				return this.RootNode;
			}
			string[] array = name.Split(new string[]
			{
				base.PathSeparator
			}, StringSplitOptions.None);
			TreeNodeCollection nodes = base.Nodes;
			TreeNode treeNode = null;
			foreach (string name2 in array)
			{
				treeNode = this.FindNodeInList(nodes, name2);
				if (treeNode == null)
				{
					break;
				}
				nodes = treeNode.Nodes;
			}
			return treeNode;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000203C4 File Offset: 0x0001E5C4
		public void ConfirmRemove(RdcTreeNode node, bool askUser)
		{
			if (!node.ConfirmRemove(askUser))
			{
				return;
			}
			this.RemoveNode(node);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000203DC File Offset: 0x0001E5DC
		private void DoRemoveChildren(RdcTreeNode node)
		{
			GroupBase groupBase = node as GroupBase;
			if (groupBase.Nodes.Count > 0)
			{
				DialogResult dialogResult = FormTools.YesNoDialog("Remove all children of the " + groupBase.Text + " group?");
				if (dialogResult != DialogResult.Yes)
				{
					return;
				}
			}
			groupBase.RemoveChildren();
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00020430 File Offset: 0x0001E630
		protected override void OnItemDrag(ItemDragEventArgs e)
		{
			base.OnItemDrag(e);
			RdcTreeNode draggedNode = e.Item as RdcTreeNode;
			this._draggedNode = draggedNode;
			this._preDragSelectedNode = base.SelectedNode;
			base.DoDragDrop(this._draggedNode, DragDropEffects.Move);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00020478 File Offset: 0x0001E678
		protected override void OnQueryContinueDrag(QueryContinueDragEventArgs e)
		{
			base.OnQueryContinueDrag(e);
			if ((e.KeyState & 3) == 0)
			{
				this.SuspendSelect();
				base.SelectedNode = this._preDragSelectedNode;
				this._preDragSelectedNode = null;
				this.ResumeSelect();
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000204BC File Offset: 0x0001E6BC
		protected override void OnDragOver(DragEventArgs e)
		{
			base.OnDragOver(e);
			Point pt = base.PointToClient(new Point(e.X, e.Y));
			RdcTreeNode rdcTreeNode = base.GetNodeAt(pt) as RdcTreeNode;
			if (rdcTreeNode != null && this._draggedNode.CanDropOnTarget(rdcTreeNode))
			{
				this.SuspendSelect();
				base.SelectedNode = rdcTreeNode;
				this.ResumeSelect();
				e.Effect = e.AllowedEffect;
				return;
			}
			this.SuspendSelect();
			base.SelectedNode = this._draggedNode;
			this.ResumeSelect();
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00020550 File Offset: 0x0001E750
		protected override void OnDragDrop(DragEventArgs e)
		{
			base.OnDragDrop(e);
			Point pt = base.PointToClient(new Point(e.X, e.Y));
			RdcTreeNode rdcTreeNode = base.GetNodeAt(pt) as RdcTreeNode;
			if (rdcTreeNode == null)
			{
				return;
			}
			GroupBase groupBase = (rdcTreeNode as GroupBase) ?? (rdcTreeNode.Parent as GroupBase);
			if (groupBase != this._draggedNode && groupBase != this._draggedNode.Parent)
			{
				this.MoveNode(this._draggedNode, groupBase);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000205D8 File Offset: 0x0001E7D8
		protected override void OnNodeMouseDoubleClick(TreeNodeMouseClickEventArgs e)
		{
			base.OnNodeMouseDoubleClick(e);
			if (e.Button != MouseButtons.Left)
			{
				return;
			}
			if (Helpers.IsControlKeyPressed)
			{
				return;
			}
			ServerBase serverBase = base.SelectedNode as ServerBase;
			if (serverBase != null)
			{
				serverBase.Connect();
				this.SetDelayedFocusServer(serverBase);
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0002062C File Offset: 0x0001E82C
		public void MoveNode(RdcTreeNode node, GroupBase newParent)
		{
			if (newParent != null && newParent.HandleMove(node))
			{
				return;
			}
			this.Operation(OperationBehavior.RestoreSelected, delegate
			{
				if (node.Parent == null)
				{
					this.Nodes.Remove(node);
					this.OnGroupChanged(this.RootNode, ChangeType.TreeChanged);
				}
				else
				{
					if (node is ServerBase)
					{
						TemporaryServer temporaryServer = (node as ServerBase).ServerNode as TemporaryServer;
						if (temporaryServer != null)
						{
							node = temporaryServer;
						}
					}
					GroupBase groupBase = node.Parent as GroupBase;
					groupBase.Nodes.Remove(node);
					this.OnGroupChanged(groupBase, ChangeType.TreeChanged);
				}
				if (newParent == null)
				{
					this.Nodes.Add(node);
					this.OnGroupChanged(this.RootNode, ChangeType.TreeChanged);
				}
				else
				{
					newParent.Nodes.Add(node);
					this.OnGroupChanged(newParent, ChangeType.TreeChanged);
				}
				this.OnNodeChanged(node, ChangeType.TreeChanged);
				if (!node.IsVisible)
				{
					node.EnsureVisible();
				}
			});
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00020690 File Offset: 0x0001E890
		public void OnGroupChanged(GroupBase group, ChangeType changeType)
		{
			if (this._noGroupChanged > 0)
			{
				return;
			}
			if (group != null)
			{
				Log.Write("OnGroupChanged({1}) {0}", new object[]
				{
					group.Text,
					changeType
				});
				HashSet<RdcTreeNode> set = new HashSet<RdcTreeNode>();
				if (group == this.RootNode)
				{
					if (changeType.HasFlag(ChangeType.PropertyChanged))
					{
						base.Nodes.VisitNodes(delegate(RdcTreeNode n)
						{
							set.Add(n);
						});
					}
				}
				else
				{
					group.CollectNodesToInvalidate(true, set);
					group.VisitParents(delegate(RdcTreeNode parent)
					{
						parent.CollectNodesToInvalidate(false, set);
					});
				}
				this.InvalidateNodes(set);
				Action<GroupChangedEventArgs> groupChanged = this.GroupChanged;
				if (groupChanged != null)
				{
					groupChanged(new GroupChangedEventArgs(group, changeType));
				}
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0002076C File Offset: 0x0001E96C
		public void OnNodeChanged(RdcTreeNode node, ChangeType changeType)
		{
			Log.Write("OnNodeChanged({1}) {0}", new object[]
			{
				node.Text,
				changeType
			});
			if (this.SortNode(node))
			{
				GroupBase groupBase = node.Parent as GroupBase;
				if (groupBase != null)
				{
					this.OnGroupChanged(groupBase, ChangeType.InvalidateUI);
				}
			}
			GroupBase groupBase2 = node as GroupBase;
			if (groupBase2 != null)
			{
				this.OnGroupChanged(groupBase2, changeType);
			}
			else
			{
				this.OnServerChanged(node as ServerBase, changeType);
			}
			Program.TheForm.SetTitle();
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000207F8 File Offset: 0x0001E9F8
		private void OnServerChanged(ServerBase serverBase, ChangeType changeType)
		{
			HashSet<RdcTreeNode> set = new HashSet<RdcTreeNode>();
			serverBase.CollectNodesToInvalidate(false, set);
			this.InvalidateNodes(set);
			Action<ServerChangedEventArgs> serverChanged = this.ServerChanged;
			if (serverChanged != null)
			{
				serverChanged(new ServerChangedEventArgs(serverBase, changeType));
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00020838 File Offset: 0x0001EA38
		public void SuspendSelect()
		{
			Interlocked.Increment(ref this._noSelectCounter);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00020848 File Offset: 0x0001EA48
		public void ResumeSelect()
		{
			Interlocked.Decrement(ref this._noSelectCounter);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00020858 File Offset: 0x0001EA58
		public void SuspendSort()
		{
			Interlocked.Increment(ref this._noSortCounter);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00020868 File Offset: 0x0001EA68
		public void ResumeSort()
		{
			Interlocked.Decrement(ref this._noSortCounter);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00020878 File Offset: 0x0001EA78
		public void SuspendGroupChanged()
		{
			Interlocked.Increment(ref this._noGroupChanged);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00020888 File Offset: 0x0001EA88
		public void ResumeGroupChanged()
		{
			Interlocked.Decrement(ref this._noGroupChanged);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00020898 File Offset: 0x0001EA98
		public static ImageConstants TranslateImage(ImageConstants index, bool toSelected)
		{
			return ServerTree.ImageConstantLookup[toSelected ? 1 : 0, (int)index];
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000208B4 File Offset: 0x0001EAB4
		private void InvalidateNodes(HashSet<RdcTreeNode> set)
		{
			foreach (RdcTreeNode rdcTreeNode in set.OrderByDescending((RdcTreeNode n) => n, new ServerTree.InvalidateComparer()))
			{
				rdcTreeNode.InvalidateNode();
			}
		}

		// Token: 0x040002AA RID: 682
		private const int DelayedFocusDelayMilliseconds = 100;

		// Token: 0x040002AB RID: 683
		private static readonly Color NotFocusedForeColor = Color.FromKnownColor(KnownColor.ControlDark);

		// Token: 0x040002AC RID: 684
		private static readonly Color NotFocusedBackColor = Color.White;

		// Token: 0x040002AD RID: 685
		private static readonly Color FocusedForeColor = Color.Black;

		// Token: 0x040002AE RID: 686
		private static readonly Color FocusedBackColor = Color.White;

		// Token: 0x040002AF RID: 687
		private static readonly ImageConstants[,] ImageConstantLookup = new ImageConstants[2, 9];

		// Token: 0x040002B0 RID: 688
		private int _noSortCounter;

		// Token: 0x040002B1 RID: 689
		private int _noSelectCounter;

		// Token: 0x040002B2 RID: 690
		private int _noGroupChanged;

		// Token: 0x040002B3 RID: 691
		private bool _contextViaMouse;

		// Token: 0x040002B4 RID: 692
		private RdcTreeNode _draggedNode;

		// Token: 0x040002B5 RID: 693
		private TreeNode _preDragSelectedNode;

		// Token: 0x040002B6 RID: 694
		private ServerBase _delayedFocusServer;

		// Token: 0x040002B7 RID: 695
		private readonly System.Threading.Timer _delayedFocusTimer;

		// Token: 0x040002B8 RID: 696
		private readonly object _delayedFocusSyncObject = new object();

		// Token: 0x040002B9 RID: 697
		private readonly GroupBase _rootNode = new ServerTree.RootNodeGroup();

		// Token: 0x020002A4 RID: 676
		private class RootNodeGroup : GroupBase
		{
			// Token: 0x06005730 RID: 22320 RVA: 0x0005F2E8 File Offset: 0x0005D4E8
			public RootNodeGroup()
			{
				base.Text = "[root]";
			}

			// Token: 0x06005731 RID: 22321 RVA: 0x0005F2FC File Offset: 0x0005D4FC
			public override void OnRemoving()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06005732 RID: 22322 RVA: 0x0005F304 File Offset: 0x0005D504
			public override void DoPropertiesDialog(Form parentForm, string activeTabName)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06005733 RID: 22323 RVA: 0x0005F30C File Offset: 0x0005D50C
			protected override void InitSettings()
			{
			}
		}

		// Token: 0x020002A5 RID: 677
		private class InvalidateComparer : IComparer<RdcTreeNode>
		{
			// Token: 0x06005734 RID: 22324 RVA: 0x0005F310 File Offset: 0x0005D510
			public int Compare(RdcTreeNode x, RdcTreeNode y)
			{
				int ordinal = this.GetOrdinal(x);
				int ordinal2 = this.GetOrdinal(y);
				return ordinal - ordinal2;
			}

			// Token: 0x06005735 RID: 22325 RVA: 0x0005F334 File Offset: 0x0005D534
			private int GetOrdinal(RdcTreeNode node)
			{
				if (node is Server)
				{
					return 9999;
				}
				if (node is ServerRef)
				{
					return 8888;
				}
				return node.GetPathLength();
			}
		}
	}
}
