using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001DC RID: 476
	[Guid("89ACB528-2557-4D16-8625-226A30E97E9A")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings8 : IMsRdpClientAdvancedSettings7
	{
		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06003C9B RID: 15515
		// (set) Token: 0x06003C9A RID: 15514
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06003C9D RID: 15517
		// (set) Token: 0x06003C9C RID: 15516
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06003C9F RID: 15519
		// (set) Token: 0x06003C9E RID: 15518
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001478 RID: 5240
		// (set) Token: 0x06003CA0 RID: 15520
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001479 RID: 5241
		// (set) Token: 0x06003CA1 RID: 15521
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700147A RID: 5242
		// (set) Token: 0x06003CA2 RID: 15522
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700147B RID: 5243
		// (set) Token: 0x06003CA3 RID: 15523
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06003CA5 RID: 15525
		// (set) Token: 0x06003CA4 RID: 15524
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06003CA7 RID: 15527
		// (set) Token: 0x06003CA6 RID: 15526
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06003CA9 RID: 15529
		// (set) Token: 0x06003CA8 RID: 15528
		[DispId(101)]
		int SmoothScroll { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06003CAB RID: 15531
		// (set) Token: 0x06003CAA RID: 15530
		[DispId(102)]
		int AcceleratorPassthrough { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06003CAD RID: 15533
		// (set) Token: 0x06003CAC RID: 15532
		[DispId(103)]
		int ShadowBitmap { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06003CAF RID: 15535
		// (set) Token: 0x06003CAE RID: 15534
		[DispId(104)]
		int TransportType { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06003CB1 RID: 15537
		// (set) Token: 0x06003CB0 RID: 15536
		[DispId(105)]
		int SasSequence { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06003CB3 RID: 15539
		// (set) Token: 0x06003CB2 RID: 15538
		[DispId(106)]
		int EncryptionEnabled { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06003CB5 RID: 15541
		// (set) Token: 0x06003CB4 RID: 15540
		[DispId(107)]
		int DedicatedTerminal { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06003CB7 RID: 15543
		// (set) Token: 0x06003CB6 RID: 15542
		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06003CB9 RID: 15545
		// (set) Token: 0x06003CB8 RID: 15544
		[DispId(109)]
		int EnableMouse { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06003CBB RID: 15547
		// (set) Token: 0x06003CBA RID: 15546
		[DispId(110)]
		int DisableCtrlAltDel { [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06003CBD RID: 15549
		// (set) Token: 0x06003CBC RID: 15548
		[DispId(111)]
		int EnableWindowsKey { [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06003CBF RID: 15551
		// (set) Token: 0x06003CBE RID: 15550
		[DispId(112)]
		int DoubleClickDetect { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06003CC1 RID: 15553
		// (set) Token: 0x06003CC0 RID: 15552
		[DispId(113)]
		int MaximizeShell { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06003CC3 RID: 15555
		// (set) Token: 0x06003CC2 RID: 15554
		[DispId(114)]
		int HotKeyFullScreen { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06003CC5 RID: 15557
		// (set) Token: 0x06003CC4 RID: 15556
		[DispId(115)]
		int HotKeyCtrlEsc { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06003CC7 RID: 15559
		// (set) Token: 0x06003CC6 RID: 15558
		[DispId(116)]
		int HotKeyAltEsc { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06003CC9 RID: 15561
		// (set) Token: 0x06003CC8 RID: 15560
		[DispId(117)]
		int HotKeyAltTab { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06003CCB RID: 15563
		// (set) Token: 0x06003CCA RID: 15562
		[DispId(118)]
		int HotKeyAltShiftTab { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06003CCD RID: 15565
		// (set) Token: 0x06003CCC RID: 15564
		[DispId(119)]
		int HotKeyAltSpace { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06003CCF RID: 15567
		// (set) Token: 0x06003CCE RID: 15566
		[DispId(120)]
		int HotKeyCtrlAltDel { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06003CD1 RID: 15569
		// (set) Token: 0x06003CD0 RID: 15568
		[DispId(123)]
		int orderDrawThreshold { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06003CD3 RID: 15571
		// (set) Token: 0x06003CD2 RID: 15570
		[DispId(124)]
		int BitmapCacheSize { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06003CD5 RID: 15573
		// (set) Token: 0x06003CD4 RID: 15572
		[DispId(125)]
		int BitmapVirtualCacheSize { [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06003CD7 RID: 15575
		// (set) Token: 0x06003CD6 RID: 15574
		[DispId(175)]
		int ScaleBitmapCachesByBPP { [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06003CD9 RID: 15577
		// (set) Token: 0x06003CD8 RID: 15576
		[DispId(126)]
		int NumBitmapCaches { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06003CDB RID: 15579
		// (set) Token: 0x06003CDA RID: 15578
		[DispId(127)]
		int CachePersistenceActive { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001498 RID: 5272
		// (set) Token: 0x06003CDC RID: 15580
		[DispId(138)]
		string PersistCacheDirectory { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06003CDE RID: 15582
		// (set) Token: 0x06003CDD RID: 15581
		[DispId(156)]
		int brushSupportLevel { [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06003CE0 RID: 15584
		// (set) Token: 0x06003CDF RID: 15583
		[DispId(157)]
		int minInputSendInterval { [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06003CE2 RID: 15586
		// (set) Token: 0x06003CE1 RID: 15585
		[DispId(158)]
		int InputEventsAtOnce { [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06003CE4 RID: 15588
		// (set) Token: 0x06003CE3 RID: 15587
		[DispId(159)]
		int maxEventCount { [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06003CE6 RID: 15590
		// (set) Token: 0x06003CE5 RID: 15589
		[DispId(160)]
		int keepAliveInterval { [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06003CE8 RID: 15592
		// (set) Token: 0x06003CE7 RID: 15591
		[DispId(163)]
		int shutdownTimeout { [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06003CEA RID: 15594
		// (set) Token: 0x06003CE9 RID: 15593
		[DispId(164)]
		int overallConnectionTimeout { [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06003CEC RID: 15596
		// (set) Token: 0x06003CEB RID: 15595
		[DispId(165)]
		int singleConnectionTimeout { [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06003CEE RID: 15598
		// (set) Token: 0x06003CED RID: 15597
		[DispId(166)]
		int KeyboardType { [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06003CF0 RID: 15600
		// (set) Token: 0x06003CEF RID: 15599
		[DispId(167)]
		int KeyboardSubType { [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06003CF2 RID: 15602
		// (set) Token: 0x06003CF1 RID: 15601
		[DispId(168)]
		int KeyboardFunctionKey { [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06003CF4 RID: 15604
		// (set) Token: 0x06003CF3 RID: 15603
		[DispId(169)]
		int WinceFixedPalette { [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06003CF6 RID: 15606
		// (set) Token: 0x06003CF5 RID: 15605
		[DispId(178)]
		bool ConnectToServerConsole { [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06003CF8 RID: 15608
		// (set) Token: 0x06003CF7 RID: 15607
		[DispId(182)]
		int BitmapPersistence { [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06003CFA RID: 15610
		// (set) Token: 0x06003CF9 RID: 15609
		[DispId(183)]
		int MinutesToIdleTimeout { [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06003CFC RID: 15612
		// (set) Token: 0x06003CFB RID: 15611
		[DispId(184)]
		bool SmartSizing { [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06003CFE RID: 15614
		// (set) Token: 0x06003CFD RID: 15613
		[DispId(185)]
		string RdpdrLocalPrintingDocName { [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06003D00 RID: 15616
		// (set) Token: 0x06003CFF RID: 15615
		[DispId(201)]
		string RdpdrClipCleanTempDirString { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06003D02 RID: 15618
		// (set) Token: 0x06003D01 RID: 15617
		[DispId(202)]
		string RdpdrClipPasteInfoString { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170014AC RID: 5292
		// (set) Token: 0x06003D03 RID: 15619
		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06003D05 RID: 15621
		// (set) Token: 0x06003D04 RID: 15620
		[DispId(187)]
		bool DisplayConnectionBar { [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06003D07 RID: 15623
		// (set) Token: 0x06003D06 RID: 15622
		[DispId(188)]
		bool PinConnectionBar { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06003D09 RID: 15625
		// (set) Token: 0x06003D08 RID: 15624
		[DispId(189)]
		bool GrabFocusOnConnect { [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06003D0B RID: 15627
		// (set) Token: 0x06003D0A RID: 15626
		[DispId(190)]
		string LoadBalanceInfo { [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06003D0D RID: 15629
		// (set) Token: 0x06003D0C RID: 15628
		[DispId(191)]
		bool RedirectDrives { [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06003D0F RID: 15631
		// (set) Token: 0x06003D0E RID: 15630
		[DispId(192)]
		bool RedirectPrinters { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06003D11 RID: 15633
		// (set) Token: 0x06003D10 RID: 15632
		[DispId(193)]
		bool RedirectPorts { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06003D13 RID: 15635
		// (set) Token: 0x06003D12 RID: 15634
		[DispId(194)]
		bool RedirectSmartCards { [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06003D15 RID: 15637
		// (set) Token: 0x06003D14 RID: 15636
		[DispId(195)]
		int BitmapVirtualCache16BppSize { [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06003D17 RID: 15639
		// (set) Token: 0x06003D16 RID: 15638
		[DispId(196)]
		int BitmapVirtualCache24BppSize { [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06003D19 RID: 15641
		// (set) Token: 0x06003D18 RID: 15640
		[DispId(200)]
		int PerformanceFlags { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014B8 RID: 5304
		// (set) Token: 0x06003D1A RID: 15642
		[DispId(203)]
		ref object ConnectWithEndpoint { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06003D1C RID: 15644
		// (set) Token: 0x06003D1B RID: 15643
		[DispId(204)]
		bool NotifyTSPublicKey { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06003D1D RID: 15645
		[DispId(205)]
		bool CanAutoReconnect { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06003D1F RID: 15647
		// (set) Token: 0x06003D1E RID: 15646
		[DispId(206)]
		bool EnableAutoReconnect { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06003D21 RID: 15649
		// (set) Token: 0x06003D20 RID: 15648
		[DispId(207)]
		int MaxReconnectAttempts { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06003D23 RID: 15651
		// (set) Token: 0x06003D22 RID: 15650
		[DispId(210)]
		bool ConnectionBarShowMinimizeButton { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06003D25 RID: 15653
		// (set) Token: 0x06003D24 RID: 15652
		[DispId(211)]
		bool ConnectionBarShowRestoreButton { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06003D27 RID: 15655
		// (set) Token: 0x06003D26 RID: 15654
		[DispId(212)]
		uint AuthenticationLevel { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06003D29 RID: 15657
		// (set) Token: 0x06003D28 RID: 15656
		[DispId(213)]
		bool RedirectClipboard { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06003D2B RID: 15659
		// (set) Token: 0x06003D2A RID: 15658
		[DispId(215)]
		uint AudioRedirectionMode { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06003D2D RID: 15661
		// (set) Token: 0x06003D2C RID: 15660
		[DispId(216)]
		bool ConnectionBarShowPinButton { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06003D2F RID: 15663
		// (set) Token: 0x06003D2E RID: 15662
		[DispId(217)]
		bool PublicMode { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06003D31 RID: 15665
		// (set) Token: 0x06003D30 RID: 15664
		[DispId(218)]
		bool RedirectDevices { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06003D33 RID: 15667
		// (set) Token: 0x06003D32 RID: 15666
		[DispId(219)]
		bool RedirectPOSDevices { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06003D35 RID: 15669
		// (set) Token: 0x06003D34 RID: 15668
		[DispId(220)]
		int BitmapVirtualCache32BppSize { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06003D37 RID: 15671
		// (set) Token: 0x06003D36 RID: 15670
		[DispId(221)]
		bool RelativeMouseMode { [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06003D38 RID: 15672
		// (set) Token: 0x06003D39 RID: 15673
		[DispId(222)]
		string AuthenticationServiceClass { [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06003D3A RID: 15674
		// (set) Token: 0x06003D3B RID: 15675
		[DispId(223)]
		string PCB { [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06003D3D RID: 15677
		// (set) Token: 0x06003D3C RID: 15676
		[DispId(224)]
		int HotKeyFocusReleaseLeft { [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06003D3F RID: 15679
		// (set) Token: 0x06003D3E RID: 15678
		[DispId(225)]
		int HotKeyFocusReleaseRight { [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06003D41 RID: 15681
		// (set) Token: 0x06003D40 RID: 15680
		[DispId(17)]
		bool EnableCredSspSupport { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06003D42 RID: 15682
		[DispId(226)]
		uint AuthenticationType { [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06003D44 RID: 15684
		// (set) Token: 0x06003D43 RID: 15683
		[DispId(227)]
		bool ConnectToAdministerServer { [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06003D46 RID: 15686
		// (set) Token: 0x06003D45 RID: 15685
		[DispId(228)]
		bool AudioCaptureRedirectionMode { [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06003D48 RID: 15688
		// (set) Token: 0x06003D47 RID: 15687
		[DispId(229)]
		uint VideoPlaybackMode { [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06003D4A RID: 15690
		// (set) Token: 0x06003D49 RID: 15689
		[DispId(230)]
		bool EnableSuperPan { [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06003D4C RID: 15692
		// (set) Token: 0x06003D4B RID: 15691
		[DispId(231)]
		uint SuperPanAccelerationFactor { [DispId(231)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(231)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06003D4E RID: 15694
		// (set) Token: 0x06003D4D RID: 15693
		[DispId(232)]
		bool NegotiateSecurityLayer { [DispId(232)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(232)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06003D50 RID: 15696
		// (set) Token: 0x06003D4F RID: 15695
		[DispId(233)]
		uint AudioQualityMode { [DispId(233)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(233)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06003D52 RID: 15698
		// (set) Token: 0x06003D51 RID: 15697
		[DispId(234)]
		bool RedirectDirectX { [DispId(234)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(234)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06003D54 RID: 15700
		// (set) Token: 0x06003D53 RID: 15699
		[DispId(235)]
		uint NetworkConnectionType { [DispId(235)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(235)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06003D56 RID: 15702
		// (set) Token: 0x06003D55 RID: 15701
		[DispId(236)]
		bool BandwidthDetection { [DispId(236)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(236)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06003D58 RID: 15704
		// (set) Token: 0x06003D57 RID: 15703
		[DispId(237)]
		[ComAliasName("MSTSCLib.ClientSpec")]
		ClientSpec ClientProtocolSpec { [DispId(237)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ClientSpec")] get; [DispId(237)] [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.ClientSpec")] [param: In] set; }
	}
}
