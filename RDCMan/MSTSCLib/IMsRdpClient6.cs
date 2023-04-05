using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001C3 RID: 451
	[TypeLibType(4160)]
	[Guid("D43B7D80-8517-4B6D-9EAC-96AD6800D7F2")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClient6 : IMsRdpClient5
	{
		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06003073 RID: 12403
		// (set) Token: 0x06003072 RID: 12402
		[DispId(1)]
		string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06003075 RID: 12405
		// (set) Token: 0x06003074 RID: 12404
		[DispId(2)]
		string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003077 RID: 12407
		// (set) Token: 0x06003076 RID: 12406
		[DispId(3)]
		string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06003079 RID: 12409
		// (set) Token: 0x06003078 RID: 12408
		[DispId(4)]
		string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x0600307B RID: 12411
		// (set) Token: 0x0600307A RID: 12410
		[DispId(5)]
		string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x0600307C RID: 12412
		[DispId(6)]
		short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x0600307E RID: 12414
		// (set) Token: 0x0600307D RID: 12413
		[DispId(12)]
		int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06003080 RID: 12416
		// (set) Token: 0x0600307F RID: 12415
		[DispId(13)]
		int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06003082 RID: 12418
		// (set) Token: 0x06003081 RID: 12417
		[DispId(16)]
		int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06003083 RID: 12419
		[DispId(17)]
		int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06003084 RID: 12420
		[DispId(18)]
		int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000E30 RID: 3632
		// (set) Token: 0x06003085 RID: 12421
		[DispId(19)]
		string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06003086 RID: 12422
		[DispId(20)]
		int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06003087 RID: 12423
		[DispId(21)]
		string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06003088 RID: 12424
		[DispId(22)]
		int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06003089 RID: 12425
		[DispId(97)]
		IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x0600308A RID: 12426
		[DispId(98)]
		IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x0600308B RID: 12427
		[DispId(99)]
		IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600308C RID: 12428
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Connect();

		// Token: 0x0600308D RID: 12429
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnect();

		// Token: 0x0600308E RID: 12430
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600308F RID: 12431
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06003091 RID: 12433
		// (set) Token: 0x06003090 RID: 12432
		[DispId(100)]
		int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06003092 RID: 12434
		[DispId(101)]
		IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06003093 RID: 12435
		[DispId(102)]
		IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06003094 RID: 12436
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06003096 RID: 12438
		// (set) Token: 0x06003095 RID: 12437
		[DispId(104)]
		bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06003097 RID: 12439
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06003098 RID: 12440
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06003099 RID: 12441
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		ControlCloseStatus RequestClose();

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x0600309A RID: 12442
		[DispId(200)]
		IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x0600309C RID: 12444
		// (set) Token: 0x0600309B RID: 12443
		[DispId(201)]
		string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x0600309D RID: 12445
		[DispId(300)]
		IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x0600309E RID: 12446
		[DispId(400)]
		IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x0600309F RID: 12447
		[DispId(500)]
		IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x060030A0 RID: 12448
		[DispId(502)]
		IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060030A1 RID: 12449
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x060030A2 RID: 12450
		[DispId(504)]
		ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x060030A3 RID: 12451
		[DispId(505)]
		IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x060030A4 RID: 12452
		[DispId(507)]
		IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x060030A5 RID: 12453
		[DispId(506)]
		IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
