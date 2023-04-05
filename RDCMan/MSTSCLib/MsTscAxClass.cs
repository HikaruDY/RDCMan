using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000194 RID: 404
	[Guid("1FB464C8-09BB-4017-A2F5-EB742F04392F")]
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[ComVisible(true)]
	[ComImport]
	public class MsTscAxClass : IMsTscAx, MsTscAx, IMsTscAxEvents_Event, IMsRdpClient, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x06001DA0 RID: 7584
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern MsTscAxClass();

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001DA2 RID: 7586
		// (set) Token: 0x06001DA1 RID: 7585
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001DA4 RID: 7588
		// (set) Token: 0x06001DA3 RID: 7587
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001DA6 RID: 7590
		// (set) Token: 0x06001DA5 RID: 7589
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001DA8 RID: 7592
		// (set) Token: 0x06001DA7 RID: 7591
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001DAA RID: 7594
		// (set) Token: 0x06001DA9 RID: 7593
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001DAB RID: 7595
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001DAD RID: 7597
		// (set) Token: 0x06001DAC RID: 7596
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001DAF RID: 7599
		// (set) Token: 0x06001DAE RID: 7598
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001DB1 RID: 7601
		// (set) Token: 0x06001DB0 RID: 7600
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001DB2 RID: 7602
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001DB3 RID: 7603
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005C4 RID: 1476
		// (set) Token: 0x06001DB4 RID: 7604
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001DB5 RID: 7605
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001DB6 RID: 7606
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001DB7 RID: 7607
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001DB8 RID: 7608
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001DB9 RID: 7609
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001DBA RID: 7610
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001DBB RID: 7611
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06001DBC RID: 7612
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06001DBD RID: 7613
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001DBE RID: 7614
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001DC0 RID: 7616
		// (set) Token: 0x06001DBF RID: 7615
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001DC2 RID: 7618
		// (set) Token: 0x06001DC1 RID: 7617
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001DC4 RID: 7620
		// (set) Token: 0x06001DC3 RID: 7619
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001DC6 RID: 7622
		// (set) Token: 0x06001DC5 RID: 7621
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001DC8 RID: 7624
		// (set) Token: 0x06001DC7 RID: 7623
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001DC9 RID: 7625
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001DCB RID: 7627
		// (set) Token: 0x06001DCA RID: 7626
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001DCD RID: 7629
		// (set) Token: 0x06001DCC RID: 7628
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001DCF RID: 7631
		// (set) Token: 0x06001DCE RID: 7630
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001DD0 RID: 7632
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001DD1 RID: 7633
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005D6 RID: 1494
		// (set) Token: 0x06001DD2 RID: 7634
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001DD3 RID: 7635
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001DD4 RID: 7636
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001DD5 RID: 7637
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001DD6 RID: 7638
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001DD7 RID: 7639
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001DD8 RID: 7640
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001DD9 RID: 7641
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06001DDA RID: 7642
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06001DDB RID: 7643
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001DDC RID: 7644
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001DDE RID: 7646
		// (set) Token: 0x06001DDD RID: 7645
		public virtual extern int ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001DDF RID: 7647
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001DE0 RID: 7648
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001DE1 RID: 7649
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001DE3 RID: 7651
		// (set) Token: 0x06001DE2 RID: 7650
		public virtual extern bool FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06001DE4 RID: 7652
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06001DE5 RID: 7653
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06001DE6 RID: 7654
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x170005E2 RID: 1506
		// (set) Token: 0x06001DE7 RID: 7655
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001DE9 RID: 7657
		// (set) Token: 0x06001DE8 RID: 7656
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001DEB RID: 7659
		// (set) Token: 0x06001DEA RID: 7658
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001DED RID: 7661
		// (set) Token: 0x06001DEC RID: 7660
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001DEF RID: 7663
		// (set) Token: 0x06001DEE RID: 7662
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001DF0 RID: 7664
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x170005E7 RID: 1511
		// (set) Token: 0x06001DF1 RID: 7665
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001DF3 RID: 7667
		// (set) Token: 0x06001DF2 RID: 7666
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001DF5 RID: 7669
		// (set) Token: 0x06001DF4 RID: 7668
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001DF7 RID: 7671
		// (set) Token: 0x06001DF6 RID: 7670
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001DF9 RID: 7673
		// (set) Token: 0x06001DF8 RID: 7672
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001DFA RID: 7674
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06001DFB RID: 7675
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06001DFC RID: 7676
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x14000377 RID: 887
		// (add) Token: 0x06001DFD RID: 7677
		// (remove) Token: 0x06001DFE RID: 7678
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000378 RID: 888
		// (add) Token: 0x06001DFF RID: 7679
		// (remove) Token: 0x06001E00 RID: 7680
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000379 RID: 889
		// (add) Token: 0x06001E01 RID: 7681
		// (remove) Token: 0x06001E02 RID: 7682
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400037A RID: 890
		// (add) Token: 0x06001E03 RID: 7683
		// (remove) Token: 0x06001E04 RID: 7684
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400037B RID: 891
		// (add) Token: 0x06001E05 RID: 7685
		// (remove) Token: 0x06001E06 RID: 7686
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400037C RID: 892
		// (add) Token: 0x06001E07 RID: 7687
		// (remove) Token: 0x06001E08 RID: 7688
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400037D RID: 893
		// (add) Token: 0x06001E09 RID: 7689
		// (remove) Token: 0x06001E0A RID: 7690
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400037E RID: 894
		// (add) Token: 0x06001E0B RID: 7691
		// (remove) Token: 0x06001E0C RID: 7692
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400037F RID: 895
		// (add) Token: 0x06001E0D RID: 7693
		// (remove) Token: 0x06001E0E RID: 7694
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000380 RID: 896
		// (add) Token: 0x06001E0F RID: 7695
		// (remove) Token: 0x06001E10 RID: 7696
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000381 RID: 897
		// (add) Token: 0x06001E11 RID: 7697
		// (remove) Token: 0x06001E12 RID: 7698
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000382 RID: 898
		// (add) Token: 0x06001E13 RID: 7699
		// (remove) Token: 0x06001E14 RID: 7700
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000383 RID: 899
		// (add) Token: 0x06001E15 RID: 7701
		// (remove) Token: 0x06001E16 RID: 7702
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000384 RID: 900
		// (add) Token: 0x06001E17 RID: 7703
		// (remove) Token: 0x06001E18 RID: 7704
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000385 RID: 901
		// (add) Token: 0x06001E19 RID: 7705
		// (remove) Token: 0x06001E1A RID: 7706
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000386 RID: 902
		// (add) Token: 0x06001E1B RID: 7707
		// (remove) Token: 0x06001E1C RID: 7708
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000387 RID: 903
		// (add) Token: 0x06001E1D RID: 7709
		// (remove) Token: 0x06001E1E RID: 7710
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000388 RID: 904
		// (add) Token: 0x06001E1F RID: 7711
		// (remove) Token: 0x06001E20 RID: 7712
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000389 RID: 905
		// (add) Token: 0x06001E21 RID: 7713
		// (remove) Token: 0x06001E22 RID: 7714
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400038A RID: 906
		// (add) Token: 0x06001E23 RID: 7715
		// (remove) Token: 0x06001E24 RID: 7716
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400038B RID: 907
		// (add) Token: 0x06001E25 RID: 7717
		// (remove) Token: 0x06001E26 RID: 7718
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400038C RID: 908
		// (add) Token: 0x06001E27 RID: 7719
		// (remove) Token: 0x06001E28 RID: 7720
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400038D RID: 909
		// (add) Token: 0x06001E29 RID: 7721
		// (remove) Token: 0x06001E2A RID: 7722
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400038E RID: 910
		// (add) Token: 0x06001E2B RID: 7723
		// (remove) Token: 0x06001E2C RID: 7724
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400038F RID: 911
		// (add) Token: 0x06001E2D RID: 7725
		// (remove) Token: 0x06001E2E RID: 7726
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000390 RID: 912
		// (add) Token: 0x06001E2F RID: 7727
		// (remove) Token: 0x06001E30 RID: 7728
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000391 RID: 913
		// (add) Token: 0x06001E31 RID: 7729
		// (remove) Token: 0x06001E32 RID: 7730
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000392 RID: 914
		// (add) Token: 0x06001E33 RID: 7731
		// (remove) Token: 0x06001E34 RID: 7732
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000393 RID: 915
		// (add) Token: 0x06001E35 RID: 7733
		// (remove) Token: 0x06001E36 RID: 7734
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000394 RID: 916
		// (add) Token: 0x06001E37 RID: 7735
		// (remove) Token: 0x06001E38 RID: 7736
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000395 RID: 917
		// (add) Token: 0x06001E39 RID: 7737
		// (remove) Token: 0x06001E3A RID: 7738
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000396 RID: 918
		// (add) Token: 0x06001E3B RID: 7739
		// (remove) Token: 0x06001E3C RID: 7740
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
