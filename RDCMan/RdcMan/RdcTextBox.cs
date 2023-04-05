using System;
using System.Windows.Forms;

namespace RdcMan
{
	public class RdcTextBox : TextBox, ISettingControl
	{
		public StringSetting Setting { get; set; }

		public Func<string> Validate { private get; set; }

		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.Text = this.Setting.Value;
			}
		}

		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.Text;
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
