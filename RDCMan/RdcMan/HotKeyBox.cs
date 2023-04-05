using System;
using System.Windows.Forms;

namespace RdcMan
{
	public class HotKeyBox : TextBox, ISettingControl
	{
		public string Prefix { get; set; }

		public EnumSetting<Keys> Setting { get; set; }

		public Keys HotKey
		{
			get
			{
				return this._hotKey;
			}
			set
			{
				this._hotKey = value;
				string str;
				if (this.HotKey == Keys.Next)
				{
					str = "PageDown";
				}
				else if (this.HotKey == Keys.Cancel)
				{
					str = "Break";
				}
				else if (this.HotKey >= Keys.D0 && this.HotKey <= Keys.D9)
				{
					str = (this.HotKey - Keys.D0).ToString();
				}
				else if (this.HotKey >= Keys.NumPad0 && this.HotKey <= Keys.NumPad9)
				{
					str = (this.HotKey - Keys.NumPad0).ToString() + " (num pad)";
				}
				else
				{
					str = this.HotKey.ToString();
				}
				this.Text = (this.Prefix + str).ToUpper();
			}
		}

		protected override bool ProcessCmdKey(ref Message m, Keys keyData)
		{
			Keys keys = keyData & Keys.KeyCode;
			if (keys == Keys.Tab || keys == Keys.Escape)
			{
				return base.ProcessCmdKey(ref m, keyData);
			}
			if ((keyData & Keys.Modifiers) == Keys.None || keys == Keys.Cancel)
			{
				this.HotKey = keys;
			}
			return true;
		}

		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.HotKey = this.Setting.Value;
			}
		}

		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.HotKey;
			}
		}

		string ISettingControl.Validate()
		{
			return null;
		}

		private Keys _hotKey;
	}
}
