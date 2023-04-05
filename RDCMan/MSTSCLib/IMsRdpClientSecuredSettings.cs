using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("605BEFCF-39C1-45CC-A811-068FB7BE346D")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientSecuredSettings : IMsTscSecuredSettings
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
	}
}
