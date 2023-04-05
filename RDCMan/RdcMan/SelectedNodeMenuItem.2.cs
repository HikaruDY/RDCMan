using System;

namespace RdcMan
{
	// Token: 0x0200009D RID: 157
	internal class SelectedNodeMenuItem : SelectedNodeMenuItem<RdcTreeNode>
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x0001A870 File Offset: 0x00018A70
		public SelectedNodeMenuItem(string text, MenuNames name, Action<RdcTreeNode> action) : base(text, name, action)
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001A87C File Offset: 0x00018A7C
		public SelectedNodeMenuItem(string text, MenuNames name, string shortcut, Action<RdcTreeNode> action) : base(text, name, shortcut, action)
		{
		}
	}
}
