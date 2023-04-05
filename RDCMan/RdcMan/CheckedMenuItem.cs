using System;

namespace RdcMan
{
	// Token: 0x02000097 RID: 151
	internal abstract class CheckedMenuItem : RdcMenuItem
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x0001A5A4 File Offset: 0x000187A4
		protected CheckedMenuItem(string text)
		{
			this.Text = text;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001A5B4 File Offset: 0x000187B4
		protected sealed override void OnClick()
		{
			this.CheckChanged(!base.Checked);
		}

		// Token: 0x0600057B RID: 1403
		protected abstract void CheckChanged(bool isChecked);
	}
}
