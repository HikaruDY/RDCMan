using System;

namespace RdcMan
{
	internal abstract class CheckedMenuItem : RdcMenuItem
	{
		protected CheckedMenuItem(string text)
		{
			this.Text = text;
		}

		protected sealed override void OnClick()
		{
			this.CheckChanged(!base.Checked);
		}

		protected abstract void CheckChanged(bool isChecked);
	}
}
