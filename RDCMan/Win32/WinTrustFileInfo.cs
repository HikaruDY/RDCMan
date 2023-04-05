using System;
using System.Runtime.InteropServices;

namespace Win32
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class WinTrustFileInfo
	{
		public WinTrustFileInfo(string _filePath)
		{
			this.pszFilePath = Marshal.StringToCoTaskMemAuto(_filePath);
		}

		~WinTrustFileInfo()
		{
			Marshal.FreeCoTaskMem(this.pszFilePath);
		}

		private uint StructSize = (uint)Marshal.SizeOf(typeof(WinTrustFileInfo));

		private IntPtr pszFilePath;

		private IntPtr hFile = IntPtr.Zero;

		private IntPtr pgKnownSubject = IntPtr.Zero;
	}
}
