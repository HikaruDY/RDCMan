using System;

namespace Win32
{
	// Token: 0x02000026 RID: 38
	public enum WinVerifyTrustResult : uint
	{
		// Token: 0x0400022E RID: 558
		Success,
		// Token: 0x0400022F RID: 559
		ProviderUnknown = 2148204545u,
		// Token: 0x04000230 RID: 560
		ActionUnknown,
		// Token: 0x04000231 RID: 561
		SubjectFormUnknown,
		// Token: 0x04000232 RID: 562
		SubjectNotTrusted,
		// Token: 0x04000233 RID: 563
		FileNotSigned = 2148204800u,
		// Token: 0x04000234 RID: 564
		SubjectExplicitlyDistrusted = 2148204817u,
		// Token: 0x04000235 RID: 565
		SignatureOrFileCorrupt = 2148098064u,
		// Token: 0x04000236 RID: 566
		SubjectCertExpired = 2148204801u,
		// Token: 0x04000237 RID: 567
		SubjectCertificateRevoked = 134262800u
	}
}
