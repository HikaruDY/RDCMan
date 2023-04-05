using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000196 RID: 406
	[TypeLibType(34)]
	[Guid("7CACBD7B-0D99-468F-AC33-22E495C0AFE5")]
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClientNotSafeForScriptingClass : IMsRdpClient, MsRdpClientNotSafeForScripting, IMsTscAxEvents_Event, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x06001E3D RID: 7741
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClientNotSafeForScriptingClass();

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001E3F RID: 7743
		// (set) Token: 0x06001E3E RID: 7742
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001E41 RID: 7745
		// (set) Token: 0x06001E40 RID: 7744
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001E43 RID: 7747
		// (set) Token: 0x06001E42 RID: 7746
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001E45 RID: 7749
		// (set) Token: 0x06001E44 RID: 7748
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001E47 RID: 7751
		// (set) Token: 0x06001E46 RID: 7750
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001E48 RID: 7752
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001E4A RID: 7754
		// (set) Token: 0x06001E49 RID: 7753
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001E4C RID: 7756
		// (set) Token: 0x06001E4B RID: 7755
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001E4E RID: 7758
		// (set) Token: 0x06001E4D RID: 7757
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001E4F RID: 7759
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001E50 RID: 7760
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005F7 RID: 1527
		// (set) Token: 0x06001E51 RID: 7761
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001E52 RID: 7762
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001E53 RID: 7763
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001E54 RID: 7764
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001E55 RID: 7765
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001E56 RID: 7766
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001E57 RID: 7767
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001E58 RID: 7768
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06001E59 RID: 7769
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06001E5A RID: 7770
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001E5B RID: 7771
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001E5D RID: 7773
		// (set) Token: 0x06001E5C RID: 7772
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001E5E RID: 7774
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001E5F RID: 7775
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001E60 RID: 7776
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001E62 RID: 7778
		// (set) Token: 0x06001E61 RID: 7777
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06001E63 RID: 7779
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06001E64 RID: 7780
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06001E65 RID: 7781
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001E67 RID: 7783
		// (set) Token: 0x06001E66 RID: 7782
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001E69 RID: 7785
		// (set) Token: 0x06001E68 RID: 7784
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001E6B RID: 7787
		// (set) Token: 0x06001E6A RID: 7786
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001E6D RID: 7789
		// (set) Token: 0x06001E6C RID: 7788
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001E6F RID: 7791
		// (set) Token: 0x06001E6E RID: 7790
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001E70 RID: 7792
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001E72 RID: 7794
		// (set) Token: 0x06001E71 RID: 7793
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001E74 RID: 7796
		// (set) Token: 0x06001E73 RID: 7795
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001E76 RID: 7798
		// (set) Token: 0x06001E75 RID: 7797
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001E77 RID: 7799
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001E78 RID: 7800
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700060E RID: 1550
		// (set) Token: 0x06001E79 RID: 7801
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001E7A RID: 7802
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001E7B RID: 7803
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001E7C RID: 7804
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001E7D RID: 7805
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001E7E RID: 7806
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001E7F RID: 7807
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001E80 RID: 7808
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06001E81 RID: 7809
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06001E82 RID: 7810
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001E83 RID: 7811
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000615 RID: 1557
		// (set) Token: 0x06001E84 RID: 7812
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001E86 RID: 7814
		// (set) Token: 0x06001E85 RID: 7813
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001E88 RID: 7816
		// (set) Token: 0x06001E87 RID: 7815
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001E8A RID: 7818
		// (set) Token: 0x06001E89 RID: 7817
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001E8C RID: 7820
		// (set) Token: 0x06001E8B RID: 7819
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001E8D RID: 7821
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x1700061A RID: 1562
		// (set) Token: 0x06001E8E RID: 7822
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001E90 RID: 7824
		// (set) Token: 0x06001E8F RID: 7823
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001E92 RID: 7826
		// (set) Token: 0x06001E91 RID: 7825
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001E94 RID: 7828
		// (set) Token: 0x06001E93 RID: 7827
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001E96 RID: 7830
		// (set) Token: 0x06001E95 RID: 7829
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001E97 RID: 7831
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06001E98 RID: 7832
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06001E99 RID: 7833
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x14000397 RID: 919
		// (add) Token: 0x06001E9A RID: 7834
		// (remove) Token: 0x06001E9B RID: 7835
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000398 RID: 920
		// (add) Token: 0x06001E9C RID: 7836
		// (remove) Token: 0x06001E9D RID: 7837
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000399 RID: 921
		// (add) Token: 0x06001E9E RID: 7838
		// (remove) Token: 0x06001E9F RID: 7839
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400039A RID: 922
		// (add) Token: 0x06001EA0 RID: 7840
		// (remove) Token: 0x06001EA1 RID: 7841
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400039B RID: 923
		// (add) Token: 0x06001EA2 RID: 7842
		// (remove) Token: 0x06001EA3 RID: 7843
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400039C RID: 924
		// (add) Token: 0x06001EA4 RID: 7844
		// (remove) Token: 0x06001EA5 RID: 7845
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400039D RID: 925
		// (add) Token: 0x06001EA6 RID: 7846
		// (remove) Token: 0x06001EA7 RID: 7847
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400039E RID: 926
		// (add) Token: 0x06001EA8 RID: 7848
		// (remove) Token: 0x06001EA9 RID: 7849
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400039F RID: 927
		// (add) Token: 0x06001EAA RID: 7850
		// (remove) Token: 0x06001EAB RID: 7851
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x140003A0 RID: 928
		// (add) Token: 0x06001EAC RID: 7852
		// (remove) Token: 0x06001EAD RID: 7853
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140003A1 RID: 929
		// (add) Token: 0x06001EAE RID: 7854
		// (remove) Token: 0x06001EAF RID: 7855
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140003A2 RID: 930
		// (add) Token: 0x06001EB0 RID: 7856
		// (remove) Token: 0x06001EB1 RID: 7857
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140003A3 RID: 931
		// (add) Token: 0x06001EB2 RID: 7858
		// (remove) Token: 0x06001EB3 RID: 7859
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x140003A4 RID: 932
		// (add) Token: 0x06001EB4 RID: 7860
		// (remove) Token: 0x06001EB5 RID: 7861
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x140003A5 RID: 933
		// (add) Token: 0x06001EB6 RID: 7862
		// (remove) Token: 0x06001EB7 RID: 7863
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140003A6 RID: 934
		// (add) Token: 0x06001EB8 RID: 7864
		// (remove) Token: 0x06001EB9 RID: 7865
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140003A7 RID: 935
		// (add) Token: 0x06001EBA RID: 7866
		// (remove) Token: 0x06001EBB RID: 7867
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140003A8 RID: 936
		// (add) Token: 0x06001EBC RID: 7868
		// (remove) Token: 0x06001EBD RID: 7869
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140003A9 RID: 937
		// (add) Token: 0x06001EBE RID: 7870
		// (remove) Token: 0x06001EBF RID: 7871
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140003AA RID: 938
		// (add) Token: 0x06001EC0 RID: 7872
		// (remove) Token: 0x06001EC1 RID: 7873
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140003AB RID: 939
		// (add) Token: 0x06001EC2 RID: 7874
		// (remove) Token: 0x06001EC3 RID: 7875
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140003AC RID: 940
		// (add) Token: 0x06001EC4 RID: 7876
		// (remove) Token: 0x06001EC5 RID: 7877
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140003AD RID: 941
		// (add) Token: 0x06001EC6 RID: 7878
		// (remove) Token: 0x06001EC7 RID: 7879
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140003AE RID: 942
		// (add) Token: 0x06001EC8 RID: 7880
		// (remove) Token: 0x06001EC9 RID: 7881
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140003AF RID: 943
		// (add) Token: 0x06001ECA RID: 7882
		// (remove) Token: 0x06001ECB RID: 7883
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140003B0 RID: 944
		// (add) Token: 0x06001ECC RID: 7884
		// (remove) Token: 0x06001ECD RID: 7885
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140003B1 RID: 945
		// (add) Token: 0x06001ECE RID: 7886
		// (remove) Token: 0x06001ECF RID: 7887
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140003B2 RID: 946
		// (add) Token: 0x06001ED0 RID: 7888
		// (remove) Token: 0x06001ED1 RID: 7889
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x140003B3 RID: 947
		// (add) Token: 0x06001ED2 RID: 7890
		// (remove) Token: 0x06001ED3 RID: 7891
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140003B4 RID: 948
		// (add) Token: 0x06001ED4 RID: 7892
		// (remove) Token: 0x06001ED5 RID: 7893
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x140003B5 RID: 949
		// (add) Token: 0x06001ED6 RID: 7894
		// (remove) Token: 0x06001ED7 RID: 7895
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x140003B6 RID: 950
		// (add) Token: 0x06001ED8 RID: 7896
		// (remove) Token: 0x06001ED9 RID: 7897
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
