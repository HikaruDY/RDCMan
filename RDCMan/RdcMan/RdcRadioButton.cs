using System;
using System.Windows.Forms;

namespace RdcMan
{
	public class RdcRadioButton : RadioButton, ISettingControl
	{
		public BoolSetting Setting { get; set; }

		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				base.Checked = this.Setting.Value;
			}
		}

		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = base.Checked;
			}
		}

		string ISettingControl.Validate()
		{
			return null;
		}
	}
}
