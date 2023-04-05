using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001B9 RID: 441
	[Guid("D012AE6D-C19A-4BFE-B367-201F8911F134")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientShell
	{
		// Token: 0x06002CCC RID: 11468
		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Launch();

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002CCE RID: 11470
		// (set) Token: 0x06002CCD RID: 11469
		[DispId(202)]
		string RdpFileContents { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002CCF RID: 11471
		[DispId(203)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRdpProperty([MarshalAs(UnmanagedType.BStr)] [In] string szProperty, [MarshalAs(UnmanagedType.Struct)] [In] object Value);

		// Token: 0x06002CD0 RID: 11472
		[DispId(204)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object GetRdpProperty([MarshalAs(UnmanagedType.BStr)] [In] string szProperty);

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002CD1 RID: 11473
		[DispId(205)]
		bool IsRemoteProgramClientInstalled { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002CD3 RID: 11475
		// (set) Token: 0x06002CD2 RID: 11474
		[DispId(211)]
		bool PublicMode { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002CD4 RID: 11476
		[DispId(212)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ShowTrustedSitesManagementDialog();
	}
}
