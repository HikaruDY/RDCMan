using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("4B84EA77-ACEA-418C-881A-4A8C28AB1510")]
	[TypeLibType(4176)]
	[ComVisible(true)]
	[ComImport]
	public interface ITSRemoteProgram3 : ITSRemoteProgram2
	{
		[DispId(200)]
		bool RemoteProgramMode { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ServerStartProgram([MarshalAs(UnmanagedType.BStr)] [In] string bstrExecutablePath, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFilePath, [MarshalAs(UnmanagedType.BStr)] [In] string bstrWorkingDirectory, [In] bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.BStr)] [In] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);

		[DispId(202)]
		string RemoteApplicationName { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(203)]
		string RemoteApplicationProgram { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(204)]
		string RemoteApplicationArgs { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(205)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ServerStartApp([MarshalAs(UnmanagedType.BStr)] [In] string bstrAppUserModelId, [MarshalAs(UnmanagedType.BStr)] [In] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);
	}
}
