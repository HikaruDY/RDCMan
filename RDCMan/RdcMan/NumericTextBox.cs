using System;
using System.Windows.Forms;

namespace RdcMan
{
	public class NumericTextBox : TextBox, ISettingControl
	{
		public NumericTextBox(int min, int max, string invalidMessage)
		{
			if (min < 0)
			{
				throw new ArgumentOutOfRangeException("min");
			}
			if (max < 0)
			{
				throw new ArgumentOutOfRangeException("max");
			}
			if (min >= max)
			{
				throw new ArgumentException("Minimum must be less than maximum");
			}
			if (string.IsNullOrWhiteSpace(invalidMessage))
			{
				throw new ArgumentOutOfRangeException("invalidMessage");
			}
			this._min = min;
			this._max = max;
			this._invalidMessage = invalidMessage;
		}

		public IntSetting Setting { get; set; }

		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.Text = this.Setting.Value.ToString();
			}
		}

		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = int.Parse(this.Text);
			}
		}

		string ISettingControl.Validate()
		{
			string result = null;
			int num = int.Parse(this.Text);
			if (num < this._min || num > this._max)
			{
				result = this._invalidMessage;
			}
			return result;
		}

		protected override bool ProcessCmdKey(ref Message m, Keys keyData)
		{
			if ((keyData & Keys.Modifiers) == Keys.None && (keyData - Keys.D0 <= 9 || keyData - Keys.NumPad0 <= 9))
			{
				return base.ProcessCmdKey(ref m, keyData);
			}
			if ((keyData & (Keys.Control | Keys.Alt)) != Keys.None)
			{
				return base.ProcessCmdKey(ref m, keyData);
			}
			Keys keys = keyData & Keys.KeyCode;
			if (keys <= Keys.Escape)
			{
				if (keys - Keys.Back > 1 && keys != Keys.Return && keys != Keys.Escape)
				{
					return true;
				}
			}
			else if (keys - Keys.End > 2 && keys != Keys.Right && keys != Keys.Delete)
			{
				return true;
			}
			return base.ProcessCmdKey(ref m, keyData);
		}

		private readonly int _min;

		private readonly int _max;

		private readonly string _invalidMessage;
	}
}
