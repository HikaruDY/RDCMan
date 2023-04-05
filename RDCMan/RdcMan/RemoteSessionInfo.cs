using System;
using Win32;

namespace RdcMan
{
	// Token: 0x020000B2 RID: 178
	internal class RemoteSessionInfo
	{
		// Token: 0x04000246 RID: 582
		public string ClientName;

		// Token: 0x04000247 RID: 583
		public string DomainName;

		// Token: 0x04000248 RID: 584
		public int SessionId;

		// Token: 0x04000249 RID: 585
		public Wts.ConnectstateClass State;

		// Token: 0x0400024A RID: 586
		public string UserName;
	}
}
