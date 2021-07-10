using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000104 RID: 260
	public static class MenuExtensions
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x000063E3 File Offset: 0x000045E3
		public static ToolStripMenuItem Add(this ToolStrip menu, string text, MenuNames nameConstant)
		{
			return menu.Items.Add(text, nameConstant);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001C520 File Offset: 0x0001A720
		public static ToolStripMenuItem Add(this ToolStripItemCollection menuItems, string text, MenuNames nameConstant)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text);
			toolStripMenuItem.Name = nameConstant.ToString();
			menuItems.Add(toolStripMenuItem);
			return toolStripMenuItem;
		}
	}
}
