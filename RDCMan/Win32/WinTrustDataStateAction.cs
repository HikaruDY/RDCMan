using System;

namespace Win32
{
	// Token: 0x0200000D RID: 13
	public enum WinTrustDataStateAction : uint
	{
		// Token: 0x0400003C RID: 60
		Ignore,
		// Token: 0x0400003D RID: 61
		Verify,
		// Token: 0x0400003E RID: 62
		Close,
		// Token: 0x0400003F RID: 63
		AutoCache,
		// Token: 0x04000040 RID: 64
		AutoCacheFlush
	}
}
