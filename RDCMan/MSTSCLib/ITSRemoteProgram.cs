using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("FDD029F9-467A-4C49-8529-64B521DBD1B4")]
	[TypeLibType(4176)]
	[ComVisible(true)]
	[ComImport]
	public interface ITSRemoteProgram
	{
		[DispId(200)]
		bool RemoteProgramMode { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ServerStartProgram([MarshalAs(UnmanagedType.BStr)] [In] string bstrExecutablePath, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFilePath, [MarshalAs(UnmanagedType.BStr)] [In] string bstrWorkingDirectory, [In] bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.BStr)] [In] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);
	}
}
