using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public class Crypto
	{
		[DllImport("crypt32.dll", CharSet = CharSet.Unicode)]
		public static extern bool CryptProtectData(ref Crypto.DataBlob dataIn, string description, ref Crypto.DataBlob optionalEntropy, IntPtr reserved, ref Crypto.CryptProtectPromptStruct promptStruct, int flags, out Crypto.DataBlob dataOut);

		[DllImport("crypt32.dll", CharSet = CharSet.Unicode)]
		public static extern bool CryptUnprotectData(ref Crypto.DataBlob dataIn, string description, ref Crypto.DataBlob optionalEntropy, IntPtr reserved, ref Crypto.CryptProtectPromptStruct promptStruct, int flags, out Crypto.DataBlob dataOut);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		public static extern void LocalFree(IntPtr ptr);

		public struct DataBlob
		{
			public int Size;

			public IntPtr Data;
		}

		public struct CryptProtectPromptStruct
		{
			public int Size;

			public int Flags;

			public IntPtr Window;

			public string Message;
		}
	}
}
