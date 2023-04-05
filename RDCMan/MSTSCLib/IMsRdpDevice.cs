using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[InterfaceType(1)]
	[Guid("60C3B9C8-9E92-4F5E-A3E7-604A912093EA")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpDevice
	{
		[DispId(222)]
		string DeviceInstanceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(220)]
		string FriendlyName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(221)]
		string DeviceDescription { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(223)]
		bool RedirectionState { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
