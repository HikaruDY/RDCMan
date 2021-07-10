using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000024 RID: 36
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class WinTrustFileInfo
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000020F6 File Offset: 0x000002F6
		public WinTrustFileInfo(string _filePath)
		{
			this.pszFilePath = Marshal.StringToCoTaskMemAuto(_filePath);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00008644 File Offset: 0x00006844
		~WinTrustFileInfo()
		{
			Marshal.FreeCoTaskMem(this.pszFilePath);
		}

		// Token: 0x0400021D RID: 541
		private uint StructSize = (uint)Marshal.SizeOf(typeof(WinTrustFileInfo));

		// Token: 0x0400021E RID: 542
		private IntPtr pszFilePath;

		// Token: 0x0400021F RID: 543
		private IntPtr hFile = IntPtr.Zero;

		// Token: 0x04000220 RID: 544
		private IntPtr pgKnownSubject = IntPtr.Zero;
	}
}
