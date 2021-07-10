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
	// Token: 0x02000149 RID: 329
	internal class ServerTree : TreeView, IServerTree
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060007F8 RID: 2040 RVA: 0x0001FA50 File Offset: 0x0001DC50
		// (remove) Token: 0x060007F9 RID: 2041 RVA: 0x0001FA88 File Offset: 0x0001DC88
		internal event Action<ServerChangedEventArgs> ServerChanged;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060007FA RID: 2042 RVA: 0x0001FAC0 File Offset: 0x0001DCC0
		// (remove) Token: 0x060007FB RID: 2043 RVA: 0x0001FAF8 File Offset: 0x0001DCF8
		internal event Action<GroupChangedEventArgs> GroupChanged;

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0000711E File Offset: 0x0000531E
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00007125 File Offset: 0x00005325
		internal static ServerTree Instance { get; private set; }

		// Token: 0x060007FE RID: 2046 RVA: 0x0001FB30 File Offset: 0x0001DD30
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

		// Token: 0x060007FF RID: 2047 RVA: 0x0001FC04 File Offset: 0x0001DE04
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0000712D File Offset: 0x0000532D
		public GroupBase RootNode
		{
			get
			{
				return this._rootNode;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00007135 File Offset: 0x00005335
		internal bool SuppressSorting
		{
			get
			{
				return this._noSortCounter > 0;
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0001FC64 File Offset: 0x0001DE64
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

		// Token: 0x06000803 RID: 2051 RVA: 0x0001FC8C File Offset: 0x0001DE8C
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

		// Token: 0x06000804 RID: 2052 RVA: 0x0001FDCC File Offset: 0x0001DFCC
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

		// Token: 0x06000805 RID: 2053 RVA: 0x0001FE34 File Offset: 0x0001E034
		internal void Init(Assembly myAssembly)
		{
			base.ImageList = new ImageList();
			base.ImageList.ColorDepth = ColorDepth.Depth8Bit;
			base.ImageList.ImageSize = new Size(16, 16);
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.disconnected.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.connecting.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.connectingselected.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.connected.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.connectedselected.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.group.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.smartgroup.ico")));
			base.ImageList.Images.Add(new Icon(myAssembly.GetManifestResourceStream("RdcMan.Resources.app.ico")));
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.Opening += this.OnContextMenu;
			this.ContextMenuStrip = contextMenuStrip;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0001FF8C File Offset: 0x0001E18C
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

		// Token: 0x06000807 RID: 2055 RVA: 0x0002000C File Offset: 0x0001E20C
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

		// Token: 0x06000808 RID: 2056 RVA: 0x00020180 File Offset: 0x0001E380
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

		// Token: 0x06000809 RID: 2057 RVA: 0x000201E0 File Offset: 0x0001E3E0
		private void SetDelayedFocusServer(ServerBase server)
		{
			object delayedFocusSyncObject = this._delayedFocusSyncObject;
			lock (delayedFocusSyncObject)
			{
				this._delayedFocusServer = server;
				this._delayedFocusTimer.Change(100, -1);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00007140 File Offset: 0x00005340
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.UpdateColors();
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0000714F File Offset: 0x0000534F
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.UpdateColors();
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0000715E File Offset: 0x0000535E
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this._contextViaMouse = true;
				return;
			}
			base.OnMouseDown(e);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00020230 File Offset: 0x0001E430
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

		// Token: 0x0600080E RID: 2062 RVA: 0x00020284 File Offset: 0x0001E484
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

		// Token: 0x0600080F RID: 2063 RVA: 0x00020320 File Offset: 0x0001E520
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

		// Token: 0x06000810 RID: 2064 RVA: 0x000203B0 File Offset: 0x0001E5B0
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

		// Token: 0x06000811 RID: 2065 RVA: 0x0000717C File Offset: 0x0000537C
		public bool AnyOpenedEditableFiles()
		{
			return base.Nodes.OfType<FileGroup>().Any((FileGroup file) => file.AllowEdit(false));
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00020818 File Offset: 0x0001EA18
		private TreeNode FindNodeInList(TreeNodeCollection nodes, string name)
		{
			return (from TreeNode node in nodes
			where node.Text == name
			select node).FirstOrDefault<TreeNode>();
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00020850 File Offset: 0x0001EA50
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

		// Token: 0x06000814 RID: 2068 RVA: 0x000071AD File Offset: 0x000053AD
		public void ConfirmRemove(RdcTreeNode node, bool askUser)
		{
			if (!node.ConfirmRemove(askUser))
			{
				return;
			}
			this.RemoveNode(node);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000208C8 File Offset: 0x0001EAC8
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

		// Token: 0x06000816 RID: 2070 RVA: 0x00020910 File Offset: 0x0001EB10
		protected override void OnItemDrag(ItemDragEventArgs e)
		{
			base.OnItemDrag(e);
			RdcTreeNode draggedNode = e.Item as RdcTreeNode;
			this._draggedNode = draggedNode;
			this._preDragSelectedNode = base.SelectedNode;
			base.DoDragDrop(this._draggedNode, DragDropEffects.Move);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000071C0 File Offset: 0x000053C0
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

		// Token: 0x06000818 RID: 2072 RVA: 0x00020954 File Offset: 0x0001EB54
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

		// Token: 0x06000819 RID: 2073 RVA: 0x000209E0 File Offset: 0x0001EBE0
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

		// Token: 0x0600081A RID: 2074 RVA: 0x00020A58 File Offset: 0x0001EC58
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

		// Token: 0x0600081B RID: 2075 RVA: 0x00020AA0 File Offset: 0x0001ECA0
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

		// Token: 0x0600081C RID: 2076 RVA: 0x00020AF8 File Offset: 0x0001ECF8
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

		// Token: 0x0600081D RID: 2077 RVA: 0x00020BC0 File Offset: 0x0001EDC0
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

		// Token: 0x0600081E RID: 2078 RVA: 0x00020C3C File Offset: 0x0001EE3C
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

		// Token: 0x0600081F RID: 2079 RVA: 0x000071F2 File Offset: 0x000053F2
		public void SuspendSelect()
		{
			Interlocked.Increment(ref this._noSelectCounter);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00007200 File Offset: 0x00005400
		public void ResumeSelect()
		{
			Interlocked.Decrement(ref this._noSelectCounter);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0000720E File Offset: 0x0000540E
		public void SuspendSort()
		{
			Interlocked.Increment(ref this._noSortCounter);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0000721C File Offset: 0x0000541C
		public void ResumeSort()
		{
			Interlocked.Decrement(ref this._noSortCounter);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0000722A File Offset: 0x0000542A
		public void SuspendGroupChanged()
		{
			Interlocked.Increment(ref this._noGroupChanged);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00007238 File Offset: 0x00005438
		public void ResumeGroupChanged()
		{
			Interlocked.Decrement(ref this._noGroupChanged);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00007246 File Offset: 0x00005446
		public static ImageConstants TranslateImage(ImageConstants index, bool toSelected)
		{
			return ServerTree.ImageConstantLookup[toSelected ? 1 : 0, (int)index];
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00020C78 File Offset: 0x0001EE78
		private void InvalidateNodes(HashSet<RdcTreeNode> set)
		{
			foreach (RdcTreeNode rdcTreeNode in set.OrderByDescending((RdcTreeNode n) => n, new ServerTree.InvalidateComparer()))
			{
				rdcTreeNode.InvalidateNode();
			}
		}

		// Token: 0x040005B8 RID: 1464
		private const int DelayedFocusDelayMilliseconds = 100;

		// Token: 0x040005B9 RID: 1465
		private static readonly Color NotFocusedForeColor = Color.FromKnownColor(KnownColor.ControlDark);

		// Token: 0x040005BA RID: 1466
		private static readonly Color NotFocusedBackColor = Color.White;

		// Token: 0x040005BB RID: 1467
		private static readonly Color FocusedForeColor = Color.Black;

		// Token: 0x040005BC RID: 1468
		private static readonly Color FocusedBackColor = Color.White;

		// Token: 0x040005BD RID: 1469
		private static readonly ImageConstants[,] ImageConstantLookup = new ImageConstants[2, 9];

		// Token: 0x040005BE RID: 1470
		private int _noSortCounter;

		// Token: 0x040005BF RID: 1471
		private int _noSelectCounter;

		// Token: 0x040005C0 RID: 1472
		private int _noGroupChanged;

		// Token: 0x040005C1 RID: 1473
		private bool _contextViaMouse;

		// Token: 0x040005C2 RID: 1474
		private RdcTreeNode _draggedNode;

		// Token: 0x040005C3 RID: 1475
		private TreeNode _preDragSelectedNode;

		// Token: 0x040005C4 RID: 1476
		private ServerBase _delayedFocusServer;

		// Token: 0x040005C5 RID: 1477
		private readonly System.Threading.Timer _delayedFocusTimer;

		// Token: 0x040005C6 RID: 1478
		private readonly object _delayedFocusSyncObject = new object();

		// Token: 0x040005C7 RID: 1479
		private readonly GroupBase _rootNode = new ServerTree.RootNodeGroup();

		// Token: 0x0200014A RID: 330
		private class RootNodeGroup : GroupBase
		{
			// Token: 0x06000829 RID: 2089 RVA: 0x0000726F File Offset: 0x0000546F
			public RootNodeGroup()
			{
				base.Text = "[root]";
			}

			// Token: 0x0600082A RID: 2090 RVA: 0x0000358A File Offset: 0x0000178A
			public override void OnRemoving()
			{
				throw new NotImplementedException();
			}

			// Token: 0x0600082B RID: 2091 RVA: 0x0000358A File Offset: 0x0000178A
			public override void DoPropertiesDialog(Form parentForm, string activeTabName)
			{
				throw new NotImplementedException();
			}

			// Token: 0x0600082C RID: 2092 RVA: 0x00002EFA File Offset: 0x000010FA
			protected override void InitSettings()
			{
			}
		}

		// Token: 0x0200014B RID: 331
		private class InvalidateComparer : IComparer<RdcTreeNode>
		{
			// Token: 0x0600082D RID: 2093 RVA: 0x00020CE8 File Offset: 0x0001EEE8
			public int Compare(RdcTreeNode x, RdcTreeNode y)
			{
				int ordinal = this.GetOrdinal(x);
				int ordinal2 = this.GetOrdinal(y);
				return ordinal - ordinal2;
			}

			// Token: 0x0600082E RID: 2094 RVA: 0x00007282 File Offset: 0x00005482
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
