using System;

namespace Win32
{
	// Token: 0x02000022 RID: 34
	[Flags]
	public enum WinTrustDataProvFlags : uint
	{
		// Token: 0x0400020D RID: 525
		UseIe4TrustFlag = 1u,
		// Token: 0x0400020E RID: 526
		NoIe4ChainFlag = 2u,
		// Token: 0x0400020F RID: 527
		NoPolicyUsageFlag = 4u,
		// Token: 0x04000210 RID: 528
		RevocationCheckNone = 16u,
		// Token: 0x04000211 RID: 529
		RevocationCheckEndCert = 32u,
		// Token: 0x04000212 RID: 530
		RevocationCheckChain = 64u,
		// Token: 0x04000213 RID: 531
		RevocationCheckChainExcludeRoot = 128u,
		// Token: 0x04000214 RID: 532
		SaferFlag = 256u,
		// Token: 0x04000215 RID: 533
		HashOnlyFlag = 512u,
		// Token: 0x04000216 RID: 534
		UseDefaultOsverCheck = 1024u,
		// Token: 0x04000217 RID: 535
		LifetimeSigningFlag = 2048u,
		// Token: 0x04000218 RID: 536
		CacheOnlyUrlRetrieval = 4096u,
		// Token: 0x04000219 RID: 537
		DisableMD2andMD4 = 8192u
	}
}
