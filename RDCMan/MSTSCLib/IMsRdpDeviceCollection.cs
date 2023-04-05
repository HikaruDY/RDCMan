using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001BB RID: 443
	[Guid("56540617-D281-488C-8738-6A8FDF64A118")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpDeviceCollection
	{
		// Token: 0x06002CF7 RID: 11511
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RescanDevices([In] bool vboolDynRedir);

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002CF8 RID: 11512
		[DispId(228)]
		IMsRdpDevice DeviceByIndex { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002CF9 RID: 11513
		[DispId(227)]
		IMsRdpDevice DeviceById { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002CFA RID: 11514
		[DispId(225)]
		uint DeviceCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
