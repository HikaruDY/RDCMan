using System;
using Win32;

namespace RdcMan
{
	// Token: 0x02000136 RID: 310
	internal class RemoteSessionInfo
	{
		// Token: 0x04000545 RID: 1349
		public string ClientName;

		// Token: 0x04000546 RID: 1350
		public string DomainName;

		// Token: 0x04000547 RID: 1351
		public int SessionId;

		// Token: 0x04000548 RID: 1352
		public Wts.ConnectstateClass State;

		// Token: 0x04000549 RID: 1353
		public string UserName;
	}
}
