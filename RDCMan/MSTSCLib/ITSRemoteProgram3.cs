using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001EC RID: 492
	[Guid("4B84EA77-ACEA-418C-881A-4A8C28AB1510")]
	[TypeLibType(4176)]
	[ComVisible(true)]
	[ComImport]
	public interface ITSRemoteProgram3 : ITSRemoteProgram2
	{
		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06004986 RID: 18822
		// (set) Token: 0x06004985 RID: 18821
		[DispId(200)]
		bool RemoteProgramMode { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004987 RID: 18823
		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ServerStartProgram([MarshalAs(UnmanagedType.BStr)] [In] string bstrExecutablePath, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFilePath, [MarshalAs(UnmanagedType.BStr)] [In] string bstrWorkingDirectory, [In] bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.BStr)] [In] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);

		// Token: 0x17001B52 RID: 6994
		// (set) Token: 0x06004988 RID: 18824
		[DispId(202)]
		string RemoteApplicationName { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B53 RID: 6995
		// (set) Token: 0x06004989 RID: 18825
		[DispId(203)]
		string RemoteApplicationProgram { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B54 RID: 6996
		// (set) Token: 0x0600498A RID: 18826
		[DispId(204)]
		string RemoteApplicationArgs { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600498B RID: 18827
		[DispId(205)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ServerStartApp([MarshalAs(UnmanagedType.BStr)] [In] string bstrAppUserModelId, [MarshalAs(UnmanagedType.BStr)] [In] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);
	}
}
