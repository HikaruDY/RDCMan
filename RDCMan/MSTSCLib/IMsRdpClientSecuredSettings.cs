using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200018D RID: 397
	[Guid("605BEFCF-39C1-45CC-A811-068FB7BE346D")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientSecuredSettings : IMsTscSecuredSettings
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001D81 RID: 7553
		// (set) Token: 0x06001D80 RID: 7552
		[DispId(1)]
		string StartProgram { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001D83 RID: 7555
		// (set) Token: 0x06001D82 RID: 7554
		[DispId(2)]
		string WorkDir { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001D85 RID: 7557
		// (set) Token: 0x06001D84 RID: 7556
		[DispId(3)]
		int FullScreen { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001D87 RID: 7559
		// (set) Token: 0x06001D86 RID: 7558
		[DispId(4)]
		int KeyboardHookMode { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001D89 RID: 7561
		// (set) Token: 0x06001D88 RID: 7560
		[DispId(5)]
		int AudioRedirectionMode { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
