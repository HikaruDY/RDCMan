using System;

namespace RdcMan
{
	// Token: 0x02000146 RID: 326
	[Flags]
	internal enum OperationBehavior
	{
		// Token: 0x040005A1 RID: 1441
		None = 0,
		// Token: 0x040005A2 RID: 1442
		SuspendSelect = 1,
		// Token: 0x040005A3 RID: 1443
		SuspendSort = 2,
		// Token: 0x040005A4 RID: 1444
		SuspendUpdate = 4,
		// Token: 0x040005A5 RID: 1445
		SuspendGroupChanged = 8,
		// Token: 0x040005A6 RID: 1446
		RestoreSelected = 17
	}
}
