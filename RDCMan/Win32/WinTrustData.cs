using System;
using System.Runtime.InteropServices;

namespace Win32
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class WinTrustData
	{
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

		~WinTrustData()
		{
			Marshal.FreeCoTaskMem(this.FileInfoPtr);
		}

		private uint StructSize = (uint)Marshal.SizeOf(typeof(WinTrustData));

		private IntPtr PolicyCallbackData = IntPtr.Zero;

		private IntPtr SIPClientData = IntPtr.Zero;

		private WinTrustDataUIChoice UIChoice = WinTrustDataUIChoice.None;

		private WinTrustDataRevocationChecks RevocationChecks;

		private WinTrustDataChoice UnionChoice = WinTrustDataChoice.File;

		private IntPtr FileInfoPtr;

		private WinTrustDataStateAction StateAction;

		private IntPtr StateData = IntPtr.Zero;

		private string URLReference;

		private WinTrustDataProvFlags ProvFlags = WinTrustDataProvFlags.RevocationCheckChainExcludeRoot;

		private WinTrustDataUIContext UIContext;
	}
}
