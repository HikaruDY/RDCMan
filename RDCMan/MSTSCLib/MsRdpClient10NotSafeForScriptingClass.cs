using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001E9 RID: 489
	[Guid("A0C63C30-F08D-4AB4-907C-34905D770C7D")]
	[TypeLibType(2)]
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient10NotSafeForScriptingClass : IMsRdpClient10, MsRdpClient10NotSafeForScripting, IMsTscAxEvents_Event, IMsRdpClient9, IMsRdpClient8, IMsRdpClient7, IMsRdpClient6, IMsRdpClient5, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3, IMsRdpClientNonScriptable4, IMsRdpClientNonScriptable5, IMsRdpPreferredRedirectionInfo, IMsRdpExtendedSettings
	{
		// Token: 0x06004620 RID: 17952
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient10NotSafeForScriptingClass();

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06004622 RID: 17954
		// (set) Token: 0x06004621 RID: 17953
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06004624 RID: 17956
		// (set) Token: 0x06004623 RID: 17955
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06004626 RID: 17958
		// (set) Token: 0x06004625 RID: 17957
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06004628 RID: 17960
		// (set) Token: 0x06004627 RID: 17959
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x0600462A RID: 17962
		// (set) Token: 0x06004629 RID: 17961
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x0600462B RID: 17963
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x0600462D RID: 17965
		// (set) Token: 0x0600462C RID: 17964
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x0600462F RID: 17967
		// (set) Token: 0x0600462E RID: 17966
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06004631 RID: 17969
		// (set) Token: 0x06004630 RID: 17968
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06004632 RID: 17970
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06004633 RID: 17971
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001987 RID: 6535
		// (set) Token: 0x06004634 RID: 17972
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06004635 RID: 17973
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06004636 RID: 17974
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06004637 RID: 17975
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06004638 RID: 17976
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06004639 RID: 17977
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x0600463A RID: 17978
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600463B RID: 17979
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x0600463C RID: 17980
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x0600463D RID: 17981
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600463E RID: 17982
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06004640 RID: 17984
		// (set) Token: 0x0600463F RID: 17983
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06004641 RID: 17985
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06004642 RID: 17986
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06004643 RID: 17987
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06004645 RID: 17989
		// (set) Token: 0x06004644 RID: 17988
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004646 RID: 17990
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004647 RID: 17991
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004648 RID: 17992
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06004649 RID: 17993
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600464B RID: 17995
		// (set) Token: 0x0600464A RID: 17994
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x0600464C RID: 17996
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x0600464D RID: 17997
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600464E RID: 17998
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x0600464F RID: 17999
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004650 RID: 18000
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06004651 RID: 18001
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06004652 RID: 18002
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06004653 RID: 18003
		[DispId(507)]
		public virtual extern IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06004654 RID: 18004
		[DispId(506)]
		public virtual extern IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06004655 RID: 18005
		[DispId(600)]
		public virtual extern IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06004656 RID: 18006
		[DispId(601)]
		public virtual extern IMsRdpClientTransportSettings3 TransportSettings3 { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004657 RID: 18007
		[DispId(602)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetStatusText([In] uint statusCode);

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06004658 RID: 18008
		[DispId(603)]
		public virtual extern IMsRdpClientSecuredSettings2 SecuredSettings3 { [DispId(603)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06004659 RID: 18009
		[DispId(604)]
		public virtual extern ITSRemoteProgram2 RemoteProgram2 { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600465A RID: 18010
		[DispId(700)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x0600465B RID: 18011
		[DispId(701)]
		public virtual extern IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600465C RID: 18012
		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x0600465D RID: 18013
		[DispId(800)]
		public virtual extern IMsRdpClientTransportSettings4 TransportSettings4 { [DispId(800)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600465E RID: 18014
		[DispId(801)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SyncSessionDisplaySettings();

		// Token: 0x0600465F RID: 18015
		[DispId(802)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x06004660 RID: 18016
		[DispId(803)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x06004661 RID: 18017
		[DispId(804)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06004662 RID: 18018
		[DispId(900)]
		public virtual extern ITSRemoteProgram3 RemoteProgram3 { [DispId(900)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06004664 RID: 18020
		// (set) Token: 0x06004663 RID: 18019
		public virtual extern string IMsRdpClient9_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06004666 RID: 18022
		// (set) Token: 0x06004665 RID: 18021
		public virtual extern string IMsRdpClient9_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06004668 RID: 18024
		// (set) Token: 0x06004667 RID: 18023
		public virtual extern string IMsRdpClient9_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x0600466A RID: 18026
		// (set) Token: 0x06004669 RID: 18025
		public virtual extern string IMsRdpClient9_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x0600466C RID: 18028
		// (set) Token: 0x0600466B RID: 18027
		public virtual extern string IMsRdpClient9_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x0600466D RID: 18029
		public virtual extern short IMsRdpClient9_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x0600466F RID: 18031
		// (set) Token: 0x0600466E RID: 18030
		public virtual extern int IMsRdpClient9_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06004671 RID: 18033
		// (set) Token: 0x06004670 RID: 18032
		public virtual extern int IMsRdpClient9_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06004673 RID: 18035
		// (set) Token: 0x06004672 RID: 18034
		public virtual extern int IMsRdpClient9_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06004674 RID: 18036
		public virtual extern int IMsRdpClient9_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06004675 RID: 18037
		public virtual extern int IMsRdpClient9_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019AF RID: 6575
		// (set) Token: 0x06004676 RID: 18038
		public virtual extern string IMsRdpClient9_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06004677 RID: 18039
		public virtual extern int IMsRdpClient9_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06004678 RID: 18040
		public virtual extern string IMsRdpClient9_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06004679 RID: 18041
		public virtual extern int IMsRdpClient9_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x0600467A RID: 18042
		public virtual extern IMsTscSecuredSettings IMsRdpClient9_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x0600467B RID: 18043
		public virtual extern IMsTscAdvancedSettings IMsRdpClient9_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x0600467C RID: 18044
		public virtual extern IMsTscDebug IMsRdpClient9_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600467D RID: 18045
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_Connect();

		// Token: 0x0600467E RID: 18046
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_Disconnect();

		// Token: 0x0600467F RID: 18047
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004680 RID: 18048
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06004682 RID: 18050
		// (set) Token: 0x06004681 RID: 18049
		public virtual extern int IMsRdpClient9_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06004683 RID: 18051
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient9_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06004684 RID: 18052
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient9_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06004685 RID: 18053
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient9_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06004687 RID: 18055
		// (set) Token: 0x06004686 RID: 18054
		public virtual extern bool IMsRdpClient9_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004688 RID: 18056
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004689 RID: 18057
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient9_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600468A RID: 18058
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient9_RequestClose();

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x0600468B RID: 18059
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient9_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x0600468D RID: 18061
		// (set) Token: 0x0600468C RID: 18060
		public virtual extern string IMsRdpClient9_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x0600468E RID: 18062
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient9_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x0600468F RID: 18063
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient9_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06004690 RID: 18064
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient9_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06004691 RID: 18065
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient9_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004692 RID: 18066
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient9_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06004693 RID: 18067
		public virtual extern ITSRemoteProgram IMsRdpClient9_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06004694 RID: 18068
		public virtual extern IMsRdpClientShell IMsRdpClient9_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06004695 RID: 18069
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient9_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06004696 RID: 18070
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient9_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06004697 RID: 18071
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient9_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06004698 RID: 18072
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient9_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004699 RID: 18073
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient9_GetStatusText([In] uint statusCode);

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x0600469A RID: 18074
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient9_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x0600469B RID: 18075
		public virtual extern ITSRemoteProgram2 IMsRdpClient9_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600469C RID: 18076
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0600469D RID: 18077
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient9_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600469E RID: 18078
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient9_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x0600469F RID: 18079
		public virtual extern IMsRdpClientTransportSettings4 IMsRdpClient9_TransportSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060046A0 RID: 18080
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_SyncSessionDisplaySettings();

		// Token: 0x060046A1 RID: 18081
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x060046A2 RID: 18082
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x060046A3 RID: 18083
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient9_detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x060046A5 RID: 18085
		// (set) Token: 0x060046A4 RID: 18084
		public virtual extern string IMsRdpClient8_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x060046A7 RID: 18087
		// (set) Token: 0x060046A6 RID: 18086
		public virtual extern string IMsRdpClient8_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x060046A9 RID: 18089
		// (set) Token: 0x060046A8 RID: 18088
		public virtual extern string IMsRdpClient8_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x060046AB RID: 18091
		// (set) Token: 0x060046AA RID: 18090
		public virtual extern string IMsRdpClient8_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x060046AD RID: 18093
		// (set) Token: 0x060046AC RID: 18092
		public virtual extern string IMsRdpClient8_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x060046AE RID: 18094
		public virtual extern short IMsRdpClient8_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x060046B0 RID: 18096
		// (set) Token: 0x060046AF RID: 18095
		public virtual extern int IMsRdpClient8_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x060046B2 RID: 18098
		// (set) Token: 0x060046B1 RID: 18097
		public virtual extern int IMsRdpClient8_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x060046B4 RID: 18100
		// (set) Token: 0x060046B3 RID: 18099
		public virtual extern int IMsRdpClient8_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x060046B5 RID: 18101
		public virtual extern int IMsRdpClient8_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x060046B6 RID: 18102
		public virtual extern int IMsRdpClient8_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019D6 RID: 6614
		// (set) Token: 0x060046B7 RID: 18103
		public virtual extern string IMsRdpClient8_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x060046B8 RID: 18104
		public virtual extern int IMsRdpClient8_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x060046B9 RID: 18105
		public virtual extern string IMsRdpClient8_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x060046BA RID: 18106
		public virtual extern int IMsRdpClient8_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x060046BB RID: 18107
		public virtual extern IMsTscSecuredSettings IMsRdpClient8_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x060046BC RID: 18108
		public virtual extern IMsTscAdvancedSettings IMsRdpClient8_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x060046BD RID: 18109
		public virtual extern IMsTscDebug IMsRdpClient8_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060046BE RID: 18110
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Connect();

		// Token: 0x060046BF RID: 18111
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Disconnect();

		// Token: 0x060046C0 RID: 18112
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060046C1 RID: 18113
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x060046C3 RID: 18115
		// (set) Token: 0x060046C2 RID: 18114
		public virtual extern int IMsRdpClient8_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x060046C4 RID: 18116
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient8_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x060046C5 RID: 18117
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient8_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x060046C6 RID: 18118
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient8_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x060046C8 RID: 18120
		// (set) Token: 0x060046C7 RID: 18119
		public virtual extern bool IMsRdpClient8_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060046C9 RID: 18121
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060046CA RID: 18122
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient8_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060046CB RID: 18123
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient8_RequestClose();

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x060046CC RID: 18124
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient8_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x060046CE RID: 18126
		// (set) Token: 0x060046CD RID: 18125
		public virtual extern string IMsRdpClient8_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x060046CF RID: 18127
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient8_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x060046D0 RID: 18128
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient8_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x060046D1 RID: 18129
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient8_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x060046D2 RID: 18130
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient8_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060046D3 RID: 18131
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x060046D4 RID: 18132
		public virtual extern ITSRemoteProgram IMsRdpClient8_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x060046D5 RID: 18133
		public virtual extern IMsRdpClientShell IMsRdpClient8_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x060046D6 RID: 18134
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient8_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x060046D7 RID: 18135
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient8_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x060046D8 RID: 18136
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient8_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x060046D9 RID: 18137
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient8_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060046DA RID: 18138
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetStatusText([In] uint statusCode);

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x060046DB RID: 18139
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient8_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x060046DC RID: 18140
		public virtual extern ITSRemoteProgram2 IMsRdpClient8_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060046DD RID: 18141
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x060046DE RID: 18142
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient8_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060046DF RID: 18143
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient8_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x060046E1 RID: 18145
		// (set) Token: 0x060046E0 RID: 18144
		public virtual extern string IMsRdpClient7_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x060046E3 RID: 18147
		// (set) Token: 0x060046E2 RID: 18146
		public virtual extern string IMsRdpClient7_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x060046E5 RID: 18149
		// (set) Token: 0x060046E4 RID: 18148
		public virtual extern string IMsRdpClient7_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x060046E7 RID: 18151
		// (set) Token: 0x060046E6 RID: 18150
		public virtual extern string IMsRdpClient7_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x060046E9 RID: 18153
		// (set) Token: 0x060046E8 RID: 18152
		public virtual extern string IMsRdpClient7_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x060046EA RID: 18154
		public virtual extern short IMsRdpClient7_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x060046EC RID: 18156
		// (set) Token: 0x060046EB RID: 18155
		public virtual extern int IMsRdpClient7_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x060046EE RID: 18158
		// (set) Token: 0x060046ED RID: 18157
		public virtual extern int IMsRdpClient7_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x060046F0 RID: 18160
		// (set) Token: 0x060046EF RID: 18159
		public virtual extern int IMsRdpClient7_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x060046F1 RID: 18161
		public virtual extern int IMsRdpClient7_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x060046F2 RID: 18162
		public virtual extern int IMsRdpClient7_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019FC RID: 6652
		// (set) Token: 0x060046F3 RID: 18163
		public virtual extern string IMsRdpClient7_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x060046F4 RID: 18164
		public virtual extern int IMsRdpClient7_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x060046F5 RID: 18165
		public virtual extern string IMsRdpClient7_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x060046F6 RID: 18166
		public virtual extern int IMsRdpClient7_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x060046F7 RID: 18167
		public virtual extern IMsTscSecuredSettings IMsRdpClient7_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x060046F8 RID: 18168
		public virtual extern IMsTscAdvancedSettings IMsRdpClient7_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x060046F9 RID: 18169
		public virtual extern IMsTscDebug IMsRdpClient7_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060046FA RID: 18170
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Connect();

		// Token: 0x060046FB RID: 18171
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Disconnect();

		// Token: 0x060046FC RID: 18172
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060046FD RID: 18173
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x060046FF RID: 18175
		// (set) Token: 0x060046FE RID: 18174
		public virtual extern int IMsRdpClient7_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06004700 RID: 18176
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient7_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06004701 RID: 18177
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient7_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06004702 RID: 18178
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient7_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06004704 RID: 18180
		// (set) Token: 0x06004703 RID: 18179
		public virtual extern bool IMsRdpClient7_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004705 RID: 18181
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004706 RID: 18182
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient7_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004707 RID: 18183
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient7_RequestClose();

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06004708 RID: 18184
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient7_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x0600470A RID: 18186
		// (set) Token: 0x06004709 RID: 18185
		public virtual extern string IMsRdpClient7_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x0600470B RID: 18187
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient7_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x0600470C RID: 18188
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient7_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x0600470D RID: 18189
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient7_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x0600470E RID: 18190
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient7_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600470F RID: 18191
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06004710 RID: 18192
		public virtual extern ITSRemoteProgram IMsRdpClient7_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06004711 RID: 18193
		public virtual extern IMsRdpClientShell IMsRdpClient7_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06004712 RID: 18194
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient7_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06004713 RID: 18195
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient7_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06004714 RID: 18196
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient7_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06004715 RID: 18197
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient7_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004716 RID: 18198
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetStatusText([In] uint statusCode);

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06004717 RID: 18199
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient7_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06004718 RID: 18200
		public virtual extern ITSRemoteProgram2 IMsRdpClient7_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x0600471A RID: 18202
		// (set) Token: 0x06004719 RID: 18201
		public virtual extern string IMsRdpClient6_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x0600471C RID: 18204
		// (set) Token: 0x0600471B RID: 18203
		public virtual extern string IMsRdpClient6_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x0600471E RID: 18206
		// (set) Token: 0x0600471D RID: 18205
		public virtual extern string IMsRdpClient6_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06004720 RID: 18208
		// (set) Token: 0x0600471F RID: 18207
		public virtual extern string IMsRdpClient6_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06004722 RID: 18210
		// (set) Token: 0x06004721 RID: 18209
		public virtual extern string IMsRdpClient6_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06004723 RID: 18211
		public virtual extern short IMsRdpClient6_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06004725 RID: 18213
		// (set) Token: 0x06004724 RID: 18212
		public virtual extern int IMsRdpClient6_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06004727 RID: 18215
		// (set) Token: 0x06004726 RID: 18214
		public virtual extern int IMsRdpClient6_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06004729 RID: 18217
		// (set) Token: 0x06004728 RID: 18216
		public virtual extern int IMsRdpClient6_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x0600472A RID: 18218
		public virtual extern int IMsRdpClient6_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x0600472B RID: 18219
		public virtual extern int IMsRdpClient6_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A21 RID: 6689
		// (set) Token: 0x0600472C RID: 18220
		public virtual extern string IMsRdpClient6_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x0600472D RID: 18221
		public virtual extern int IMsRdpClient6_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x0600472E RID: 18222
		public virtual extern string IMsRdpClient6_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x0600472F RID: 18223
		public virtual extern int IMsRdpClient6_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06004730 RID: 18224
		public virtual extern IMsTscSecuredSettings IMsRdpClient6_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06004731 RID: 18225
		public virtual extern IMsTscAdvancedSettings IMsRdpClient6_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06004732 RID: 18226
		public virtual extern IMsTscDebug IMsRdpClient6_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004733 RID: 18227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Connect();

		// Token: 0x06004734 RID: 18228
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Disconnect();

		// Token: 0x06004735 RID: 18229
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004736 RID: 18230
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06004738 RID: 18232
		// (set) Token: 0x06004737 RID: 18231
		public virtual extern int IMsRdpClient6_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06004739 RID: 18233
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient6_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x0600473A RID: 18234
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient6_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x0600473B RID: 18235
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient6_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x0600473D RID: 18237
		// (set) Token: 0x0600473C RID: 18236
		public virtual extern bool IMsRdpClient6_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600473E RID: 18238
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600473F RID: 18239
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient6_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004740 RID: 18240
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient6_RequestClose();

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06004741 RID: 18241
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient6_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06004743 RID: 18243
		// (set) Token: 0x06004742 RID: 18242
		public virtual extern string IMsRdpClient6_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06004744 RID: 18244
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient6_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06004745 RID: 18245
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient6_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06004746 RID: 18246
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient6_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06004747 RID: 18247
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient6_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004748 RID: 18248
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient6_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06004749 RID: 18249
		public virtual extern ITSRemoteProgram IMsRdpClient6_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x0600474A RID: 18250
		public virtual extern IMsRdpClientShell IMsRdpClient6_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x0600474B RID: 18251
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient6_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x0600474C RID: 18252
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient6_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600474E RID: 18254
		// (set) Token: 0x0600474D RID: 18253
		public virtual extern string IMsRdpClient5_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06004750 RID: 18256
		// (set) Token: 0x0600474F RID: 18255
		public virtual extern string IMsRdpClient5_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06004752 RID: 18258
		// (set) Token: 0x06004751 RID: 18257
		public virtual extern string IMsRdpClient5_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06004754 RID: 18260
		// (set) Token: 0x06004753 RID: 18259
		public virtual extern string IMsRdpClient5_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06004756 RID: 18262
		// (set) Token: 0x06004755 RID: 18261
		public virtual extern string IMsRdpClient5_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06004757 RID: 18263
		public virtual extern short IMsRdpClient5_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06004759 RID: 18265
		// (set) Token: 0x06004758 RID: 18264
		public virtual extern int IMsRdpClient5_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x0600475B RID: 18267
		// (set) Token: 0x0600475A RID: 18266
		public virtual extern int IMsRdpClient5_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x0600475D RID: 18269
		// (set) Token: 0x0600475C RID: 18268
		public virtual extern int IMsRdpClient5_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x0600475E RID: 18270
		public virtual extern int IMsRdpClient5_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x0600475F RID: 18271
		public virtual extern int IMsRdpClient5_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A42 RID: 6722
		// (set) Token: 0x06004760 RID: 18272
		public virtual extern string IMsRdpClient5_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06004761 RID: 18273
		public virtual extern int IMsRdpClient5_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06004762 RID: 18274
		public virtual extern string IMsRdpClient5_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06004763 RID: 18275
		public virtual extern int IMsRdpClient5_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06004764 RID: 18276
		public virtual extern IMsTscSecuredSettings IMsRdpClient5_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06004765 RID: 18277
		public virtual extern IMsTscAdvancedSettings IMsRdpClient5_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06004766 RID: 18278
		public virtual extern IMsTscDebug IMsRdpClient5_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004767 RID: 18279
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Connect();

		// Token: 0x06004768 RID: 18280
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Disconnect();

		// Token: 0x06004769 RID: 18281
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600476A RID: 18282
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x0600476C RID: 18284
		// (set) Token: 0x0600476B RID: 18283
		public virtual extern int IMsRdpClient5_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x0600476D RID: 18285
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient5_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x0600476E RID: 18286
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient5_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600476F RID: 18287
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient5_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06004771 RID: 18289
		// (set) Token: 0x06004770 RID: 18288
		public virtual extern bool IMsRdpClient5_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004772 RID: 18290
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004773 RID: 18291
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient5_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004774 RID: 18292
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient5_RequestClose();

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06004775 RID: 18293
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient5_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06004777 RID: 18295
		// (set) Token: 0x06004776 RID: 18294
		public virtual extern string IMsRdpClient5_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06004778 RID: 18296
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient5_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06004779 RID: 18297
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient5_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x0600477A RID: 18298
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient5_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x0600477B RID: 18299
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient5_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600477C RID: 18300
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient5_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x0600477D RID: 18301
		public virtual extern ITSRemoteProgram IMsRdpClient5_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x0600477E RID: 18302
		public virtual extern IMsRdpClientShell IMsRdpClient5_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06004780 RID: 18304
		// (set) Token: 0x0600477F RID: 18303
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06004782 RID: 18306
		// (set) Token: 0x06004781 RID: 18305
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06004784 RID: 18308
		// (set) Token: 0x06004783 RID: 18307
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06004786 RID: 18310
		// (set) Token: 0x06004785 RID: 18309
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06004788 RID: 18312
		// (set) Token: 0x06004787 RID: 18311
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06004789 RID: 18313
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x0600478B RID: 18315
		// (set) Token: 0x0600478A RID: 18314
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x0600478D RID: 18317
		// (set) Token: 0x0600478C RID: 18316
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x0600478F RID: 18319
		// (set) Token: 0x0600478E RID: 18318
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06004790 RID: 18320
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06004791 RID: 18321
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A61 RID: 6753
		// (set) Token: 0x06004792 RID: 18322
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06004793 RID: 18323
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06004794 RID: 18324
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06004795 RID: 18325
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06004796 RID: 18326
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06004797 RID: 18327
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06004798 RID: 18328
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004799 RID: 18329
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x0600479A RID: 18330
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x0600479B RID: 18331
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600479C RID: 18332
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x0600479E RID: 18334
		// (set) Token: 0x0600479D RID: 18333
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600479F RID: 18335
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x060047A0 RID: 18336
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x060047A1 RID: 18337
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x060047A3 RID: 18339
		// (set) Token: 0x060047A2 RID: 18338
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060047A4 RID: 18340
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060047A5 RID: 18341
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060047A6 RID: 18342
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x060047A7 RID: 18343
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x060047A9 RID: 18345
		// (set) Token: 0x060047A8 RID: 18344
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x060047AA RID: 18346
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x060047AB RID: 18347
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x060047AD RID: 18349
		// (set) Token: 0x060047AC RID: 18348
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x060047AF RID: 18351
		// (set) Token: 0x060047AE RID: 18350
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x060047B1 RID: 18353
		// (set) Token: 0x060047B0 RID: 18352
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x060047B3 RID: 18355
		// (set) Token: 0x060047B2 RID: 18354
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x060047B5 RID: 18357
		// (set) Token: 0x060047B4 RID: 18356
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x060047B6 RID: 18358
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x060047B8 RID: 18360
		// (set) Token: 0x060047B7 RID: 18359
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x060047BA RID: 18362
		// (set) Token: 0x060047B9 RID: 18361
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x060047BC RID: 18364
		// (set) Token: 0x060047BB RID: 18363
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x060047BD RID: 18365
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x060047BE RID: 18366
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A7C RID: 6780
		// (set) Token: 0x060047BF RID: 18367
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x060047C0 RID: 18368
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x060047C1 RID: 18369
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x060047C2 RID: 18370
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x060047C3 RID: 18371
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x060047C4 RID: 18372
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x060047C5 RID: 18373
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060047C6 RID: 18374
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x060047C7 RID: 18375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x060047C8 RID: 18376
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060047C9 RID: 18377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x060047CB RID: 18379
		// (set) Token: 0x060047CA RID: 18378
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x060047CC RID: 18380
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x060047CD RID: 18381
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x060047CE RID: 18382
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x060047D0 RID: 18384
		// (set) Token: 0x060047CF RID: 18383
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060047D1 RID: 18385
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060047D2 RID: 18386
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060047D3 RID: 18387
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x060047D4 RID: 18388
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x060047D6 RID: 18390
		// (set) Token: 0x060047D5 RID: 18389
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x060047D7 RID: 18391
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x060047D9 RID: 18393
		// (set) Token: 0x060047D8 RID: 18392
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x060047DB RID: 18395
		// (set) Token: 0x060047DA RID: 18394
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x060047DD RID: 18397
		// (set) Token: 0x060047DC RID: 18396
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x060047DF RID: 18399
		// (set) Token: 0x060047DE RID: 18398
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x060047E1 RID: 18401
		// (set) Token: 0x060047E0 RID: 18400
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x060047E2 RID: 18402
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060047E4 RID: 18404
		// (set) Token: 0x060047E3 RID: 18403
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x060047E6 RID: 18406
		// (set) Token: 0x060047E5 RID: 18405
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x060047E8 RID: 18408
		// (set) Token: 0x060047E7 RID: 18407
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060047E9 RID: 18409
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060047EA RID: 18410
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A96 RID: 6806
		// (set) Token: 0x060047EB RID: 18411
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060047EC RID: 18412
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060047ED RID: 18413
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060047EE RID: 18414
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060047EF RID: 18415
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060047F0 RID: 18416
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060047F1 RID: 18417
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060047F2 RID: 18418
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x060047F3 RID: 18419
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x060047F4 RID: 18420
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060047F5 RID: 18421
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060047F7 RID: 18423
		// (set) Token: 0x060047F6 RID: 18422
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060047F8 RID: 18424
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060047F9 RID: 18425
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060047FA RID: 18426
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x060047FC RID: 18428
		// (set) Token: 0x060047FB RID: 18427
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060047FD RID: 18429
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060047FE RID: 18430
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060047FF RID: 18431
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06004800 RID: 18432
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06004802 RID: 18434
		// (set) Token: 0x06004801 RID: 18433
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06004804 RID: 18436
		// (set) Token: 0x06004803 RID: 18435
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06004806 RID: 18438
		// (set) Token: 0x06004805 RID: 18437
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06004808 RID: 18440
		// (set) Token: 0x06004807 RID: 18439
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x0600480A RID: 18442
		// (set) Token: 0x06004809 RID: 18441
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x0600480C RID: 18444
		// (set) Token: 0x0600480B RID: 18443
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x0600480D RID: 18445
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x0600480F RID: 18447
		// (set) Token: 0x0600480E RID: 18446
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06004811 RID: 18449
		// (set) Token: 0x06004810 RID: 18448
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06004813 RID: 18451
		// (set) Token: 0x06004812 RID: 18450
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06004814 RID: 18452
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06004815 RID: 18453
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AAF RID: 6831
		// (set) Token: 0x06004816 RID: 18454
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06004817 RID: 18455
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06004818 RID: 18456
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06004819 RID: 18457
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x0600481A RID: 18458
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x0600481B RID: 18459
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x0600481C RID: 18460
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600481D RID: 18461
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x0600481E RID: 18462
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x0600481F RID: 18463
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004820 RID: 18464
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06004822 RID: 18466
		// (set) Token: 0x06004821 RID: 18465
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06004823 RID: 18467
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06004824 RID: 18468
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06004825 RID: 18469
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06004827 RID: 18471
		// (set) Token: 0x06004826 RID: 18470
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004828 RID: 18472
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004829 RID: 18473
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600482A RID: 18474
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x0600482C RID: 18476
		// (set) Token: 0x0600482B RID: 18475
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x0600482E RID: 18478
		// (set) Token: 0x0600482D RID: 18477
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06004830 RID: 18480
		// (set) Token: 0x0600482F RID: 18479
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06004832 RID: 18482
		// (set) Token: 0x06004831 RID: 18481
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06004834 RID: 18484
		// (set) Token: 0x06004833 RID: 18483
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06004835 RID: 18485
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06004837 RID: 18487
		// (set) Token: 0x06004836 RID: 18486
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06004839 RID: 18489
		// (set) Token: 0x06004838 RID: 18488
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x0600483B RID: 18491
		// (set) Token: 0x0600483A RID: 18490
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x0600483C RID: 18492
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x0600483D RID: 18493
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AC6 RID: 6854
		// (set) Token: 0x0600483E RID: 18494
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x0600483F RID: 18495
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06004840 RID: 18496
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06004841 RID: 18497
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06004842 RID: 18498
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06004843 RID: 18499
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06004844 RID: 18500
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004845 RID: 18501
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06004846 RID: 18502
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06004847 RID: 18503
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004848 RID: 18504
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001ACD RID: 6861
		// (set) Token: 0x06004849 RID: 18505
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x0600484B RID: 18507
		// (set) Token: 0x0600484A RID: 18506
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x0600484D RID: 18509
		// (set) Token: 0x0600484C RID: 18508
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x0600484F RID: 18511
		// (set) Token: 0x0600484E RID: 18510
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06004851 RID: 18513
		// (set) Token: 0x06004850 RID: 18512
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004852 RID: 18514
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17001AD2 RID: 6866
		// (set) Token: 0x06004853 RID: 18515
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06004855 RID: 18517
		// (set) Token: 0x06004854 RID: 18516
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06004857 RID: 18519
		// (set) Token: 0x06004856 RID: 18518
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06004859 RID: 18521
		// (set) Token: 0x06004858 RID: 18520
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x0600485B RID: 18523
		// (set) Token: 0x0600485A RID: 18522
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600485C RID: 18524
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x0600485D RID: 18525
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600485E RID: 18526
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001AD7 RID: 6871
		// (set) Token: 0x0600485F RID: 18527
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06004861 RID: 18529
		// (set) Token: 0x06004860 RID: 18528
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06004863 RID: 18531
		// (set) Token: 0x06004862 RID: 18530
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06004865 RID: 18533
		// (set) Token: 0x06004864 RID: 18532
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06004867 RID: 18535
		// (set) Token: 0x06004866 RID: 18534
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004868 RID: 18536
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06004869 RID: 18537
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600486A RID: 18538
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x0600486C RID: 18540
		// (set) Token: 0x0600486B RID: 18539
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001ADD RID: 6877
		// (set) Token: 0x0600486D RID: 18541
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x0600486F RID: 18543
		// (set) Token: 0x0600486E RID: 18542
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06004871 RID: 18545
		// (set) Token: 0x06004870 RID: 18544
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06004873 RID: 18547
		// (set) Token: 0x06004872 RID: 18546
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06004875 RID: 18549
		// (set) Token: 0x06004874 RID: 18548
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004876 RID: 18550
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x06004877 RID: 18551
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004878 RID: 18552
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x0600487A RID: 18554
		// (set) Token: 0x06004879 RID: 18553
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x0600487C RID: 18556
		// (set) Token: 0x0600487B RID: 18555
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x0600487E RID: 18558
		// (set) Token: 0x0600487D RID: 18557
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06004880 RID: 18560
		// (set) Token: 0x0600487F RID: 18559
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06004882 RID: 18562
		// (set) Token: 0x06004881 RID: 18561
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06004884 RID: 18564
		// (set) Token: 0x06004883 RID: 18563
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06004886 RID: 18566
		// (set) Token: 0x06004885 RID: 18565
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06004887 RID: 18567
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06004888 RID: 18568
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x0600488A RID: 18570
		// (set) Token: 0x06004889 RID: 18569
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x0600488C RID: 18572
		// (set) Token: 0x0600488B RID: 18571
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x0600488E RID: 18574
		// (set) Token: 0x0600488D RID: 18573
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AEE RID: 6894
		// (set) Token: 0x0600488F RID: 18575
		public virtual extern string IMsRdpClientNonScriptable4_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06004891 RID: 18577
		// (set) Token: 0x06004890 RID: 18576
		public virtual extern string IMsRdpClientNonScriptable4_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06004893 RID: 18579
		// (set) Token: 0x06004892 RID: 18578
		public virtual extern string IMsRdpClientNonScriptable4_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06004895 RID: 18581
		// (set) Token: 0x06004894 RID: 18580
		public virtual extern string IMsRdpClientNonScriptable4_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06004897 RID: 18583
		// (set) Token: 0x06004896 RID: 18582
		public virtual extern string IMsRdpClientNonScriptable4_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004898 RID: 18584
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_ResetPassword();

		// Token: 0x06004899 RID: 18585
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600489A RID: 18586
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x0600489C RID: 18588
		// (set) Token: 0x0600489B RID: 18587
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable4_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x0600489E RID: 18590
		// (set) Token: 0x0600489D RID: 18589
		public virtual extern bool IMsRdpClientNonScriptable4_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x060048A0 RID: 18592
		// (set) Token: 0x0600489F RID: 18591
		public virtual extern bool IMsRdpClientNonScriptable4_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x060048A2 RID: 18594
		// (set) Token: 0x060048A1 RID: 18593
		public virtual extern bool IMsRdpClientNonScriptable4_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x060048A4 RID: 18596
		// (set) Token: 0x060048A3 RID: 18595
		public virtual extern bool IMsRdpClientNonScriptable4_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x060048A6 RID: 18598
		// (set) Token: 0x060048A5 RID: 18597
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x060048A8 RID: 18600
		// (set) Token: 0x060048A7 RID: 18599
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x060048A9 RID: 18601
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable4_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x060048AA RID: 18602
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable4_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x060048AC RID: 18604
		// (set) Token: 0x060048AB RID: 18603
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x060048AE RID: 18606
		// (set) Token: 0x060048AD RID: 18605
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x060048B0 RID: 18608
		// (set) Token: 0x060048AF RID: 18607
		public virtual extern string IMsRdpClientNonScriptable4_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x060048B2 RID: 18610
		// (set) Token: 0x060048B1 RID: 18609
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x060048B4 RID: 18612
		// (set) Token: 0x060048B3 RID: 18611
		public virtual extern bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x060048B6 RID: 18614
		// (set) Token: 0x060048B5 RID: 18613
		public virtual extern object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x060048B8 RID: 18616
		// (set) Token: 0x060048B7 RID: 18615
		public virtual extern bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x060048BA RID: 18618
		// (set) Token: 0x060048B9 RID: 18617
		public virtual extern bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x060048BC RID: 18620
		// (set) Token: 0x060048BB RID: 18619
		public virtual extern bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x060048BE RID: 18622
		// (set) Token: 0x060048BD RID: 18621
		public virtual extern bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x060048C0 RID: 18624
		// (set) Token: 0x060048BF RID: 18623
		public virtual extern bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B07 RID: 6919
		// (set) Token: 0x060048C1 RID: 18625
		public virtual extern string IMsRdpClientNonScriptable5_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x060048C3 RID: 18627
		// (set) Token: 0x060048C2 RID: 18626
		public virtual extern string IMsRdpClientNonScriptable5_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x060048C5 RID: 18629
		// (set) Token: 0x060048C4 RID: 18628
		public virtual extern string IMsRdpClientNonScriptable5_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x060048C7 RID: 18631
		// (set) Token: 0x060048C6 RID: 18630
		public virtual extern string IMsRdpClientNonScriptable5_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x060048C9 RID: 18633
		// (set) Token: 0x060048C8 RID: 18632
		public virtual extern string IMsRdpClientNonScriptable5_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060048CA RID: 18634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_ResetPassword();

		// Token: 0x060048CB RID: 18635
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060048CC RID: 18636
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x060048CE RID: 18638
		// (set) Token: 0x060048CD RID: 18637
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable5_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x060048D0 RID: 18640
		// (set) Token: 0x060048CF RID: 18639
		public virtual extern bool IMsRdpClientNonScriptable5_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x060048D2 RID: 18642
		// (set) Token: 0x060048D1 RID: 18641
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x060048D4 RID: 18644
		// (set) Token: 0x060048D3 RID: 18643
		public virtual extern bool IMsRdpClientNonScriptable5_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x060048D6 RID: 18646
		// (set) Token: 0x060048D5 RID: 18645
		public virtual extern bool IMsRdpClientNonScriptable5_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x060048D8 RID: 18648
		// (set) Token: 0x060048D7 RID: 18647
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x060048DA RID: 18650
		// (set) Token: 0x060048D9 RID: 18649
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x060048DB RID: 18651
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable5_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x060048DC RID: 18652
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable5_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x060048DE RID: 18654
		// (set) Token: 0x060048DD RID: 18653
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x060048E0 RID: 18656
		// (set) Token: 0x060048DF RID: 18655
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x060048E2 RID: 18658
		// (set) Token: 0x060048E1 RID: 18657
		public virtual extern string IMsRdpClientNonScriptable5_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x060048E4 RID: 18660
		// (set) Token: 0x060048E3 RID: 18659
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable5_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x060048E6 RID: 18662
		// (set) Token: 0x060048E5 RID: 18661
		public virtual extern bool IMsRdpClientNonScriptable5_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x060048E8 RID: 18664
		// (set) Token: 0x060048E7 RID: 18663
		public virtual extern object IMsRdpClientNonScriptable5_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x060048EA RID: 18666
		// (set) Token: 0x060048E9 RID: 18665
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x060048EC RID: 18668
		// (set) Token: 0x060048EB RID: 18667
		public virtual extern bool IMsRdpClientNonScriptable5_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x060048EE RID: 18670
		// (set) Token: 0x060048ED RID: 18669
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x060048F0 RID: 18672
		// (set) Token: 0x060048EF RID: 18671
		public virtual extern bool IMsRdpClientNonScriptable5_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x060048F2 RID: 18674
		// (set) Token: 0x060048F1 RID: 18673
		public virtual extern bool IMsRdpClientNonScriptable5_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x060048F4 RID: 18676
		// (set) Token: 0x060048F3 RID: 18675
		public virtual extern bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x060048F5 RID: 18677
		public virtual extern uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060048F6 RID: 18678
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x060048F7 RID: 18679
		public virtual extern bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001B23 RID: 6947
		// (set) Token: 0x060048F8 RID: 18680
		public virtual extern bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x060048FA RID: 18682
		// (set) Token: 0x060048F9 RID: 18681
		public virtual extern bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x060048FC RID: 18684
		// (set) Token: 0x060048FB RID: 18683
		public virtual extern bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x060048FE RID: 18686
		// (set) Token: 0x060048FD RID: 18685
		public virtual extern bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06004900 RID: 18688
		// (set) Token: 0x060048FF RID: 18687
		public virtual extern bool UseRedirectionServerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06004902 RID: 18690
		// (set) Token: 0x06004901 RID: 18689
		public virtual extern object Property { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x14000637 RID: 1591
		// (add) Token: 0x06004903 RID: 18691
		// (remove) Token: 0x06004904 RID: 18692
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000638 RID: 1592
		// (add) Token: 0x06004905 RID: 18693
		// (remove) Token: 0x06004906 RID: 18694
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000639 RID: 1593
		// (add) Token: 0x06004907 RID: 18695
		// (remove) Token: 0x06004908 RID: 18696
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400063A RID: 1594
		// (add) Token: 0x06004909 RID: 18697
		// (remove) Token: 0x0600490A RID: 18698
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400063B RID: 1595
		// (add) Token: 0x0600490B RID: 18699
		// (remove) Token: 0x0600490C RID: 18700
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400063C RID: 1596
		// (add) Token: 0x0600490D RID: 18701
		// (remove) Token: 0x0600490E RID: 18702
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400063D RID: 1597
		// (add) Token: 0x0600490F RID: 18703
		// (remove) Token: 0x06004910 RID: 18704
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400063E RID: 1598
		// (add) Token: 0x06004911 RID: 18705
		// (remove) Token: 0x06004912 RID: 18706
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400063F RID: 1599
		// (add) Token: 0x06004913 RID: 18707
		// (remove) Token: 0x06004914 RID: 18708
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000640 RID: 1600
		// (add) Token: 0x06004915 RID: 18709
		// (remove) Token: 0x06004916 RID: 18710
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000641 RID: 1601
		// (add) Token: 0x06004917 RID: 18711
		// (remove) Token: 0x06004918 RID: 18712
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000642 RID: 1602
		// (add) Token: 0x06004919 RID: 18713
		// (remove) Token: 0x0600491A RID: 18714
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000643 RID: 1603
		// (add) Token: 0x0600491B RID: 18715
		// (remove) Token: 0x0600491C RID: 18716
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000644 RID: 1604
		// (add) Token: 0x0600491D RID: 18717
		// (remove) Token: 0x0600491E RID: 18718
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000645 RID: 1605
		// (add) Token: 0x0600491F RID: 18719
		// (remove) Token: 0x06004920 RID: 18720
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000646 RID: 1606
		// (add) Token: 0x06004921 RID: 18721
		// (remove) Token: 0x06004922 RID: 18722
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000647 RID: 1607
		// (add) Token: 0x06004923 RID: 18723
		// (remove) Token: 0x06004924 RID: 18724
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000648 RID: 1608
		// (add) Token: 0x06004925 RID: 18725
		// (remove) Token: 0x06004926 RID: 18726
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000649 RID: 1609
		// (add) Token: 0x06004927 RID: 18727
		// (remove) Token: 0x06004928 RID: 18728
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400064A RID: 1610
		// (add) Token: 0x06004929 RID: 18729
		// (remove) Token: 0x0600492A RID: 18730
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400064B RID: 1611
		// (add) Token: 0x0600492B RID: 18731
		// (remove) Token: 0x0600492C RID: 18732
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400064C RID: 1612
		// (add) Token: 0x0600492D RID: 18733
		// (remove) Token: 0x0600492E RID: 18734
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400064D RID: 1613
		// (add) Token: 0x0600492F RID: 18735
		// (remove) Token: 0x06004930 RID: 18736
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400064E RID: 1614
		// (add) Token: 0x06004931 RID: 18737
		// (remove) Token: 0x06004932 RID: 18738
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400064F RID: 1615
		// (add) Token: 0x06004933 RID: 18739
		// (remove) Token: 0x06004934 RID: 18740
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000650 RID: 1616
		// (add) Token: 0x06004935 RID: 18741
		// (remove) Token: 0x06004936 RID: 18742
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000651 RID: 1617
		// (add) Token: 0x06004937 RID: 18743
		// (remove) Token: 0x06004938 RID: 18744
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000652 RID: 1618
		// (add) Token: 0x06004939 RID: 18745
		// (remove) Token: 0x0600493A RID: 18746
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000653 RID: 1619
		// (add) Token: 0x0600493B RID: 18747
		// (remove) Token: 0x0600493C RID: 18748
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000654 RID: 1620
		// (add) Token: 0x0600493D RID: 18749
		// (remove) Token: 0x0600493E RID: 18750
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000655 RID: 1621
		// (add) Token: 0x0600493F RID: 18751
		// (remove) Token: 0x06004940 RID: 18752
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000656 RID: 1622
		// (add) Token: 0x06004941 RID: 18753
		// (remove) Token: 0x06004942 RID: 18754
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
