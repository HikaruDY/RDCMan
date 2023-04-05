using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000027 RID: 39
	public class RdcRadioButton : RadioButton, ISettingControl
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000050B4 File Offset: 0x000032B4
		// (set) Token: 0x060000CE RID: 206 RVA: 0x000050BC File Offset: 0x000032BC
		public BoolSetting Setting { get; set; }

		// Token: 0x060000CF RID: 207 RVA: 0x000050C8 File Offset: 0x000032C8
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				base.Checked = this.Setting.Value;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000050E8 File Offset: 0x000032E8
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = base.Checked;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005108 File Offset: 0x00003308
		string ISettingControl.Validate()
		{
			return null;
		}
	}
}
