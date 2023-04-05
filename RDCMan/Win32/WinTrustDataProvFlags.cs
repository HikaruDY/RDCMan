using System;

namespace Win32
{
	[Flags]
	public enum WinTrustDataProvFlags : uint
	{
		UseIe4TrustFlag = 1U,
		NoIe4ChainFlag = 2U,
		NoPolicyUsageFlag = 4U,
		RevocationCheckNone = 16U,
		RevocationCheckEndCert = 32U,
		RevocationCheckChain = 64U,
		RevocationCheckChainExcludeRoot = 128U,
		SaferFlag = 256U,
		HashOnlyFlag = 512U,
		UseDefaultOsverCheck = 1024U,
		LifetimeSigningFlag = 2048U,
		CacheOnlyUrlRetrieval = 4096U,
		DisableMD2andMD4 = 8192U
	}
}
