using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000198 RID: 408
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[Guid("791FA017-2DE3-492E-ACC5-53C67A2B94D0")]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClientClass : IMsRdpClient, MsRdpClient, IMsTscAxEvents_Event, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x06001EDA RID: 7898
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern MsRdpClientClass();

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001EDC RID: 7900
		// (set) Token: 0x06001EDB RID: 7899
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001EDE RID: 7902
		// (set) Token: 0x06001EDD RID: 7901
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001EE0 RID: 7904
		// (set) Token: 0x06001EDF RID: 7903
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001EE2 RID: 7906
		// (set) Token: 0x06001EE1 RID: 7905
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001EE4 RID: 7908
		// (set) Token: 0x06001EE3 RID: 7907
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001EE5 RID: 7909
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001EE7 RID: 7911
		// (set) Token: 0x06001EE6 RID: 7910
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001EE9 RID: 7913
		// (set) Token: 0x06001EE8 RID: 7912
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001EEB RID: 7915
		// (set) Token: 0x06001EEA RID: 7914
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001EEC RID: 7916
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001EED RID: 7917
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700062A RID: 1578
		// (set) Token: 0x06001EEE RID: 7918
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001EEF RID: 7919
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001EF0 RID: 7920
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001EF1 RID: 7921
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001EF2 RID: 7922
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001EF3 RID: 7923
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001EF4 RID: 7924
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001EF5 RID: 7925
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06001EF6 RID: 7926
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06001EF7 RID: 7927
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001EF8 RID: 7928
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001EFA RID: 7930
		// (set) Token: 0x06001EF9 RID: 7929
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001EFB RID: 7931
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001EFC RID: 7932
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001EFD RID: 7933
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001EFF RID: 7935
		// (set) Token: 0x06001EFE RID: 7934
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06001F00 RID: 7936
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06001F01 RID: 7937
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06001F02 RID: 7938
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001F04 RID: 7940
		// (set) Token: 0x06001F03 RID: 7939
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001F06 RID: 7942
		// (set) Token: 0x06001F05 RID: 7941
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001F08 RID: 7944
		// (set) Token: 0x06001F07 RID: 7943
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001F0A RID: 7946
		// (set) Token: 0x06001F09 RID: 7945
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001F0C RID: 7948
		// (set) Token: 0x06001F0B RID: 7947
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001F0D RID: 7949
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001F0F RID: 7951
		// (set) Token: 0x06001F0E RID: 7950
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001F11 RID: 7953
		// (set) Token: 0x06001F10 RID: 7952
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001F13 RID: 7955
		// (set) Token: 0x06001F12 RID: 7954
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001F14 RID: 7956
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001F15 RID: 7957
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000641 RID: 1601
		// (set) Token: 0x06001F16 RID: 7958
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001F17 RID: 7959
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001F18 RID: 7960
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001F19 RID: 7961
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001F1A RID: 7962
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001F1B RID: 7963
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001F1C RID: 7964
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001F1D RID: 7965
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06001F1E RID: 7966
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06001F1F RID: 7967
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001F20 RID: 7968
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000648 RID: 1608
		// (set) Token: 0x06001F21 RID: 7969
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001F23 RID: 7971
		// (set) Token: 0x06001F22 RID: 7970
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001F25 RID: 7973
		// (set) Token: 0x06001F24 RID: 7972
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001F27 RID: 7975
		// (set) Token: 0x06001F26 RID: 7974
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001F29 RID: 7977
		// (set) Token: 0x06001F28 RID: 7976
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001F2A RID: 7978
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x1700064D RID: 1613
		// (set) Token: 0x06001F2B RID: 7979
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001F2D RID: 7981
		// (set) Token: 0x06001F2C RID: 7980
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001F2F RID: 7983
		// (set) Token: 0x06001F2E RID: 7982
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001F31 RID: 7985
		// (set) Token: 0x06001F30 RID: 7984
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001F33 RID: 7987
		// (set) Token: 0x06001F32 RID: 7986
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001F34 RID: 7988
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06001F35 RID: 7989
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06001F36 RID: 7990
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x140003B7 RID: 951
		// (add) Token: 0x06001F37 RID: 7991
		// (remove) Token: 0x06001F38 RID: 7992
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x140003B8 RID: 952
		// (add) Token: 0x06001F39 RID: 7993
		// (remove) Token: 0x06001F3A RID: 7994
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x140003B9 RID: 953
		// (add) Token: 0x06001F3B RID: 7995
		// (remove) Token: 0x06001F3C RID: 7996
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x140003BA RID: 954
		// (add) Token: 0x06001F3D RID: 7997
		// (remove) Token: 0x06001F3E RID: 7998
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140003BB RID: 955
		// (add) Token: 0x06001F3F RID: 7999
		// (remove) Token: 0x06001F40 RID: 8000
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x140003BC RID: 956
		// (add) Token: 0x06001F41 RID: 8001
		// (remove) Token: 0x06001F42 RID: 8002
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x140003BD RID: 957
		// (add) Token: 0x06001F43 RID: 8003
		// (remove) Token: 0x06001F44 RID: 8004
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140003BE RID: 958
		// (add) Token: 0x06001F45 RID: 8005
		// (remove) Token: 0x06001F46 RID: 8006
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x140003BF RID: 959
		// (add) Token: 0x06001F47 RID: 8007
		// (remove) Token: 0x06001F48 RID: 8008
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x140003C0 RID: 960
		// (add) Token: 0x06001F49 RID: 8009
		// (remove) Token: 0x06001F4A RID: 8010
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140003C1 RID: 961
		// (add) Token: 0x06001F4B RID: 8011
		// (remove) Token: 0x06001F4C RID: 8012
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140003C2 RID: 962
		// (add) Token: 0x06001F4D RID: 8013
		// (remove) Token: 0x06001F4E RID: 8014
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140003C3 RID: 963
		// (add) Token: 0x06001F4F RID: 8015
		// (remove) Token: 0x06001F50 RID: 8016
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x140003C4 RID: 964
		// (add) Token: 0x06001F51 RID: 8017
		// (remove) Token: 0x06001F52 RID: 8018
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x140003C5 RID: 965
		// (add) Token: 0x06001F53 RID: 8019
		// (remove) Token: 0x06001F54 RID: 8020
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140003C6 RID: 966
		// (add) Token: 0x06001F55 RID: 8021
		// (remove) Token: 0x06001F56 RID: 8022
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140003C7 RID: 967
		// (add) Token: 0x06001F57 RID: 8023
		// (remove) Token: 0x06001F58 RID: 8024
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140003C8 RID: 968
		// (add) Token: 0x06001F59 RID: 8025
		// (remove) Token: 0x06001F5A RID: 8026
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140003C9 RID: 969
		// (add) Token: 0x06001F5B RID: 8027
		// (remove) Token: 0x06001F5C RID: 8028
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140003CA RID: 970
		// (add) Token: 0x06001F5D RID: 8029
		// (remove) Token: 0x06001F5E RID: 8030
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140003CB RID: 971
		// (add) Token: 0x06001F5F RID: 8031
		// (remove) Token: 0x06001F60 RID: 8032
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140003CC RID: 972
		// (add) Token: 0x06001F61 RID: 8033
		// (remove) Token: 0x06001F62 RID: 8034
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140003CD RID: 973
		// (add) Token: 0x06001F63 RID: 8035
		// (remove) Token: 0x06001F64 RID: 8036
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140003CE RID: 974
		// (add) Token: 0x06001F65 RID: 8037
		// (remove) Token: 0x06001F66 RID: 8038
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140003CF RID: 975
		// (add) Token: 0x06001F67 RID: 8039
		// (remove) Token: 0x06001F68 RID: 8040
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140003D0 RID: 976
		// (add) Token: 0x06001F69 RID: 8041
		// (remove) Token: 0x06001F6A RID: 8042
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140003D1 RID: 977
		// (add) Token: 0x06001F6B RID: 8043
		// (remove) Token: 0x06001F6C RID: 8044
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140003D2 RID: 978
		// (add) Token: 0x06001F6D RID: 8045
		// (remove) Token: 0x06001F6E RID: 8046
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x140003D3 RID: 979
		// (add) Token: 0x06001F6F RID: 8047
		// (remove) Token: 0x06001F70 RID: 8048
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140003D4 RID: 980
		// (add) Token: 0x06001F71 RID: 8049
		// (remove) Token: 0x06001F72 RID: 8050
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x140003D5 RID: 981
		// (add) Token: 0x06001F73 RID: 8051
		// (remove) Token: 0x06001F74 RID: 8052
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x140003D6 RID: 982
		// (add) Token: 0x06001F75 RID: 8053
		// (remove) Token: 0x06001F76 RID: 8054
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
