using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000053 RID: 83
	public interface ISettingsTabPage
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001F9 RID: 505
		InheritanceControl InheritanceControl { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001FA RID: 506
		Control FocusControl { get; }

		// Token: 0x060001FB RID: 507
		void UpdateControls();

		// Token: 0x060001FC RID: 508
		bool Validate();

		// Token: 0x060001FD RID: 509
		void UpdateSettings();
	}
}
