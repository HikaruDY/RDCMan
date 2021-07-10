using System;

namespace RdcMan
{
	// Token: 0x0200003E RID: 62
	public interface ISettingControl
	{
		// Token: 0x060000CC RID: 204
		void UpdateControl();

		// Token: 0x060000CD RID: 205
		void UpdateSetting();

		// Token: 0x060000CE RID: 206
		string Validate();
	}
}
