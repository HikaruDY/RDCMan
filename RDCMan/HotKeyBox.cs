using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000033 RID: 51
	public class HotKeyBox : TextBox, ISettingControl
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000023B2 File Offset: 0x000005B2
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000023BA File Offset: 0x000005BA
		public string Prefix { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000023C3 File Offset: 0x000005C3
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000023CB File Offset: 0x000005CB
		public EnumSetting<Keys> Setting { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000023D4 File Offset: 0x000005D4
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000A660 File Offset: 0x00008860
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

		// Token: 0x0600008F RID: 143 RVA: 0x0000A720 File Offset: 0x00008920
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

		// Token: 0x06000090 RID: 144 RVA: 0x000023E4 File Offset: 0x000005E4
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.HotKey = this.Setting.Value;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000023FF File Offset: 0x000005FF
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.HotKey;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000241A File Offset: 0x0000061A
		string ISettingControl.Validate()
		{
			return null;
		}

		// Token: 0x04000261 RID: 609
		private Keys _hotKey;
	}
}
