using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("011C3236-4D81-4515-9143-067AB630D299")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientTransportSettings4 : IMsRdpClientTransportSettings3
	{
		[DispId(210)]
		string GatewayHostname { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(211)]
		uint GatewayUsageMethod { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(212)]
		uint GatewayProfileUsageMethod { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(213)]
		uint GatewayCredsSource { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(216)]
		uint GatewayUserSelectedCredsSource { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(214)]
		int GatewayIsSupported { [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(215)]
		uint GatewayDefaultUsageMethod { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(222)]
		uint GatewayCredSharing { [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(217)]
		uint GatewayPreAuthRequirement { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(218)]
		string GatewayPreAuthServerAddr { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(219)]
		string GatewaySupportUrl { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(220)]
		string GatewayEncryptedOtpCookie { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(221)]
		uint GatewayEncryptedOtpCookieSize { [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(223)]
		string GatewayUsername { [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(224)]
		string GatewayDomain { [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(225)]
		string GatewayPassword { [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(226)]
		uint GatewayCredSourceCookie { [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(227)]
		string GatewayAuthCookieServerAddr { [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(228)]
		string GatewayEncryptedAuthCookie { [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(229)]
		uint GatewayEncryptedAuthCookieSize { [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(230)]
		string GatewayAuthLoginPage { [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(231)]
		uint GatewayBrokeringType { [DispId(231)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
