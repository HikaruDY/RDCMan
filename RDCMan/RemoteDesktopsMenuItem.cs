using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000111 RID: 273
	internal class RemoteDesktopsMenuItem : RdcMenuItem
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		public RemoteDesktopsMenuItem() : base("Remote Desktops")
		{
			base.Name = MenuNames.RemoteDesktops.ToString();
			ServerTree.Instance.GroupChanged += this.GroupChanged;
			ServerTree.Instance.ServerChanged += this.ServerChanged;
			this.HasChangedSinceMenuUpdate = true;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000065F4 File Offset: 0x000047F4
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x000065FC File Offset: 0x000047FC
		private bool HasChangedSinceMenuUpdate { get; set; }

		// Token: 0x060006EE RID: 1774 RVA: 0x00006605 File Offset: 0x00004805
		private void ServerChanged(ServerChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.TreeChanged) && !e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			this.HasChangedSinceMenuUpdate = true;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000663F File Offset: 0x0000483F
		private void GroupChanged(GroupChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.TreeChanged) && !e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			this.HasChangedSinceMenuUpdate = true;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001C744 File Offset: 0x0001A944
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

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002EFA File Offset: 0x000010FA
		protected override void OnClick()
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001C7C4 File Offset: 0x0001A9C4
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

		// Token: 0x040004D4 RID: 1236
		private const string AllItem = "[All]";
	}
}
