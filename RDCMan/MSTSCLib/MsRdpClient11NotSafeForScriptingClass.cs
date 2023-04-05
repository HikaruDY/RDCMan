using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001EF RID: 495
	[Guid("1DF7C823-B2D4-4B54-975A-F2AC5D7CF8B8")]
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[TypeLibType(2)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient11NotSafeForScriptingClass : IMsRdpClient10, MsRdpClient11NotSafeForScripting, IMsTscAxEvents_Event, IMsRdpClient9, IMsRdpClient8, IMsRdpClient7, IMsRdpClient6, IMsRdpClient5, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3, IMsRdpClientNonScriptable4, IMsRdpClientNonScriptable5, IMsRdpClientNonScriptable6, IMsRdpClientNonScriptable7, IMsRdpPreferredRedirectionInfo, IMsRdpExtendedSettings
	{
		// Token: 0x06004CAD RID: 19629
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient11NotSafeForScriptingClass();

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06004CAF RID: 19631
		// (set) Token: 0x06004CAE RID: 19630
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06004CB1 RID: 19633
		// (set) Token: 0x06004CB0 RID: 19632
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06004CB3 RID: 19635
		// (set) Token: 0x06004CB2 RID: 19634
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06004CB5 RID: 19637
		// (set) Token: 0x06004CB4 RID: 19636
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06004CB7 RID: 19639
		// (set) Token: 0x06004CB6 RID: 19638
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06004CB8 RID: 19640
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06004CBA RID: 19642
		// (set) Token: 0x06004CB9 RID: 19641
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06004CBC RID: 19644
		// (set) Token: 0x06004CBB RID: 19643
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06004CBE RID: 19646
		// (set) Token: 0x06004CBD RID: 19645
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06004CBF RID: 19647
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06004CC0 RID: 19648
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D0C RID: 7436
		// (set) Token: 0x06004CC1 RID: 19649
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06004CC2 RID: 19650
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06004CC3 RID: 19651
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06004CC4 RID: 19652
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06004CC5 RID: 19653
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06004CC6 RID: 19654
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06004CC7 RID: 19655
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004CC8 RID: 19656
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06004CC9 RID: 19657
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06004CCA RID: 19658
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004CCB RID: 19659
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06004CCD RID: 19661
		// (set) Token: 0x06004CCC RID: 19660
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06004CCE RID: 19662
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06004CCF RID: 19663
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06004CD0 RID: 19664
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06004CD2 RID: 19666
		// (set) Token: 0x06004CD1 RID: 19665
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004CD3 RID: 19667
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004CD4 RID: 19668
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004CD5 RID: 19669
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06004CD6 RID: 19670
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06004CD8 RID: 19672
		// (set) Token: 0x06004CD7 RID: 19671
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06004CD9 RID: 19673
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06004CDA RID: 19674
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06004CDB RID: 19675
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06004CDC RID: 19676
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004CDD RID: 19677
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x06004CDE RID: 19678
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06004CDF RID: 19679
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06004CE0 RID: 19680
		[DispId(507)]
		public virtual extern IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06004CE1 RID: 19681
		[DispId(506)]
		public virtual extern IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06004CE2 RID: 19682
		[DispId(600)]
		public virtual extern IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06004CE3 RID: 19683
		[DispId(601)]
		public virtual extern IMsRdpClientTransportSettings3 TransportSettings3 { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004CE4 RID: 19684
		[DispId(602)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetStatusText([In] uint statusCode);

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06004CE5 RID: 19685
		[DispId(603)]
		public virtual extern IMsRdpClientSecuredSettings2 SecuredSettings3 { [DispId(603)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06004CE6 RID: 19686
		[DispId(604)]
		public virtual extern ITSRemoteProgram2 RemoteProgram2 { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004CE7 RID: 19687
		[DispId(700)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06004CE8 RID: 19688
		[DispId(701)]
		public virtual extern IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004CE9 RID: 19689
		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06004CEA RID: 19690
		[DispId(800)]
		public virtual extern IMsRdpClientTransportSettings4 TransportSettings4 { [DispId(800)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004CEB RID: 19691
		[DispId(801)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SyncSessionDisplaySettings();

		// Token: 0x06004CEC RID: 19692
		[DispId(802)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x06004CED RID: 19693
		[DispId(803)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x06004CEE RID: 19694
		[DispId(804)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06004CEF RID: 19695
		[DispId(900)]
		public virtual extern ITSRemoteProgram3 RemoteProgram3 { [DispId(900)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06004CF1 RID: 19697
		// (set) Token: 0x06004CF0 RID: 19696
		public virtual extern string IMsRdpClient9_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06004CF3 RID: 19699
		// (set) Token: 0x06004CF2 RID: 19698
		public virtual extern string IMsRdpClient9_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06004CF5 RID: 19701
		// (set) Token: 0x06004CF4 RID: 19700
		public virtual extern string IMsRdpClient9_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06004CF7 RID: 19703
		// (set) Token: 0x06004CF6 RID: 19702
		public virtual extern string IMsRdpClient9_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06004CF9 RID: 19705
		// (set) Token: 0x06004CF8 RID: 19704
		public virtual extern string IMsRdpClient9_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06004CFA RID: 19706
		public virtual extern short IMsRdpClient9_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06004CFC RID: 19708
		// (set) Token: 0x06004CFB RID: 19707
		public virtual extern int IMsRdpClient9_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06004CFE RID: 19710
		// (set) Token: 0x06004CFD RID: 19709
		public virtual extern int IMsRdpClient9_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06004D00 RID: 19712
		// (set) Token: 0x06004CFF RID: 19711
		public virtual extern int IMsRdpClient9_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x06004D01 RID: 19713
		public virtual extern int IMsRdpClient9_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06004D02 RID: 19714
		public virtual extern int IMsRdpClient9_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D34 RID: 7476
		// (set) Token: 0x06004D03 RID: 19715
		public virtual extern string IMsRdpClient9_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06004D04 RID: 19716
		public virtual extern int IMsRdpClient9_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06004D05 RID: 19717
		public virtual extern string IMsRdpClient9_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06004D06 RID: 19718
		public virtual extern int IMsRdpClient9_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06004D07 RID: 19719
		public virtual extern IMsTscSecuredSettings IMsRdpClient9_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06004D08 RID: 19720
		public virtual extern IMsTscAdvancedSettings IMsRdpClient9_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06004D09 RID: 19721
		public virtual extern IMsTscDebug IMsRdpClient9_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D0A RID: 19722
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_Connect();

		// Token: 0x06004D0B RID: 19723
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_Disconnect();

		// Token: 0x06004D0C RID: 19724
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004D0D RID: 19725
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06004D0F RID: 19727
		// (set) Token: 0x06004D0E RID: 19726
		public virtual extern int IMsRdpClient9_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06004D10 RID: 19728
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient9_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06004D11 RID: 19729
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient9_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06004D12 RID: 19730
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient9_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06004D14 RID: 19732
		// (set) Token: 0x06004D13 RID: 19731
		public virtual extern bool IMsRdpClient9_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004D15 RID: 19733
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004D16 RID: 19734
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient9_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004D17 RID: 19735
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient9_RequestClose();

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06004D18 RID: 19736
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient9_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06004D1A RID: 19738
		// (set) Token: 0x06004D19 RID: 19737
		public virtual extern string IMsRdpClient9_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06004D1B RID: 19739
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient9_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06004D1C RID: 19740
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient9_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06004D1D RID: 19741
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient9_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06004D1E RID: 19742
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient9_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D1F RID: 19743
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient9_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06004D20 RID: 19744
		public virtual extern ITSRemoteProgram IMsRdpClient9_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06004D21 RID: 19745
		public virtual extern IMsRdpClientShell IMsRdpClient9_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06004D22 RID: 19746
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient9_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06004D23 RID: 19747
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient9_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06004D24 RID: 19748
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient9_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06004D25 RID: 19749
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient9_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D26 RID: 19750
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient9_GetStatusText([In] uint statusCode);

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06004D27 RID: 19751
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient9_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06004D28 RID: 19752
		public virtual extern ITSRemoteProgram2 IMsRdpClient9_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D29 RID: 19753
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06004D2A RID: 19754
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient9_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D2B RID: 19755
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient9_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06004D2C RID: 19756
		public virtual extern IMsRdpClientTransportSettings4 IMsRdpClient9_TransportSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D2D RID: 19757
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SyncSessionDisplaySettings();

		// Token: 0x06004D2E RID: 19758
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x06004D2F RID: 19759
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x06004D30 RID: 19760
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06004D32 RID: 19762
		// (set) Token: 0x06004D31 RID: 19761
		public virtual extern string IMsRdpClient8_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06004D34 RID: 19764
		// (set) Token: 0x06004D33 RID: 19763
		public virtual extern string IMsRdpClient8_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06004D36 RID: 19766
		// (set) Token: 0x06004D35 RID: 19765
		public virtual extern string IMsRdpClient8_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06004D38 RID: 19768
		// (set) Token: 0x06004D37 RID: 19767
		public virtual extern string IMsRdpClient8_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06004D3A RID: 19770
		// (set) Token: 0x06004D39 RID: 19769
		public virtual extern string IMsRdpClient8_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06004D3B RID: 19771
		public virtual extern short IMsRdpClient8_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06004D3D RID: 19773
		// (set) Token: 0x06004D3C RID: 19772
		public virtual extern int IMsRdpClient8_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06004D3F RID: 19775
		// (set) Token: 0x06004D3E RID: 19774
		public virtual extern int IMsRdpClient8_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06004D41 RID: 19777
		// (set) Token: 0x06004D40 RID: 19776
		public virtual extern int IMsRdpClient8_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06004D42 RID: 19778
		public virtual extern int IMsRdpClient8_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06004D43 RID: 19779
		public virtual extern int IMsRdpClient8_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D5B RID: 7515
		// (set) Token: 0x06004D44 RID: 19780
		public virtual extern string IMsRdpClient8_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06004D45 RID: 19781
		public virtual extern int IMsRdpClient8_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06004D46 RID: 19782
		public virtual extern string IMsRdpClient8_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06004D47 RID: 19783
		public virtual extern int IMsRdpClient8_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06004D48 RID: 19784
		public virtual extern IMsTscSecuredSettings IMsRdpClient8_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06004D49 RID: 19785
		public virtual extern IMsTscAdvancedSettings IMsRdpClient8_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06004D4A RID: 19786
		public virtual extern IMsTscDebug IMsRdpClient8_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D4B RID: 19787
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Connect();

		// Token: 0x06004D4C RID: 19788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Disconnect();

		// Token: 0x06004D4D RID: 19789
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004D4E RID: 19790
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06004D50 RID: 19792
		// (set) Token: 0x06004D4F RID: 19791
		public virtual extern int IMsRdpClient8_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06004D51 RID: 19793
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient8_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06004D52 RID: 19794
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient8_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06004D53 RID: 19795
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient8_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06004D55 RID: 19797
		// (set) Token: 0x06004D54 RID: 19796
		public virtual extern bool IMsRdpClient8_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004D56 RID: 19798
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004D57 RID: 19799
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient8_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004D58 RID: 19800
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient8_RequestClose();

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06004D59 RID: 19801
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient8_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06004D5B RID: 19803
		// (set) Token: 0x06004D5A RID: 19802
		public virtual extern string IMsRdpClient8_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06004D5C RID: 19804
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient8_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06004D5D RID: 19805
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient8_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06004D5E RID: 19806
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient8_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06004D5F RID: 19807
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient8_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D60 RID: 19808
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06004D61 RID: 19809
		public virtual extern ITSRemoteProgram IMsRdpClient8_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06004D62 RID: 19810
		public virtual extern IMsRdpClientShell IMsRdpClient8_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06004D63 RID: 19811
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient8_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06004D64 RID: 19812
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient8_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06004D65 RID: 19813
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient8_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06004D66 RID: 19814
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient8_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D67 RID: 19815
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetStatusText([In] uint statusCode);

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x06004D68 RID: 19816
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient8_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06004D69 RID: 19817
		public virtual extern ITSRemoteProgram2 IMsRdpClient8_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D6A RID: 19818
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06004D6B RID: 19819
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient8_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D6C RID: 19820
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient8_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06004D6E RID: 19822
		// (set) Token: 0x06004D6D RID: 19821
		public virtual extern string IMsRdpClient7_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06004D70 RID: 19824
		// (set) Token: 0x06004D6F RID: 19823
		public virtual extern string IMsRdpClient7_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06004D72 RID: 19826
		// (set) Token: 0x06004D71 RID: 19825
		public virtual extern string IMsRdpClient7_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x06004D74 RID: 19828
		// (set) Token: 0x06004D73 RID: 19827
		public virtual extern string IMsRdpClient7_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06004D76 RID: 19830
		// (set) Token: 0x06004D75 RID: 19829
		public virtual extern string IMsRdpClient7_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06004D77 RID: 19831
		public virtual extern short IMsRdpClient7_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06004D79 RID: 19833
		// (set) Token: 0x06004D78 RID: 19832
		public virtual extern int IMsRdpClient7_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06004D7B RID: 19835
		// (set) Token: 0x06004D7A RID: 19834
		public virtual extern int IMsRdpClient7_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06004D7D RID: 19837
		// (set) Token: 0x06004D7C RID: 19836
		public virtual extern int IMsRdpClient7_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06004D7E RID: 19838
		public virtual extern int IMsRdpClient7_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06004D7F RID: 19839
		public virtual extern int IMsRdpClient7_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D81 RID: 7553
		// (set) Token: 0x06004D80 RID: 19840
		public virtual extern string IMsRdpClient7_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x06004D81 RID: 19841
		public virtual extern int IMsRdpClient7_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06004D82 RID: 19842
		public virtual extern string IMsRdpClient7_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06004D83 RID: 19843
		public virtual extern int IMsRdpClient7_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06004D84 RID: 19844
		public virtual extern IMsTscSecuredSettings IMsRdpClient7_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06004D85 RID: 19845
		public virtual extern IMsTscAdvancedSettings IMsRdpClient7_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06004D86 RID: 19846
		public virtual extern IMsTscDebug IMsRdpClient7_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D87 RID: 19847
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Connect();

		// Token: 0x06004D88 RID: 19848
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Disconnect();

		// Token: 0x06004D89 RID: 19849
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004D8A RID: 19850
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06004D8C RID: 19852
		// (set) Token: 0x06004D8B RID: 19851
		public virtual extern int IMsRdpClient7_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x06004D8D RID: 19853
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient7_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06004D8E RID: 19854
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient7_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06004D8F RID: 19855
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient7_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06004D91 RID: 19857
		// (set) Token: 0x06004D90 RID: 19856
		public virtual extern bool IMsRdpClient7_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004D92 RID: 19858
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004D93 RID: 19859
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient7_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004D94 RID: 19860
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient7_RequestClose();

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06004D95 RID: 19861
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient7_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06004D97 RID: 19863
		// (set) Token: 0x06004D96 RID: 19862
		public virtual extern string IMsRdpClient7_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06004D98 RID: 19864
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient7_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06004D99 RID: 19865
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient7_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06004D9A RID: 19866
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient7_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06004D9B RID: 19867
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient7_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004D9C RID: 19868
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06004D9D RID: 19869
		public virtual extern ITSRemoteProgram IMsRdpClient7_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06004D9E RID: 19870
		public virtual extern IMsRdpClientShell IMsRdpClient7_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06004D9F RID: 19871
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient7_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06004DA0 RID: 19872
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient7_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06004DA1 RID: 19873
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient7_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x06004DA2 RID: 19874
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient7_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004DA3 RID: 19875
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetStatusText([In] uint statusCode);

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x06004DA4 RID: 19876
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient7_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06004DA5 RID: 19877
		public virtual extern ITSRemoteProgram2 IMsRdpClient7_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06004DA7 RID: 19879
		// (set) Token: 0x06004DA6 RID: 19878
		public virtual extern string IMsRdpClient6_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06004DA9 RID: 19881
		// (set) Token: 0x06004DA8 RID: 19880
		public virtual extern string IMsRdpClient6_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06004DAB RID: 19883
		// (set) Token: 0x06004DAA RID: 19882
		public virtual extern string IMsRdpClient6_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06004DAD RID: 19885
		// (set) Token: 0x06004DAC RID: 19884
		public virtual extern string IMsRdpClient6_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06004DAF RID: 19887
		// (set) Token: 0x06004DAE RID: 19886
		public virtual extern string IMsRdpClient6_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06004DB0 RID: 19888
		public virtual extern short IMsRdpClient6_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06004DB2 RID: 19890
		// (set) Token: 0x06004DB1 RID: 19889
		public virtual extern int IMsRdpClient6_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06004DB4 RID: 19892
		// (set) Token: 0x06004DB3 RID: 19891
		public virtual extern int IMsRdpClient6_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06004DB6 RID: 19894
		// (set) Token: 0x06004DB5 RID: 19893
		public virtual extern int IMsRdpClient6_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06004DB7 RID: 19895
		public virtual extern int IMsRdpClient6_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06004DB8 RID: 19896
		public virtual extern int IMsRdpClient6_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DA6 RID: 7590
		// (set) Token: 0x06004DB9 RID: 19897
		public virtual extern string IMsRdpClient6_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06004DBA RID: 19898
		public virtual extern int IMsRdpClient6_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06004DBB RID: 19899
		public virtual extern string IMsRdpClient6_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06004DBC RID: 19900
		public virtual extern int IMsRdpClient6_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06004DBD RID: 19901
		public virtual extern IMsTscSecuredSettings IMsRdpClient6_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06004DBE RID: 19902
		public virtual extern IMsTscAdvancedSettings IMsRdpClient6_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06004DBF RID: 19903
		public virtual extern IMsTscDebug IMsRdpClient6_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004DC0 RID: 19904
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Connect();

		// Token: 0x06004DC1 RID: 19905
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Disconnect();

		// Token: 0x06004DC2 RID: 19906
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004DC3 RID: 19907
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06004DC5 RID: 19909
		// (set) Token: 0x06004DC4 RID: 19908
		public virtual extern int IMsRdpClient6_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06004DC6 RID: 19910
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient6_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06004DC7 RID: 19911
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient6_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06004DC8 RID: 19912
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient6_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06004DCA RID: 19914
		// (set) Token: 0x06004DC9 RID: 19913
		public virtual extern bool IMsRdpClient6_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004DCB RID: 19915
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004DCC RID: 19916
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient6_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004DCD RID: 19917
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient6_RequestClose();

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06004DCE RID: 19918
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient6_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06004DD0 RID: 19920
		// (set) Token: 0x06004DCF RID: 19919
		public virtual extern string IMsRdpClient6_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06004DD1 RID: 19921
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient6_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06004DD2 RID: 19922
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient6_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06004DD3 RID: 19923
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient6_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06004DD4 RID: 19924
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient6_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004DD5 RID: 19925
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient6_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06004DD6 RID: 19926
		public virtual extern ITSRemoteProgram IMsRdpClient6_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06004DD7 RID: 19927
		public virtual extern IMsRdpClientShell IMsRdpClient6_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06004DD8 RID: 19928
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient6_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06004DD9 RID: 19929
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient6_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06004DDB RID: 19931
		// (set) Token: 0x06004DDA RID: 19930
		public virtual extern string IMsRdpClient5_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06004DDD RID: 19933
		// (set) Token: 0x06004DDC RID: 19932
		public virtual extern string IMsRdpClient5_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06004DDF RID: 19935
		// (set) Token: 0x06004DDE RID: 19934
		public virtual extern string IMsRdpClient5_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06004DE1 RID: 19937
		// (set) Token: 0x06004DE0 RID: 19936
		public virtual extern string IMsRdpClient5_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06004DE3 RID: 19939
		// (set) Token: 0x06004DE2 RID: 19938
		public virtual extern string IMsRdpClient5_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06004DE4 RID: 19940
		public virtual extern short IMsRdpClient5_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06004DE6 RID: 19942
		// (set) Token: 0x06004DE5 RID: 19941
		public virtual extern int IMsRdpClient5_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06004DE8 RID: 19944
		// (set) Token: 0x06004DE7 RID: 19943
		public virtual extern int IMsRdpClient5_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06004DEA RID: 19946
		// (set) Token: 0x06004DE9 RID: 19945
		public virtual extern int IMsRdpClient5_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06004DEB RID: 19947
		public virtual extern int IMsRdpClient5_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06004DEC RID: 19948
		public virtual extern int IMsRdpClient5_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DC7 RID: 7623
		// (set) Token: 0x06004DED RID: 19949
		public virtual extern string IMsRdpClient5_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06004DEE RID: 19950
		public virtual extern int IMsRdpClient5_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x06004DEF RID: 19951
		public virtual extern string IMsRdpClient5_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x06004DF0 RID: 19952
		public virtual extern int IMsRdpClient5_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x06004DF1 RID: 19953
		public virtual extern IMsTscSecuredSettings IMsRdpClient5_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x06004DF2 RID: 19954
		public virtual extern IMsTscAdvancedSettings IMsRdpClient5_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x06004DF3 RID: 19955
		public virtual extern IMsTscDebug IMsRdpClient5_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004DF4 RID: 19956
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Connect();

		// Token: 0x06004DF5 RID: 19957
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Disconnect();

		// Token: 0x06004DF6 RID: 19958
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004DF7 RID: 19959
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06004DF9 RID: 19961
		// (set) Token: 0x06004DF8 RID: 19960
		public virtual extern int IMsRdpClient5_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x06004DFA RID: 19962
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient5_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x06004DFB RID: 19963
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient5_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06004DFC RID: 19964
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient5_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06004DFE RID: 19966
		// (set) Token: 0x06004DFD RID: 19965
		public virtual extern bool IMsRdpClient5_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004DFF RID: 19967
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004E00 RID: 19968
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient5_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004E01 RID: 19969
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient5_RequestClose();

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06004E02 RID: 19970
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient5_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06004E04 RID: 19972
		// (set) Token: 0x06004E03 RID: 19971
		public virtual extern string IMsRdpClient5_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06004E05 RID: 19973
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient5_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06004E06 RID: 19974
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient5_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x06004E07 RID: 19975
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient5_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x06004E08 RID: 19976
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient5_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004E09 RID: 19977
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient5_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x06004E0A RID: 19978
		public virtual extern ITSRemoteProgram IMsRdpClient5_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06004E0B RID: 19979
		public virtual extern IMsRdpClientShell IMsRdpClient5_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06004E0D RID: 19981
		// (set) Token: 0x06004E0C RID: 19980
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06004E0F RID: 19983
		// (set) Token: 0x06004E0E RID: 19982
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06004E11 RID: 19985
		// (set) Token: 0x06004E10 RID: 19984
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06004E13 RID: 19987
		// (set) Token: 0x06004E12 RID: 19986
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x06004E15 RID: 19989
		// (set) Token: 0x06004E14 RID: 19988
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x06004E16 RID: 19990
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x06004E18 RID: 19992
		// (set) Token: 0x06004E17 RID: 19991
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06004E1A RID: 19994
		// (set) Token: 0x06004E19 RID: 19993
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06004E1C RID: 19996
		// (set) Token: 0x06004E1B RID: 19995
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06004E1D RID: 19997
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06004E1E RID: 19998
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DE6 RID: 7654
		// (set) Token: 0x06004E1F RID: 19999
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06004E20 RID: 20000
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06004E21 RID: 20001
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06004E22 RID: 20002
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x06004E23 RID: 20003
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06004E24 RID: 20004
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06004E25 RID: 20005
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004E26 RID: 20006
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x06004E27 RID: 20007
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x06004E28 RID: 20008
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004E29 RID: 20009
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06004E2B RID: 20011
		// (set) Token: 0x06004E2A RID: 20010
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06004E2C RID: 20012
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06004E2D RID: 20013
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06004E2E RID: 20014
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06004E30 RID: 20016
		// (set) Token: 0x06004E2F RID: 20015
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004E31 RID: 20017
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004E32 RID: 20018
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004E33 RID: 20019
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06004E34 RID: 20020
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06004E36 RID: 20022
		// (set) Token: 0x06004E35 RID: 20021
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06004E37 RID: 20023
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06004E38 RID: 20024
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06004E3A RID: 20026
		// (set) Token: 0x06004E39 RID: 20025
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06004E3C RID: 20028
		// (set) Token: 0x06004E3B RID: 20027
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06004E3E RID: 20030
		// (set) Token: 0x06004E3D RID: 20029
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06004E40 RID: 20032
		// (set) Token: 0x06004E3F RID: 20031
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06004E42 RID: 20034
		// (set) Token: 0x06004E41 RID: 20033
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06004E43 RID: 20035
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06004E45 RID: 20037
		// (set) Token: 0x06004E44 RID: 20036
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06004E47 RID: 20039
		// (set) Token: 0x06004E46 RID: 20038
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06004E49 RID: 20041
		// (set) Token: 0x06004E48 RID: 20040
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06004E4A RID: 20042
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06004E4B RID: 20043
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E01 RID: 7681
		// (set) Token: 0x06004E4C RID: 20044
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06004E4D RID: 20045
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06004E4E RID: 20046
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06004E4F RID: 20047
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06004E50 RID: 20048
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06004E51 RID: 20049
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x06004E52 RID: 20050
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004E53 RID: 20051
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x06004E54 RID: 20052
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x06004E55 RID: 20053
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004E56 RID: 20054
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06004E58 RID: 20056
		// (set) Token: 0x06004E57 RID: 20055
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x06004E59 RID: 20057
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x06004E5A RID: 20058
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x06004E5B RID: 20059
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x06004E5D RID: 20061
		// (set) Token: 0x06004E5C RID: 20060
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004E5E RID: 20062
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004E5F RID: 20063
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004E60 RID: 20064
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x06004E61 RID: 20065
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x06004E63 RID: 20067
		// (set) Token: 0x06004E62 RID: 20066
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x06004E64 RID: 20068
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x06004E66 RID: 20070
		// (set) Token: 0x06004E65 RID: 20069
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06004E68 RID: 20072
		// (set) Token: 0x06004E67 RID: 20071
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06004E6A RID: 20074
		// (set) Token: 0x06004E69 RID: 20073
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06004E6C RID: 20076
		// (set) Token: 0x06004E6B RID: 20075
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06004E6E RID: 20078
		// (set) Token: 0x06004E6D RID: 20077
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x06004E6F RID: 20079
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06004E71 RID: 20081
		// (set) Token: 0x06004E70 RID: 20080
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06004E73 RID: 20083
		// (set) Token: 0x06004E72 RID: 20082
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06004E75 RID: 20085
		// (set) Token: 0x06004E74 RID: 20084
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x06004E76 RID: 20086
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x06004E77 RID: 20087
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E1B RID: 7707
		// (set) Token: 0x06004E78 RID: 20088
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x06004E79 RID: 20089
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x06004E7A RID: 20090
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06004E7B RID: 20091
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06004E7C RID: 20092
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x06004E7D RID: 20093
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06004E7E RID: 20094
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004E7F RID: 20095
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x06004E80 RID: 20096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x06004E81 RID: 20097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004E82 RID: 20098
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06004E84 RID: 20100
		// (set) Token: 0x06004E83 RID: 20099
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06004E85 RID: 20101
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06004E86 RID: 20102
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06004E87 RID: 20103
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06004E89 RID: 20105
		// (set) Token: 0x06004E88 RID: 20104
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004E8A RID: 20106
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004E8B RID: 20107
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004E8C RID: 20108
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06004E8D RID: 20109
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06004E8F RID: 20111
		// (set) Token: 0x06004E8E RID: 20110
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06004E91 RID: 20113
		// (set) Token: 0x06004E90 RID: 20112
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06004E93 RID: 20115
		// (set) Token: 0x06004E92 RID: 20114
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06004E95 RID: 20117
		// (set) Token: 0x06004E94 RID: 20116
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06004E97 RID: 20119
		// (set) Token: 0x06004E96 RID: 20118
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x06004E99 RID: 20121
		// (set) Token: 0x06004E98 RID: 20120
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x06004E9A RID: 20122
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06004E9C RID: 20124
		// (set) Token: 0x06004E9B RID: 20123
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x06004E9E RID: 20126
		// (set) Token: 0x06004E9D RID: 20125
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x06004EA0 RID: 20128
		// (set) Token: 0x06004E9F RID: 20127
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06004EA1 RID: 20129
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06004EA2 RID: 20130
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E34 RID: 7732
		// (set) Token: 0x06004EA3 RID: 20131
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06004EA4 RID: 20132
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06004EA5 RID: 20133
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06004EA6 RID: 20134
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06004EA7 RID: 20135
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06004EA8 RID: 20136
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06004EA9 RID: 20137
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004EAA RID: 20138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06004EAB RID: 20139
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06004EAC RID: 20140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004EAD RID: 20141
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06004EAF RID: 20143
		// (set) Token: 0x06004EAE RID: 20142
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x06004EB0 RID: 20144
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x06004EB1 RID: 20145
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06004EB2 RID: 20146
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06004EB4 RID: 20148
		// (set) Token: 0x06004EB3 RID: 20147
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004EB5 RID: 20149
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004EB6 RID: 20150
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004EB7 RID: 20151
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06004EB9 RID: 20153
		// (set) Token: 0x06004EB8 RID: 20152
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x06004EBB RID: 20155
		// (set) Token: 0x06004EBA RID: 20154
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06004EBD RID: 20157
		// (set) Token: 0x06004EBC RID: 20156
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x06004EBF RID: 20159
		// (set) Token: 0x06004EBE RID: 20158
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06004EC1 RID: 20161
		// (set) Token: 0x06004EC0 RID: 20160
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x06004EC2 RID: 20162
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06004EC4 RID: 20164
		// (set) Token: 0x06004EC3 RID: 20163
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x06004EC6 RID: 20166
		// (set) Token: 0x06004EC5 RID: 20165
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x06004EC8 RID: 20168
		// (set) Token: 0x06004EC7 RID: 20167
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x06004EC9 RID: 20169
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06004ECA RID: 20170
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E4B RID: 7755
		// (set) Token: 0x06004ECB RID: 20171
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06004ECC RID: 20172
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06004ECD RID: 20173
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06004ECE RID: 20174
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06004ECF RID: 20175
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06004ED0 RID: 20176
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x06004ED1 RID: 20177
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004ED2 RID: 20178
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06004ED3 RID: 20179
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06004ED4 RID: 20180
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004ED5 RID: 20181
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001E52 RID: 7762
		// (set) Token: 0x06004ED6 RID: 20182
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06004ED8 RID: 20184
		// (set) Token: 0x06004ED7 RID: 20183
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06004EDA RID: 20186
		// (set) Token: 0x06004ED9 RID: 20185
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06004EDC RID: 20188
		// (set) Token: 0x06004EDB RID: 20187
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06004EDE RID: 20190
		// (set) Token: 0x06004EDD RID: 20189
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004EDF RID: 20191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17001E57 RID: 7767
		// (set) Token: 0x06004EE0 RID: 20192
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06004EE2 RID: 20194
		// (set) Token: 0x06004EE1 RID: 20193
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06004EE4 RID: 20196
		// (set) Token: 0x06004EE3 RID: 20195
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06004EE6 RID: 20198
		// (set) Token: 0x06004EE5 RID: 20197
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06004EE8 RID: 20200
		// (set) Token: 0x06004EE7 RID: 20199
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004EE9 RID: 20201
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06004EEA RID: 20202
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004EEB RID: 20203
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001E5C RID: 7772
		// (set) Token: 0x06004EEC RID: 20204
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06004EEE RID: 20206
		// (set) Token: 0x06004EED RID: 20205
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06004EF0 RID: 20208
		// (set) Token: 0x06004EEF RID: 20207
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x06004EF2 RID: 20210
		// (set) Token: 0x06004EF1 RID: 20209
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06004EF4 RID: 20212
		// (set) Token: 0x06004EF3 RID: 20211
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004EF5 RID: 20213
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06004EF6 RID: 20214
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004EF7 RID: 20215
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06004EF9 RID: 20217
		// (set) Token: 0x06004EF8 RID: 20216
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001E62 RID: 7778
		// (set) Token: 0x06004EFA RID: 20218
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06004EFC RID: 20220
		// (set) Token: 0x06004EFB RID: 20219
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06004EFE RID: 20222
		// (set) Token: 0x06004EFD RID: 20221
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x06004F00 RID: 20224
		// (set) Token: 0x06004EFF RID: 20223
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x06004F02 RID: 20226
		// (set) Token: 0x06004F01 RID: 20225
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004F03 RID: 20227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x06004F04 RID: 20228
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004F05 RID: 20229
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06004F07 RID: 20231
		// (set) Token: 0x06004F06 RID: 20230
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06004F09 RID: 20233
		// (set) Token: 0x06004F08 RID: 20232
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06004F0B RID: 20235
		// (set) Token: 0x06004F0A RID: 20234
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06004F0D RID: 20237
		// (set) Token: 0x06004F0C RID: 20236
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x06004F0F RID: 20239
		// (set) Token: 0x06004F0E RID: 20238
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06004F11 RID: 20241
		// (set) Token: 0x06004F10 RID: 20240
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06004F13 RID: 20243
		// (set) Token: 0x06004F12 RID: 20242
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06004F14 RID: 20244
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06004F15 RID: 20245
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x06004F17 RID: 20247
		// (set) Token: 0x06004F16 RID: 20246
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06004F19 RID: 20249
		// (set) Token: 0x06004F18 RID: 20248
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06004F1B RID: 20251
		// (set) Token: 0x06004F1A RID: 20250
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E73 RID: 7795
		// (set) Token: 0x06004F1C RID: 20252
		public virtual extern string IMsRdpClientNonScriptable4_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06004F1E RID: 20254
		// (set) Token: 0x06004F1D RID: 20253
		public virtual extern string IMsRdpClientNonScriptable4_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06004F20 RID: 20256
		// (set) Token: 0x06004F1F RID: 20255
		public virtual extern string IMsRdpClientNonScriptable4_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06004F22 RID: 20258
		// (set) Token: 0x06004F21 RID: 20257
		public virtual extern string IMsRdpClientNonScriptable4_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x06004F24 RID: 20260
		// (set) Token: 0x06004F23 RID: 20259
		public virtual extern string IMsRdpClientNonScriptable4_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004F25 RID: 20261
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_ResetPassword();

		// Token: 0x06004F26 RID: 20262
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004F27 RID: 20263
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x06004F29 RID: 20265
		// (set) Token: 0x06004F28 RID: 20264
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable4_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06004F2B RID: 20267
		// (set) Token: 0x06004F2A RID: 20266
		public virtual extern bool IMsRdpClientNonScriptable4_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06004F2D RID: 20269
		// (set) Token: 0x06004F2C RID: 20268
		public virtual extern bool IMsRdpClientNonScriptable4_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06004F2F RID: 20271
		// (set) Token: 0x06004F2E RID: 20270
		public virtual extern bool IMsRdpClientNonScriptable4_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06004F31 RID: 20273
		// (set) Token: 0x06004F30 RID: 20272
		public virtual extern bool IMsRdpClientNonScriptable4_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06004F33 RID: 20275
		// (set) Token: 0x06004F32 RID: 20274
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06004F35 RID: 20277
		// (set) Token: 0x06004F34 RID: 20276
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06004F36 RID: 20278
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable4_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06004F37 RID: 20279
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable4_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06004F39 RID: 20281
		// (set) Token: 0x06004F38 RID: 20280
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06004F3B RID: 20283
		// (set) Token: 0x06004F3A RID: 20282
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x06004F3D RID: 20285
		// (set) Token: 0x06004F3C RID: 20284
		public virtual extern string IMsRdpClientNonScriptable4_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06004F3F RID: 20287
		// (set) Token: 0x06004F3E RID: 20286
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06004F41 RID: 20289
		// (set) Token: 0x06004F40 RID: 20288
		public virtual extern bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06004F43 RID: 20291
		// (set) Token: 0x06004F42 RID: 20290
		public virtual extern object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06004F45 RID: 20293
		// (set) Token: 0x06004F44 RID: 20292
		public virtual extern bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06004F47 RID: 20295
		// (set) Token: 0x06004F46 RID: 20294
		public virtual extern bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06004F49 RID: 20297
		// (set) Token: 0x06004F48 RID: 20296
		public virtual extern bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06004F4B RID: 20299
		// (set) Token: 0x06004F4A RID: 20298
		public virtual extern bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06004F4D RID: 20301
		// (set) Token: 0x06004F4C RID: 20300
		public virtual extern bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E8C RID: 7820
		// (set) Token: 0x06004F4E RID: 20302
		public virtual extern string IMsRdpClientNonScriptable5_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06004F50 RID: 20304
		// (set) Token: 0x06004F4F RID: 20303
		public virtual extern string IMsRdpClientNonScriptable5_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06004F52 RID: 20306
		// (set) Token: 0x06004F51 RID: 20305
		public virtual extern string IMsRdpClientNonScriptable5_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06004F54 RID: 20308
		// (set) Token: 0x06004F53 RID: 20307
		public virtual extern string IMsRdpClientNonScriptable5_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06004F56 RID: 20310
		// (set) Token: 0x06004F55 RID: 20309
		public virtual extern string IMsRdpClientNonScriptable5_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004F57 RID: 20311
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_ResetPassword();

		// Token: 0x06004F58 RID: 20312
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004F59 RID: 20313
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06004F5B RID: 20315
		// (set) Token: 0x06004F5A RID: 20314
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable5_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06004F5D RID: 20317
		// (set) Token: 0x06004F5C RID: 20316
		public virtual extern bool IMsRdpClientNonScriptable5_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06004F5F RID: 20319
		// (set) Token: 0x06004F5E RID: 20318
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06004F61 RID: 20321
		// (set) Token: 0x06004F60 RID: 20320
		public virtual extern bool IMsRdpClientNonScriptable5_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06004F63 RID: 20323
		// (set) Token: 0x06004F62 RID: 20322
		public virtual extern bool IMsRdpClientNonScriptable5_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x06004F65 RID: 20325
		// (set) Token: 0x06004F64 RID: 20324
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06004F67 RID: 20327
		// (set) Token: 0x06004F66 RID: 20326
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06004F68 RID: 20328
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable5_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06004F69 RID: 20329
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable5_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06004F6B RID: 20331
		// (set) Token: 0x06004F6A RID: 20330
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06004F6D RID: 20333
		// (set) Token: 0x06004F6C RID: 20332
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06004F6F RID: 20335
		// (set) Token: 0x06004F6E RID: 20334
		public virtual extern string IMsRdpClientNonScriptable5_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x06004F71 RID: 20337
		// (set) Token: 0x06004F70 RID: 20336
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable5_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x06004F73 RID: 20339
		// (set) Token: 0x06004F72 RID: 20338
		public virtual extern bool IMsRdpClientNonScriptable5_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06004F75 RID: 20341
		// (set) Token: 0x06004F74 RID: 20340
		public virtual extern object IMsRdpClientNonScriptable5_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06004F77 RID: 20343
		// (set) Token: 0x06004F76 RID: 20342
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06004F79 RID: 20345
		// (set) Token: 0x06004F78 RID: 20344
		public virtual extern bool IMsRdpClientNonScriptable5_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06004F7B RID: 20347
		// (set) Token: 0x06004F7A RID: 20346
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06004F7D RID: 20349
		// (set) Token: 0x06004F7C RID: 20348
		public virtual extern bool IMsRdpClientNonScriptable5_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06004F7F RID: 20351
		// (set) Token: 0x06004F7E RID: 20350
		public virtual extern bool IMsRdpClientNonScriptable5_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x06004F81 RID: 20353
		// (set) Token: 0x06004F80 RID: 20352
		public virtual extern bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x06004F82 RID: 20354
		public virtual extern uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004F83 RID: 20355
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06004F84 RID: 20356
		public virtual extern bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001EA8 RID: 7848
		// (set) Token: 0x06004F85 RID: 20357
		public virtual extern bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06004F87 RID: 20359
		// (set) Token: 0x06004F86 RID: 20358
		public virtual extern bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06004F89 RID: 20361
		// (set) Token: 0x06004F88 RID: 20360
		public virtual extern bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06004F8B RID: 20363
		// (set) Token: 0x06004F8A RID: 20362
		public virtual extern bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EAC RID: 7852
		// (set) Token: 0x06004F8C RID: 20364
		public virtual extern string IMsRdpClientNonScriptable6_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x06004F8E RID: 20366
		// (set) Token: 0x06004F8D RID: 20365
		public virtual extern string IMsRdpClientNonScriptable6_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06004F90 RID: 20368
		// (set) Token: 0x06004F8F RID: 20367
		public virtual extern string IMsRdpClientNonScriptable6_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06004F92 RID: 20370
		// (set) Token: 0x06004F91 RID: 20369
		public virtual extern string IMsRdpClientNonScriptable6_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06004F94 RID: 20372
		// (set) Token: 0x06004F93 RID: 20371
		public virtual extern string IMsRdpClientNonScriptable6_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004F95 RID: 20373
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable6_ResetPassword();

		// Token: 0x06004F96 RID: 20374
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable6_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004F97 RID: 20375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable6_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06004F99 RID: 20377
		// (set) Token: 0x06004F98 RID: 20376
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable6_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06004F9B RID: 20379
		// (set) Token: 0x06004F9A RID: 20378
		public virtual extern bool IMsRdpClientNonScriptable6_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06004F9D RID: 20381
		// (set) Token: 0x06004F9C RID: 20380
		public virtual extern bool IMsRdpClientNonScriptable6_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06004F9F RID: 20383
		// (set) Token: 0x06004F9E RID: 20382
		public virtual extern bool IMsRdpClientNonScriptable6_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06004FA1 RID: 20385
		// (set) Token: 0x06004FA0 RID: 20384
		public virtual extern bool IMsRdpClientNonScriptable6_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06004FA3 RID: 20387
		// (set) Token: 0x06004FA2 RID: 20386
		public virtual extern bool IMsRdpClientNonScriptable6_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06004FA5 RID: 20389
		// (set) Token: 0x06004FA4 RID: 20388
		public virtual extern bool IMsRdpClientNonScriptable6_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06004FA6 RID: 20390
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable6_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06004FA7 RID: 20391
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable6_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06004FA9 RID: 20393
		// (set) Token: 0x06004FA8 RID: 20392
		public virtual extern bool IMsRdpClientNonScriptable6_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06004FAB RID: 20395
		// (set) Token: 0x06004FAA RID: 20394
		public virtual extern bool IMsRdpClientNonScriptable6_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06004FAD RID: 20397
		// (set) Token: 0x06004FAC RID: 20396
		public virtual extern string IMsRdpClientNonScriptable6_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06004FAF RID: 20399
		// (set) Token: 0x06004FAE RID: 20398
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable6_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06004FB1 RID: 20401
		// (set) Token: 0x06004FB0 RID: 20400
		public virtual extern bool IMsRdpClientNonScriptable6_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06004FB3 RID: 20403
		// (set) Token: 0x06004FB2 RID: 20402
		public virtual extern object IMsRdpClientNonScriptable6_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06004FB5 RID: 20405
		// (set) Token: 0x06004FB4 RID: 20404
		public virtual extern bool IMsRdpClientNonScriptable6_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06004FB7 RID: 20407
		// (set) Token: 0x06004FB6 RID: 20406
		public virtual extern bool IMsRdpClientNonScriptable6_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06004FB9 RID: 20409
		// (set) Token: 0x06004FB8 RID: 20408
		public virtual extern bool IMsRdpClientNonScriptable6_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06004FBB RID: 20411
		// (set) Token: 0x06004FBA RID: 20410
		public virtual extern bool IMsRdpClientNonScriptable6_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06004FBD RID: 20413
		// (set) Token: 0x06004FBC RID: 20412
		public virtual extern bool IMsRdpClientNonScriptable6_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06004FBF RID: 20415
		// (set) Token: 0x06004FBE RID: 20414
		public virtual extern bool IMsRdpClientNonScriptable6_UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06004FC0 RID: 20416
		public virtual extern uint IMsRdpClientNonScriptable6_RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004FC1 RID: 20417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable6_GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06004FC2 RID: 20418
		public virtual extern bool IMsRdpClientNonScriptable6_RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001EC8 RID: 7880
		// (set) Token: 0x06004FC3 RID: 20419
		public virtual extern bool IMsRdpClientNonScriptable6_DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06004FC5 RID: 20421
		// (set) Token: 0x06004FC4 RID: 20420
		public virtual extern bool IMsRdpClientNonScriptable6_DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06004FC7 RID: 20423
		// (set) Token: 0x06004FC6 RID: 20422
		public virtual extern bool IMsRdpClientNonScriptable6_WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06004FC9 RID: 20425
		// (set) Token: 0x06004FC8 RID: 20424
		public virtual extern bool IMsRdpClientNonScriptable6_AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004FCA RID: 20426
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendLocation2D([In] double latitude, [In] double longitude);

		// Token: 0x06004FCB RID: 20427
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendLocation3D([In] double latitude, [In] double longitude, [In] int altitude);

		// Token: 0x17001ECC RID: 7884
		// (set) Token: 0x06004FCC RID: 20428
		public virtual extern string IMsRdpClientNonScriptable7_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06004FCE RID: 20430
		// (set) Token: 0x06004FCD RID: 20429
		public virtual extern string IMsRdpClientNonScriptable7_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06004FD0 RID: 20432
		// (set) Token: 0x06004FCF RID: 20431
		public virtual extern string IMsRdpClientNonScriptable7_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06004FD2 RID: 20434
		// (set) Token: 0x06004FD1 RID: 20433
		public virtual extern string IMsRdpClientNonScriptable7_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06004FD4 RID: 20436
		// (set) Token: 0x06004FD3 RID: 20435
		public virtual extern string IMsRdpClientNonScriptable7_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004FD5 RID: 20437
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_ResetPassword();

		// Token: 0x06004FD6 RID: 20438
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004FD7 RID: 20439
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06004FD9 RID: 20441
		// (set) Token: 0x06004FD8 RID: 20440
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable7_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06004FDB RID: 20443
		// (set) Token: 0x06004FDA RID: 20442
		public virtual extern bool IMsRdpClientNonScriptable7_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06004FDD RID: 20445
		// (set) Token: 0x06004FDC RID: 20444
		public virtual extern bool IMsRdpClientNonScriptable7_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06004FDF RID: 20447
		// (set) Token: 0x06004FDE RID: 20446
		public virtual extern bool IMsRdpClientNonScriptable7_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06004FE1 RID: 20449
		// (set) Token: 0x06004FE0 RID: 20448
		public virtual extern bool IMsRdpClientNonScriptable7_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06004FE3 RID: 20451
		// (set) Token: 0x06004FE2 RID: 20450
		public virtual extern bool IMsRdpClientNonScriptable7_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x06004FE5 RID: 20453
		// (set) Token: 0x06004FE4 RID: 20452
		public virtual extern bool IMsRdpClientNonScriptable7_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06004FE6 RID: 20454
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable7_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06004FE7 RID: 20455
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable7_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06004FE9 RID: 20457
		// (set) Token: 0x06004FE8 RID: 20456
		public virtual extern bool IMsRdpClientNonScriptable7_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06004FEB RID: 20459
		// (set) Token: 0x06004FEA RID: 20458
		public virtual extern bool IMsRdpClientNonScriptable7_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06004FED RID: 20461
		// (set) Token: 0x06004FEC RID: 20460
		public virtual extern string IMsRdpClientNonScriptable7_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06004FEF RID: 20463
		// (set) Token: 0x06004FEE RID: 20462
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable7_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06004FF1 RID: 20465
		// (set) Token: 0x06004FF0 RID: 20464
		public virtual extern bool IMsRdpClientNonScriptable7_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06004FF3 RID: 20467
		// (set) Token: 0x06004FF2 RID: 20466
		public virtual extern object IMsRdpClientNonScriptable7_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06004FF5 RID: 20469
		// (set) Token: 0x06004FF4 RID: 20468
		public virtual extern bool IMsRdpClientNonScriptable7_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06004FF7 RID: 20471
		// (set) Token: 0x06004FF6 RID: 20470
		public virtual extern bool IMsRdpClientNonScriptable7_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06004FF9 RID: 20473
		// (set) Token: 0x06004FF8 RID: 20472
		public virtual extern bool IMsRdpClientNonScriptable7_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x06004FFB RID: 20475
		// (set) Token: 0x06004FFA RID: 20474
		public virtual extern bool IMsRdpClientNonScriptable7_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06004FFD RID: 20477
		// (set) Token: 0x06004FFC RID: 20476
		public virtual extern bool IMsRdpClientNonScriptable7_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06004FFF RID: 20479
		// (set) Token: 0x06004FFE RID: 20478
		public virtual extern bool IMsRdpClientNonScriptable7_UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06005000 RID: 20480
		public virtual extern uint IMsRdpClientNonScriptable7_RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06005001 RID: 20481
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x06005002 RID: 20482
		public virtual extern bool IMsRdpClientNonScriptable7_RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001EE8 RID: 7912
		// (set) Token: 0x06005003 RID: 20483
		public virtual extern bool IMsRdpClientNonScriptable7_DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06005005 RID: 20485
		// (set) Token: 0x06005004 RID: 20484
		public virtual extern bool IMsRdpClientNonScriptable7_DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06005007 RID: 20487
		// (set) Token: 0x06005006 RID: 20486
		public virtual extern bool IMsRdpClientNonScriptable7_WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06005009 RID: 20489
		// (set) Token: 0x06005008 RID: 20488
		public virtual extern bool IMsRdpClientNonScriptable7_AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600500A RID: 20490
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_SendLocation2D([In] double latitude, [In] double longitude);

		// Token: 0x0600500B RID: 20491
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_SendLocation3D([In] double latitude, [In] double longitude, [In] int altitude);

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x0600500C RID: 20492
		public virtual extern IMsRdpCameraRedirConfigCollection CameraRedirConfigCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600500D RID: 20493
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void DisableDpiCursorScalingForProcess();

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x0600500E RID: 20494
		public virtual extern IMsRdpClipboard Clipboard { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x06005010 RID: 20496
		// (set) Token: 0x0600500F RID: 20495
		public virtual extern bool UseRedirectionServerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06005012 RID: 20498
		// (set) Token: 0x06005011 RID: 20497
		public virtual extern object Property { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x14000677 RID: 1655
		// (add) Token: 0x06005013 RID: 20499
		// (remove) Token: 0x06005014 RID: 20500
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000678 RID: 1656
		// (add) Token: 0x06005015 RID: 20501
		// (remove) Token: 0x06005016 RID: 20502
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000679 RID: 1657
		// (add) Token: 0x06005017 RID: 20503
		// (remove) Token: 0x06005018 RID: 20504
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400067A RID: 1658
		// (add) Token: 0x06005019 RID: 20505
		// (remove) Token: 0x0600501A RID: 20506
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400067B RID: 1659
		// (add) Token: 0x0600501B RID: 20507
		// (remove) Token: 0x0600501C RID: 20508
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400067C RID: 1660
		// (add) Token: 0x0600501D RID: 20509
		// (remove) Token: 0x0600501E RID: 20510
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400067D RID: 1661
		// (add) Token: 0x0600501F RID: 20511
		// (remove) Token: 0x06005020 RID: 20512
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400067E RID: 1662
		// (add) Token: 0x06005021 RID: 20513
		// (remove) Token: 0x06005022 RID: 20514
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400067F RID: 1663
		// (add) Token: 0x06005023 RID: 20515
		// (remove) Token: 0x06005024 RID: 20516
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000680 RID: 1664
		// (add) Token: 0x06005025 RID: 20517
		// (remove) Token: 0x06005026 RID: 20518
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000681 RID: 1665
		// (add) Token: 0x06005027 RID: 20519
		// (remove) Token: 0x06005028 RID: 20520
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000682 RID: 1666
		// (add) Token: 0x06005029 RID: 20521
		// (remove) Token: 0x0600502A RID: 20522
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000683 RID: 1667
		// (add) Token: 0x0600502B RID: 20523
		// (remove) Token: 0x0600502C RID: 20524
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000684 RID: 1668
		// (add) Token: 0x0600502D RID: 20525
		// (remove) Token: 0x0600502E RID: 20526
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000685 RID: 1669
		// (add) Token: 0x0600502F RID: 20527
		// (remove) Token: 0x06005030 RID: 20528
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000686 RID: 1670
		// (add) Token: 0x06005031 RID: 20529
		// (remove) Token: 0x06005032 RID: 20530
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000687 RID: 1671
		// (add) Token: 0x06005033 RID: 20531
		// (remove) Token: 0x06005034 RID: 20532
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000688 RID: 1672
		// (add) Token: 0x06005035 RID: 20533
		// (remove) Token: 0x06005036 RID: 20534
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000689 RID: 1673
		// (add) Token: 0x06005037 RID: 20535
		// (remove) Token: 0x06005038 RID: 20536
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400068A RID: 1674
		// (add) Token: 0x06005039 RID: 20537
		// (remove) Token: 0x0600503A RID: 20538
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400068B RID: 1675
		// (add) Token: 0x0600503B RID: 20539
		// (remove) Token: 0x0600503C RID: 20540
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400068C RID: 1676
		// (add) Token: 0x0600503D RID: 20541
		// (remove) Token: 0x0600503E RID: 20542
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400068D RID: 1677
		// (add) Token: 0x0600503F RID: 20543
		// (remove) Token: 0x06005040 RID: 20544
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400068E RID: 1678
		// (add) Token: 0x06005041 RID: 20545
		// (remove) Token: 0x06005042 RID: 20546
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400068F RID: 1679
		// (add) Token: 0x06005043 RID: 20547
		// (remove) Token: 0x06005044 RID: 20548
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000690 RID: 1680
		// (add) Token: 0x06005045 RID: 20549
		// (remove) Token: 0x06005046 RID: 20550
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000691 RID: 1681
		// (add) Token: 0x06005047 RID: 20551
		// (remove) Token: 0x06005048 RID: 20552
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000692 RID: 1682
		// (add) Token: 0x06005049 RID: 20553
		// (remove) Token: 0x0600504A RID: 20554
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000693 RID: 1683
		// (add) Token: 0x0600504B RID: 20555
		// (remove) Token: 0x0600504C RID: 20556
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000694 RID: 1684
		// (add) Token: 0x0600504D RID: 20557
		// (remove) Token: 0x0600504E RID: 20558
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000695 RID: 1685
		// (add) Token: 0x0600504F RID: 20559
		// (remove) Token: 0x06005050 RID: 20560
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000696 RID: 1686
		// (add) Token: 0x06005051 RID: 20561
		// (remove) Token: 0x06005052 RID: 20562
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
