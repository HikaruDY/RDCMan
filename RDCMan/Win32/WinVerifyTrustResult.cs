using System;

namespace Win32
{
	// Token: 0x02000012 RID: 18
	public enum WinVerifyTrustResult : uint
	{
		// Token: 0x04000063 RID: 99
		Success,
		// Token: 0x04000064 RID: 100
		ProviderUnknown = 2148204545U,
		// Token: 0x04000065 RID: 101
		ActionUnknown,
		// Token: 0x04000066 RID: 102
		SubjectFormUnknown,
		// Token: 0x04000067 RID: 103
		SubjectNotTrusted,
		// Token: 0x04000068 RID: 104
		FileNotSigned = 2148204800U,
		// Token: 0x04000069 RID: 105
		SubjectExplicitlyDistrusted = 2148204817U,
		// Token: 0x0400006A RID: 106
		SignatureOrFileCorrupt = 2148098064U,
		// Token: 0x0400006B RID: 107
		SubjectCertExpired = 2148204801U,
		// Token: 0x0400006C RID: 108
		SubjectCertificateRevoked = 134262800U
	}
}
