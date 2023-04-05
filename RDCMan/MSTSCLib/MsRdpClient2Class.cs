using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200019E RID: 414
	[Guid("9059F30F-4EB1-4BD2-9FDC-36F43A218F4A")]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[TypeLibType(34)]
	[ClassInterface(0)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient2Class : IMsRdpClient2, MsRdpClient2, IMsTscAxEvents_Event, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x060020F2 RID: 8434
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient2Class();

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060020F4 RID: 8436
		// (set) Token: 0x060020F3 RID: 8435
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060020F6 RID: 8438
		// (set) Token: 0x060020F5 RID: 8437
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060020F8 RID: 8440
		// (set) Token: 0x060020F7 RID: 8439
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060020FA RID: 8442
		// (set) Token: 0x060020F9 RID: 8441
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060020FC RID: 8444
		// (set) Token: 0x060020FB RID: 8443
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060020FD RID: 8445
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060020FF RID: 8447
		// (set) Token: 0x060020FE RID: 8446
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002101 RID: 8449
		// (set) Token: 0x06002100 RID: 8448
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002103 RID: 8451
		// (set) Token: 0x06002102 RID: 8450
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002104 RID: 8452
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002105 RID: 8453
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700070A RID: 1802
		// (set) Token: 0x06002106 RID: 8454
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002107 RID: 8455
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002108 RID: 8456
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002109 RID: 8457
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600210A RID: 8458
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600210B RID: 8459
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600210C RID: 8460
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600210D RID: 8461
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x0600210E RID: 8462
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x0600210F RID: 8463
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002110 RID: 8464
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06002112 RID: 8466
		// (set) Token: 0x06002111 RID: 8465
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002113 RID: 8467
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002114 RID: 8468
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002115 RID: 8469
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002117 RID: 8471
		// (set) Token: 0x06002116 RID: 8470
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002118 RID: 8472
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002119 RID: 8473
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600211A RID: 8474
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600211B RID: 8475
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600211D RID: 8477
		// (set) Token: 0x0600211C RID: 8476
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x0600211F RID: 8479
		// (set) Token: 0x0600211E RID: 8478
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002121 RID: 8481
		// (set) Token: 0x06002120 RID: 8480
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002123 RID: 8483
		// (set) Token: 0x06002122 RID: 8482
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002125 RID: 8485
		// (set) Token: 0x06002124 RID: 8484
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002127 RID: 8487
		// (set) Token: 0x06002126 RID: 8486
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002128 RID: 8488
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600212A RID: 8490
		// (set) Token: 0x06002129 RID: 8489
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600212C RID: 8492
		// (set) Token: 0x0600212B RID: 8491
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600212E RID: 8494
		// (set) Token: 0x0600212D RID: 8493
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600212F RID: 8495
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002130 RID: 8496
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000723 RID: 1827
		// (set) Token: 0x06002131 RID: 8497
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002132 RID: 8498
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002133 RID: 8499
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002134 RID: 8500
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002135 RID: 8501
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002136 RID: 8502
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06002137 RID: 8503
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002138 RID: 8504
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06002139 RID: 8505
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x0600213A RID: 8506
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600213B RID: 8507
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600213D RID: 8509
		// (set) Token: 0x0600213C RID: 8508
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600213E RID: 8510
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600213F RID: 8511
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002140 RID: 8512
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002142 RID: 8514
		// (set) Token: 0x06002141 RID: 8513
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002143 RID: 8515
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002144 RID: 8516
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002145 RID: 8517
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002147 RID: 8519
		// (set) Token: 0x06002146 RID: 8518
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002149 RID: 8521
		// (set) Token: 0x06002148 RID: 8520
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600214B RID: 8523
		// (set) Token: 0x0600214A RID: 8522
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600214D RID: 8525
		// (set) Token: 0x0600214C RID: 8524
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600214F RID: 8527
		// (set) Token: 0x0600214E RID: 8526
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06002150 RID: 8528
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06002152 RID: 8530
		// (set) Token: 0x06002151 RID: 8529
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002154 RID: 8532
		// (set) Token: 0x06002153 RID: 8531
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002156 RID: 8534
		// (set) Token: 0x06002155 RID: 8533
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06002157 RID: 8535
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002158 RID: 8536
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700073A RID: 1850
		// (set) Token: 0x06002159 RID: 8537
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600215A RID: 8538
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600215B RID: 8539
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600215C RID: 8540
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x0600215D RID: 8541
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600215E RID: 8542
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600215F RID: 8543
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002160 RID: 8544
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06002161 RID: 8545
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06002162 RID: 8546
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002163 RID: 8547
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000741 RID: 1857
		// (set) Token: 0x06002164 RID: 8548
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06002166 RID: 8550
		// (set) Token: 0x06002165 RID: 8549
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002168 RID: 8552
		// (set) Token: 0x06002167 RID: 8551
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600216A RID: 8554
		// (set) Token: 0x06002169 RID: 8553
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600216C RID: 8556
		// (set) Token: 0x0600216B RID: 8555
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600216D RID: 8557
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17000746 RID: 1862
		// (set) Token: 0x0600216E RID: 8558
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002170 RID: 8560
		// (set) Token: 0x0600216F RID: 8559
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002172 RID: 8562
		// (set) Token: 0x06002171 RID: 8561
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002174 RID: 8564
		// (set) Token: 0x06002173 RID: 8563
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002176 RID: 8566
		// (set) Token: 0x06002175 RID: 8565
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002177 RID: 8567
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06002178 RID: 8568
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002179 RID: 8569
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x140003F7 RID: 1015
		// (add) Token: 0x0600217A RID: 8570
		// (remove) Token: 0x0600217B RID: 8571
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x140003F8 RID: 1016
		// (add) Token: 0x0600217C RID: 8572
		// (remove) Token: 0x0600217D RID: 8573
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x140003F9 RID: 1017
		// (add) Token: 0x0600217E RID: 8574
		// (remove) Token: 0x0600217F RID: 8575
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x140003FA RID: 1018
		// (add) Token: 0x06002180 RID: 8576
		// (remove) Token: 0x06002181 RID: 8577
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140003FB RID: 1019
		// (add) Token: 0x06002182 RID: 8578
		// (remove) Token: 0x06002183 RID: 8579
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x140003FC RID: 1020
		// (add) Token: 0x06002184 RID: 8580
		// (remove) Token: 0x06002185 RID: 8581
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x140003FD RID: 1021
		// (add) Token: 0x06002186 RID: 8582
		// (remove) Token: 0x06002187 RID: 8583
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140003FE RID: 1022
		// (add) Token: 0x06002188 RID: 8584
		// (remove) Token: 0x06002189 RID: 8585
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x140003FF RID: 1023
		// (add) Token: 0x0600218A RID: 8586
		// (remove) Token: 0x0600218B RID: 8587
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000400 RID: 1024
		// (add) Token: 0x0600218C RID: 8588
		// (remove) Token: 0x0600218D RID: 8589
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000401 RID: 1025
		// (add) Token: 0x0600218E RID: 8590
		// (remove) Token: 0x0600218F RID: 8591
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000402 RID: 1026
		// (add) Token: 0x06002190 RID: 8592
		// (remove) Token: 0x06002191 RID: 8593
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000403 RID: 1027
		// (add) Token: 0x06002192 RID: 8594
		// (remove) Token: 0x06002193 RID: 8595
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000404 RID: 1028
		// (add) Token: 0x06002194 RID: 8596
		// (remove) Token: 0x06002195 RID: 8597
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000405 RID: 1029
		// (add) Token: 0x06002196 RID: 8598
		// (remove) Token: 0x06002197 RID: 8599
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000406 RID: 1030
		// (add) Token: 0x06002198 RID: 8600
		// (remove) Token: 0x06002199 RID: 8601
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000407 RID: 1031
		// (add) Token: 0x0600219A RID: 8602
		// (remove) Token: 0x0600219B RID: 8603
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000408 RID: 1032
		// (add) Token: 0x0600219C RID: 8604
		// (remove) Token: 0x0600219D RID: 8605
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000409 RID: 1033
		// (add) Token: 0x0600219E RID: 8606
		// (remove) Token: 0x0600219F RID: 8607
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400040A RID: 1034
		// (add) Token: 0x060021A0 RID: 8608
		// (remove) Token: 0x060021A1 RID: 8609
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400040B RID: 1035
		// (add) Token: 0x060021A2 RID: 8610
		// (remove) Token: 0x060021A3 RID: 8611
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400040C RID: 1036
		// (add) Token: 0x060021A4 RID: 8612
		// (remove) Token: 0x060021A5 RID: 8613
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400040D RID: 1037
		// (add) Token: 0x060021A6 RID: 8614
		// (remove) Token: 0x060021A7 RID: 8615
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400040E RID: 1038
		// (add) Token: 0x060021A8 RID: 8616
		// (remove) Token: 0x060021A9 RID: 8617
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400040F RID: 1039
		// (add) Token: 0x060021AA RID: 8618
		// (remove) Token: 0x060021AB RID: 8619
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000410 RID: 1040
		// (add) Token: 0x060021AC RID: 8620
		// (remove) Token: 0x060021AD RID: 8621
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000411 RID: 1041
		// (add) Token: 0x060021AE RID: 8622
		// (remove) Token: 0x060021AF RID: 8623
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000412 RID: 1042
		// (add) Token: 0x060021B0 RID: 8624
		// (remove) Token: 0x060021B1 RID: 8625
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000413 RID: 1043
		// (add) Token: 0x060021B2 RID: 8626
		// (remove) Token: 0x060021B3 RID: 8627
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000414 RID: 1044
		// (add) Token: 0x060021B4 RID: 8628
		// (remove) Token: 0x060021B5 RID: 8629
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000415 RID: 1045
		// (add) Token: 0x060021B6 RID: 8630
		// (remove) Token: 0x060021B7 RID: 8631
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000416 RID: 1046
		// (add) Token: 0x060021B8 RID: 8632
		// (remove) Token: 0x060021B9 RID: 8633
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
