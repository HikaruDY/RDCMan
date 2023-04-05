using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001CF RID: 463
	[TypeLibType(4160)]
	[Guid("3D5B21AC-748D-41DE-8F30-E15169586BD4")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientTransportSettings3 : IMsRdpClientTransportSettings2
	{
		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060036E2 RID: 14050
		// (set) Token: 0x060036E1 RID: 14049
		[DispId(210)]
		string GatewayHostname { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060036E4 RID: 14052
		// (set) Token: 0x060036E3 RID: 14051
		[DispId(211)]
		uint GatewayUsageMethod { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060036E6 RID: 14054
		// (set) Token: 0x060036E5 RID: 14053
		[DispId(212)]
		uint GatewayProfileUsageMethod { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x060036E8 RID: 14056
		// (set) Token: 0x060036E7 RID: 14055
		[DispId(213)]
		uint GatewayCredsSource { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x060036EA RID: 14058
		// (set) Token: 0x060036E9 RID: 14057
		[DispId(216)]
		uint GatewayUserSelectedCredsSource { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060036EB RID: 14059
		[DispId(214)]
		int GatewayIsSupported { [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x060036EC RID: 14060
		[DispId(215)]
		uint GatewayDefaultUsageMethod { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060036EE RID: 14062
		// (set) Token: 0x060036ED RID: 14061
		[DispId(222)]
		uint GatewayCredSharing { [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x060036F0 RID: 14064
		// (set) Token: 0x060036EF RID: 14063
		[DispId(217)]
		uint GatewayPreAuthRequirement { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060036F2 RID: 14066
		// (set) Token: 0x060036F1 RID: 14065
		[DispId(218)]
		string GatewayPreAuthServerAddr { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060036F4 RID: 14068
		// (set) Token: 0x060036F3 RID: 14067
		[DispId(219)]
		string GatewaySupportUrl { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x060036F6 RID: 14070
		// (set) Token: 0x060036F5 RID: 14069
		[DispId(220)]
		string GatewayEncryptedOtpCookie { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060036F8 RID: 14072
		// (set) Token: 0x060036F7 RID: 14071
		[DispId(221)]
		uint GatewayEncryptedOtpCookieSize { [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060036FA RID: 14074
		// (set) Token: 0x060036F9 RID: 14073
		[DispId(223)]
		string GatewayUsername { [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060036FC RID: 14076
		// (set) Token: 0x060036FB RID: 14075
		[DispId(224)]
		string GatewayDomain { [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001188 RID: 4488
		// (set) Token: 0x060036FD RID: 14077
		[DispId(225)]
		string GatewayPassword { [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060036FF RID: 14079
		// (set) Token: 0x060036FE RID: 14078
		[DispId(226)]
		uint GatewayCredSourceCookie { [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06003701 RID: 14081
		// (set) Token: 0x06003700 RID: 14080
		[DispId(227)]
		string GatewayAuthCookieServerAddr { [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06003703 RID: 14083
		// (set) Token: 0x06003702 RID: 14082
		[DispId(228)]
		string GatewayEncryptedAuthCookie { [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06003705 RID: 14085
		// (set) Token: 0x06003704 RID: 14084
		[DispId(229)]
		uint GatewayEncryptedAuthCookieSize { [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06003707 RID: 14087
		// (set) Token: 0x06003706 RID: 14086
		[DispId(230)]
		string GatewayAuthLoginPage { [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
