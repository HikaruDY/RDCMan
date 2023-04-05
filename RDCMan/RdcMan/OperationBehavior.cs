using System;

namespace RdcMan
{
	// Token: 0x020000BB RID: 187
	[Flags]
	internal enum OperationBehavior
	{
		// Token: 0x04000293 RID: 659
		None = 0,
		// Token: 0x04000294 RID: 660
		SuspendSelect = 1,
		// Token: 0x04000295 RID: 661
		SuspendSort = 2,
		// Token: 0x04000296 RID: 662
		SuspendUpdate = 4,
		// Token: 0x04000297 RID: 663
		SuspendGroupChanged = 8,
		// Token: 0x04000298 RID: 664
		RestoreSelected = 17
	}
}
