using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000025 RID: 37
	public class RdcCheckBox : CheckBox, ISettingControl
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004FC0 File Offset: 0x000031C0
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00004FC8 File Offset: 0x000031C8
		public BoolSetting Setting { get; set; }

		// Token: 0x060000C1 RID: 193 RVA: 0x00004FD4 File Offset: 0x000031D4
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				base.Checked = this.Setting.Value;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004FF4 File Offset: 0x000031F4
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = base.Checked;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005014 File Offset: 0x00003214
		string ISettingControl.Validate()
		{
			return null;
		}
	}
}
