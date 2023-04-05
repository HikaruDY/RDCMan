using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001D1 RID: 465
	[Guid("92C38A7D-241A-418C-9936-099872C9AF20")]
	[TypeLibType(4176)]
	[ComVisible(true)]
	[ComImport]
	public interface ITSRemoteProgram2 : ITSRemoteProgram
	{
		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06003715 RID: 14101
		// (set) Token: 0x06003714 RID: 14100
		[DispId(200)]
		bool RemoteProgramMode { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06003716 RID: 14102
		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ServerStartProgram([MarshalAs(UnmanagedType.BStr)] [In] string bstrExecutablePath, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFilePath, [MarshalAs(UnmanagedType.BStr)] [In] string bstrWorkingDirectory, [In] bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.BStr)] [In] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);

		// Token: 0x17001195 RID: 4501
		// (set) Token: 0x06003717 RID: 14103
		[DispId(202)]
		string RemoteApplicationName { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001196 RID: 4502
		// (set) Token: 0x06003718 RID: 14104
		[DispId(203)]
		string RemoteApplicationProgram { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001197 RID: 4503
		// (set) Token: 0x06003719 RID: 14105
		[DispId(204)]
		string RemoteApplicationArgs { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
