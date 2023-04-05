using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200001B RID: 27
	public class HotKeyBox : TextBox, ISettingControl
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000460C File Offset: 0x0000280C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00004614 File Offset: 0x00002814
		public string Prefix { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00004620 File Offset: 0x00002820
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00004628 File Offset: 0x00002828
		public EnumSetting<Keys> Setting { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00004634 File Offset: 0x00002834
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000463C File Offset: 0x0000283C
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

		// Token: 0x06000085 RID: 133 RVA: 0x00004724 File Offset: 0x00002924
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

		// Token: 0x06000086 RID: 134 RVA: 0x00004774 File Offset: 0x00002974
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.HotKey = this.Setting.Value;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004794 File Offset: 0x00002994
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.HotKey;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000047B4 File Offset: 0x000029B4
		string ISettingControl.Validate()
		{
			return null;
		}

		// Token: 0x04000092 RID: 146
		private Keys _hotKey;
	}
}
