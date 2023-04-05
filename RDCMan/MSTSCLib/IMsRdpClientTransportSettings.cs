using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001B6 RID: 438
	[Guid("720298C0-A099-46F5-9F82-96921BAE4701")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientTransportSettings
	{
		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002C22 RID: 11298
		// (set) Token: 0x06002C21 RID: 11297
		[DispId(210)]
		string GatewayHostname { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002C24 RID: 11300
		// (set) Token: 0x06002C23 RID: 11299
		[DispId(211)]
		uint GatewayUsageMethod { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002C26 RID: 11302
		// (set) Token: 0x06002C25 RID: 11301
		[DispId(212)]
		uint GatewayProfileUsageMethod { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002C28 RID: 11304
		// (set) Token: 0x06002C27 RID: 11303
		[DispId(213)]
		uint GatewayCredsSource { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002C2A RID: 11306
		// (set) Token: 0x06002C29 RID: 11305
		[DispId(216)]
		uint GatewayUserSelectedCredsSource { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002C2B RID: 11307
		[DispId(214)]
		int GatewayIsSupported { [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002C2C RID: 11308
		[DispId(215)]
		uint GatewayDefaultUsageMethod { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
