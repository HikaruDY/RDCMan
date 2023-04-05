using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001C5 RID: 453
	[Guid("67341688-D606-4C73-A5D2-2E0489009319")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientTransportSettings2 : IMsRdpClientTransportSettings
	{
		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06003152 RID: 12626
		// (set) Token: 0x06003151 RID: 12625
		[DispId(210)]
		string GatewayHostname { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06003154 RID: 12628
		// (set) Token: 0x06003153 RID: 12627
		[DispId(211)]
		uint GatewayUsageMethod { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06003156 RID: 12630
		// (set) Token: 0x06003155 RID: 12629
		[DispId(212)]
		uint GatewayProfileUsageMethod { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06003158 RID: 12632
		// (set) Token: 0x06003157 RID: 12631
		[DispId(213)]
		uint GatewayCredsSource { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600315A RID: 12634
		// (set) Token: 0x06003159 RID: 12633
		[DispId(216)]
		uint GatewayUserSelectedCredsSource { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x0600315B RID: 12635
		[DispId(214)]
		int GatewayIsSupported { [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x0600315C RID: 12636
		[DispId(215)]
		uint GatewayDefaultUsageMethod { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x0600315E RID: 12638
		// (set) Token: 0x0600315D RID: 12637
		[DispId(222)]
		uint GatewayCredSharing { [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06003160 RID: 12640
		// (set) Token: 0x0600315F RID: 12639
		[DispId(217)]
		uint GatewayPreAuthRequirement { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06003162 RID: 12642
		// (set) Token: 0x06003161 RID: 12641
		[DispId(218)]
		string GatewayPreAuthServerAddr { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06003164 RID: 12644
		// (set) Token: 0x06003163 RID: 12643
		[DispId(219)]
		string GatewaySupportUrl { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06003166 RID: 12646
		// (set) Token: 0x06003165 RID: 12645
		[DispId(220)]
		string GatewayEncryptedOtpCookie { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06003168 RID: 12648
		// (set) Token: 0x06003167 RID: 12647
		[DispId(221)]
		uint GatewayEncryptedOtpCookieSize { [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x0600316A RID: 12650
		// (set) Token: 0x06003169 RID: 12649
		[DispId(223)]
		string GatewayUsername { [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x0600316C RID: 12652
		// (set) Token: 0x0600316B RID: 12651
		[DispId(224)]
		string GatewayDomain { [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EAF RID: 3759
		// (set) Token: 0x0600316D RID: 12653
		[DispId(225)]
		string GatewayPassword { [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
