using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000032 RID: 50
	public class NumericTextBox : TextBox, ISettingControl
	{
		// Token: 0x06000081 RID: 129 RVA: 0x0000A514 File Offset: 0x00008714
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
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002381 File Offset: 0x00000581
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002389 File Offset: 0x00000589
		public IntSetting Setting { get; set; }

		// Token: 0x06000084 RID: 132 RVA: 0x0000A57C File Offset: 0x0000877C
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.Text = this.Setting.Value.ToString();
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002392 File Offset: 0x00000592
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = int.Parse(this.Text);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000A5AC File Offset: 0x000087AC
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

		// Token: 0x06000087 RID: 135 RVA: 0x0000A5E4 File Offset: 0x000087E4
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

		// Token: 0x0400025B RID: 603
		private readonly int _min;

		// Token: 0x0400025C RID: 604
		private readonly int _max;

		// Token: 0x0400025D RID: 605
		private readonly string _invalidMessage;
	}
}
