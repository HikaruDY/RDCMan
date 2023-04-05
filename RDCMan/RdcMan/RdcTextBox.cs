using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000024 RID: 36
	public class RdcTextBox : TextBox, ISettingControl
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00004F3C File Offset: 0x0000313C
		public StringSetting Setting { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004F48 File Offset: 0x00003148
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00004F50 File Offset: 0x00003150
		public Func<string> Validate { private get; set; }

		// Token: 0x060000BB RID: 187 RVA: 0x00004F5C File Offset: 0x0000315C
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.Text = this.Setting.Value;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004F7C File Offset: 0x0000317C
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.Text;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004F9C File Offset: 0x0000319C
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
