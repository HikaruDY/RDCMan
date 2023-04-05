using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200009E RID: 158
	internal class RemoteDesktopsMenuItem : RdcMenuItem
	{
		// Token: 0x0600058E RID: 1422 RVA: 0x0001A88C File Offset: 0x00018A8C
		public RemoteDesktopsMenuItem() : base("Remote Desktops")
		{
			base.Name = MenuNames.RemoteDesktops.ToString();
			ServerTree.Instance.GroupChanged += this.GroupChanged;
			ServerTree.Instance.ServerChanged += this.ServerChanged;
			this.HasChangedSinceMenuUpdate = true;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0001A8FC File Offset: 0x00018AFC
		private bool HasChangedSinceMenuUpdate { get; set; }

		// Token: 0x06000591 RID: 1425 RVA: 0x0001A908 File Offset: 0x00018B08
		private void ServerChanged(ServerChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.TreeChanged) && !e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			this.HasChangedSinceMenuUpdate = true;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0001A948 File Offset: 0x00018B48
		private void GroupChanged(GroupChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.TreeChanged) && !e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			this.HasChangedSinceMenuUpdate = true;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0001A988 File Offset: 0x00018B88
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

		// Token: 0x06000594 RID: 1428 RVA: 0x0001AA14 File Offset: 0x00018C14
		protected override void OnClick()
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001AA18 File Offset: 0x00018C18
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

		// Token: 0x0400020D RID: 525
		private const string AllItem = "[All]";
	}
}
