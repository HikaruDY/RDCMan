using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000040 RID: 64
	public class RdcCheckBox : CheckBox, ISettingControl
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000026C0 File Offset: 0x000008C0
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000026C8 File Offset: 0x000008C8
		public BoolSetting Setting { get; set; }

		// Token: 0x060000D9 RID: 217 RVA: 0x000026D1 File Offset: 0x000008D1
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				base.Checked = this.Setting.Value;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000026EC File Offset: 0x000008EC
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = base.Checked;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000241A File Offset: 0x0000061A
		string ISettingControl.Validate()
		{
			return null;
		}
	}
}
