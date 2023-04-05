using System;
using System.Windows.Forms;

namespace RdcMan
{
	internal class RemoteDesktopsMenuItem : RdcMenuItem
	{
		public RemoteDesktopsMenuItem() : base("Remote Desktops")
		{
			base.Name = MenuNames.RemoteDesktops.ToString();
			ServerTree.Instance.GroupChanged += this.GroupChanged;
			ServerTree.Instance.ServerChanged += this.ServerChanged;
			this.HasChangedSinceMenuUpdate = true;
		}

		private bool HasChangedSinceMenuUpdate { get; set; }

		private void ServerChanged(ServerChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.TreeChanged) && !e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			this.HasChangedSinceMenuUpdate = true;
		}

		private void GroupChanged(GroupChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.TreeChanged) && !e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			this.HasChangedSinceMenuUpdate = true;
		}

		public override void Update()
		{
			if (!this.HasChangedSinceMenuUpdate)
			{
				return;
			}
			this.HasChangedSinceMenuUpdate = false;
			base.DropDownItems.Clear();
			foreach (object obj in ServerTree.Instance.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				this.PopulateRemoteDesktopsMenuItems(base.DropDownItems, treeNode);
			}
		}

		protected override void OnClick()
		{
		}

		private void PopulateRemoteDesktopsMenuItems(ToolStripItemCollection items, TreeNode treeNode)
		{
			RdcTreeNode rdcTreeNode = treeNode as RdcTreeNode;
			GroupBase groupBase = rdcTreeNode as GroupBase;
			ToolStripMenuItem toolStripMenuItem;
			if (groupBase != null && (groupBase.Nodes.Count > 1 || groupBase.HasGroups))
			{
				toolStripMenuItem = new ToolStripMenuItem(rdcTreeNode.Text);
				ServerMenuItem serverMenuItem = new ServerMenuItem(rdcTreeNode);
				serverMenuItem.Text = "[All]";
				toolStripMenuItem.DropDownItems.Add(serverMenuItem);
			}
			else
			{
				toolStripMenuItem = new ServerMenuItem(rdcTreeNode);
			}
			foreach (object obj in rdcTreeNode.Nodes)
			{
				TreeNode treeNode2 = (TreeNode)obj;
				this.PopulateRemoteDesktopsMenuItems(toolStripMenuItem.DropDownItems, treeNode2);
			}
			items.Add(toolStripMenuItem);
		}

		private const string AllItem = "[All]";
	}
}
