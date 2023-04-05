using System;

namespace Win32
{
	// Token: 0x0200000E RID: 14
	[Flags]
	public enum WinTrustDataProvFlags : uint
	{
		// Token: 0x04000042 RID: 66
		UseIe4TrustFlag = 1U,
		// Token: 0x04000043 RID: 67
		NoIe4ChainFlag = 2U,
		// Token: 0x04000044 RID: 68
		NoPolicyUsageFlag = 4U,
		// Token: 0x04000045 RID: 69
		RevocationCheckNone = 16U,
		// Token: 0x04000046 RID: 70
		RevocationCheckEndCert = 32U,
		// Token: 0x04000047 RID: 71
		RevocationCheckChain = 64U,
		// Token: 0x04000048 RID: 72
		RevocationCheckChainExcludeRoot = 128U,
		// Token: 0x04000049 RID: 73
		SaferFlag = 256U,
		// Token: 0x0400004A RID: 74
		HashOnlyFlag = 512U,
		// Token: 0x0400004B RID: 75
		UseDefaultOsverCheck = 1024U,
		// Token: 0x0400004C RID: 76
		LifetimeSigningFlag = 2048U,
		// Token: 0x0400004D RID: 77
		CacheOnlyUrlRetrieval = 4096U,
		// Token: 0x0400004E RID: 78
		DisableMD2andMD4 = 8192U
	}
}
