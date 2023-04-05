using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000007 RID: 7
	public class Crypto
	{
		// Token: 0x06000010 RID: 16
		[DllImport("crypt32.dll", CharSet = CharSet.Unicode)]
		public static extern bool CryptProtectData(ref Crypto.DataBlob dataIn, string description, ref Crypto.DataBlob optionalEntropy, IntPtr reserved, ref Crypto.CryptProtectPromptStruct promptStruct, int flags, out Crypto.DataBlob dataOut);

		// Token: 0x06000011 RID: 17
		[DllImport("crypt32.dll", CharSet = CharSet.Unicode)]
		public static extern bool CryptUnprotectData(ref Crypto.DataBlob dataIn, string description, ref Crypto.DataBlob optionalEntropy, IntPtr reserved, ref Crypto.CryptProtectPromptStruct promptStruct, int flags, out Crypto.DataBlob dataOut);

		// Token: 0x06000012 RID: 18
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		public static extern void LocalFree(IntPtr ptr);

		// Token: 0x0200021F RID: 543
		public struct DataBlob
		{
			// Token: 0x04000838 RID: 2104
			public int Size;

			// Token: 0x04000839 RID: 2105
			public IntPtr Data;
		}

		// Token: 0x02000220 RID: 544
		public struct CryptProtectPromptStruct
		{
			// Token: 0x0400083A RID: 2106
			public int Size;

			// Token: 0x0400083B RID: 2107
			public int Flags;

			// Token: 0x0400083C RID: 2108
			public IntPtr Window;

			// Token: 0x0400083D RID: 2109
			public string Message;
		}
	}
}
