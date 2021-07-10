using System;
using System.Collections.Generic;

namespace RdcMan
{
	// Token: 0x0200017D RID: 381
	public class EnableTabsEventArgs : EventArgs
	{
		// Token: 0x0400066C RID: 1644
		public bool Enabled;

		// Token: 0x0400066D RID: 1645
		public string Reason;

		// Token: 0x0400066E RID: 1646
		public IEnumerable<string> TabNames;
	}
}
