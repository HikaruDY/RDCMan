using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000093 RID: 147
	public static class MenuExtensions
	{
		// Token: 0x0600056C RID: 1388 RVA: 0x0001A47C File Offset: 0x0001867C
		public static ToolStripMenuItem Add(this ToolStrip menu, string text, MenuNames nameConstant)
		{
			return menu.Items.Add(text, nameConstant);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0001A48C File Offset: 0x0001868C
		public static ToolStripMenuItem Add(this ToolStripItemCollection menuItems, string text, MenuNames nameConstant)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text);
			toolStripMenuItem.Name = nameConstant.ToString();
			menuItems.Add(toolStripMenuItem);
			return toolStripMenuItem;
		}
	}
}
