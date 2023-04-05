using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001C4 RID: 452
	[TypeLibType(4160)]
	[Guid("222C4B5D-45D9-4DF0-A7C6-60CF9089D285")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings6 : IMsRdpClientAdvancedSettings5
	{
		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060030A7 RID: 12455
		// (set) Token: 0x060030A6 RID: 12454
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x060030A9 RID: 12457
		// (set) Token: 0x060030A8 RID: 12456
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x060030AB RID: 12459
		// (set) Token: 0x060030AA RID: 12458
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E49 RID: 3657
		// (set) Token: 0x060030AC RID: 12460
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E4A RID: 3658
		// (set) Token: 0x060030AD RID: 12461
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E4B RID: 3659
		// (set) Token: 0x060030AE RID: 12462
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E4C RID: 3660
		// (set) Token: 0x060030AF RID: 12463
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x060030B1 RID: 12465
		// (set) Token: 0x060030B0 RID: 12464
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x060030B3 RID: 12467
		// (set) Token: 0x060030B2 RID: 12466
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x060030B5 RID: 12469
		// (set) Token: 0x060030B4 RID: 12468
		[DispId(101)]
		int SmoothScroll { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x060030B7 RID: 12471
		// (set) Token: 0x060030B6 RID: 12470
		[DispId(102)]
		int AcceleratorPassthrough { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060030B9 RID: 12473
		// (set) Token: 0x060030B8 RID: 12472
		[DispId(103)]
		int ShadowBitmap { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060030BB RID: 12475
		// (set) Token: 0x060030BA RID: 12474
		[DispId(104)]
		int TransportType { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060030BD RID: 12477
		// (set) Token: 0x060030BC RID: 12476
		[DispId(105)]
		int SasSequence { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060030BF RID: 12479
		// (set) Token: 0x060030BE RID: 12478
		[DispId(106)]
		int EncryptionEnabled { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060030C1 RID: 12481
		// (set) Token: 0x060030C0 RID: 12480
		[DispId(107)]
		int DedicatedTerminal { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060030C3 RID: 12483
		// (set) Token: 0x060030C2 RID: 12482
		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x060030C5 RID: 12485
		// (set) Token: 0x060030C4 RID: 12484
		[DispId(109)]
		int EnableMouse { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060030C7 RID: 12487
		// (set) Token: 0x060030C6 RID: 12486
		[DispId(110)]
		int DisableCtrlAltDel { [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060030C9 RID: 12489
		// (set) Token: 0x060030C8 RID: 12488
		[DispId(111)]
		int EnableWindowsKey { [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060030CB RID: 12491
		// (set) Token: 0x060030CA RID: 12490
		[DispId(112)]
		int DoubleClickDetect { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060030CD RID: 12493
		// (set) Token: 0x060030CC RID: 12492
		[DispId(113)]
		int MaximizeShell { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060030CF RID: 12495
		// (set) Token: 0x060030CE RID: 12494
		[DispId(114)]
		int HotKeyFullScreen { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060030D1 RID: 12497
		// (set) Token: 0x060030D0 RID: 12496
		[DispId(115)]
		int HotKeyCtrlEsc { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060030D3 RID: 12499
		// (set) Token: 0x060030D2 RID: 12498
		[DispId(116)]
		int HotKeyAltEsc { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060030D5 RID: 12501
		// (set) Token: 0x060030D4 RID: 12500
		[DispId(117)]
		int HotKeyAltTab { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060030D7 RID: 12503
		// (set) Token: 0x060030D6 RID: 12502
		[DispId(118)]
		int HotKeyAltShiftTab { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060030D9 RID: 12505
		// (set) Token: 0x060030D8 RID: 12504
		[DispId(119)]
		int HotKeyAltSpace { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060030DB RID: 12507
		// (set) Token: 0x060030DA RID: 12506
		[DispId(120)]
		int HotKeyCtrlAltDel { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060030DD RID: 12509
		// (set) Token: 0x060030DC RID: 12508
		[DispId(123)]
		int orderDrawThreshold { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060030DF RID: 12511
		// (set) Token: 0x060030DE RID: 12510
		[DispId(124)]
		int BitmapCacheSize { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060030E1 RID: 12513
		// (set) Token: 0x060030E0 RID: 12512
		[DispId(125)]
		int BitmapVirtualCacheSize { [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060030E3 RID: 12515
		// (set) Token: 0x060030E2 RID: 12514
		[DispId(175)]
		int ScaleBitmapCachesByBPP { [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x060030E5 RID: 12517
		// (set) Token: 0x060030E4 RID: 12516
		[DispId(126)]
		int NumBitmapCaches { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060030E7 RID: 12519
		// (set) Token: 0x060030E6 RID: 12518
		[DispId(127)]
		int CachePersistenceActive { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E69 RID: 3689
		// (set) Token: 0x060030E8 RID: 12520
		[DispId(138)]
		string PersistCacheDirectory { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x060030EA RID: 12522
		// (set) Token: 0x060030E9 RID: 12521
		[DispId(156)]
		int brushSupportLevel { [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x060030EC RID: 12524
		// (set) Token: 0x060030EB RID: 12523
		[DispId(157)]
		int minInputSendInterval { [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x060030EE RID: 12526
		// (set) Token: 0x060030ED RID: 12525
		[DispId(158)]
		int InputEventsAtOnce { [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x060030F0 RID: 12528
		// (set) Token: 0x060030EF RID: 12527
		[DispId(159)]
		int maxEventCount { [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x060030F2 RID: 12530
		// (set) Token: 0x060030F1 RID: 12529
		[DispId(160)]
		int keepAliveInterval { [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x060030F4 RID: 12532
		// (set) Token: 0x060030F3 RID: 12531
		[DispId(163)]
		int shutdownTimeout { [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x060030F6 RID: 12534
		// (set) Token: 0x060030F5 RID: 12533
		[DispId(164)]
		int overallConnectionTimeout { [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x060030F8 RID: 12536
		// (set) Token: 0x060030F7 RID: 12535
		[DispId(165)]
		int singleConnectionTimeout { [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x060030FA RID: 12538
		// (set) Token: 0x060030F9 RID: 12537
		[DispId(166)]
		int KeyboardType { [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x060030FC RID: 12540
		// (set) Token: 0x060030FB RID: 12539
		[DispId(167)]
		int KeyboardSubType { [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x060030FE RID: 12542
		// (set) Token: 0x060030FD RID: 12541
		[DispId(168)]
		int KeyboardFunctionKey { [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06003100 RID: 12544
		// (set) Token: 0x060030FF RID: 12543
		[DispId(169)]
		int WinceFixedPalette { [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06003102 RID: 12546
		// (set) Token: 0x06003101 RID: 12545
		[DispId(178)]
		bool ConnectToServerConsole { [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06003104 RID: 12548
		// (set) Token: 0x06003103 RID: 12547
		[DispId(182)]
		int BitmapPersistence { [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06003106 RID: 12550
		// (set) Token: 0x06003105 RID: 12549
		[DispId(183)]
		int MinutesToIdleTimeout { [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06003108 RID: 12552
		// (set) Token: 0x06003107 RID: 12551
		[DispId(184)]
		bool SmartSizing { [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x0600310A RID: 12554
		// (set) Token: 0x06003109 RID: 12553
		[DispId(185)]
		string RdpdrLocalPrintingDocName { [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x0600310C RID: 12556
		// (set) Token: 0x0600310B RID: 12555
		[DispId(201)]
		string RdpdrClipCleanTempDirString { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x0600310E RID: 12558
		// (set) Token: 0x0600310D RID: 12557
		[DispId(202)]
		string RdpdrClipPasteInfoString { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E7D RID: 3709
		// (set) Token: 0x0600310F RID: 12559
		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06003111 RID: 12561
		// (set) Token: 0x06003110 RID: 12560
		[DispId(187)]
		bool DisplayConnectionBar { [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06003113 RID: 12563
		// (set) Token: 0x06003112 RID: 12562
		[DispId(188)]
		bool PinConnectionBar { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06003115 RID: 12565
		// (set) Token: 0x06003114 RID: 12564
		[DispId(189)]
		bool GrabFocusOnConnect { [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06003117 RID: 12567
		// (set) Token: 0x06003116 RID: 12566
		[DispId(190)]
		string LoadBalanceInfo { [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06003119 RID: 12569
		// (set) Token: 0x06003118 RID: 12568
		[DispId(191)]
		bool RedirectDrives { [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x0600311B RID: 12571
		// (set) Token: 0x0600311A RID: 12570
		[DispId(192)]
		bool RedirectPrinters { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x0600311D RID: 12573
		// (set) Token: 0x0600311C RID: 12572
		[DispId(193)]
		bool RedirectPorts { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x0600311F RID: 12575
		// (set) Token: 0x0600311E RID: 12574
		[DispId(194)]
		bool RedirectSmartCards { [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06003121 RID: 12577
		// (set) Token: 0x06003120 RID: 12576
		[DispId(195)]
		int BitmapVirtualCache16BppSize { [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06003123 RID: 12579
		// (set) Token: 0x06003122 RID: 12578
		[DispId(196)]
		int BitmapVirtualCache24BppSize { [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06003125 RID: 12581
		// (set) Token: 0x06003124 RID: 12580
		[DispId(200)]
		int PerformanceFlags { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E89 RID: 3721
		// (set) Token: 0x06003126 RID: 12582
		[DispId(203)]
		ref object ConnectWithEndpoint { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06003128 RID: 12584
		// (set) Token: 0x06003127 RID: 12583
		[DispId(204)]
		bool NotifyTSPublicKey { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06003129 RID: 12585
		[DispId(205)]
		bool CanAutoReconnect { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x0600312B RID: 12587
		// (set) Token: 0x0600312A RID: 12586
		[DispId(206)]
		bool EnableAutoReconnect { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x0600312D RID: 12589
		// (set) Token: 0x0600312C RID: 12588
		[DispId(207)]
		int MaxReconnectAttempts { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x0600312F RID: 12591
		// (set) Token: 0x0600312E RID: 12590
		[DispId(210)]
		bool ConnectionBarShowMinimizeButton { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06003131 RID: 12593
		// (set) Token: 0x06003130 RID: 12592
		[DispId(211)]
		bool ConnectionBarShowRestoreButton { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06003133 RID: 12595
		// (set) Token: 0x06003132 RID: 12594
		[DispId(212)]
		uint AuthenticationLevel { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06003135 RID: 12597
		// (set) Token: 0x06003134 RID: 12596
		[DispId(213)]
		bool RedirectClipboard { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06003137 RID: 12599
		// (set) Token: 0x06003136 RID: 12598
		[DispId(215)]
		uint AudioRedirectionMode { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06003139 RID: 12601
		// (set) Token: 0x06003138 RID: 12600
		[DispId(216)]
		bool ConnectionBarShowPinButton { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x0600313B RID: 12603
		// (set) Token: 0x0600313A RID: 12602
		[DispId(217)]
		bool PublicMode { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x0600313D RID: 12605
		// (set) Token: 0x0600313C RID: 12604
		[DispId(218)]
		bool RedirectDevices { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x0600313F RID: 12607
		// (set) Token: 0x0600313E RID: 12606
		[DispId(219)]
		bool RedirectPOSDevices { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06003141 RID: 12609
		// (set) Token: 0x06003140 RID: 12608
		[DispId(220)]
		int BitmapVirtualCache32BppSize { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06003143 RID: 12611
		// (set) Token: 0x06003142 RID: 12610
		[DispId(221)]
		bool RelativeMouseMode { [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06003144 RID: 12612
		// (set) Token: 0x06003145 RID: 12613
		[DispId(222)]
		string AuthenticationServiceClass { [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06003146 RID: 12614
		// (set) Token: 0x06003147 RID: 12615
		[DispId(223)]
		string PCB { [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06003149 RID: 12617
		// (set) Token: 0x06003148 RID: 12616
		[DispId(224)]
		int HotKeyFocusReleaseLeft { [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x0600314B RID: 12619
		// (set) Token: 0x0600314A RID: 12618
		[DispId(225)]
		int HotKeyFocusReleaseRight { [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x0600314D RID: 12621
		// (set) Token: 0x0600314C RID: 12620
		[DispId(17)]
		bool EnableCredSspSupport { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600314E RID: 12622
		[DispId(226)]
		uint AuthenticationType { [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06003150 RID: 12624
		// (set) Token: 0x0600314F RID: 12623
		[DispId(227)]
		bool ConnectToAdministerServer { [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
