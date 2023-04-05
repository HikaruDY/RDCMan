using System;

namespace Win32
{
	// Token: 0x0200000C RID: 12
	public enum WinTrustDataChoice : uint
	{
		// Token: 0x04000036 RID: 54
		File = 1U,
		// Token: 0x04000037 RID: 55
		Catalog,
		// Token: 0x04000038 RID: 56
		Blob,
		// Token: 0x04000039 RID: 57
		Signer,
		// Token: 0x0400003A RID: 58
		Certificate
	}
}
