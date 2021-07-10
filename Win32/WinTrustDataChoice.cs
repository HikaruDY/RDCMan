using System;

namespace Win32
{
	// Token: 0x02000020 RID: 32
	public enum WinTrustDataChoice : uint
	{
		// Token: 0x04000201 RID: 513
		File = 1u,
		// Token: 0x04000202 RID: 514
		Catalog,
		// Token: 0x04000203 RID: 515
		Blob,
		// Token: 0x04000204 RID: 516
		Signer,
		// Token: 0x04000205 RID: 517
		Certificate
	}
}
