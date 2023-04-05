using System;

namespace Win32
{
	public enum WinTrustDataChoice : uint
	{
		File = 1U,
		Catalog,
		Blob,
		Signer,
		Certificate
	}
}
