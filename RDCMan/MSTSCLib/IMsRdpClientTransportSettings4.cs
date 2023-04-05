using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001E6 RID: 486
	[Guid("011C3236-4D81-4515-9143-067AB630D299")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientTransportSettings4 : IMsRdpClientTransportSettings3
	{
		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x0600431A RID: 17178
		// (set) Token: 0x06004319 RID: 17177
		[DispId(210)]
		string GatewayHostname { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x0600431C RID: 17180
		// (set) Token: 0x0600431B RID: 17179
		[DispId(211)]
		uint GatewayUsageMethod { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x0600431E RID: 17182
		// (set) Token: 0x0600431D RID: 17181
		[DispId(212)]
		uint GatewayProfileUsageMethod { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06004320 RID: 17184
		// (set) Token: 0x0600431F RID: 17183
		[DispId(213)]
		uint GatewayCredsSource { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06004322 RID: 17186
		// (set) Token: 0x06004321 RID: 17185
		[DispId(216)]
		uint GatewayUserSelectedCredsSource { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06004323 RID: 17187
		[DispId(214)]
		int GatewayIsSupported { [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06004324 RID: 17188
		[DispId(215)]
		uint GatewayDefaultUsageMethod { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06004326 RID: 17190
		// (set) Token: 0x06004325 RID: 17189
		[DispId(222)]
		uint GatewayCredSharing { [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004328 RID: 17192
		// (set) Token: 0x06004327 RID: 17191
		[DispId(217)]
		uint GatewayPreAuthRequirement { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x0600432A RID: 17194
		// (set) Token: 0x06004329 RID: 17193
		[DispId(218)]
		string GatewayPreAuthServerAddr { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x0600432C RID: 17196
		// (set) Token: 0x0600432B RID: 17195
		[DispId(219)]
		string GatewaySupportUrl { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x0600432E RID: 17198
		// (set) Token: 0x0600432D RID: 17197
		[DispId(220)]
		string GatewayEncryptedOtpCookie { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004330 RID: 17200
		// (set) Token: 0x0600432F RID: 17199
		[DispId(221)]
		uint GatewayEncryptedOtpCookieSize { [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06004332 RID: 17202
		// (set) Token: 0x06004331 RID: 17201
		[DispId(223)]
		string GatewayUsername { [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06004334 RID: 17204
		// (set) Token: 0x06004333 RID: 17203
		[DispId(224)]
		string GatewayDomain { [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017F1 RID: 6129
		// (set) Token: 0x06004335 RID: 17205
		[DispId(225)]
		string GatewayPassword { [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06004337 RID: 17207
		// (set) Token: 0x06004336 RID: 17206
		[DispId(226)]
		uint GatewayCredSourceCookie { [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06004339 RID: 17209
		// (set) Token: 0x06004338 RID: 17208
		[DispId(227)]
		string GatewayAuthCookieServerAddr { [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x0600433B RID: 17211
		// (set) Token: 0x0600433A RID: 17210
		[DispId(228)]
		string GatewayEncryptedAuthCookie { [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x0600433D RID: 17213
		// (set) Token: 0x0600433C RID: 17212
		[DispId(229)]
		uint GatewayEncryptedAuthCookieSize { [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x0600433F RID: 17215
		// (set) Token: 0x0600433E RID: 17214
		[DispId(230)]
		string GatewayAuthLoginPage { [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017F7 RID: 6135
		// (set) Token: 0x06004340 RID: 17216
		[DispId(231)]
		uint GatewayBrokeringType { [DispId(231)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
