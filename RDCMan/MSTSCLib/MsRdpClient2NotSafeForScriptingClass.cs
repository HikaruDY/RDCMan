using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200019A RID: 410
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[Guid("3523C2FB-4031-44E4-9A3B-F1E94986EE7F")]
	[ClassInterface(0)]
	[TypeLibType(34)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient2NotSafeForScriptingClass : IMsRdpClient2, MsRdpClient2NotSafeForScripting, IMsTscAxEvents_Event, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x06001F77 RID: 8055
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient2NotSafeForScriptingClass();

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001F79 RID: 8057
		// (set) Token: 0x06001F78 RID: 8056
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001F7B RID: 8059
		// (set) Token: 0x06001F7A RID: 8058
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001F7D RID: 8061
		// (set) Token: 0x06001F7C RID: 8060
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001F7F RID: 8063
		// (set) Token: 0x06001F7E RID: 8062
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001F81 RID: 8065
		// (set) Token: 0x06001F80 RID: 8064
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001F82 RID: 8066
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001F84 RID: 8068
		// (set) Token: 0x06001F83 RID: 8067
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001F86 RID: 8070
		// (set) Token: 0x06001F85 RID: 8069
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001F88 RID: 8072
		// (set) Token: 0x06001F87 RID: 8071
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001F89 RID: 8073
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001F8A RID: 8074
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700065D RID: 1629
		// (set) Token: 0x06001F8B RID: 8075
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001F8C RID: 8076
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001F8D RID: 8077
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001F8E RID: 8078
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001F8F RID: 8079
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001F90 RID: 8080
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001F91 RID: 8081
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001F92 RID: 8082
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06001F93 RID: 8083
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06001F94 RID: 8084
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001F95 RID: 8085
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001F97 RID: 8087
		// (set) Token: 0x06001F96 RID: 8086
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001F98 RID: 8088
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001F99 RID: 8089
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001F9A RID: 8090
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001F9C RID: 8092
		// (set) Token: 0x06001F9B RID: 8091
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06001F9D RID: 8093
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06001F9E RID: 8094
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06001F9F RID: 8095
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001FA0 RID: 8096
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001FA2 RID: 8098
		// (set) Token: 0x06001FA1 RID: 8097
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001FA4 RID: 8100
		// (set) Token: 0x06001FA3 RID: 8099
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001FA6 RID: 8102
		// (set) Token: 0x06001FA5 RID: 8101
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001FA8 RID: 8104
		// (set) Token: 0x06001FA7 RID: 8103
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001FAA RID: 8106
		// (set) Token: 0x06001FA9 RID: 8105
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001FAC RID: 8108
		// (set) Token: 0x06001FAB RID: 8107
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001FAD RID: 8109
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001FAF RID: 8111
		// (set) Token: 0x06001FAE RID: 8110
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001FB1 RID: 8113
		// (set) Token: 0x06001FB0 RID: 8112
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001FB3 RID: 8115
		// (set) Token: 0x06001FB2 RID: 8114
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001FB4 RID: 8116
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001FB5 RID: 8117
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000676 RID: 1654
		// (set) Token: 0x06001FB6 RID: 8118
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001FB7 RID: 8119
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001FB8 RID: 8120
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001FB9 RID: 8121
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001FBA RID: 8122
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001FBB RID: 8123
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001FBC RID: 8124
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001FBD RID: 8125
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06001FBE RID: 8126
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06001FBF RID: 8127
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001FC0 RID: 8128
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001FC2 RID: 8130
		// (set) Token: 0x06001FC1 RID: 8129
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001FC3 RID: 8131
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001FC4 RID: 8132
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001FC5 RID: 8133
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001FC7 RID: 8135
		// (set) Token: 0x06001FC6 RID: 8134
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06001FC8 RID: 8136
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06001FC9 RID: 8137
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06001FCA RID: 8138
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001FCC RID: 8140
		// (set) Token: 0x06001FCB RID: 8139
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001FCE RID: 8142
		// (set) Token: 0x06001FCD RID: 8141
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001FD0 RID: 8144
		// (set) Token: 0x06001FCF RID: 8143
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001FD2 RID: 8146
		// (set) Token: 0x06001FD1 RID: 8145
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001FD4 RID: 8148
		// (set) Token: 0x06001FD3 RID: 8147
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001FD5 RID: 8149
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001FD7 RID: 8151
		// (set) Token: 0x06001FD6 RID: 8150
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001FD9 RID: 8153
		// (set) Token: 0x06001FD8 RID: 8152
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001FDB RID: 8155
		// (set) Token: 0x06001FDA RID: 8154
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001FDC RID: 8156
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001FDD RID: 8157
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700068D RID: 1677
		// (set) Token: 0x06001FDE RID: 8158
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001FDF RID: 8159
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001FE0 RID: 8160
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001FE1 RID: 8161
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001FE2 RID: 8162
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001FE3 RID: 8163
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001FE4 RID: 8164
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001FE5 RID: 8165
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06001FE6 RID: 8166
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06001FE7 RID: 8167
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001FE8 RID: 8168
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000694 RID: 1684
		// (set) Token: 0x06001FE9 RID: 8169
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001FEB RID: 8171
		// (set) Token: 0x06001FEA RID: 8170
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001FED RID: 8173
		// (set) Token: 0x06001FEC RID: 8172
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001FEF RID: 8175
		// (set) Token: 0x06001FEE RID: 8174
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001FF1 RID: 8177
		// (set) Token: 0x06001FF0 RID: 8176
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001FF2 RID: 8178
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17000699 RID: 1689
		// (set) Token: 0x06001FF3 RID: 8179
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001FF5 RID: 8181
		// (set) Token: 0x06001FF4 RID: 8180
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001FF7 RID: 8183
		// (set) Token: 0x06001FF6 RID: 8182
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001FF9 RID: 8185
		// (set) Token: 0x06001FF8 RID: 8184
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001FFB RID: 8187
		// (set) Token: 0x06001FFA RID: 8186
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001FFC RID: 8188
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06001FFD RID: 8189
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06001FFE RID: 8190
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x140003D7 RID: 983
		// (add) Token: 0x06001FFF RID: 8191
		// (remove) Token: 0x06002000 RID: 8192
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x140003D8 RID: 984
		// (add) Token: 0x06002001 RID: 8193
		// (remove) Token: 0x06002002 RID: 8194
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x140003D9 RID: 985
		// (add) Token: 0x06002003 RID: 8195
		// (remove) Token: 0x06002004 RID: 8196
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x140003DA RID: 986
		// (add) Token: 0x06002005 RID: 8197
		// (remove) Token: 0x06002006 RID: 8198
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140003DB RID: 987
		// (add) Token: 0x06002007 RID: 8199
		// (remove) Token: 0x06002008 RID: 8200
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x140003DC RID: 988
		// (add) Token: 0x06002009 RID: 8201
		// (remove) Token: 0x0600200A RID: 8202
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x140003DD RID: 989
		// (add) Token: 0x0600200B RID: 8203
		// (remove) Token: 0x0600200C RID: 8204
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140003DE RID: 990
		// (add) Token: 0x0600200D RID: 8205
		// (remove) Token: 0x0600200E RID: 8206
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x140003DF RID: 991
		// (add) Token: 0x0600200F RID: 8207
		// (remove) Token: 0x06002010 RID: 8208
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x140003E0 RID: 992
		// (add) Token: 0x06002011 RID: 8209
		// (remove) Token: 0x06002012 RID: 8210
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140003E1 RID: 993
		// (add) Token: 0x06002013 RID: 8211
		// (remove) Token: 0x06002014 RID: 8212
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140003E2 RID: 994
		// (add) Token: 0x06002015 RID: 8213
		// (remove) Token: 0x06002016 RID: 8214
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140003E3 RID: 995
		// (add) Token: 0x06002017 RID: 8215
		// (remove) Token: 0x06002018 RID: 8216
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x140003E4 RID: 996
		// (add) Token: 0x06002019 RID: 8217
		// (remove) Token: 0x0600201A RID: 8218
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x140003E5 RID: 997
		// (add) Token: 0x0600201B RID: 8219
		// (remove) Token: 0x0600201C RID: 8220
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140003E6 RID: 998
		// (add) Token: 0x0600201D RID: 8221
		// (remove) Token: 0x0600201E RID: 8222
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140003E7 RID: 999
		// (add) Token: 0x0600201F RID: 8223
		// (remove) Token: 0x06002020 RID: 8224
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140003E8 RID: 1000
		// (add) Token: 0x06002021 RID: 8225
		// (remove) Token: 0x06002022 RID: 8226
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140003E9 RID: 1001
		// (add) Token: 0x06002023 RID: 8227
		// (remove) Token: 0x06002024 RID: 8228
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140003EA RID: 1002
		// (add) Token: 0x06002025 RID: 8229
		// (remove) Token: 0x06002026 RID: 8230
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140003EB RID: 1003
		// (add) Token: 0x06002027 RID: 8231
		// (remove) Token: 0x06002028 RID: 8232
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140003EC RID: 1004
		// (add) Token: 0x06002029 RID: 8233
		// (remove) Token: 0x0600202A RID: 8234
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140003ED RID: 1005
		// (add) Token: 0x0600202B RID: 8235
		// (remove) Token: 0x0600202C RID: 8236
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140003EE RID: 1006
		// (add) Token: 0x0600202D RID: 8237
		// (remove) Token: 0x0600202E RID: 8238
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140003EF RID: 1007
		// (add) Token: 0x0600202F RID: 8239
		// (remove) Token: 0x06002030 RID: 8240
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140003F0 RID: 1008
		// (add) Token: 0x06002031 RID: 8241
		// (remove) Token: 0x06002032 RID: 8242
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140003F1 RID: 1009
		// (add) Token: 0x06002033 RID: 8243
		// (remove) Token: 0x06002034 RID: 8244
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140003F2 RID: 1010
		// (add) Token: 0x06002035 RID: 8245
		// (remove) Token: 0x06002036 RID: 8246
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x140003F3 RID: 1011
		// (add) Token: 0x06002037 RID: 8247
		// (remove) Token: 0x06002038 RID: 8248
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140003F4 RID: 1012
		// (add) Token: 0x06002039 RID: 8249
		// (remove) Token: 0x0600203A RID: 8250
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x140003F5 RID: 1013
		// (add) Token: 0x0600203B RID: 8251
		// (remove) Token: 0x0600203C RID: 8252
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x140003F6 RID: 1014
		// (add) Token: 0x0600203D RID: 8253
		// (remove) Token: 0x0600203E RID: 8254
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
