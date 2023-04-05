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
	internal class ServerTree : TreeView, IServerTree
	{
		internal event Action<ServerChangedEventArgs> ServerChanged;

		internal event Action<GroupChangedEventArgs> GroupChanged;

		internal static ServerTree Instance { get; private set; }

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

		public GroupBase RootNode
		{
			get
			{
				return this._rootNode;
			}
		}

		internal bool SuppressSorting
		{
			get
			{
				return this._noSortCounter > 0;
			}
		}

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

		private void SetDelayedFocusServer(ServerBase server)
		{
			object delayedFocusSyncObject = this._delayedFocusSyncObject;
			lock (delayedFocusSyncObject)
			{
				this._delayedFocusServer = server;
				this._delayedFocusTimer.Change(100, -1);
			}
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.UpdateColors();
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.UpdateColors();
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this._contextViaMouse = true;
				return;
			}
			base.OnMouseDown(e);
		}

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

		public bool AnyOpenedEditableFiles()
		{
			return base.Nodes.OfType<FileGroup>().Any((FileGroup file) => file.AllowEdit(false));
		}

		private TreeNode FindNodeInList(TreeNodeCollection nodes, string name)
		{
			return (from TreeNode node in nodes
			where node.Text == name
			select node).FirstOrDefault<TreeNode>();
		}

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

		public void ConfirmRemove(RdcTreeNode node, bool askUser)
		{
			if (!node.ConfirmRemove(askUser))
			{
				return;
			}
			this.RemoveNode(node);
		}

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

		protected override void OnItemDrag(ItemDragEventArgs e)
		{
			base.OnItemDrag(e);
			RdcTreeNode draggedNode = e.Item as RdcTreeNode;
			this._draggedNode = draggedNode;
			this._preDragSelectedNode = base.SelectedNode;
			base.DoDragDrop(this._draggedNode, DragDropEffects.Move);
		}

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

		public void SuspendSelect()
		{
			Interlocked.Increment(ref this._noSelectCounter);
		}

		public void ResumeSelect()
		{
			Interlocked.Decrement(ref this._noSelectCounter);
		}

		public void SuspendSort()
		{
			Interlocked.Increment(ref this._noSortCounter);
		}

		public void ResumeSort()
		{
			Interlocked.Decrement(ref this._noSortCounter);
		}

		public void SuspendGroupChanged()
		{
			Interlocked.Increment(ref this._noGroupChanged);
		}

		public void ResumeGroupChanged()
		{
			Interlocked.Decrement(ref this._noGroupChanged);
		}

		public static ImageConstants TranslateImage(ImageConstants index, bool toSelected)
		{
			return ServerTree.ImageConstantLookup[toSelected ? 1 : 0, (int)index];
		}

		private void InvalidateNodes(HashSet<RdcTreeNode> set)
		{
			foreach (RdcTreeNode rdcTreeNode in set.OrderByDescending((RdcTreeNode n) => n, new ServerTree.InvalidateComparer()))
			{
				rdcTreeNode.InvalidateNode();
			}
		}

		private const int DelayedFocusDelayMilliseconds = 100;

		private static readonly Color NotFocusedForeColor = Color.FromKnownColor(KnownColor.ControlDark);

		private static readonly Color NotFocusedBackColor = Color.White;

		private static readonly Color FocusedForeColor = Color.Black;

		private static readonly Color FocusedBackColor = Color.White;

		private static readonly ImageConstants[,] ImageConstantLookup = new ImageConstants[2, 9];

		private int _noSortCounter;

		private int _noSelectCounter;

		private int _noGroupChanged;

		private bool _contextViaMouse;

		private RdcTreeNode _draggedNode;

		private TreeNode _preDragSelectedNode;

		private ServerBase _delayedFocusServer;

		private readonly System.Threading.Timer _delayedFocusTimer;

		private readonly object _delayedFocusSyncObject = new object();

		private readonly GroupBase _rootNode = new ServerTree.RootNodeGroup();

		private class RootNodeGroup : GroupBase
		{
			public RootNodeGroup()
			{
				base.Text = "[root]";
			}

			public override void OnRemoving()
			{
				throw new NotImplementedException();
			}

			public override void DoPropertiesDialog(Form parentForm, string activeTabName)
			{
				throw new NotImplementedException();
			}

			protected override void InitSettings()
			{
			}
		}

		private class InvalidateComparer : IComparer<RdcTreeNode>
		{
			public int Compare(RdcTreeNode x, RdcTreeNode y)
			{
				int ordinal = this.GetOrdinal(x);
				int ordinal2 = this.GetOrdinal(y);
				return ordinal - ordinal2;
			}

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
