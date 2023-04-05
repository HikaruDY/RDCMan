using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001F8 RID: 504
	[Guid("22A7E88C-5BF5-4DE6-B687-60F7331DF190")]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[TypeLibType(2)]
	[ClassInterface(0)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient11Class : IMsRdpClient10, MsRdpClient11, IMsTscAxEvents_Event, IMsRdpClient9, IMsRdpClient8, IMsRdpClient7, IMsRdpClient6, IMsRdpClient5, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3, IMsRdpClientNonScriptable4, IMsRdpClientNonScriptable5, IMsRdpClientNonScriptable6, IMsRdpClientNonScriptable7, IMsRdpPreferredRedirectionInfo
	{
		// Token: 0x060050ED RID: 20717
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient11Class();

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x060050EF RID: 20719
		// (set) Token: 0x060050EE RID: 20718
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x060050F1 RID: 20721
		// (set) Token: 0x060050F0 RID: 20720
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x060050F3 RID: 20723
		// (set) Token: 0x060050F2 RID: 20722
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x060050F5 RID: 20725
		// (set) Token: 0x060050F4 RID: 20724
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x060050F7 RID: 20727
		// (set) Token: 0x060050F6 RID: 20726
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x060050F8 RID: 20728
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x060050FA RID: 20730
		// (set) Token: 0x060050F9 RID: 20729
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x060050FC RID: 20732
		// (set) Token: 0x060050FB RID: 20731
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x060050FE RID: 20734
		// (set) Token: 0x060050FD RID: 20733
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x060050FF RID: 20735
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x06005100 RID: 20736
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F4A RID: 8010
		// (set) Token: 0x06005101 RID: 20737
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06005102 RID: 20738
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06005103 RID: 20739
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06005104 RID: 20740
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06005105 RID: 20741
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06005106 RID: 20742
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x06005107 RID: 20743
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005108 RID: 20744
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06005109 RID: 20745
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x0600510A RID: 20746
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600510B RID: 20747
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600510D RID: 20749
		// (set) Token: 0x0600510C RID: 20748
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x0600510E RID: 20750
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x0600510F RID: 20751
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06005110 RID: 20752
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x06005112 RID: 20754
		// (set) Token: 0x06005111 RID: 20753
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005113 RID: 20755
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06005114 RID: 20756
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06005115 RID: 20757
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06005116 RID: 20758
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06005118 RID: 20760
		// (set) Token: 0x06005117 RID: 20759
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06005119 RID: 20761
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x0600511A RID: 20762
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x0600511B RID: 20763
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x0600511C RID: 20764
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600511D RID: 20765
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x0600511E RID: 20766
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x0600511F RID: 20767
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06005120 RID: 20768
		[DispId(507)]
		public virtual extern IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06005121 RID: 20769
		[DispId(506)]
		public virtual extern IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06005122 RID: 20770
		[DispId(600)]
		public virtual extern IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06005123 RID: 20771
		[DispId(601)]
		public virtual extern IMsRdpClientTransportSettings3 TransportSettings3 { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005124 RID: 20772
		[DispId(602)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetStatusText([In] uint statusCode);

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06005125 RID: 20773
		[DispId(603)]
		public virtual extern IMsRdpClientSecuredSettings2 SecuredSettings3 { [DispId(603)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06005126 RID: 20774
		[DispId(604)]
		public virtual extern ITSRemoteProgram2 RemoteProgram2 { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005127 RID: 20775
		[DispId(700)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06005128 RID: 20776
		[DispId(701)]
		public virtual extern IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005129 RID: 20777
		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x0600512A RID: 20778
		[DispId(800)]
		public virtual extern IMsRdpClientTransportSettings4 TransportSettings4 { [DispId(800)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600512B RID: 20779
		[DispId(801)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SyncSessionDisplaySettings();

		// Token: 0x0600512C RID: 20780
		[DispId(802)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x0600512D RID: 20781
		[DispId(803)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x0600512E RID: 20782
		[DispId(804)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x0600512F RID: 20783
		[DispId(900)]
		public virtual extern ITSRemoteProgram3 RemoteProgram3 { [DispId(900)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06005131 RID: 20785
		// (set) Token: 0x06005130 RID: 20784
		public virtual extern string IMsRdpClient9_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06005133 RID: 20787
		// (set) Token: 0x06005132 RID: 20786
		public virtual extern string IMsRdpClient9_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06005135 RID: 20789
		// (set) Token: 0x06005134 RID: 20788
		public virtual extern string IMsRdpClient9_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06005137 RID: 20791
		// (set) Token: 0x06005136 RID: 20790
		public virtual extern string IMsRdpClient9_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06005139 RID: 20793
		// (set) Token: 0x06005138 RID: 20792
		public virtual extern string IMsRdpClient9_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x0600513A RID: 20794
		public virtual extern short IMsRdpClient9_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x0600513C RID: 20796
		// (set) Token: 0x0600513B RID: 20795
		public virtual extern int IMsRdpClient9_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x0600513E RID: 20798
		// (set) Token: 0x0600513D RID: 20797
		public virtual extern int IMsRdpClient9_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06005140 RID: 20800
		// (set) Token: 0x0600513F RID: 20799
		public virtual extern int IMsRdpClient9_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06005141 RID: 20801
		public virtual extern int IMsRdpClient9_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06005142 RID: 20802
		public virtual extern int IMsRdpClient9_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F72 RID: 8050
		// (set) Token: 0x06005143 RID: 20803
		public virtual extern string IMsRdpClient9_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06005144 RID: 20804
		public virtual extern int IMsRdpClient9_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06005145 RID: 20805
		public virtual extern string IMsRdpClient9_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06005146 RID: 20806
		public virtual extern int IMsRdpClient9_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06005147 RID: 20807
		public virtual extern IMsTscSecuredSettings IMsRdpClient9_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06005148 RID: 20808
		public virtual extern IMsTscAdvancedSettings IMsRdpClient9_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06005149 RID: 20809
		public virtual extern IMsTscDebug IMsRdpClient9_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600514A RID: 20810
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_Connect();

		// Token: 0x0600514B RID: 20811
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_Disconnect();

		// Token: 0x0600514C RID: 20812
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600514D RID: 20813
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x0600514F RID: 20815
		// (set) Token: 0x0600514E RID: 20814
		public virtual extern int IMsRdpClient9_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06005150 RID: 20816
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient9_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06005151 RID: 20817
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient9_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06005152 RID: 20818
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient9_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06005154 RID: 20820
		// (set) Token: 0x06005153 RID: 20819
		public virtual extern bool IMsRdpClient9_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005155 RID: 20821
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06005156 RID: 20822
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient9_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06005157 RID: 20823
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient9_RequestClose();

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06005158 RID: 20824
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient9_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0600515A RID: 20826
		// (set) Token: 0x06005159 RID: 20825
		public virtual extern string IMsRdpClient9_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x0600515B RID: 20827
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient9_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x0600515C RID: 20828
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient9_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x0600515D RID: 20829
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient9_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x0600515E RID: 20830
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient9_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600515F RID: 20831
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient9_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06005160 RID: 20832
		public virtual extern ITSRemoteProgram IMsRdpClient9_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06005161 RID: 20833
		public virtual extern IMsRdpClientShell IMsRdpClient9_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06005162 RID: 20834
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient9_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06005163 RID: 20835
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient9_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06005164 RID: 20836
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient9_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x06005165 RID: 20837
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient9_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005166 RID: 20838
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient9_GetStatusText([In] uint statusCode);

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06005167 RID: 20839
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient9_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06005168 RID: 20840
		public virtual extern ITSRemoteProgram2 IMsRdpClient9_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005169 RID: 20841
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x0600516A RID: 20842
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient9_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600516B RID: 20843
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient9_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x0600516C RID: 20844
		public virtual extern IMsRdpClientTransportSettings4 IMsRdpClient9_TransportSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600516D RID: 20845
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SyncSessionDisplaySettings();

		// Token: 0x0600516E RID: 20846
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x0600516F RID: 20847
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x06005170 RID: 20848
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06005172 RID: 20850
		// (set) Token: 0x06005171 RID: 20849
		public virtual extern string IMsRdpClient8_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06005174 RID: 20852
		// (set) Token: 0x06005173 RID: 20851
		public virtual extern string IMsRdpClient8_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06005176 RID: 20854
		// (set) Token: 0x06005175 RID: 20853
		public virtual extern string IMsRdpClient8_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06005178 RID: 20856
		// (set) Token: 0x06005177 RID: 20855
		public virtual extern string IMsRdpClient8_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x0600517A RID: 20858
		// (set) Token: 0x06005179 RID: 20857
		public virtual extern string IMsRdpClient8_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600517B RID: 20859
		public virtual extern short IMsRdpClient8_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x0600517D RID: 20861
		// (set) Token: 0x0600517C RID: 20860
		public virtual extern int IMsRdpClient8_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600517F RID: 20863
		// (set) Token: 0x0600517E RID: 20862
		public virtual extern int IMsRdpClient8_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06005181 RID: 20865
		// (set) Token: 0x06005180 RID: 20864
		public virtual extern int IMsRdpClient8_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06005182 RID: 20866
		public virtual extern int IMsRdpClient8_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06005183 RID: 20867
		public virtual extern int IMsRdpClient8_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F99 RID: 8089
		// (set) Token: 0x06005184 RID: 20868
		public virtual extern string IMsRdpClient8_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06005185 RID: 20869
		public virtual extern int IMsRdpClient8_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06005186 RID: 20870
		public virtual extern string IMsRdpClient8_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06005187 RID: 20871
		public virtual extern int IMsRdpClient8_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06005188 RID: 20872
		public virtual extern IMsTscSecuredSettings IMsRdpClient8_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06005189 RID: 20873
		public virtual extern IMsTscAdvancedSettings IMsRdpClient8_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600518A RID: 20874
		public virtual extern IMsTscDebug IMsRdpClient8_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600518B RID: 20875
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Connect();

		// Token: 0x0600518C RID: 20876
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Disconnect();

		// Token: 0x0600518D RID: 20877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600518E RID: 20878
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06005190 RID: 20880
		// (set) Token: 0x0600518F RID: 20879
		public virtual extern int IMsRdpClient8_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06005191 RID: 20881
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient8_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06005192 RID: 20882
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient8_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06005193 RID: 20883
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient8_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06005195 RID: 20885
		// (set) Token: 0x06005194 RID: 20884
		public virtual extern bool IMsRdpClient8_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005196 RID: 20886
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06005197 RID: 20887
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient8_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06005198 RID: 20888
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient8_RequestClose();

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06005199 RID: 20889
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient8_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600519B RID: 20891
		// (set) Token: 0x0600519A RID: 20890
		public virtual extern string IMsRdpClient8_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x0600519C RID: 20892
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient8_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x0600519D RID: 20893
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient8_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x0600519E RID: 20894
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient8_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x0600519F RID: 20895
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient8_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060051A0 RID: 20896
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x060051A1 RID: 20897
		public virtual extern ITSRemoteProgram IMsRdpClient8_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x060051A2 RID: 20898
		public virtual extern IMsRdpClientShell IMsRdpClient8_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x060051A3 RID: 20899
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient8_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x060051A4 RID: 20900
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient8_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x060051A5 RID: 20901
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient8_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x060051A6 RID: 20902
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient8_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060051A7 RID: 20903
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetStatusText([In] uint statusCode);

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x060051A8 RID: 20904
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient8_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x060051A9 RID: 20905
		public virtual extern ITSRemoteProgram2 IMsRdpClient8_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060051AA RID: 20906
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x060051AB RID: 20907
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient8_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060051AC RID: 20908
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient8_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x060051AE RID: 20910
		// (set) Token: 0x060051AD RID: 20909
		public virtual extern string IMsRdpClient7_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x060051B0 RID: 20912
		// (set) Token: 0x060051AF RID: 20911
		public virtual extern string IMsRdpClient7_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x060051B2 RID: 20914
		// (set) Token: 0x060051B1 RID: 20913
		public virtual extern string IMsRdpClient7_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x060051B4 RID: 20916
		// (set) Token: 0x060051B3 RID: 20915
		public virtual extern string IMsRdpClient7_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x060051B6 RID: 20918
		// (set) Token: 0x060051B5 RID: 20917
		public virtual extern string IMsRdpClient7_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x060051B7 RID: 20919
		public virtual extern short IMsRdpClient7_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x060051B9 RID: 20921
		// (set) Token: 0x060051B8 RID: 20920
		public virtual extern int IMsRdpClient7_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x060051BB RID: 20923
		// (set) Token: 0x060051BA RID: 20922
		public virtual extern int IMsRdpClient7_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x060051BD RID: 20925
		// (set) Token: 0x060051BC RID: 20924
		public virtual extern int IMsRdpClient7_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x060051BE RID: 20926
		public virtual extern int IMsRdpClient7_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x060051BF RID: 20927
		public virtual extern int IMsRdpClient7_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FBF RID: 8127
		// (set) Token: 0x060051C0 RID: 20928
		public virtual extern string IMsRdpClient7_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x060051C1 RID: 20929
		public virtual extern int IMsRdpClient7_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x060051C2 RID: 20930
		public virtual extern string IMsRdpClient7_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x060051C3 RID: 20931
		public virtual extern int IMsRdpClient7_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x060051C4 RID: 20932
		public virtual extern IMsTscSecuredSettings IMsRdpClient7_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x060051C5 RID: 20933
		public virtual extern IMsTscAdvancedSettings IMsRdpClient7_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x060051C6 RID: 20934
		public virtual extern IMsTscDebug IMsRdpClient7_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060051C7 RID: 20935
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Connect();

		// Token: 0x060051C8 RID: 20936
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Disconnect();

		// Token: 0x060051C9 RID: 20937
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060051CA RID: 20938
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x060051CC RID: 20940
		// (set) Token: 0x060051CB RID: 20939
		public virtual extern int IMsRdpClient7_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x060051CD RID: 20941
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient7_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x060051CE RID: 20942
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient7_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x060051CF RID: 20943
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient7_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x060051D1 RID: 20945
		// (set) Token: 0x060051D0 RID: 20944
		public virtual extern bool IMsRdpClient7_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060051D2 RID: 20946
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060051D3 RID: 20947
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient7_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060051D4 RID: 20948
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient7_RequestClose();

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x060051D5 RID: 20949
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient7_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x060051D7 RID: 20951
		// (set) Token: 0x060051D6 RID: 20950
		public virtual extern string IMsRdpClient7_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x060051D8 RID: 20952
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient7_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x060051D9 RID: 20953
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient7_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x060051DA RID: 20954
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient7_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x060051DB RID: 20955
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient7_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060051DC RID: 20956
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x060051DD RID: 20957
		public virtual extern ITSRemoteProgram IMsRdpClient7_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x060051DE RID: 20958
		public virtual extern IMsRdpClientShell IMsRdpClient7_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x060051DF RID: 20959
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient7_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x060051E0 RID: 20960
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient7_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x060051E1 RID: 20961
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient7_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x060051E2 RID: 20962
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient7_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060051E3 RID: 20963
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetStatusText([In] uint statusCode);

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x060051E4 RID: 20964
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient7_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x060051E5 RID: 20965
		public virtual extern ITSRemoteProgram2 IMsRdpClient7_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x060051E7 RID: 20967
		// (set) Token: 0x060051E6 RID: 20966
		public virtual extern string IMsRdpClient6_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x060051E9 RID: 20969
		// (set) Token: 0x060051E8 RID: 20968
		public virtual extern string IMsRdpClient6_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x060051EB RID: 20971
		// (set) Token: 0x060051EA RID: 20970
		public virtual extern string IMsRdpClient6_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x060051ED RID: 20973
		// (set) Token: 0x060051EC RID: 20972
		public virtual extern string IMsRdpClient6_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x060051EF RID: 20975
		// (set) Token: 0x060051EE RID: 20974
		public virtual extern string IMsRdpClient6_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x060051F0 RID: 20976
		public virtual extern short IMsRdpClient6_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x060051F2 RID: 20978
		// (set) Token: 0x060051F1 RID: 20977
		public virtual extern int IMsRdpClient6_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x060051F4 RID: 20980
		// (set) Token: 0x060051F3 RID: 20979
		public virtual extern int IMsRdpClient6_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x060051F6 RID: 20982
		// (set) Token: 0x060051F5 RID: 20981
		public virtual extern int IMsRdpClient6_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x060051F7 RID: 20983
		public virtual extern int IMsRdpClient6_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x060051F8 RID: 20984
		public virtual extern int IMsRdpClient6_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FE4 RID: 8164
		// (set) Token: 0x060051F9 RID: 20985
		public virtual extern string IMsRdpClient6_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x060051FA RID: 20986
		public virtual extern int IMsRdpClient6_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x060051FB RID: 20987
		public virtual extern string IMsRdpClient6_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x060051FC RID: 20988
		public virtual extern int IMsRdpClient6_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x060051FD RID: 20989
		public virtual extern IMsTscSecuredSettings IMsRdpClient6_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x060051FE RID: 20990
		public virtual extern IMsTscAdvancedSettings IMsRdpClient6_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x060051FF RID: 20991
		public virtual extern IMsTscDebug IMsRdpClient6_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005200 RID: 20992
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Connect();

		// Token: 0x06005201 RID: 20993
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Disconnect();

		// Token: 0x06005202 RID: 20994
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06005203 RID: 20995
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06005205 RID: 20997
		// (set) Token: 0x06005204 RID: 20996
		public virtual extern int IMsRdpClient6_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06005206 RID: 20998
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient6_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06005207 RID: 20999
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient6_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06005208 RID: 21000
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient6_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x0600520A RID: 21002
		// (set) Token: 0x06005209 RID: 21001
		public virtual extern bool IMsRdpClient6_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600520B RID: 21003
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600520C RID: 21004
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient6_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600520D RID: 21005
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient6_RequestClose();

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x0600520E RID: 21006
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient6_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06005210 RID: 21008
		// (set) Token: 0x0600520F RID: 21007
		public virtual extern string IMsRdpClient6_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06005211 RID: 21009
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient6_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06005212 RID: 21010
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient6_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06005213 RID: 21011
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient6_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06005214 RID: 21012
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient6_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005215 RID: 21013
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient6_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06005216 RID: 21014
		public virtual extern ITSRemoteProgram IMsRdpClient6_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06005217 RID: 21015
		public virtual extern IMsRdpClientShell IMsRdpClient6_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06005218 RID: 21016
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient6_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06005219 RID: 21017
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient6_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x0600521B RID: 21019
		// (set) Token: 0x0600521A RID: 21018
		public virtual extern string IMsRdpClient5_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x0600521D RID: 21021
		// (set) Token: 0x0600521C RID: 21020
		public virtual extern string IMsRdpClient5_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x0600521F RID: 21023
		// (set) Token: 0x0600521E RID: 21022
		public virtual extern string IMsRdpClient5_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06005221 RID: 21025
		// (set) Token: 0x06005220 RID: 21024
		public virtual extern string IMsRdpClient5_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06005223 RID: 21027
		// (set) Token: 0x06005222 RID: 21026
		public virtual extern string IMsRdpClient5_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06005224 RID: 21028
		public virtual extern short IMsRdpClient5_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06005226 RID: 21030
		// (set) Token: 0x06005225 RID: 21029
		public virtual extern int IMsRdpClient5_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06005228 RID: 21032
		// (set) Token: 0x06005227 RID: 21031
		public virtual extern int IMsRdpClient5_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x0600522A RID: 21034
		// (set) Token: 0x06005229 RID: 21033
		public virtual extern int IMsRdpClient5_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x0600522B RID: 21035
		public virtual extern int IMsRdpClient5_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x0600522C RID: 21036
		public virtual extern int IMsRdpClient5_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002005 RID: 8197
		// (set) Token: 0x0600522D RID: 21037
		public virtual extern string IMsRdpClient5_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x0600522E RID: 21038
		public virtual extern int IMsRdpClient5_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x0600522F RID: 21039
		public virtual extern string IMsRdpClient5_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06005230 RID: 21040
		public virtual extern int IMsRdpClient5_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06005231 RID: 21041
		public virtual extern IMsTscSecuredSettings IMsRdpClient5_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06005232 RID: 21042
		public virtual extern IMsTscAdvancedSettings IMsRdpClient5_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06005233 RID: 21043
		public virtual extern IMsTscDebug IMsRdpClient5_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005234 RID: 21044
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Connect();

		// Token: 0x06005235 RID: 21045
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Disconnect();

		// Token: 0x06005236 RID: 21046
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06005237 RID: 21047
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06005239 RID: 21049
		// (set) Token: 0x06005238 RID: 21048
		public virtual extern int IMsRdpClient5_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x0600523A RID: 21050
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient5_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x0600523B RID: 21051
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient5_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x0600523C RID: 21052
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient5_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x0600523E RID: 21054
		// (set) Token: 0x0600523D RID: 21053
		public virtual extern bool IMsRdpClient5_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600523F RID: 21055
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06005240 RID: 21056
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient5_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06005241 RID: 21057
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient5_RequestClose();

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06005242 RID: 21058
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient5_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06005244 RID: 21060
		// (set) Token: 0x06005243 RID: 21059
		public virtual extern string IMsRdpClient5_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06005245 RID: 21061
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient5_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06005246 RID: 21062
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient5_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06005247 RID: 21063
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient5_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06005248 RID: 21064
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient5_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005249 RID: 21065
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient5_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x0600524A RID: 21066
		public virtual extern ITSRemoteProgram IMsRdpClient5_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x0600524B RID: 21067
		public virtual extern IMsRdpClientShell IMsRdpClient5_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x0600524D RID: 21069
		// (set) Token: 0x0600524C RID: 21068
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x0600524F RID: 21071
		// (set) Token: 0x0600524E RID: 21070
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06005251 RID: 21073
		// (set) Token: 0x06005250 RID: 21072
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06005253 RID: 21075
		// (set) Token: 0x06005252 RID: 21074
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06005255 RID: 21077
		// (set) Token: 0x06005254 RID: 21076
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06005256 RID: 21078
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06005258 RID: 21080
		// (set) Token: 0x06005257 RID: 21079
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600525A RID: 21082
		// (set) Token: 0x06005259 RID: 21081
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600525C RID: 21084
		// (set) Token: 0x0600525B RID: 21083
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x0600525D RID: 21085
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x0600525E RID: 21086
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002024 RID: 8228
		// (set) Token: 0x0600525F RID: 21087
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06005260 RID: 21088
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06005261 RID: 21089
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06005262 RID: 21090
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06005263 RID: 21091
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06005264 RID: 21092
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06005265 RID: 21093
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005266 RID: 21094
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x06005267 RID: 21095
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x06005268 RID: 21096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06005269 RID: 21097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x0600526B RID: 21099
		// (set) Token: 0x0600526A RID: 21098
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x0600526C RID: 21100
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x0600526D RID: 21101
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x0600526E RID: 21102
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06005270 RID: 21104
		// (set) Token: 0x0600526F RID: 21103
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005271 RID: 21105
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06005272 RID: 21106
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06005273 RID: 21107
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06005274 RID: 21108
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06005276 RID: 21110
		// (set) Token: 0x06005275 RID: 21109
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06005277 RID: 21111
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06005278 RID: 21112
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x0600527A RID: 21114
		// (set) Token: 0x06005279 RID: 21113
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x0600527C RID: 21116
		// (set) Token: 0x0600527B RID: 21115
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x0600527E RID: 21118
		// (set) Token: 0x0600527D RID: 21117
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06005280 RID: 21120
		// (set) Token: 0x0600527F RID: 21119
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06005282 RID: 21122
		// (set) Token: 0x06005281 RID: 21121
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06005283 RID: 21123
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06005285 RID: 21125
		// (set) Token: 0x06005284 RID: 21124
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06005287 RID: 21127
		// (set) Token: 0x06005286 RID: 21126
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06005289 RID: 21129
		// (set) Token: 0x06005288 RID: 21128
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600528A RID: 21130
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600528B RID: 21131
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700203F RID: 8255
		// (set) Token: 0x0600528C RID: 21132
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600528D RID: 21133
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600528E RID: 21134
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600528F RID: 21135
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06005290 RID: 21136
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06005291 RID: 21137
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06005292 RID: 21138
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005293 RID: 21139
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x06005294 RID: 21140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x06005295 RID: 21141
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06005296 RID: 21142
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x06005298 RID: 21144
		// (set) Token: 0x06005297 RID: 21143
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x06005299 RID: 21145
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x0600529A RID: 21146
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x0600529B RID: 21147
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x0600529D RID: 21149
		// (set) Token: 0x0600529C RID: 21148
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600529E RID: 21150
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600529F RID: 21151
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060052A0 RID: 21152
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x060052A1 RID: 21153
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x060052A3 RID: 21155
		// (set) Token: 0x060052A2 RID: 21154
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x060052A4 RID: 21156
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x060052A6 RID: 21158
		// (set) Token: 0x060052A5 RID: 21157
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x060052A8 RID: 21160
		// (set) Token: 0x060052A7 RID: 21159
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x060052AA RID: 21162
		// (set) Token: 0x060052A9 RID: 21161
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x060052AC RID: 21164
		// (set) Token: 0x060052AB RID: 21163
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x060052AE RID: 21166
		// (set) Token: 0x060052AD RID: 21165
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x060052AF RID: 21167
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x060052B1 RID: 21169
		// (set) Token: 0x060052B0 RID: 21168
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x060052B3 RID: 21171
		// (set) Token: 0x060052B2 RID: 21170
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x060052B5 RID: 21173
		// (set) Token: 0x060052B4 RID: 21172
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x060052B6 RID: 21174
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x060052B7 RID: 21175
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002059 RID: 8281
		// (set) Token: 0x060052B8 RID: 21176
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x060052B9 RID: 21177
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x060052BA RID: 21178
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x060052BB RID: 21179
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x060052BC RID: 21180
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x060052BD RID: 21181
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x060052BE RID: 21182
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060052BF RID: 21183
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x060052C0 RID: 21184
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x060052C1 RID: 21185
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060052C2 RID: 21186
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x060052C4 RID: 21188
		// (set) Token: 0x060052C3 RID: 21187
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x060052C5 RID: 21189
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x060052C6 RID: 21190
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x060052C7 RID: 21191
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x060052C9 RID: 21193
		// (set) Token: 0x060052C8 RID: 21192
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060052CA RID: 21194
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060052CB RID: 21195
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060052CC RID: 21196
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x060052CD RID: 21197
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x060052CF RID: 21199
		// (set) Token: 0x060052CE RID: 21198
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x060052D1 RID: 21201
		// (set) Token: 0x060052D0 RID: 21200
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x060052D3 RID: 21203
		// (set) Token: 0x060052D2 RID: 21202
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x060052D5 RID: 21205
		// (set) Token: 0x060052D4 RID: 21204
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x060052D7 RID: 21207
		// (set) Token: 0x060052D6 RID: 21206
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x060052D9 RID: 21209
		// (set) Token: 0x060052D8 RID: 21208
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x060052DA RID: 21210
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x060052DC RID: 21212
		// (set) Token: 0x060052DB RID: 21211
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x060052DE RID: 21214
		// (set) Token: 0x060052DD RID: 21213
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x060052E0 RID: 21216
		// (set) Token: 0x060052DF RID: 21215
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x060052E1 RID: 21217
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x060052E2 RID: 21218
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002072 RID: 8306
		// (set) Token: 0x060052E3 RID: 21219
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x060052E4 RID: 21220
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x060052E5 RID: 21221
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x060052E6 RID: 21222
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x060052E7 RID: 21223
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x060052E8 RID: 21224
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x060052E9 RID: 21225
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060052EA RID: 21226
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x060052EB RID: 21227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x060052EC RID: 21228
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060052ED RID: 21229
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x060052EF RID: 21231
		// (set) Token: 0x060052EE RID: 21230
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x060052F0 RID: 21232
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x060052F1 RID: 21233
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x060052F2 RID: 21234
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x060052F4 RID: 21236
		// (set) Token: 0x060052F3 RID: 21235
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060052F5 RID: 21237
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060052F6 RID: 21238
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060052F7 RID: 21239
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x060052F9 RID: 21241
		// (set) Token: 0x060052F8 RID: 21240
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x060052FB RID: 21243
		// (set) Token: 0x060052FA RID: 21242
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x060052FD RID: 21245
		// (set) Token: 0x060052FC RID: 21244
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x060052FF RID: 21247
		// (set) Token: 0x060052FE RID: 21246
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06005301 RID: 21249
		// (set) Token: 0x06005300 RID: 21248
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06005302 RID: 21250
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06005304 RID: 21252
		// (set) Token: 0x06005303 RID: 21251
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06005306 RID: 21254
		// (set) Token: 0x06005305 RID: 21253
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06005308 RID: 21256
		// (set) Token: 0x06005307 RID: 21255
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06005309 RID: 21257
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0600530A RID: 21258
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002089 RID: 8329
		// (set) Token: 0x0600530B RID: 21259
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x0600530C RID: 21260
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x0600530D RID: 21261
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x0600530E RID: 21262
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x0600530F RID: 21263
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06005310 RID: 21264
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06005311 RID: 21265
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005312 RID: 21266
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06005313 RID: 21267
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06005314 RID: 21268
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06005315 RID: 21269
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17002090 RID: 8336
		// (set) Token: 0x06005316 RID: 21270
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06005318 RID: 21272
		// (set) Token: 0x06005317 RID: 21271
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x0600531A RID: 21274
		// (set) Token: 0x06005319 RID: 21273
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x0600531C RID: 21276
		// (set) Token: 0x0600531B RID: 21275
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x0600531E RID: 21278
		// (set) Token: 0x0600531D RID: 21277
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600531F RID: 21279
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17002095 RID: 8341
		// (set) Token: 0x06005320 RID: 21280
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06005322 RID: 21282
		// (set) Token: 0x06005321 RID: 21281
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06005324 RID: 21284
		// (set) Token: 0x06005323 RID: 21283
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06005326 RID: 21286
		// (set) Token: 0x06005325 RID: 21285
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06005328 RID: 21288
		// (set) Token: 0x06005327 RID: 21287
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06005329 RID: 21289
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x0600532A RID: 21290
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600532B RID: 21291
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x1700209A RID: 8346
		// (set) Token: 0x0600532C RID: 21292
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x0600532E RID: 21294
		// (set) Token: 0x0600532D RID: 21293
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06005330 RID: 21296
		// (set) Token: 0x0600532F RID: 21295
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06005332 RID: 21298
		// (set) Token: 0x06005331 RID: 21297
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06005334 RID: 21300
		// (set) Token: 0x06005333 RID: 21299
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06005335 RID: 21301
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06005336 RID: 21302
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06005337 RID: 21303
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06005339 RID: 21305
		// (set) Token: 0x06005338 RID: 21304
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170020A0 RID: 8352
		// (set) Token: 0x0600533A RID: 21306
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600533C RID: 21308
		// (set) Token: 0x0600533B RID: 21307
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x0600533E RID: 21310
		// (set) Token: 0x0600533D RID: 21309
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06005340 RID: 21312
		// (set) Token: 0x0600533F RID: 21311
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06005342 RID: 21314
		// (set) Token: 0x06005341 RID: 21313
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06005343 RID: 21315
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x06005344 RID: 21316
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06005345 RID: 21317
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06005347 RID: 21319
		// (set) Token: 0x06005346 RID: 21318
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06005349 RID: 21321
		// (set) Token: 0x06005348 RID: 21320
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600534B RID: 21323
		// (set) Token: 0x0600534A RID: 21322
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x0600534D RID: 21325
		// (set) Token: 0x0600534C RID: 21324
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x0600534F RID: 21327
		// (set) Token: 0x0600534E RID: 21326
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06005351 RID: 21329
		// (set) Token: 0x06005350 RID: 21328
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06005353 RID: 21331
		// (set) Token: 0x06005352 RID: 21330
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06005354 RID: 21332
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06005355 RID: 21333
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06005357 RID: 21335
		// (set) Token: 0x06005356 RID: 21334
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06005359 RID: 21337
		// (set) Token: 0x06005358 RID: 21336
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x0600535B RID: 21339
		// (set) Token: 0x0600535A RID: 21338
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020B1 RID: 8369
		// (set) Token: 0x0600535C RID: 21340
		public virtual extern string IMsRdpClientNonScriptable4_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600535E RID: 21342
		// (set) Token: 0x0600535D RID: 21341
		public virtual extern string IMsRdpClientNonScriptable4_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06005360 RID: 21344
		// (set) Token: 0x0600535F RID: 21343
		public virtual extern string IMsRdpClientNonScriptable4_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06005362 RID: 21346
		// (set) Token: 0x06005361 RID: 21345
		public virtual extern string IMsRdpClientNonScriptable4_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06005364 RID: 21348
		// (set) Token: 0x06005363 RID: 21347
		public virtual extern string IMsRdpClientNonScriptable4_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06005365 RID: 21349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_ResetPassword();

		// Token: 0x06005366 RID: 21350
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06005367 RID: 21351
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06005369 RID: 21353
		// (set) Token: 0x06005368 RID: 21352
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable4_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x0600536B RID: 21355
		// (set) Token: 0x0600536A RID: 21354
		public virtual extern bool IMsRdpClientNonScriptable4_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x0600536D RID: 21357
		// (set) Token: 0x0600536C RID: 21356
		public virtual extern bool IMsRdpClientNonScriptable4_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x0600536F RID: 21359
		// (set) Token: 0x0600536E RID: 21358
		public virtual extern bool IMsRdpClientNonScriptable4_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06005371 RID: 21361
		// (set) Token: 0x06005370 RID: 21360
		public virtual extern bool IMsRdpClientNonScriptable4_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06005373 RID: 21363
		// (set) Token: 0x06005372 RID: 21362
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06005375 RID: 21365
		// (set) Token: 0x06005374 RID: 21364
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06005376 RID: 21366
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable4_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06005377 RID: 21367
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable4_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06005379 RID: 21369
		// (set) Token: 0x06005378 RID: 21368
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600537B RID: 21371
		// (set) Token: 0x0600537A RID: 21370
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600537D RID: 21373
		// (set) Token: 0x0600537C RID: 21372
		public virtual extern string IMsRdpClientNonScriptable4_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x0600537F RID: 21375
		// (set) Token: 0x0600537E RID: 21374
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06005381 RID: 21377
		// (set) Token: 0x06005380 RID: 21376
		public virtual extern bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06005383 RID: 21379
		// (set) Token: 0x06005382 RID: 21378
		public virtual extern object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06005385 RID: 21381
		// (set) Token: 0x06005384 RID: 21380
		public virtual extern bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06005387 RID: 21383
		// (set) Token: 0x06005386 RID: 21382
		public virtual extern bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06005389 RID: 21385
		// (set) Token: 0x06005388 RID: 21384
		public virtual extern bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x0600538B RID: 21387
		// (set) Token: 0x0600538A RID: 21386
		public virtual extern bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x0600538D RID: 21389
		// (set) Token: 0x0600538C RID: 21388
		public virtual extern bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020CA RID: 8394
		// (set) Token: 0x0600538E RID: 21390
		public virtual extern string IMsRdpClientNonScriptable5_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06005390 RID: 21392
		// (set) Token: 0x0600538F RID: 21391
		public virtual extern string IMsRdpClientNonScriptable5_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06005392 RID: 21394
		// (set) Token: 0x06005391 RID: 21393
		public virtual extern string IMsRdpClientNonScriptable5_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06005394 RID: 21396
		// (set) Token: 0x06005393 RID: 21395
		public virtual extern string IMsRdpClientNonScriptable5_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06005396 RID: 21398
		// (set) Token: 0x06005395 RID: 21397
		public virtual extern string IMsRdpClientNonScriptable5_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06005397 RID: 21399
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_ResetPassword();

		// Token: 0x06005398 RID: 21400
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06005399 RID: 21401
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x0600539B RID: 21403
		// (set) Token: 0x0600539A RID: 21402
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable5_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x0600539D RID: 21405
		// (set) Token: 0x0600539C RID: 21404
		public virtual extern bool IMsRdpClientNonScriptable5_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x0600539F RID: 21407
		// (set) Token: 0x0600539E RID: 21406
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x060053A1 RID: 21409
		// (set) Token: 0x060053A0 RID: 21408
		public virtual extern bool IMsRdpClientNonScriptable5_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x060053A3 RID: 21411
		// (set) Token: 0x060053A2 RID: 21410
		public virtual extern bool IMsRdpClientNonScriptable5_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x060053A5 RID: 21413
		// (set) Token: 0x060053A4 RID: 21412
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x060053A7 RID: 21415
		// (set) Token: 0x060053A6 RID: 21414
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x060053A8 RID: 21416
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable5_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x060053A9 RID: 21417
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable5_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x060053AB RID: 21419
		// (set) Token: 0x060053AA RID: 21418
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x060053AD RID: 21421
		// (set) Token: 0x060053AC RID: 21420
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x060053AF RID: 21423
		// (set) Token: 0x060053AE RID: 21422
		public virtual extern string IMsRdpClientNonScriptable5_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x060053B1 RID: 21425
		// (set) Token: 0x060053B0 RID: 21424
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable5_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x060053B3 RID: 21427
		// (set) Token: 0x060053B2 RID: 21426
		public virtual extern bool IMsRdpClientNonScriptable5_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x060053B5 RID: 21429
		// (set) Token: 0x060053B4 RID: 21428
		public virtual extern object IMsRdpClientNonScriptable5_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x060053B7 RID: 21431
		// (set) Token: 0x060053B6 RID: 21430
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x060053B9 RID: 21433
		// (set) Token: 0x060053B8 RID: 21432
		public virtual extern bool IMsRdpClientNonScriptable5_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x060053BB RID: 21435
		// (set) Token: 0x060053BA RID: 21434
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x060053BD RID: 21437
		// (set) Token: 0x060053BC RID: 21436
		public virtual extern bool IMsRdpClientNonScriptable5_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x060053BF RID: 21439
		// (set) Token: 0x060053BE RID: 21438
		public virtual extern bool IMsRdpClientNonScriptable5_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x060053C1 RID: 21441
		// (set) Token: 0x060053C0 RID: 21440
		public virtual extern bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x060053C2 RID: 21442
		public virtual extern uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060053C3 RID: 21443
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x060053C4 RID: 21444
		public virtual extern bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170020E6 RID: 8422
		// (set) Token: 0x060053C5 RID: 21445
		public virtual extern bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x060053C7 RID: 21447
		// (set) Token: 0x060053C6 RID: 21446
		public virtual extern bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x060053C9 RID: 21449
		// (set) Token: 0x060053C8 RID: 21448
		public virtual extern bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x060053CB RID: 21451
		// (set) Token: 0x060053CA RID: 21450
		public virtual extern bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020EA RID: 8426
		// (set) Token: 0x060053CC RID: 21452
		public virtual extern string IMsRdpClientNonScriptable6_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x060053CE RID: 21454
		// (set) Token: 0x060053CD RID: 21453
		public virtual extern string IMsRdpClientNonScriptable6_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x060053D0 RID: 21456
		// (set) Token: 0x060053CF RID: 21455
		public virtual extern string IMsRdpClientNonScriptable6_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x060053D2 RID: 21458
		// (set) Token: 0x060053D1 RID: 21457
		public virtual extern string IMsRdpClientNonScriptable6_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x060053D4 RID: 21460
		// (set) Token: 0x060053D3 RID: 21459
		public virtual extern string IMsRdpClientNonScriptable6_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060053D5 RID: 21461
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable6_ResetPassword();

		// Token: 0x060053D6 RID: 21462
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable6_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060053D7 RID: 21463
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable6_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x060053D9 RID: 21465
		// (set) Token: 0x060053D8 RID: 21464
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable6_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x060053DB RID: 21467
		// (set) Token: 0x060053DA RID: 21466
		public virtual extern bool IMsRdpClientNonScriptable6_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x060053DD RID: 21469
		// (set) Token: 0x060053DC RID: 21468
		public virtual extern bool IMsRdpClientNonScriptable6_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x060053DF RID: 21471
		// (set) Token: 0x060053DE RID: 21470
		public virtual extern bool IMsRdpClientNonScriptable6_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x060053E1 RID: 21473
		// (set) Token: 0x060053E0 RID: 21472
		public virtual extern bool IMsRdpClientNonScriptable6_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x060053E3 RID: 21475
		// (set) Token: 0x060053E2 RID: 21474
		public virtual extern bool IMsRdpClientNonScriptable6_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x060053E5 RID: 21477
		// (set) Token: 0x060053E4 RID: 21476
		public virtual extern bool IMsRdpClientNonScriptable6_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x060053E6 RID: 21478
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable6_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x060053E7 RID: 21479
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable6_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x060053E9 RID: 21481
		// (set) Token: 0x060053E8 RID: 21480
		public virtual extern bool IMsRdpClientNonScriptable6_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x060053EB RID: 21483
		// (set) Token: 0x060053EA RID: 21482
		public virtual extern bool IMsRdpClientNonScriptable6_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x060053ED RID: 21485
		// (set) Token: 0x060053EC RID: 21484
		public virtual extern string IMsRdpClientNonScriptable6_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x060053EF RID: 21487
		// (set) Token: 0x060053EE RID: 21486
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable6_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x060053F1 RID: 21489
		// (set) Token: 0x060053F0 RID: 21488
		public virtual extern bool IMsRdpClientNonScriptable6_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x060053F3 RID: 21491
		// (set) Token: 0x060053F2 RID: 21490
		public virtual extern object IMsRdpClientNonScriptable6_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x060053F5 RID: 21493
		// (set) Token: 0x060053F4 RID: 21492
		public virtual extern bool IMsRdpClientNonScriptable6_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x060053F7 RID: 21495
		// (set) Token: 0x060053F6 RID: 21494
		public virtual extern bool IMsRdpClientNonScriptable6_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x060053F9 RID: 21497
		// (set) Token: 0x060053F8 RID: 21496
		public virtual extern bool IMsRdpClientNonScriptable6_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x060053FB RID: 21499
		// (set) Token: 0x060053FA RID: 21498
		public virtual extern bool IMsRdpClientNonScriptable6_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x060053FD RID: 21501
		// (set) Token: 0x060053FC RID: 21500
		public virtual extern bool IMsRdpClientNonScriptable6_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x060053FF RID: 21503
		// (set) Token: 0x060053FE RID: 21502
		public virtual extern bool IMsRdpClientNonScriptable6_UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06005400 RID: 21504
		public virtual extern uint IMsRdpClientNonScriptable6_RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06005401 RID: 21505
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable6_GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06005402 RID: 21506
		public virtual extern bool IMsRdpClientNonScriptable6_RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002106 RID: 8454
		// (set) Token: 0x06005403 RID: 21507
		public virtual extern bool IMsRdpClientNonScriptable6_DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06005405 RID: 21509
		// (set) Token: 0x06005404 RID: 21508
		public virtual extern bool IMsRdpClientNonScriptable6_DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06005407 RID: 21511
		// (set) Token: 0x06005406 RID: 21510
		public virtual extern bool IMsRdpClientNonScriptable6_WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06005409 RID: 21513
		// (set) Token: 0x06005408 RID: 21512
		public virtual extern bool IMsRdpClientNonScriptable6_AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600540A RID: 21514
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendLocation2D([In] double latitude, [In] double longitude);

		// Token: 0x0600540B RID: 21515
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendLocation3D([In] double latitude, [In] double longitude, [In] int altitude);

		// Token: 0x1700210A RID: 8458
		// (set) Token: 0x0600540C RID: 21516
		public virtual extern string IMsRdpClientNonScriptable7_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x0600540E RID: 21518
		// (set) Token: 0x0600540D RID: 21517
		public virtual extern string IMsRdpClientNonScriptable7_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06005410 RID: 21520
		// (set) Token: 0x0600540F RID: 21519
		public virtual extern string IMsRdpClientNonScriptable7_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06005412 RID: 21522
		// (set) Token: 0x06005411 RID: 21521
		public virtual extern string IMsRdpClientNonScriptable7_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06005414 RID: 21524
		// (set) Token: 0x06005413 RID: 21523
		public virtual extern string IMsRdpClientNonScriptable7_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06005415 RID: 21525
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_ResetPassword();

		// Token: 0x06005416 RID: 21526
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06005417 RID: 21527
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06005419 RID: 21529
		// (set) Token: 0x06005418 RID: 21528
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable7_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x0600541B RID: 21531
		// (set) Token: 0x0600541A RID: 21530
		public virtual extern bool IMsRdpClientNonScriptable7_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x0600541D RID: 21533
		// (set) Token: 0x0600541C RID: 21532
		public virtual extern bool IMsRdpClientNonScriptable7_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x0600541F RID: 21535
		// (set) Token: 0x0600541E RID: 21534
		public virtual extern bool IMsRdpClientNonScriptable7_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06005421 RID: 21537
		// (set) Token: 0x06005420 RID: 21536
		public virtual extern bool IMsRdpClientNonScriptable7_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06005423 RID: 21539
		// (set) Token: 0x06005422 RID: 21538
		public virtual extern bool IMsRdpClientNonScriptable7_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06005425 RID: 21541
		// (set) Token: 0x06005424 RID: 21540
		public virtual extern bool IMsRdpClientNonScriptable7_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06005426 RID: 21542
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable7_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06005427 RID: 21543
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable7_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06005429 RID: 21545
		// (set) Token: 0x06005428 RID: 21544
		public virtual extern bool IMsRdpClientNonScriptable7_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x0600542B RID: 21547
		// (set) Token: 0x0600542A RID: 21546
		public virtual extern bool IMsRdpClientNonScriptable7_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x0600542D RID: 21549
		// (set) Token: 0x0600542C RID: 21548
		public virtual extern string IMsRdpClientNonScriptable7_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x0600542F RID: 21551
		// (set) Token: 0x0600542E RID: 21550
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable7_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06005431 RID: 21553
		// (set) Token: 0x06005430 RID: 21552
		public virtual extern bool IMsRdpClientNonScriptable7_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x06005433 RID: 21555
		// (set) Token: 0x06005432 RID: 21554
		public virtual extern object IMsRdpClientNonScriptable7_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x06005435 RID: 21557
		// (set) Token: 0x06005434 RID: 21556
		public virtual extern bool IMsRdpClientNonScriptable7_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06005437 RID: 21559
		// (set) Token: 0x06005436 RID: 21558
		public virtual extern bool IMsRdpClientNonScriptable7_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06005439 RID: 21561
		// (set) Token: 0x06005438 RID: 21560
		public virtual extern bool IMsRdpClientNonScriptable7_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x0600543B RID: 21563
		// (set) Token: 0x0600543A RID: 21562
		public virtual extern bool IMsRdpClientNonScriptable7_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x0600543D RID: 21565
		// (set) Token: 0x0600543C RID: 21564
		public virtual extern bool IMsRdpClientNonScriptable7_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x0600543F RID: 21567
		// (set) Token: 0x0600543E RID: 21566
		public virtual extern bool IMsRdpClientNonScriptable7_UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06005440 RID: 21568
		public virtual extern uint IMsRdpClientNonScriptable7_RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06005441 RID: 21569
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06005442 RID: 21570
		public virtual extern bool IMsRdpClientNonScriptable7_RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17002126 RID: 8486
		// (set) Token: 0x06005443 RID: 21571
		public virtual extern bool IMsRdpClientNonScriptable7_DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06005445 RID: 21573
		// (set) Token: 0x06005444 RID: 21572
		public virtual extern bool IMsRdpClientNonScriptable7_DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06005447 RID: 21575
		// (set) Token: 0x06005446 RID: 21574
		public virtual extern bool IMsRdpClientNonScriptable7_WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06005449 RID: 21577
		// (set) Token: 0x06005448 RID: 21576
		public virtual extern bool IMsRdpClientNonScriptable7_AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600544A RID: 21578
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_SendLocation2D([In] double latitude, [In] double longitude);

		// Token: 0x0600544B RID: 21579
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable7_SendLocation3D([In] double latitude, [In] double longitude, [In] int altitude);

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600544C RID: 21580
		public virtual extern IMsRdpCameraRedirConfigCollection CameraRedirConfigCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600544D RID: 21581
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void DisableDpiCursorScalingForProcess();

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600544E RID: 21582
		public virtual extern IMsRdpClipboard Clipboard { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06005450 RID: 21584
		// (set) Token: 0x0600544F RID: 21583
		public virtual extern bool UseRedirectionServerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x14000697 RID: 1687
		// (add) Token: 0x06005451 RID: 21585
		// (remove) Token: 0x06005452 RID: 21586
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000698 RID: 1688
		// (add) Token: 0x06005453 RID: 21587
		// (remove) Token: 0x06005454 RID: 21588
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000699 RID: 1689
		// (add) Token: 0x06005455 RID: 21589
		// (remove) Token: 0x06005456 RID: 21590
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400069A RID: 1690
		// (add) Token: 0x06005457 RID: 21591
		// (remove) Token: 0x06005458 RID: 21592
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400069B RID: 1691
		// (add) Token: 0x06005459 RID: 21593
		// (remove) Token: 0x0600545A RID: 21594
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400069C RID: 1692
		// (add) Token: 0x0600545B RID: 21595
		// (remove) Token: 0x0600545C RID: 21596
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400069D RID: 1693
		// (add) Token: 0x0600545D RID: 21597
		// (remove) Token: 0x0600545E RID: 21598
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400069E RID: 1694
		// (add) Token: 0x0600545F RID: 21599
		// (remove) Token: 0x06005460 RID: 21600
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400069F RID: 1695
		// (add) Token: 0x06005461 RID: 21601
		// (remove) Token: 0x06005462 RID: 21602
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x140006A0 RID: 1696
		// (add) Token: 0x06005463 RID: 21603
		// (remove) Token: 0x06005464 RID: 21604
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140006A1 RID: 1697
		// (add) Token: 0x06005465 RID: 21605
		// (remove) Token: 0x06005466 RID: 21606
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140006A2 RID: 1698
		// (add) Token: 0x06005467 RID: 21607
		// (remove) Token: 0x06005468 RID: 21608
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140006A3 RID: 1699
		// (add) Token: 0x06005469 RID: 21609
		// (remove) Token: 0x0600546A RID: 21610
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x140006A4 RID: 1700
		// (add) Token: 0x0600546B RID: 21611
		// (remove) Token: 0x0600546C RID: 21612
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x140006A5 RID: 1701
		// (add) Token: 0x0600546D RID: 21613
		// (remove) Token: 0x0600546E RID: 21614
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140006A6 RID: 1702
		// (add) Token: 0x0600546F RID: 21615
		// (remove) Token: 0x06005470 RID: 21616
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140006A7 RID: 1703
		// (add) Token: 0x06005471 RID: 21617
		// (remove) Token: 0x06005472 RID: 21618
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140006A8 RID: 1704
		// (add) Token: 0x06005473 RID: 21619
		// (remove) Token: 0x06005474 RID: 21620
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140006A9 RID: 1705
		// (add) Token: 0x06005475 RID: 21621
		// (remove) Token: 0x06005476 RID: 21622
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140006AA RID: 1706
		// (add) Token: 0x06005477 RID: 21623
		// (remove) Token: 0x06005478 RID: 21624
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140006AB RID: 1707
		// (add) Token: 0x06005479 RID: 21625
		// (remove) Token: 0x0600547A RID: 21626
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140006AC RID: 1708
		// (add) Token: 0x0600547B RID: 21627
		// (remove) Token: 0x0600547C RID: 21628
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140006AD RID: 1709
		// (add) Token: 0x0600547D RID: 21629
		// (remove) Token: 0x0600547E RID: 21630
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140006AE RID: 1710
		// (add) Token: 0x0600547F RID: 21631
		// (remove) Token: 0x06005480 RID: 21632
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140006AF RID: 1711
		// (add) Token: 0x06005481 RID: 21633
		// (remove) Token: 0x06005482 RID: 21634
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140006B0 RID: 1712
		// (add) Token: 0x06005483 RID: 21635
		// (remove) Token: 0x06005484 RID: 21636
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140006B1 RID: 1713
		// (add) Token: 0x06005485 RID: 21637
		// (remove) Token: 0x06005486 RID: 21638
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140006B2 RID: 1714
		// (add) Token: 0x06005487 RID: 21639
		// (remove) Token: 0x06005488 RID: 21640
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x140006B3 RID: 1715
		// (add) Token: 0x06005489 RID: 21641
		// (remove) Token: 0x0600548A RID: 21642
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140006B4 RID: 1716
		// (add) Token: 0x0600548B RID: 21643
		// (remove) Token: 0x0600548C RID: 21644
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x140006B5 RID: 1717
		// (add) Token: 0x0600548D RID: 21645
		// (remove) Token: 0x0600548E RID: 21646
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x140006B6 RID: 1718
		// (add) Token: 0x0600548F RID: 21647
		// (remove) Token: 0x06005490 RID: 21648
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
