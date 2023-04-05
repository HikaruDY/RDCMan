using System;
using System.Collections.Generic;

namespace RdcMan
{
	// Token: 0x020000E5 RID: 229
	public class EnableTabsEventArgs : EventArgs
	{
		// Token: 0x0400034D RID: 845
		public bool Enabled;

		// Token: 0x0400034E RID: 846
		public string Reason;

		// Token: 0x0400034F RID: 847
		public IEnumerable<string> TabNames;
	}
}
