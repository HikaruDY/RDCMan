using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000107 RID: 263
	internal abstract class RdcMenuItem : ToolStripMenuItem
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x00006412 File Offset: 0x00004612
		protected RdcMenuItem()
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000641A File Offset: 0x0000461A
		protected RdcMenuItem(string text) : this()
		{
			this.Text = text;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00006429 File Offset: 0x00004629
		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			this.OnClick();
		}

		// Token: 0x060006CE RID: 1742
		public abstract void Update();

		// Token: 0x060006CF RID: 1743
		protected abstract void OnClick();
	}
}
