using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001BC RID: 444
	[InterfaceType(1)]
	[Guid("60C3B9C8-9E92-4F5E-A3E7-604A912093EA")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpDevice
	{
		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002CFB RID: 11515
		[DispId(222)]
		string DeviceInstanceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002CFC RID: 11516
		[DispId(220)]
		string FriendlyName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002CFD RID: 11517
		[DispId(221)]
		string DeviceDescription { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002CFF RID: 11519
		// (set) Token: 0x06002CFE RID: 11518
		[DispId(223)]
		bool RedirectionState { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
