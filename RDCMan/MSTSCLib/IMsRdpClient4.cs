using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001AC RID: 428
	[Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClient4 : IMsRdpClient3
	{
		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06002746 RID: 10054
		// (set) Token: 0x06002745 RID: 10053
		[DispId(1)]
		string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002748 RID: 10056
		// (set) Token: 0x06002747 RID: 10055
		[DispId(2)]
		string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600274A RID: 10058
		// (set) Token: 0x06002749 RID: 10057
		[DispId(3)]
		string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x0600274C RID: 10060
		// (set) Token: 0x0600274B RID: 10059
		[DispId(4)]
		string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x0600274E RID: 10062
		// (set) Token: 0x0600274D RID: 10061
		[DispId(5)]
		string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x0600274F RID: 10063
		[DispId(6)]
		short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002751 RID: 10065
		// (set) Token: 0x06002750 RID: 10064
		[DispId(12)]
		int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002753 RID: 10067
		// (set) Token: 0x06002752 RID: 10066
		[DispId(13)]
		int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002755 RID: 10069
		// (set) Token: 0x06002754 RID: 10068
		[DispId(16)]
		int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002756 RID: 10070
		[DispId(17)]
		int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002757 RID: 10071
		[DispId(18)]
		int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009BF RID: 2495
		// (set) Token: 0x06002758 RID: 10072
		[DispId(19)]
		string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002759 RID: 10073
		[DispId(20)]
		int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x0600275A RID: 10074
		[DispId(21)]
		string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600275B RID: 10075
		[DispId(22)]
		int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600275C RID: 10076
		[DispId(97)]
		IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600275D RID: 10077
		[DispId(98)]
		IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600275E RID: 10078
		[DispId(99)]
		IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600275F RID: 10079
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Connect();

		// Token: 0x06002760 RID: 10080
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnect();

		// Token: 0x06002761 RID: 10081
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002762 RID: 10082
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002764 RID: 10084
		// (set) Token: 0x06002763 RID: 10083
		[DispId(100)]
		int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002765 RID: 10085
		[DispId(101)]
		IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002766 RID: 10086
		[DispId(102)]
		IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002767 RID: 10087
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002769 RID: 10089
		// (set) Token: 0x06002768 RID: 10088
		[DispId(104)]
		bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600276A RID: 10090
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600276B RID: 10091
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600276C RID: 10092
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		ControlCloseStatus RequestClose();

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x0600276D RID: 10093
		[DispId(200)]
		IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x0600276F RID: 10095
		// (set) Token: 0x0600276E RID: 10094
		[DispId(201)]
		string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002770 RID: 10096
		[DispId(300)]
		IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06002771 RID: 10097
		[DispId(400)]
		IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
