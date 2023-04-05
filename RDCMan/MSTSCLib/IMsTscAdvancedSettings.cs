using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("809945CC-4B3B-4A92-A6B0-DBF9B5F2EF2D")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsTscAdvancedSettings
	{
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
