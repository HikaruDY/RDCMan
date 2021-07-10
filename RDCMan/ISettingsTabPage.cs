using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000083 RID: 131
	public interface ISettingsTabPage
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000265 RID: 613
		InheritanceControl InheritanceControl { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000266 RID: 614
		Control FocusControl { get; }

		// Token: 0x06000267 RID: 615
		void UpdateControls();

		// Token: 0x06000268 RID: 616
		bool Validate();

		// Token: 0x06000269 RID: 617
		void UpdateSettings();
	}
}
