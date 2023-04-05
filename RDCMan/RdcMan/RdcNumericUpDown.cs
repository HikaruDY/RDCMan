using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000026 RID: 38
	public class RdcNumericUpDown : NumericUpDown, ISettingControl
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00005020 File Offset: 0x00003220
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00005028 File Offset: 0x00003228
		public IntSetting Setting { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00005034 File Offset: 0x00003234
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000503C File Offset: 0x0000323C
		public new Func<string> Validate { private get; set; }

		// Token: 0x060000C9 RID: 201 RVA: 0x00005048 File Offset: 0x00003248
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				base.Value = this.Setting.Value;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000506C File Offset: 0x0000326C
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = (int)base.Value;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005090 File Offset: 0x00003290
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
