using System;

namespace RdcMan
{
	// Token: 0x02000109 RID: 265
	internal abstract class CheckedMenuItem : RdcMenuItem
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x0000641A File Offset: 0x0000461A
		protected CheckedMenuItem(string text)
		{
			this.Text = text;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000648D File Offset: 0x0000468D
		protected sealed override void OnClick()
		{
			this.CheckChanged(!base.Checked);
		}

		// Token: 0x060006D6 RID: 1750
		protected abstract void CheckChanged(bool isChecked);
	}
}
