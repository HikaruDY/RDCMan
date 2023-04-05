using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("56540617-D281-488C-8738-6A8FDF64A118")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpDeviceCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RescanDevices([In] bool vboolDynRedir);

		[DispId(228)]
		IMsRdpDevice DeviceByIndex { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(227)]
		IMsRdpDevice DeviceById { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(225)]
		uint DeviceCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
