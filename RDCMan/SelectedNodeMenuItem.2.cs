using System;

namespace RdcMan
{
	// Token: 0x02000110 RID: 272
	internal class SelectedNodeMenuItem : SelectedNodeMenuItem<RdcTreeNode>
	{
		// Token: 0x060006E9 RID: 1769 RVA: 0x000065DC File Offset: 0x000047DC
		public SelectedNodeMenuItem(string text, MenuNames name, Action<RdcTreeNode> action) : base(text, name, action)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000065E7 File Offset: 0x000047E7
		public SelectedNodeMenuItem(string text, MenuNames name, string shortcut, Action<RdcTreeNode> action) : base(text, name, shortcut, action)
		{
		}
	}
}
