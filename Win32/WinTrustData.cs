using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000025 RID: 37
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class WinTrustData
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00008678 File Offset: 0x00006878
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

		// Token: 0x06000033 RID: 51 RVA: 0x00008788 File Offset: 0x00006988
		~WinTrustData()
		{
			Marshal.FreeCoTaskMem(this.FileInfoPtr);
		}

		// Token: 0x04000221 RID: 545
		private uint StructSize = (uint)Marshal.SizeOf(typeof(WinTrustData));

		// Token: 0x04000222 RID: 546
		private IntPtr PolicyCallbackData = IntPtr.Zero;

		// Token: 0x04000223 RID: 547
		private IntPtr SIPClientData = IntPtr.Zero;

		// Token: 0x04000224 RID: 548
		private WinTrustDataUIChoice UIChoice = WinTrustDataUIChoice.None;

		// Token: 0x04000225 RID: 549
		private WinTrustDataRevocationChecks RevocationChecks;

		// Token: 0x04000226 RID: 550
		private WinTrustDataChoice UnionChoice = WinTrustDataChoice.File;

		// Token: 0x04000227 RID: 551
		private IntPtr FileInfoPtr;

		// Token: 0x04000228 RID: 552
		private WinTrustDataStateAction StateAction;

		// Token: 0x04000229 RID: 553
		private IntPtr StateData = IntPtr.Zero;

		// Token: 0x0400022A RID: 554
		private string URLReference;

		// Token: 0x0400022B RID: 555
		private WinTrustDataProvFlags ProvFlags = WinTrustDataProvFlags.RevocationCheckChainExcludeRoot;

		// Token: 0x0400022C RID: 556
		private WinTrustDataUIContext UIContext;
	}
}
