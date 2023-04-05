using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000094 RID: 148
	public class DelegateMenuItem : ToolStripMenuItem
	{
		// Token: 0x0600056E RID: 1390 RVA: 0x0001A4C0 File Offset: 0x000186C0
		public DelegateMenuItem(string text, MenuNames name, Action click) : base(text)
		{
			base.Click += delegate(object s, EventArgs e)
			{
				click();
			};
			base.Name = name.ToString();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0001A50C File Offset: 0x0001870C
		public DelegateMenuItem(string text, MenuNames name, string shortcut, Action click) : this(text, name, click)
		{
			base.ShortcutKeyDisplayString = shortcut;
		}
	}
}
