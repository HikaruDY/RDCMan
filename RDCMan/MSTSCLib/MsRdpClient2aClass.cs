using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001A0 RID: 416
	[TypeLibType(34)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[ClassInterface(0)]
	[Guid("971127BB-259F-48C2-BD75-5F97A3331551")]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient2aClass : IMsRdpClient2, MsRdpClient2a, IMsTscAxEvents_Event, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x060021BA RID: 8634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient2aClass();

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060021BC RID: 8636
		// (set) Token: 0x060021BB RID: 8635
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060021BE RID: 8638
		// (set) Token: 0x060021BD RID: 8637
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060021C0 RID: 8640
		// (set) Token: 0x060021BF RID: 8639
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060021C2 RID: 8642
		// (set) Token: 0x060021C1 RID: 8641
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060021C4 RID: 8644
		// (set) Token: 0x060021C3 RID: 8643
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060021C5 RID: 8645
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060021C7 RID: 8647
		// (set) Token: 0x060021C6 RID: 8646
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060021C9 RID: 8649
		// (set) Token: 0x060021C8 RID: 8648
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060021CB RID: 8651
		// (set) Token: 0x060021CA RID: 8650
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060021CC RID: 8652
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060021CD RID: 8653
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000756 RID: 1878
		// (set) Token: 0x060021CE RID: 8654
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060021CF RID: 8655
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060021D0 RID: 8656
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060021D1 RID: 8657
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060021D2 RID: 8658
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060021D3 RID: 8659
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060021D4 RID: 8660
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060021D5 RID: 8661
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x060021D6 RID: 8662
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x060021D7 RID: 8663
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060021D8 RID: 8664
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060021DA RID: 8666
		// (set) Token: 0x060021D9 RID: 8665
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060021DB RID: 8667
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060021DC RID: 8668
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060021DD RID: 8669
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060021DF RID: 8671
		// (set) Token: 0x060021DE RID: 8670
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060021E0 RID: 8672
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060021E1 RID: 8673
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060021E2 RID: 8674
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060021E3 RID: 8675
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060021E5 RID: 8677
		// (set) Token: 0x060021E4 RID: 8676
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060021E7 RID: 8679
		// (set) Token: 0x060021E6 RID: 8678
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060021E9 RID: 8681
		// (set) Token: 0x060021E8 RID: 8680
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060021EB RID: 8683
		// (set) Token: 0x060021EA RID: 8682
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060021ED RID: 8685
		// (set) Token: 0x060021EC RID: 8684
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060021EF RID: 8687
		// (set) Token: 0x060021EE RID: 8686
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060021F0 RID: 8688
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060021F2 RID: 8690
		// (set) Token: 0x060021F1 RID: 8689
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060021F4 RID: 8692
		// (set) Token: 0x060021F3 RID: 8691
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060021F6 RID: 8694
		// (set) Token: 0x060021F5 RID: 8693
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060021F7 RID: 8695
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060021F8 RID: 8696
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700076F RID: 1903
		// (set) Token: 0x060021F9 RID: 8697
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060021FA RID: 8698
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060021FB RID: 8699
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060021FC RID: 8700
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060021FD RID: 8701
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060021FE RID: 8702
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060021FF RID: 8703
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002200 RID: 8704
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06002201 RID: 8705
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06002202 RID: 8706
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002203 RID: 8707
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06002205 RID: 8709
		// (set) Token: 0x06002204 RID: 8708
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06002206 RID: 8710
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002207 RID: 8711
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002208 RID: 8712
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x0600220A RID: 8714
		// (set) Token: 0x06002209 RID: 8713
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600220B RID: 8715
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600220C RID: 8716
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600220D RID: 8717
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600220F RID: 8719
		// (set) Token: 0x0600220E RID: 8718
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002211 RID: 8721
		// (set) Token: 0x06002210 RID: 8720
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002213 RID: 8723
		// (set) Token: 0x06002212 RID: 8722
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002215 RID: 8725
		// (set) Token: 0x06002214 RID: 8724
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002217 RID: 8727
		// (set) Token: 0x06002216 RID: 8726
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06002218 RID: 8728
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600221A RID: 8730
		// (set) Token: 0x06002219 RID: 8729
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600221C RID: 8732
		// (set) Token: 0x0600221B RID: 8731
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600221E RID: 8734
		// (set) Token: 0x0600221D RID: 8733
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600221F RID: 8735
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002220 RID: 8736
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000786 RID: 1926
		// (set) Token: 0x06002221 RID: 8737
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002222 RID: 8738
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002223 RID: 8739
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002224 RID: 8740
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002225 RID: 8741
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002226 RID: 8742
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002227 RID: 8743
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002228 RID: 8744
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06002229 RID: 8745
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x0600222A RID: 8746
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600222B RID: 8747
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700078D RID: 1933
		// (set) Token: 0x0600222C RID: 8748
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600222E RID: 8750
		// (set) Token: 0x0600222D RID: 8749
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002230 RID: 8752
		// (set) Token: 0x0600222F RID: 8751
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002232 RID: 8754
		// (set) Token: 0x06002231 RID: 8753
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002234 RID: 8756
		// (set) Token: 0x06002233 RID: 8755
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002235 RID: 8757
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17000792 RID: 1938
		// (set) Token: 0x06002236 RID: 8758
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002238 RID: 8760
		// (set) Token: 0x06002237 RID: 8759
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600223A RID: 8762
		// (set) Token: 0x06002239 RID: 8761
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600223C RID: 8764
		// (set) Token: 0x0600223B RID: 8763
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600223E RID: 8766
		// (set) Token: 0x0600223D RID: 8765
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600223F RID: 8767
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06002240 RID: 8768
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002241 RID: 8769
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x14000417 RID: 1047
		// (add) Token: 0x06002242 RID: 8770
		// (remove) Token: 0x06002243 RID: 8771
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000418 RID: 1048
		// (add) Token: 0x06002244 RID: 8772
		// (remove) Token: 0x06002245 RID: 8773
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000419 RID: 1049
		// (add) Token: 0x06002246 RID: 8774
		// (remove) Token: 0x06002247 RID: 8775
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400041A RID: 1050
		// (add) Token: 0x06002248 RID: 8776
		// (remove) Token: 0x06002249 RID: 8777
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400041B RID: 1051
		// (add) Token: 0x0600224A RID: 8778
		// (remove) Token: 0x0600224B RID: 8779
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400041C RID: 1052
		// (add) Token: 0x0600224C RID: 8780
		// (remove) Token: 0x0600224D RID: 8781
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400041D RID: 1053
		// (add) Token: 0x0600224E RID: 8782
		// (remove) Token: 0x0600224F RID: 8783
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400041E RID: 1054
		// (add) Token: 0x06002250 RID: 8784
		// (remove) Token: 0x06002251 RID: 8785
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400041F RID: 1055
		// (add) Token: 0x06002252 RID: 8786
		// (remove) Token: 0x06002253 RID: 8787
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000420 RID: 1056
		// (add) Token: 0x06002254 RID: 8788
		// (remove) Token: 0x06002255 RID: 8789
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000421 RID: 1057
		// (add) Token: 0x06002256 RID: 8790
		// (remove) Token: 0x06002257 RID: 8791
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000422 RID: 1058
		// (add) Token: 0x06002258 RID: 8792
		// (remove) Token: 0x06002259 RID: 8793
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000423 RID: 1059
		// (add) Token: 0x0600225A RID: 8794
		// (remove) Token: 0x0600225B RID: 8795
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000424 RID: 1060
		// (add) Token: 0x0600225C RID: 8796
		// (remove) Token: 0x0600225D RID: 8797
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000425 RID: 1061
		// (add) Token: 0x0600225E RID: 8798
		// (remove) Token: 0x0600225F RID: 8799
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000426 RID: 1062
		// (add) Token: 0x06002260 RID: 8800
		// (remove) Token: 0x06002261 RID: 8801
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000427 RID: 1063
		// (add) Token: 0x06002262 RID: 8802
		// (remove) Token: 0x06002263 RID: 8803
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000428 RID: 1064
		// (add) Token: 0x06002264 RID: 8804
		// (remove) Token: 0x06002265 RID: 8805
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000429 RID: 1065
		// (add) Token: 0x06002266 RID: 8806
		// (remove) Token: 0x06002267 RID: 8807
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400042A RID: 1066
		// (add) Token: 0x06002268 RID: 8808
		// (remove) Token: 0x06002269 RID: 8809
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400042B RID: 1067
		// (add) Token: 0x0600226A RID: 8810
		// (remove) Token: 0x0600226B RID: 8811
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400042C RID: 1068
		// (add) Token: 0x0600226C RID: 8812
		// (remove) Token: 0x0600226D RID: 8813
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400042D RID: 1069
		// (add) Token: 0x0600226E RID: 8814
		// (remove) Token: 0x0600226F RID: 8815
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400042E RID: 1070
		// (add) Token: 0x06002270 RID: 8816
		// (remove) Token: 0x06002271 RID: 8817
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400042F RID: 1071
		// (add) Token: 0x06002272 RID: 8818
		// (remove) Token: 0x06002273 RID: 8819
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000430 RID: 1072
		// (add) Token: 0x06002274 RID: 8820
		// (remove) Token: 0x06002275 RID: 8821
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000431 RID: 1073
		// (add) Token: 0x06002276 RID: 8822
		// (remove) Token: 0x06002277 RID: 8823
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000432 RID: 1074
		// (add) Token: 0x06002278 RID: 8824
		// (remove) Token: 0x06002279 RID: 8825
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000433 RID: 1075
		// (add) Token: 0x0600227A RID: 8826
		// (remove) Token: 0x0600227B RID: 8827
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000434 RID: 1076
		// (add) Token: 0x0600227C RID: 8828
		// (remove) Token: 0x0600227D RID: 8829
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000435 RID: 1077
		// (add) Token: 0x0600227E RID: 8830
		// (remove) Token: 0x0600227F RID: 8831
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000436 RID: 1078
		// (add) Token: 0x06002280 RID: 8832
		// (remove) Token: 0x06002281 RID: 8833
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
