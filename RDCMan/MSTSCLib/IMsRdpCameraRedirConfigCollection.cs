using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001F3 RID: 499
	[InterfaceType(1)]
	[Guid("AE45252B-AAAB-4504-B681-649D6073A37A")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpCameraRedirConfigCollection
	{
		// Token: 0x060050D6 RID: 20694
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Rescan();

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x060050D7 RID: 20695
		[DispId(2)]
		uint Count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x060050D8 RID: 20696
		[DispId(3)]
		IMsRdpCameraRedirConfig ByIndex { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x060050D9 RID: 20697
		[DispId(4)]
		IMsRdpCameraRedirConfig BySymbolicLink { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x060050DA RID: 20698
		[DispId(5)]
		IMsRdpCameraRedirConfig ByInstanceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060050DB RID: 20699
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddConfig([MarshalAs(UnmanagedType.BStr)] [In] string SymbolicLink, [In] bool fRedirected);

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x060050DD RID: 20701
		// (set) Token: 0x060050DC RID: 20700
		[DispId(7)]
		bool RedirectByDefault { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x060050DF RID: 20703
		// (set) Token: 0x060050DE RID: 20702
		[DispId(8)]
		bool EncodeVideo { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x060050E1 RID: 20705
		// (set) Token: 0x060050E0 RID: 20704
		[DispId(9)]
		[ComAliasName("MSTSCLib.CameraRedirEncodingQuality")]
		CameraRedirEncodingQuality EncodingQuality { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.CameraRedirEncodingQuality")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.CameraRedirEncodingQuality")] [param: In] set; }
	}
}
