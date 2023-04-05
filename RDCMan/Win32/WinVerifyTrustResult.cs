using System;

namespace Win32
{
	public enum WinVerifyTrustResult : uint
	{
		Success,
		ProviderUnknown = 2148204545U,
		ActionUnknown,
		SubjectFormUnknown,
		SubjectNotTrusted,
		FileNotSigned = 2148204800U,
		SubjectExplicitlyDistrusted = 2148204817U,
		SignatureOrFileCorrupt = 2148098064U,
		SubjectCertExpired = 2148204801U,
		SubjectCertificateRevoked = 134262800U
	}
}
