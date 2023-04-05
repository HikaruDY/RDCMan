using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200001A RID: 26
	public class NumericTextBox : TextBox, ISettingControl
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00004440 File Offset: 0x00002640
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

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000044B8 File Offset: 0x000026B8
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000044C0 File Offset: 0x000026C0
		public IntSetting Setting { get; set; }

		// Token: 0x0600007A RID: 122 RVA: 0x000044CC File Offset: 0x000026CC
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.Text = this.Setting.Value.ToString();
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004504 File Offset: 0x00002704
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = int.Parse(this.Text);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004528 File Offset: 0x00002728
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

		// Token: 0x0600007D RID: 125 RVA: 0x00004568 File Offset: 0x00002768
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

		// Token: 0x0400008C RID: 140
		private readonly int _min;

		// Token: 0x0400008D RID: 141
		private readonly int _max;

		// Token: 0x0400008E RID: 142
		private readonly string _invalidMessage;
	}
}
