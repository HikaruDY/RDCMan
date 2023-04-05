using System;

namespace RdcMan
{
	// Token: 0x0200009F RID: 159
	internal class ServerMenuItem : RdcMenuItem
	{
		// Token: 0x06000596 RID: 1430 RVA: 0x0001AAF8 File Offset: 0x00018CF8
		public ServerMenuItem(RdcTreeNode node)
		{
			base.Tag = node;
			this.Text = node.Text;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001AB24 File Offset: 0x00018D24
		public override void Update()
		{
			if (base.DropDownItems.Count == 0)
			{
				base.Checked = (ServerTree.Instance.SelectedNode == base.Tag);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001AB60 File Offset: 0x00018D60
		protected override void OnClick()
		{
			ServerTree.Instance.SelectedNode = (RdcTreeNode)base.Tag;
		}
	}
}
