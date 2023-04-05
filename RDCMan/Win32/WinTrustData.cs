using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000011 RID: 17
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class WinTrustData
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000216C File Offset: 0x0000036C
		public WinTrustData(string _fileName)
		{
			if (Environment.OSVersion.Version.Major > 6 || (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor > 1) || (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1 && !string.IsNullOrEmpty(Environment.OSVersion.ServicePack)))
			{
				this.ProvFlags |= WinTrustDataProvFlags.DisableMD2andMD4;
			}
			WinTrustFileInfo structure = new WinTrustFileInfo(_fileName);
			this.FileInfoPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(WinTrustFileInfo)));
			Marshal.StructureToPtr<WinTrustFileInfo>(structure, this.FileInfoPtr, false);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002290 File Offset: 0x00000490
		~WinTrustData()
		{
			Marshal.FreeCoTaskMem(this.FileInfoPtr);
		}

		// Token: 0x04000056 RID: 86
		private uint StructSize = (uint)Marshal.SizeOf(typeof(WinTrustData));

		// Token: 0x04000057 RID: 87
		private IntPtr PolicyCallbackData = IntPtr.Zero;

		// Token: 0x04000058 RID: 88
		private IntPtr SIPClientData = IntPtr.Zero;

		// Token: 0x04000059 RID: 89
		private WinTrustDataUIChoice UIChoice = WinTrustDataUIChoice.None;

		// Token: 0x0400005A RID: 90
		private WinTrustDataRevocationChecks RevocationChecks;

		// Token: 0x0400005B RID: 91
		private WinTrustDataChoice UnionChoice = WinTrustDataChoice.File;

		// Token: 0x0400005C RID: 92
		private IntPtr FileInfoPtr;

		// Token: 0x0400005D RID: 93
		private WinTrustDataStateAction StateAction;

		// Token: 0x0400005E RID: 94
		private IntPtr StateData = IntPtr.Zero;

		// Token: 0x0400005F RID: 95
		private string URLReference;

		// Token: 0x04000060 RID: 96
		private WinTrustDataProvFlags ProvFlags = WinTrustDataProvFlags.RevocationCheckChainExcludeRoot;

		// Token: 0x04000061 RID: 97
		private WinTrustDataUIContext UIContext;
	}
}
