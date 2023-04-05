using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001D0 RID: 464
	[TypeLibType(4160)]
	[Guid("25F2CE20-8B1D-4971-A7CD-549DAE201FC0")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientSecuredSettings2 : IMsRdpClientSecuredSettings
	{
		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06003709 RID: 14089
		// (set) Token: 0x06003708 RID: 14088
		[DispId(1)]
		string StartProgram { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x0600370B RID: 14091
		// (set) Token: 0x0600370A RID: 14090
		[DispId(2)]
		string WorkDir { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x0600370D RID: 14093
		// (set) Token: 0x0600370C RID: 14092
		[DispId(3)]
		int FullScreen { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600370F RID: 14095
		// (set) Token: 0x0600370E RID: 14094
		[DispId(4)]
		int KeyboardHookMode { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06003711 RID: 14097
		// (set) Token: 0x06003710 RID: 14096
		[DispId(5)]
		int AudioRedirectionMode { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06003712 RID: 14098
		// (set) Token: 0x06003713 RID: 14099
		[DispId(6)]
		string PCB { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
