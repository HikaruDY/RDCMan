using System;
using System.Windows.Forms;

namespace RdcMan
{
	public class RdcNumericUpDown : NumericUpDown, ISettingControl
	{
		public IntSetting Setting { get; set; }

		public new Func<string> Validate { private get; set; }

		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				base.Value = this.Setting.Value;
			}
		}

		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = (int)base.Value;
			}
		}

		string ISettingControl.Validate()
		{
			if (this.Validate != null)
			{
				return this.Validate();
			}
			return null;
		}
	}
}
