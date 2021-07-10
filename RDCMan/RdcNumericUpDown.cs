using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000041 RID: 65
	public class RdcNumericUpDown : NumericUpDown, ISettingControl
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000270F File Offset: 0x0000090F
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002717 File Offset: 0x00000917
		public IntSetting Setting { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002720 File Offset: 0x00000920
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002728 File Offset: 0x00000928
		public new Func<string> Validate { private get; set; }

		// Token: 0x060000E1 RID: 225 RVA: 0x00002731 File Offset: 0x00000931
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				base.Value = this.Setting.Value;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002751 File Offset: 0x00000951
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = (int)base.Value;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002771 File Offset: 0x00000971
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
