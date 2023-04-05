using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001ED RID: 493
	[Guid("C0EFA91A-EEB7-41C7-97FA-F0ED645EFB24")]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[ClassInterface(0)]
	[TypeLibType(2)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient10Class : IMsRdpClient10, MsRdpClient10, IMsTscAxEvents_Event, IMsRdpClient9, IMsRdpClient8, IMsRdpClient7, IMsRdpClient6, IMsRdpClient5, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3, IMsRdpClientNonScriptable4, IMsRdpClientNonScriptable5, IMsRdpPreferredRedirectionInfo
	{
		// Token: 0x0600498C RID: 18828
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient10Class();

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x0600498E RID: 18830
		// (set) Token: 0x0600498D RID: 18829
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06004990 RID: 18832
		// (set) Token: 0x0600498F RID: 18831
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06004992 RID: 18834
		// (set) Token: 0x06004991 RID: 18833
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06004994 RID: 18836
		// (set) Token: 0x06004993 RID: 18835
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06004996 RID: 18838
		// (set) Token: 0x06004995 RID: 18837
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06004997 RID: 18839
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06004999 RID: 18841
		// (set) Token: 0x06004998 RID: 18840
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x0600499B RID: 18843
		// (set) Token: 0x0600499A RID: 18842
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x0600499D RID: 18845
		// (set) Token: 0x0600499C RID: 18844
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x0600499E RID: 18846
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x0600499F RID: 18847
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B60 RID: 7008
		// (set) Token: 0x060049A0 RID: 18848
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x060049A1 RID: 18849
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x060049A2 RID: 18850
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x060049A3 RID: 18851
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x060049A4 RID: 18852
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x060049A5 RID: 18853
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x060049A6 RID: 18854
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060049A7 RID: 18855
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x060049A8 RID: 18856
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x060049A9 RID: 18857
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060049AA RID: 18858
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x060049AC RID: 18860
		// (set) Token: 0x060049AB RID: 18859
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x060049AD RID: 18861
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x060049AE RID: 18862
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x060049AF RID: 18863
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x060049B1 RID: 18865
		// (set) Token: 0x060049B0 RID: 18864
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060049B2 RID: 18866
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060049B3 RID: 18867
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060049B4 RID: 18868
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x060049B5 RID: 18869
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x060049B7 RID: 18871
		// (set) Token: 0x060049B6 RID: 18870
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x060049B8 RID: 18872
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x060049B9 RID: 18873
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x060049BA RID: 18874
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x060049BB RID: 18875
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060049BC RID: 18876
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x060049BD RID: 18877
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x060049BE RID: 18878
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x060049BF RID: 18879
		[DispId(507)]
		public virtual extern IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x060049C0 RID: 18880
		[DispId(506)]
		public virtual extern IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x060049C1 RID: 18881
		[DispId(600)]
		public virtual extern IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x060049C2 RID: 18882
		[DispId(601)]
		public virtual extern IMsRdpClientTransportSettings3 TransportSettings3 { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060049C3 RID: 18883
		[DispId(602)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetStatusText([In] uint statusCode);

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x060049C4 RID: 18884
		[DispId(603)]
		public virtual extern IMsRdpClientSecuredSettings2 SecuredSettings3 { [DispId(603)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x060049C5 RID: 18885
		[DispId(604)]
		public virtual extern ITSRemoteProgram2 RemoteProgram2 { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060049C6 RID: 18886
		[DispId(700)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x060049C7 RID: 18887
		[DispId(701)]
		public virtual extern IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060049C8 RID: 18888
		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x060049C9 RID: 18889
		[DispId(800)]
		public virtual extern IMsRdpClientTransportSettings4 TransportSettings4 { [DispId(800)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060049CA RID: 18890
		[DispId(801)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SyncSessionDisplaySettings();

		// Token: 0x060049CB RID: 18891
		[DispId(802)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x060049CC RID: 18892
		[DispId(803)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x060049CD RID: 18893
		[DispId(804)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x060049CE RID: 18894
		[DispId(900)]
		public virtual extern ITSRemoteProgram3 RemoteProgram3 { [DispId(900)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x060049D0 RID: 18896
		// (set) Token: 0x060049CF RID: 18895
		public virtual extern string IMsRdpClient9_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x060049D2 RID: 18898
		// (set) Token: 0x060049D1 RID: 18897
		public virtual extern string IMsRdpClient9_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x060049D4 RID: 18900
		// (set) Token: 0x060049D3 RID: 18899
		public virtual extern string IMsRdpClient9_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x060049D6 RID: 18902
		// (set) Token: 0x060049D5 RID: 18901
		public virtual extern string IMsRdpClient9_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x060049D8 RID: 18904
		// (set) Token: 0x060049D7 RID: 18903
		public virtual extern string IMsRdpClient9_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x060049D9 RID: 18905
		public virtual extern short IMsRdpClient9_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x060049DB RID: 18907
		// (set) Token: 0x060049DA RID: 18906
		public virtual extern int IMsRdpClient9_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x060049DD RID: 18909
		// (set) Token: 0x060049DC RID: 18908
		public virtual extern int IMsRdpClient9_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x060049DF RID: 18911
		// (set) Token: 0x060049DE RID: 18910
		public virtual extern int IMsRdpClient9_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x060049E0 RID: 18912
		public virtual extern int IMsRdpClient9_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x060049E1 RID: 18913
		public virtual extern int IMsRdpClient9_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B88 RID: 7048
		// (set) Token: 0x060049E2 RID: 18914
		public virtual extern string IMsRdpClient9_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x060049E3 RID: 18915
		public virtual extern int IMsRdpClient9_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x060049E4 RID: 18916
		public virtual extern string IMsRdpClient9_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x060049E5 RID: 18917
		public virtual extern int IMsRdpClient9_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x060049E6 RID: 18918
		public virtual extern IMsTscSecuredSettings IMsRdpClient9_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x060049E7 RID: 18919
		public virtual extern IMsTscAdvancedSettings IMsRdpClient9_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x060049E8 RID: 18920
		public virtual extern IMsTscDebug IMsRdpClient9_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060049E9 RID: 18921
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_Connect();

		// Token: 0x060049EA RID: 18922
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_Disconnect();

		// Token: 0x060049EB RID: 18923
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060049EC RID: 18924
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x060049EE RID: 18926
		// (set) Token: 0x060049ED RID: 18925
		public virtual extern int IMsRdpClient9_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x060049EF RID: 18927
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient9_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x060049F0 RID: 18928
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient9_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x060049F1 RID: 18929
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient9_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x060049F3 RID: 18931
		// (set) Token: 0x060049F2 RID: 18930
		public virtual extern bool IMsRdpClient9_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060049F4 RID: 18932
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060049F5 RID: 18933
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient9_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060049F6 RID: 18934
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient9_RequestClose();

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x060049F7 RID: 18935
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient9_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x060049F9 RID: 18937
		// (set) Token: 0x060049F8 RID: 18936
		public virtual extern string IMsRdpClient9_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x060049FA RID: 18938
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient9_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x060049FB RID: 18939
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient9_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x060049FC RID: 18940
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient9_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x060049FD RID: 18941
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient9_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060049FE RID: 18942
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient9_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x060049FF RID: 18943
		public virtual extern ITSRemoteProgram IMsRdpClient9_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06004A00 RID: 18944
		public virtual extern IMsRdpClientShell IMsRdpClient9_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06004A01 RID: 18945
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient9_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06004A02 RID: 18946
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient9_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06004A03 RID: 18947
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient9_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06004A04 RID: 18948
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient9_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A05 RID: 18949
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient9_GetStatusText([In] uint statusCode);

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06004A06 RID: 18950
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient9_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06004A07 RID: 18951
		public virtual extern ITSRemoteProgram2 IMsRdpClient9_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A08 RID: 18952
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06004A09 RID: 18953
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient9_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A0A RID: 18954
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient9_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06004A0B RID: 18955
		public virtual extern IMsRdpClientTransportSettings4 IMsRdpClient9_TransportSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A0C RID: 18956
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SyncSessionDisplaySettings();

		// Token: 0x06004A0D RID: 18957
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x06004A0E RID: 18958
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x06004A0F RID: 18959
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06004A11 RID: 18961
		// (set) Token: 0x06004A10 RID: 18960
		public virtual extern string IMsRdpClient8_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06004A13 RID: 18963
		// (set) Token: 0x06004A12 RID: 18962
		public virtual extern string IMsRdpClient8_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06004A15 RID: 18965
		// (set) Token: 0x06004A14 RID: 18964
		public virtual extern string IMsRdpClient8_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06004A17 RID: 18967
		// (set) Token: 0x06004A16 RID: 18966
		public virtual extern string IMsRdpClient8_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06004A19 RID: 18969
		// (set) Token: 0x06004A18 RID: 18968
		public virtual extern string IMsRdpClient8_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06004A1A RID: 18970
		public virtual extern short IMsRdpClient8_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06004A1C RID: 18972
		// (set) Token: 0x06004A1B RID: 18971
		public virtual extern int IMsRdpClient8_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06004A1E RID: 18974
		// (set) Token: 0x06004A1D RID: 18973
		public virtual extern int IMsRdpClient8_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06004A20 RID: 18976
		// (set) Token: 0x06004A1F RID: 18975
		public virtual extern int IMsRdpClient8_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06004A21 RID: 18977
		public virtual extern int IMsRdpClient8_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06004A22 RID: 18978
		public virtual extern int IMsRdpClient8_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BAF RID: 7087
		// (set) Token: 0x06004A23 RID: 18979
		public virtual extern string IMsRdpClient8_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06004A24 RID: 18980
		public virtual extern int IMsRdpClient8_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06004A25 RID: 18981
		public virtual extern string IMsRdpClient8_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06004A26 RID: 18982
		public virtual extern int IMsRdpClient8_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06004A27 RID: 18983
		public virtual extern IMsTscSecuredSettings IMsRdpClient8_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06004A28 RID: 18984
		public virtual extern IMsTscAdvancedSettings IMsRdpClient8_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06004A29 RID: 18985
		public virtual extern IMsTscDebug IMsRdpClient8_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A2A RID: 18986
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Connect();

		// Token: 0x06004A2B RID: 18987
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Disconnect();

		// Token: 0x06004A2C RID: 18988
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004A2D RID: 18989
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06004A2F RID: 18991
		// (set) Token: 0x06004A2E RID: 18990
		public virtual extern int IMsRdpClient8_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06004A30 RID: 18992
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient8_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06004A31 RID: 18993
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient8_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06004A32 RID: 18994
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient8_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06004A34 RID: 18996
		// (set) Token: 0x06004A33 RID: 18995
		public virtual extern bool IMsRdpClient8_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004A35 RID: 18997
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004A36 RID: 18998
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient8_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004A37 RID: 18999
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient8_RequestClose();

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06004A38 RID: 19000
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient8_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06004A3A RID: 19002
		// (set) Token: 0x06004A39 RID: 19001
		public virtual extern string IMsRdpClient8_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06004A3B RID: 19003
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient8_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06004A3C RID: 19004
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient8_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06004A3D RID: 19005
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient8_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06004A3E RID: 19006
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient8_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A3F RID: 19007
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06004A40 RID: 19008
		public virtual extern ITSRemoteProgram IMsRdpClient8_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06004A41 RID: 19009
		public virtual extern IMsRdpClientShell IMsRdpClient8_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06004A42 RID: 19010
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient8_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06004A43 RID: 19011
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient8_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06004A44 RID: 19012
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient8_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06004A45 RID: 19013
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient8_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A46 RID: 19014
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetStatusText([In] uint statusCode);

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06004A47 RID: 19015
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient8_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06004A48 RID: 19016
		public virtual extern ITSRemoteProgram2 IMsRdpClient8_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A49 RID: 19017
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06004A4A RID: 19018
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient8_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A4B RID: 19019
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient8_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06004A4D RID: 19021
		// (set) Token: 0x06004A4C RID: 19020
		public virtual extern string IMsRdpClient7_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06004A4F RID: 19023
		// (set) Token: 0x06004A4E RID: 19022
		public virtual extern string IMsRdpClient7_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06004A51 RID: 19025
		// (set) Token: 0x06004A50 RID: 19024
		public virtual extern string IMsRdpClient7_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06004A53 RID: 19027
		// (set) Token: 0x06004A52 RID: 19026
		public virtual extern string IMsRdpClient7_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06004A55 RID: 19029
		// (set) Token: 0x06004A54 RID: 19028
		public virtual extern string IMsRdpClient7_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06004A56 RID: 19030
		public virtual extern short IMsRdpClient7_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06004A58 RID: 19032
		// (set) Token: 0x06004A57 RID: 19031
		public virtual extern int IMsRdpClient7_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06004A5A RID: 19034
		// (set) Token: 0x06004A59 RID: 19033
		public virtual extern int IMsRdpClient7_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06004A5C RID: 19036
		// (set) Token: 0x06004A5B RID: 19035
		public virtual extern int IMsRdpClient7_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06004A5D RID: 19037
		public virtual extern int IMsRdpClient7_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06004A5E RID: 19038
		public virtual extern int IMsRdpClient7_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BD5 RID: 7125
		// (set) Token: 0x06004A5F RID: 19039
		public virtual extern string IMsRdpClient7_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06004A60 RID: 19040
		public virtual extern int IMsRdpClient7_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06004A61 RID: 19041
		public virtual extern string IMsRdpClient7_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06004A62 RID: 19042
		public virtual extern int IMsRdpClient7_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06004A63 RID: 19043
		public virtual extern IMsTscSecuredSettings IMsRdpClient7_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06004A64 RID: 19044
		public virtual extern IMsTscAdvancedSettings IMsRdpClient7_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06004A65 RID: 19045
		public virtual extern IMsTscDebug IMsRdpClient7_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A66 RID: 19046
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Connect();

		// Token: 0x06004A67 RID: 19047
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Disconnect();

		// Token: 0x06004A68 RID: 19048
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004A69 RID: 19049
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06004A6B RID: 19051
		// (set) Token: 0x06004A6A RID: 19050
		public virtual extern int IMsRdpClient7_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06004A6C RID: 19052
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient7_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06004A6D RID: 19053
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient7_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06004A6E RID: 19054
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient7_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06004A70 RID: 19056
		// (set) Token: 0x06004A6F RID: 19055
		public virtual extern bool IMsRdpClient7_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004A71 RID: 19057
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004A72 RID: 19058
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient7_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004A73 RID: 19059
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient7_RequestClose();

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06004A74 RID: 19060
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient7_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06004A76 RID: 19062
		// (set) Token: 0x06004A75 RID: 19061
		public virtual extern string IMsRdpClient7_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06004A77 RID: 19063
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient7_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06004A78 RID: 19064
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient7_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06004A79 RID: 19065
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient7_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06004A7A RID: 19066
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient7_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A7B RID: 19067
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06004A7C RID: 19068
		public virtual extern ITSRemoteProgram IMsRdpClient7_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06004A7D RID: 19069
		public virtual extern IMsRdpClientShell IMsRdpClient7_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06004A7E RID: 19070
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient7_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06004A7F RID: 19071
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient7_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06004A80 RID: 19072
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient7_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06004A81 RID: 19073
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient7_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A82 RID: 19074
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetStatusText([In] uint statusCode);

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06004A83 RID: 19075
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient7_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06004A84 RID: 19076
		public virtual extern ITSRemoteProgram2 IMsRdpClient7_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06004A86 RID: 19078
		// (set) Token: 0x06004A85 RID: 19077
		public virtual extern string IMsRdpClient6_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06004A88 RID: 19080
		// (set) Token: 0x06004A87 RID: 19079
		public virtual extern string IMsRdpClient6_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06004A8A RID: 19082
		// (set) Token: 0x06004A89 RID: 19081
		public virtual extern string IMsRdpClient6_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06004A8C RID: 19084
		// (set) Token: 0x06004A8B RID: 19083
		public virtual extern string IMsRdpClient6_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06004A8E RID: 19086
		// (set) Token: 0x06004A8D RID: 19085
		public virtual extern string IMsRdpClient6_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06004A8F RID: 19087
		public virtual extern short IMsRdpClient6_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06004A91 RID: 19089
		// (set) Token: 0x06004A90 RID: 19088
		public virtual extern int IMsRdpClient6_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06004A93 RID: 19091
		// (set) Token: 0x06004A92 RID: 19090
		public virtual extern int IMsRdpClient6_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06004A95 RID: 19093
		// (set) Token: 0x06004A94 RID: 19092
		public virtual extern int IMsRdpClient6_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06004A96 RID: 19094
		public virtual extern int IMsRdpClient6_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06004A97 RID: 19095
		public virtual extern int IMsRdpClient6_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BFA RID: 7162
		// (set) Token: 0x06004A98 RID: 19096
		public virtual extern string IMsRdpClient6_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06004A99 RID: 19097
		public virtual extern int IMsRdpClient6_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06004A9A RID: 19098
		public virtual extern string IMsRdpClient6_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06004A9B RID: 19099
		public virtual extern int IMsRdpClient6_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06004A9C RID: 19100
		public virtual extern IMsTscSecuredSettings IMsRdpClient6_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06004A9D RID: 19101
		public virtual extern IMsTscAdvancedSettings IMsRdpClient6_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06004A9E RID: 19102
		public virtual extern IMsTscDebug IMsRdpClient6_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004A9F RID: 19103
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Connect();

		// Token: 0x06004AA0 RID: 19104
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Disconnect();

		// Token: 0x06004AA1 RID: 19105
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004AA2 RID: 19106
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06004AA4 RID: 19108
		// (set) Token: 0x06004AA3 RID: 19107
		public virtual extern int IMsRdpClient6_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06004AA5 RID: 19109
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient6_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06004AA6 RID: 19110
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient6_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06004AA7 RID: 19111
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient6_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06004AA9 RID: 19113
		// (set) Token: 0x06004AA8 RID: 19112
		public virtual extern bool IMsRdpClient6_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004AAA RID: 19114
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004AAB RID: 19115
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient6_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004AAC RID: 19116
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient6_RequestClose();

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06004AAD RID: 19117
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient6_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06004AAF RID: 19119
		// (set) Token: 0x06004AAE RID: 19118
		public virtual extern string IMsRdpClient6_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06004AB0 RID: 19120
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient6_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06004AB1 RID: 19121
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient6_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06004AB2 RID: 19122
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient6_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06004AB3 RID: 19123
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient6_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004AB4 RID: 19124
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient6_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06004AB5 RID: 19125
		public virtual extern ITSRemoteProgram IMsRdpClient6_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06004AB6 RID: 19126
		public virtual extern IMsRdpClientShell IMsRdpClient6_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06004AB7 RID: 19127
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient6_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06004AB8 RID: 19128
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient6_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06004ABA RID: 19130
		// (set) Token: 0x06004AB9 RID: 19129
		public virtual extern string IMsRdpClient5_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06004ABC RID: 19132
		// (set) Token: 0x06004ABB RID: 19131
		public virtual extern string IMsRdpClient5_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06004ABE RID: 19134
		// (set) Token: 0x06004ABD RID: 19133
		public virtual extern string IMsRdpClient5_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06004AC0 RID: 19136
		// (set) Token: 0x06004ABF RID: 19135
		public virtual extern string IMsRdpClient5_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06004AC2 RID: 19138
		// (set) Token: 0x06004AC1 RID: 19137
		public virtual extern string IMsRdpClient5_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06004AC3 RID: 19139
		public virtual extern short IMsRdpClient5_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06004AC5 RID: 19141
		// (set) Token: 0x06004AC4 RID: 19140
		public virtual extern int IMsRdpClient5_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06004AC7 RID: 19143
		// (set) Token: 0x06004AC6 RID: 19142
		public virtual extern int IMsRdpClient5_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06004AC9 RID: 19145
		// (set) Token: 0x06004AC8 RID: 19144
		public virtual extern int IMsRdpClient5_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06004ACA RID: 19146
		public virtual extern int IMsRdpClient5_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06004ACB RID: 19147
		public virtual extern int IMsRdpClient5_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C1B RID: 7195
		// (set) Token: 0x06004ACC RID: 19148
		public virtual extern string IMsRdpClient5_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06004ACD RID: 19149
		public virtual extern int IMsRdpClient5_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06004ACE RID: 19150
		public virtual extern string IMsRdpClient5_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06004ACF RID: 19151
		public virtual extern int IMsRdpClient5_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06004AD0 RID: 19152
		public virtual extern IMsTscSecuredSettings IMsRdpClient5_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06004AD1 RID: 19153
		public virtual extern IMsTscAdvancedSettings IMsRdpClient5_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06004AD2 RID: 19154
		public virtual extern IMsTscDebug IMsRdpClient5_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004AD3 RID: 19155
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Connect();

		// Token: 0x06004AD4 RID: 19156
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Disconnect();

		// Token: 0x06004AD5 RID: 19157
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004AD6 RID: 19158
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06004AD8 RID: 19160
		// (set) Token: 0x06004AD7 RID: 19159
		public virtual extern int IMsRdpClient5_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06004AD9 RID: 19161
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient5_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06004ADA RID: 19162
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient5_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06004ADB RID: 19163
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient5_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06004ADD RID: 19165
		// (set) Token: 0x06004ADC RID: 19164
		public virtual extern bool IMsRdpClient5_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004ADE RID: 19166
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004ADF RID: 19167
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient5_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004AE0 RID: 19168
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient5_RequestClose();

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06004AE1 RID: 19169
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient5_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06004AE3 RID: 19171
		// (set) Token: 0x06004AE2 RID: 19170
		public virtual extern string IMsRdpClient5_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06004AE4 RID: 19172
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient5_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06004AE5 RID: 19173
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient5_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06004AE6 RID: 19174
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient5_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06004AE7 RID: 19175
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient5_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004AE8 RID: 19176
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient5_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06004AE9 RID: 19177
		public virtual extern ITSRemoteProgram IMsRdpClient5_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06004AEA RID: 19178
		public virtual extern IMsRdpClientShell IMsRdpClient5_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06004AEC RID: 19180
		// (set) Token: 0x06004AEB RID: 19179
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06004AEE RID: 19182
		// (set) Token: 0x06004AED RID: 19181
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06004AF0 RID: 19184
		// (set) Token: 0x06004AEF RID: 19183
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06004AF2 RID: 19186
		// (set) Token: 0x06004AF1 RID: 19185
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06004AF4 RID: 19188
		// (set) Token: 0x06004AF3 RID: 19187
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06004AF5 RID: 19189
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06004AF7 RID: 19191
		// (set) Token: 0x06004AF6 RID: 19190
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06004AF9 RID: 19193
		// (set) Token: 0x06004AF8 RID: 19192
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06004AFB RID: 19195
		// (set) Token: 0x06004AFA RID: 19194
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06004AFC RID: 19196
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06004AFD RID: 19197
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C3A RID: 7226
		// (set) Token: 0x06004AFE RID: 19198
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06004AFF RID: 19199
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06004B00 RID: 19200
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06004B01 RID: 19201
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06004B02 RID: 19202
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06004B03 RID: 19203
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06004B04 RID: 19204
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004B05 RID: 19205
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x06004B06 RID: 19206
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x06004B07 RID: 19207
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004B08 RID: 19208
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06004B0A RID: 19210
		// (set) Token: 0x06004B09 RID: 19209
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06004B0B RID: 19211
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06004B0C RID: 19212
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06004B0D RID: 19213
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06004B0F RID: 19215
		// (set) Token: 0x06004B0E RID: 19214
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004B10 RID: 19216
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004B11 RID: 19217
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004B12 RID: 19218
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06004B13 RID: 19219
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06004B15 RID: 19221
		// (set) Token: 0x06004B14 RID: 19220
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06004B16 RID: 19222
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06004B17 RID: 19223
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06004B19 RID: 19225
		// (set) Token: 0x06004B18 RID: 19224
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06004B1B RID: 19227
		// (set) Token: 0x06004B1A RID: 19226
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06004B1D RID: 19229
		// (set) Token: 0x06004B1C RID: 19228
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06004B1F RID: 19231
		// (set) Token: 0x06004B1E RID: 19230
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06004B21 RID: 19233
		// (set) Token: 0x06004B20 RID: 19232
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06004B22 RID: 19234
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06004B24 RID: 19236
		// (set) Token: 0x06004B23 RID: 19235
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06004B26 RID: 19238
		// (set) Token: 0x06004B25 RID: 19237
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06004B28 RID: 19240
		// (set) Token: 0x06004B27 RID: 19239
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06004B29 RID: 19241
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06004B2A RID: 19242
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C55 RID: 7253
		// (set) Token: 0x06004B2B RID: 19243
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06004B2C RID: 19244
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06004B2D RID: 19245
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06004B2E RID: 19246
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06004B2F RID: 19247
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06004B30 RID: 19248
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06004B31 RID: 19249
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004B32 RID: 19250
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x06004B33 RID: 19251
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x06004B34 RID: 19252
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004B35 RID: 19253
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06004B37 RID: 19255
		// (set) Token: 0x06004B36 RID: 19254
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06004B38 RID: 19256
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06004B39 RID: 19257
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06004B3A RID: 19258
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06004B3C RID: 19260
		// (set) Token: 0x06004B3B RID: 19259
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004B3D RID: 19261
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004B3E RID: 19262
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004B3F RID: 19263
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06004B40 RID: 19264
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06004B42 RID: 19266
		// (set) Token: 0x06004B41 RID: 19265
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06004B43 RID: 19267
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06004B45 RID: 19269
		// (set) Token: 0x06004B44 RID: 19268
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06004B47 RID: 19271
		// (set) Token: 0x06004B46 RID: 19270
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06004B49 RID: 19273
		// (set) Token: 0x06004B48 RID: 19272
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06004B4B RID: 19275
		// (set) Token: 0x06004B4A RID: 19274
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06004B4D RID: 19277
		// (set) Token: 0x06004B4C RID: 19276
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06004B4E RID: 19278
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06004B50 RID: 19280
		// (set) Token: 0x06004B4F RID: 19279
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06004B52 RID: 19282
		// (set) Token: 0x06004B51 RID: 19281
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06004B54 RID: 19284
		// (set) Token: 0x06004B53 RID: 19283
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06004B55 RID: 19285
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06004B56 RID: 19286
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C6F RID: 7279
		// (set) Token: 0x06004B57 RID: 19287
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06004B58 RID: 19288
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06004B59 RID: 19289
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06004B5A RID: 19290
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06004B5B RID: 19291
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06004B5C RID: 19292
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06004B5D RID: 19293
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004B5E RID: 19294
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x06004B5F RID: 19295
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x06004B60 RID: 19296
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004B61 RID: 19297
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06004B63 RID: 19299
		// (set) Token: 0x06004B62 RID: 19298
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06004B64 RID: 19300
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06004B65 RID: 19301
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06004B66 RID: 19302
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06004B68 RID: 19304
		// (set) Token: 0x06004B67 RID: 19303
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004B69 RID: 19305
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004B6A RID: 19306
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004B6B RID: 19307
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06004B6C RID: 19308
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06004B6E RID: 19310
		// (set) Token: 0x06004B6D RID: 19309
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06004B70 RID: 19312
		// (set) Token: 0x06004B6F RID: 19311
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06004B72 RID: 19314
		// (set) Token: 0x06004B71 RID: 19313
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06004B74 RID: 19316
		// (set) Token: 0x06004B73 RID: 19315
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06004B76 RID: 19318
		// (set) Token: 0x06004B75 RID: 19317
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06004B78 RID: 19320
		// (set) Token: 0x06004B77 RID: 19319
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06004B79 RID: 19321
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06004B7B RID: 19323
		// (set) Token: 0x06004B7A RID: 19322
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06004B7D RID: 19325
		// (set) Token: 0x06004B7C RID: 19324
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06004B7F RID: 19327
		// (set) Token: 0x06004B7E RID: 19326
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06004B80 RID: 19328
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06004B81 RID: 19329
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C88 RID: 7304
		// (set) Token: 0x06004B82 RID: 19330
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06004B83 RID: 19331
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06004B84 RID: 19332
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06004B85 RID: 19333
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06004B86 RID: 19334
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06004B87 RID: 19335
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06004B88 RID: 19336
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004B89 RID: 19337
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06004B8A RID: 19338
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06004B8B RID: 19339
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004B8C RID: 19340
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06004B8E RID: 19342
		// (set) Token: 0x06004B8D RID: 19341
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06004B8F RID: 19343
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06004B90 RID: 19344
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06004B91 RID: 19345
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06004B93 RID: 19347
		// (set) Token: 0x06004B92 RID: 19346
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004B94 RID: 19348
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004B95 RID: 19349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004B96 RID: 19350
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06004B98 RID: 19352
		// (set) Token: 0x06004B97 RID: 19351
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06004B9A RID: 19354
		// (set) Token: 0x06004B99 RID: 19353
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06004B9C RID: 19356
		// (set) Token: 0x06004B9B RID: 19355
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06004B9E RID: 19358
		// (set) Token: 0x06004B9D RID: 19357
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06004BA0 RID: 19360
		// (set) Token: 0x06004B9F RID: 19359
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06004BA1 RID: 19361
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06004BA3 RID: 19363
		// (set) Token: 0x06004BA2 RID: 19362
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06004BA5 RID: 19365
		// (set) Token: 0x06004BA4 RID: 19364
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06004BA7 RID: 19367
		// (set) Token: 0x06004BA6 RID: 19366
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06004BA8 RID: 19368
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06004BA9 RID: 19369
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001C9F RID: 7327
		// (set) Token: 0x06004BAA RID: 19370
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06004BAB RID: 19371
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06004BAC RID: 19372
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06004BAD RID: 19373
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06004BAE RID: 19374
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06004BAF RID: 19375
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06004BB0 RID: 19376
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004BB1 RID: 19377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06004BB2 RID: 19378
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06004BB3 RID: 19379
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004BB4 RID: 19380
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001CA6 RID: 7334
		// (set) Token: 0x06004BB5 RID: 19381
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06004BB7 RID: 19383
		// (set) Token: 0x06004BB6 RID: 19382
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06004BB9 RID: 19385
		// (set) Token: 0x06004BB8 RID: 19384
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06004BBB RID: 19387
		// (set) Token: 0x06004BBA RID: 19386
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06004BBD RID: 19389
		// (set) Token: 0x06004BBC RID: 19388
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004BBE RID: 19390
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17001CAB RID: 7339
		// (set) Token: 0x06004BBF RID: 19391
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06004BC1 RID: 19393
		// (set) Token: 0x06004BC0 RID: 19392
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06004BC3 RID: 19395
		// (set) Token: 0x06004BC2 RID: 19394
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06004BC5 RID: 19397
		// (set) Token: 0x06004BC4 RID: 19396
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06004BC7 RID: 19399
		// (set) Token: 0x06004BC6 RID: 19398
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004BC8 RID: 19400
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06004BC9 RID: 19401
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004BCA RID: 19402
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001CB0 RID: 7344
		// (set) Token: 0x06004BCB RID: 19403
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06004BCD RID: 19405
		// (set) Token: 0x06004BCC RID: 19404
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06004BCF RID: 19407
		// (set) Token: 0x06004BCE RID: 19406
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06004BD1 RID: 19409
		// (set) Token: 0x06004BD0 RID: 19408
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06004BD3 RID: 19411
		// (set) Token: 0x06004BD2 RID: 19410
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004BD4 RID: 19412
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06004BD5 RID: 19413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004BD6 RID: 19414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06004BD8 RID: 19416
		// (set) Token: 0x06004BD7 RID: 19415
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001CB6 RID: 7350
		// (set) Token: 0x06004BD9 RID: 19417
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06004BDB RID: 19419
		// (set) Token: 0x06004BDA RID: 19418
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06004BDD RID: 19421
		// (set) Token: 0x06004BDC RID: 19420
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06004BDF RID: 19423
		// (set) Token: 0x06004BDE RID: 19422
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06004BE1 RID: 19425
		// (set) Token: 0x06004BE0 RID: 19424
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004BE2 RID: 19426
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x06004BE3 RID: 19427
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004BE4 RID: 19428
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06004BE6 RID: 19430
		// (set) Token: 0x06004BE5 RID: 19429
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06004BE8 RID: 19432
		// (set) Token: 0x06004BE7 RID: 19431
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06004BEA RID: 19434
		// (set) Token: 0x06004BE9 RID: 19433
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06004BEC RID: 19436
		// (set) Token: 0x06004BEB RID: 19435
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06004BEE RID: 19438
		// (set) Token: 0x06004BED RID: 19437
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06004BF0 RID: 19440
		// (set) Token: 0x06004BEF RID: 19439
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06004BF2 RID: 19442
		// (set) Token: 0x06004BF1 RID: 19441
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06004BF3 RID: 19443
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06004BF4 RID: 19444
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06004BF6 RID: 19446
		// (set) Token: 0x06004BF5 RID: 19445
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06004BF8 RID: 19448
		// (set) Token: 0x06004BF7 RID: 19447
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06004BFA RID: 19450
		// (set) Token: 0x06004BF9 RID: 19449
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CC7 RID: 7367
		// (set) Token: 0x06004BFB RID: 19451
		public virtual extern string IMsRdpClientNonScriptable4_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06004BFD RID: 19453
		// (set) Token: 0x06004BFC RID: 19452
		public virtual extern string IMsRdpClientNonScriptable4_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06004BFF RID: 19455
		// (set) Token: 0x06004BFE RID: 19454
		public virtual extern string IMsRdpClientNonScriptable4_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06004C01 RID: 19457
		// (set) Token: 0x06004C00 RID: 19456
		public virtual extern string IMsRdpClientNonScriptable4_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06004C03 RID: 19459
		// (set) Token: 0x06004C02 RID: 19458
		public virtual extern string IMsRdpClientNonScriptable4_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004C04 RID: 19460
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_ResetPassword();

		// Token: 0x06004C05 RID: 19461
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004C06 RID: 19462
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06004C08 RID: 19464
		// (set) Token: 0x06004C07 RID: 19463
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable4_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06004C0A RID: 19466
		// (set) Token: 0x06004C09 RID: 19465
		public virtual extern bool IMsRdpClientNonScriptable4_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06004C0C RID: 19468
		// (set) Token: 0x06004C0B RID: 19467
		public virtual extern bool IMsRdpClientNonScriptable4_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06004C0E RID: 19470
		// (set) Token: 0x06004C0D RID: 19469
		public virtual extern bool IMsRdpClientNonScriptable4_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06004C10 RID: 19472
		// (set) Token: 0x06004C0F RID: 19471
		public virtual extern bool IMsRdpClientNonScriptable4_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06004C12 RID: 19474
		// (set) Token: 0x06004C11 RID: 19473
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06004C14 RID: 19476
		// (set) Token: 0x06004C13 RID: 19475
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06004C15 RID: 19477
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable4_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06004C16 RID: 19478
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable4_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06004C18 RID: 19480
		// (set) Token: 0x06004C17 RID: 19479
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06004C1A RID: 19482
		// (set) Token: 0x06004C19 RID: 19481
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06004C1C RID: 19484
		// (set) Token: 0x06004C1B RID: 19483
		public virtual extern string IMsRdpClientNonScriptable4_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06004C1E RID: 19486
		// (set) Token: 0x06004C1D RID: 19485
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06004C20 RID: 19488
		// (set) Token: 0x06004C1F RID: 19487
		public virtual extern bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06004C22 RID: 19490
		// (set) Token: 0x06004C21 RID: 19489
		public virtual extern object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06004C24 RID: 19492
		// (set) Token: 0x06004C23 RID: 19491
		public virtual extern bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06004C26 RID: 19494
		// (set) Token: 0x06004C25 RID: 19493
		public virtual extern bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06004C28 RID: 19496
		// (set) Token: 0x06004C27 RID: 19495
		public virtual extern bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06004C2A RID: 19498
		// (set) Token: 0x06004C29 RID: 19497
		public virtual extern bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06004C2C RID: 19500
		// (set) Token: 0x06004C2B RID: 19499
		public virtual extern bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CE0 RID: 7392
		// (set) Token: 0x06004C2D RID: 19501
		public virtual extern string IMsRdpClientNonScriptable5_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06004C2F RID: 19503
		// (set) Token: 0x06004C2E RID: 19502
		public virtual extern string IMsRdpClientNonScriptable5_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06004C31 RID: 19505
		// (set) Token: 0x06004C30 RID: 19504
		public virtual extern string IMsRdpClientNonScriptable5_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06004C33 RID: 19507
		// (set) Token: 0x06004C32 RID: 19506
		public virtual extern string IMsRdpClientNonScriptable5_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06004C35 RID: 19509
		// (set) Token: 0x06004C34 RID: 19508
		public virtual extern string IMsRdpClientNonScriptable5_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004C36 RID: 19510
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_ResetPassword();

		// Token: 0x06004C37 RID: 19511
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004C38 RID: 19512
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06004C3A RID: 19514
		// (set) Token: 0x06004C39 RID: 19513
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable5_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06004C3C RID: 19516
		// (set) Token: 0x06004C3B RID: 19515
		public virtual extern bool IMsRdpClientNonScriptable5_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06004C3E RID: 19518
		// (set) Token: 0x06004C3D RID: 19517
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06004C40 RID: 19520
		// (set) Token: 0x06004C3F RID: 19519
		public virtual extern bool IMsRdpClientNonScriptable5_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06004C42 RID: 19522
		// (set) Token: 0x06004C41 RID: 19521
		public virtual extern bool IMsRdpClientNonScriptable5_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06004C44 RID: 19524
		// (set) Token: 0x06004C43 RID: 19523
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06004C46 RID: 19526
		// (set) Token: 0x06004C45 RID: 19525
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06004C47 RID: 19527
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable5_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06004C48 RID: 19528
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable5_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06004C4A RID: 19530
		// (set) Token: 0x06004C49 RID: 19529
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06004C4C RID: 19532
		// (set) Token: 0x06004C4B RID: 19531
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06004C4E RID: 19534
		// (set) Token: 0x06004C4D RID: 19533
		public virtual extern string IMsRdpClientNonScriptable5_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06004C50 RID: 19536
		// (set) Token: 0x06004C4F RID: 19535
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable5_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06004C52 RID: 19538
		// (set) Token: 0x06004C51 RID: 19537
		public virtual extern bool IMsRdpClientNonScriptable5_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06004C54 RID: 19540
		// (set) Token: 0x06004C53 RID: 19539
		public virtual extern object IMsRdpClientNonScriptable5_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06004C56 RID: 19542
		// (set) Token: 0x06004C55 RID: 19541
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06004C58 RID: 19544
		// (set) Token: 0x06004C57 RID: 19543
		public virtual extern bool IMsRdpClientNonScriptable5_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06004C5A RID: 19546
		// (set) Token: 0x06004C59 RID: 19545
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06004C5C RID: 19548
		// (set) Token: 0x06004C5B RID: 19547
		public virtual extern bool IMsRdpClientNonScriptable5_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06004C5E RID: 19550
		// (set) Token: 0x06004C5D RID: 19549
		public virtual extern bool IMsRdpClientNonScriptable5_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06004C60 RID: 19552
		// (set) Token: 0x06004C5F RID: 19551
		public virtual extern bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06004C61 RID: 19553
		public virtual extern uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004C62 RID: 19554
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06004C63 RID: 19555
		public virtual extern bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001CFC RID: 7420
		// (set) Token: 0x06004C64 RID: 19556
		public virtual extern bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06004C66 RID: 19558
		// (set) Token: 0x06004C65 RID: 19557
		public virtual extern bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06004C68 RID: 19560
		// (set) Token: 0x06004C67 RID: 19559
		public virtual extern bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06004C6A RID: 19562
		// (set) Token: 0x06004C69 RID: 19561
		public virtual extern bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06004C6C RID: 19564
		// (set) Token: 0x06004C6B RID: 19563
		public virtual extern bool UseRedirectionServerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x14000657 RID: 1623
		// (add) Token: 0x06004C6D RID: 19565
		// (remove) Token: 0x06004C6E RID: 19566
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000658 RID: 1624
		// (add) Token: 0x06004C6F RID: 19567
		// (remove) Token: 0x06004C70 RID: 19568
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000659 RID: 1625
		// (add) Token: 0x06004C71 RID: 19569
		// (remove) Token: 0x06004C72 RID: 19570
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400065A RID: 1626
		// (add) Token: 0x06004C73 RID: 19571
		// (remove) Token: 0x06004C74 RID: 19572
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400065B RID: 1627
		// (add) Token: 0x06004C75 RID: 19573
		// (remove) Token: 0x06004C76 RID: 19574
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400065C RID: 1628
		// (add) Token: 0x06004C77 RID: 19575
		// (remove) Token: 0x06004C78 RID: 19576
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400065D RID: 1629
		// (add) Token: 0x06004C79 RID: 19577
		// (remove) Token: 0x06004C7A RID: 19578
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400065E RID: 1630
		// (add) Token: 0x06004C7B RID: 19579
		// (remove) Token: 0x06004C7C RID: 19580
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400065F RID: 1631
		// (add) Token: 0x06004C7D RID: 19581
		// (remove) Token: 0x06004C7E RID: 19582
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000660 RID: 1632
		// (add) Token: 0x06004C7F RID: 19583
		// (remove) Token: 0x06004C80 RID: 19584
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000661 RID: 1633
		// (add) Token: 0x06004C81 RID: 19585
		// (remove) Token: 0x06004C82 RID: 19586
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000662 RID: 1634
		// (add) Token: 0x06004C83 RID: 19587
		// (remove) Token: 0x06004C84 RID: 19588
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000663 RID: 1635
		// (add) Token: 0x06004C85 RID: 19589
		// (remove) Token: 0x06004C86 RID: 19590
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000664 RID: 1636
		// (add) Token: 0x06004C87 RID: 19591
		// (remove) Token: 0x06004C88 RID: 19592
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000665 RID: 1637
		// (add) Token: 0x06004C89 RID: 19593
		// (remove) Token: 0x06004C8A RID: 19594
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000666 RID: 1638
		// (add) Token: 0x06004C8B RID: 19595
		// (remove) Token: 0x06004C8C RID: 19596
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000667 RID: 1639
		// (add) Token: 0x06004C8D RID: 19597
		// (remove) Token: 0x06004C8E RID: 19598
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000668 RID: 1640
		// (add) Token: 0x06004C8F RID: 19599
		// (remove) Token: 0x06004C90 RID: 19600
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000669 RID: 1641
		// (add) Token: 0x06004C91 RID: 19601
		// (remove) Token: 0x06004C92 RID: 19602
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400066A RID: 1642
		// (add) Token: 0x06004C93 RID: 19603
		// (remove) Token: 0x06004C94 RID: 19604
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400066B RID: 1643
		// (add) Token: 0x06004C95 RID: 19605
		// (remove) Token: 0x06004C96 RID: 19606
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400066C RID: 1644
		// (add) Token: 0x06004C97 RID: 19607
		// (remove) Token: 0x06004C98 RID: 19608
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400066D RID: 1645
		// (add) Token: 0x06004C99 RID: 19609
		// (remove) Token: 0x06004C9A RID: 19610
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400066E RID: 1646
		// (add) Token: 0x06004C9B RID: 19611
		// (remove) Token: 0x06004C9C RID: 19612
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400066F RID: 1647
		// (add) Token: 0x06004C9D RID: 19613
		// (remove) Token: 0x06004C9E RID: 19614
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000670 RID: 1648
		// (add) Token: 0x06004C9F RID: 19615
		// (remove) Token: 0x06004CA0 RID: 19616
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000671 RID: 1649
		// (add) Token: 0x06004CA1 RID: 19617
		// (remove) Token: 0x06004CA2 RID: 19618
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000672 RID: 1650
		// (add) Token: 0x06004CA3 RID: 19619
		// (remove) Token: 0x06004CA4 RID: 19620
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000673 RID: 1651
		// (add) Token: 0x06004CA5 RID: 19621
		// (remove) Token: 0x06004CA6 RID: 19622
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000674 RID: 1652
		// (add) Token: 0x06004CA7 RID: 19623
		// (remove) Token: 0x06004CA8 RID: 19624
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000675 RID: 1653
		// (add) Token: 0x06004CA9 RID: 19625
		// (remove) Token: 0x06004CAA RID: 19626
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000676 RID: 1654
		// (add) Token: 0x06004CAB RID: 19627
		// (remove) Token: 0x06004CAC RID: 19628
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
