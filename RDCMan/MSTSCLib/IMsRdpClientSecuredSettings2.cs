using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(4160)]
	[Guid("25F2CE20-8B1D-4971-A7CD-549DAE201FC0")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientSecuredSettings2 : IMsRdpClientSecuredSettings
	{
		[DispId(1)]
		string StartProgram { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(2)]
		string WorkDir { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(3)]
		int FullScreen { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(4)]
		int KeyboardHookMode { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(5)]
		int AudioRedirectionMode { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(6)]
		string PCB { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
