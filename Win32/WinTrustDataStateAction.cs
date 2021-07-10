using System;

namespace Win32
{
	// Token: 0x02000021 RID: 33
	public enum WinTrustDataStateAction : uint
	{
		// Token: 0x04000207 RID: 519
		Ignore,
		// Token: 0x04000208 RID: 520
		Verify,
		// Token: 0x04000209 RID: 521
		Close,
		// Token: 0x0400020A RID: 522
		AutoCache,
		// Token: 0x0400020B RID: 523
		AutoCacheFlush
	}
}
