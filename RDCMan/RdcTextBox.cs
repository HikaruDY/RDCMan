using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200003F RID: 63
	public class RdcTextBox : TextBox, ISettingControl
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002651 File Offset: 0x00000851
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002659 File Offset: 0x00000859
		public StringSetting Setting { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002662 File Offset: 0x00000862
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000266A File Offset: 0x0000086A
		public Func<string> Validate { private get; set; }

		// Token: 0x060000D3 RID: 211 RVA: 0x00002673 File Offset: 0x00000873
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.Text = this.Setting.Value;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000268E File Offset: 0x0000088E
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.Text;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000026A9 File Offset: 0x000008A9
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
