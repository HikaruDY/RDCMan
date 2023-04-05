using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000010 RID: 16
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class WinTrustFileInfo
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000020F8 File Offset: 0x000002F8
		public WinTrustFileInfo(string _filePath)
		{
			this.pszFilePath = Marshal.StringToCoTaskMemAuto(_filePath);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002138 File Offset: 0x00000338
		~WinTrustFileInfo()
		{
			Marshal.FreeCoTaskMem(this.pszFilePath);
		}

		// Token: 0x04000052 RID: 82
		private uint StructSize = (uint)Marshal.SizeOf(typeof(WinTrustFileInfo));

		// Token: 0x04000053 RID: 83
		private IntPtr pszFilePath;

		// Token: 0x04000054 RID: 84
		private IntPtr hFile = IntPtr.Zero;

		// Token: 0x04000055 RID: 85
		private IntPtr pgKnownSubject = IntPtr.Zero;
	}
}
