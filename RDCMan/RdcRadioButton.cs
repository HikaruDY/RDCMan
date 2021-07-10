using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000042 RID: 66
	public class RdcRadioButton : RadioButton, ISettingControl
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002790 File Offset: 0x00000990
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002798 File Offset: 0x00000998
		public BoolSetting Setting { get; set; }

		// Token: 0x060000E7 RID: 231 RVA: 0x000027A1 File Offset: 0x000009A1
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				base.Checked = this.Setting.Value;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000027BC File Offset: 0x000009BC
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = base.Checked;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000241A File Offset: 0x0000061A
		string ISettingControl.Validate()
		{
			return null;
		}
	}
}
