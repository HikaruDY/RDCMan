using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x0200000C RID: 12
	public class Crypto
	{
		// Token: 0x06000011 RID: 17
		[DllImport("crypt32.dll", CharSet = CharSet.Unicode)]
		public static extern bool CryptProtectData(ref Crypto.DataBlob dataIn, string description, ref Crypto.DataBlob optionalEntropy, IntPtr reserved, ref Crypto.CryptProtectPromptStruct promptStruct, int flags, out Crypto.DataBlob dataOut);

		// Token: 0x06000012 RID: 18
		[DllImport("crypt32.dll", CharSet = CharSet.Unicode)]
		public static extern bool CryptUnprotectData(ref Crypto.DataBlob dataIn, string description, ref Crypto.DataBlob optionalEntropy, IntPtr reserved, ref Crypto.CryptProtectPromptStruct promptStruct, int flags, out Crypto.DataBlob dataOut);

		// Token: 0x06000013 RID: 19
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		public static extern void LocalFree(IntPtr ptr);

		// Token: 0x0200000D RID: 13
		public struct DataBlob
		{
			// Token: 0x04000047 RID: 71
			public int Size;

			// Token: 0x04000048 RID: 72
			public IntPtr Data;
		}

		// Token: 0x0200000E RID: 14
		public struct CryptProtectPromptStruct
		{
			// Token: 0x04000049 RID: 73
			public int Size;

			// Token: 0x0400004A RID: 74
			public int Flags;

			// Token: 0x0400004B RID: 75
			public IntPtr Window;

			// Token: 0x0400004C RID: 76
			public string Message;
		}
	}
}
