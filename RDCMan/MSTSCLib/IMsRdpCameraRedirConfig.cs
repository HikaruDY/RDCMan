using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001F4 RID: 500
	[InterfaceType(1)]
	[Guid("09750604-D625-47C1-9FCD-F09F735705D7")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpCameraRedirConfig
	{
		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x060050E2 RID: 20706
		[DispId(1)]
		string FriendlyName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x060050E3 RID: 20707
		[DispId(2)]
		string SymbolicLink { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x060050E4 RID: 20708
		[DispId(3)]
		string InstanceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x060050E5 RID: 20709
		[DispId(4)]
		string ParentInstanceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x060050E7 RID: 20711
		// (set) Token: 0x060050E6 RID: 20710
		[DispId(5)]
		bool Redirected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x060050E8 RID: 20712
		[DispId(6)]
		bool DeviceExists { [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
