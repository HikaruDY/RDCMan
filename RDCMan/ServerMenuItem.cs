using System;

namespace RdcMan
{
	// Token: 0x02000112 RID: 274
	internal class ServerMenuItem : RdcMenuItem
	{
		// Token: 0x060006F3 RID: 1779 RVA: 0x00006679 File Offset: 0x00004879
		public ServerMenuItem(RdcTreeNode node)
		{
			base.Tag = node;
			this.Text = node.Text;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00006694 File Offset: 0x00004894
		public override void Update()
		{
			if (base.DropDownItems.Count == 0)
			{
				base.Checked = (ServerTree.Instance.SelectedNode == base.Tag);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000066BB File Offset: 0x000048BB
		protected override void OnClick()
		{
			ServerTree.Instance.SelectedNode = (RdcTreeNode)base.Tag;
		}
	}
}
