using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000105 RID: 261
	public class DelegateMenuItem : ToolStripMenuItem
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x0001C550 File Offset: 0x0001A750
		public DelegateMenuItem(string text, MenuNames name, Action click) : base(text)
		{
			base.Click += delegate(object s, EventArgs e)
			{
				click();
			};
			base.Name = name.ToString();
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000063F2 File Offset: 0x000045F2
		public DelegateMenuItem(string text, MenuNames name, string shortcut, Action click) : this(text, name, click)
		{
			base.ShortcutKeyDisplayString = shortcut;
		}
	}
}
