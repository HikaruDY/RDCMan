using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200018C RID: 396
	[TypeLibType(4160)]
	[ComConversionLoss]
	[Guid("3C65B4AB-12B3-465B-ACD4-B8DAD3BFF9E2")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings : IMsTscAdvancedSettings
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001CFE RID: 7422
		// (set) Token: 0x06001CFD RID: 7421
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001D00 RID: 7424
		// (set) Token: 0x06001CFF RID: 7423
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001D02 RID: 7426
		// (set) Token: 0x06001D01 RID: 7425
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000568 RID: 1384
		// (set) Token: 0x06001D03 RID: 7427
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000569 RID: 1385
		// (set) Token: 0x06001D04 RID: 7428
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700056A RID: 1386
		// (set) Token: 0x06001D05 RID: 7429
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700056B RID: 1387
		// (set) Token: 0x06001D06 RID: 7430
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001D08 RID: 7432
		// (set) Token: 0x06001D07 RID: 7431
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001D0A RID: 7434
		// (set) Token: 0x06001D09 RID: 7433
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001D0C RID: 7436
		// (set) Token: 0x06001D0B RID: 7435
		[DispId(101)]
		int SmoothScroll { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001D0E RID: 7438
		// (set) Token: 0x06001D0D RID: 7437
		[DispId(102)]
		int AcceleratorPassthrough { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001D10 RID: 7440
		// (set) Token: 0x06001D0F RID: 7439
		[DispId(103)]
		int ShadowBitmap { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001D12 RID: 7442
		// (set) Token: 0x06001D11 RID: 7441
		[DispId(104)]
		int TransportType { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001D14 RID: 7444
		// (set) Token: 0x06001D13 RID: 7443
		[DispId(105)]
		int SasSequence { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001D16 RID: 7446
		// (set) Token: 0x06001D15 RID: 7445
		[DispId(106)]
		int EncryptionEnabled { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001D18 RID: 7448
		// (set) Token: 0x06001D17 RID: 7447
		[DispId(107)]
		int DedicatedTerminal { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001D1A RID: 7450
		// (set) Token: 0x06001D19 RID: 7449
		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001D1C RID: 7452
		// (set) Token: 0x06001D1B RID: 7451
		[DispId(109)]
		int EnableMouse { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001D1E RID: 7454
		// (set) Token: 0x06001D1D RID: 7453
		[DispId(110)]
		int DisableCtrlAltDel { [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001D20 RID: 7456
		// (set) Token: 0x06001D1F RID: 7455
		[DispId(111)]
		int EnableWindowsKey { [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001D22 RID: 7458
		// (set) Token: 0x06001D21 RID: 7457
		[DispId(112)]
		int DoubleClickDetect { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001D24 RID: 7460
		// (set) Token: 0x06001D23 RID: 7459
		[DispId(113)]
		int MaximizeShell { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001D26 RID: 7462
		// (set) Token: 0x06001D25 RID: 7461
		[DispId(114)]
		int HotKeyFullScreen { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001D28 RID: 7464
		// (set) Token: 0x06001D27 RID: 7463
		[DispId(115)]
		int HotKeyCtrlEsc { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001D2A RID: 7466
		// (set) Token: 0x06001D29 RID: 7465
		[DispId(116)]
		int HotKeyAltEsc { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001D2C RID: 7468
		// (set) Token: 0x06001D2B RID: 7467
		[DispId(117)]
		int HotKeyAltTab { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001D2E RID: 7470
		// (set) Token: 0x06001D2D RID: 7469
		[DispId(118)]
		int HotKeyAltShiftTab { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001D30 RID: 7472
		// (set) Token: 0x06001D2F RID: 7471
		[DispId(119)]
		int HotKeyAltSpace { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001D32 RID: 7474
		// (set) Token: 0x06001D31 RID: 7473
		[DispId(120)]
		int HotKeyCtrlAltDel { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001D34 RID: 7476
		// (set) Token: 0x06001D33 RID: 7475
		[DispId(123)]
		int orderDrawThreshold { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001D36 RID: 7478
		// (set) Token: 0x06001D35 RID: 7477
		[DispId(124)]
		int BitmapCacheSize { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001D38 RID: 7480
		// (set) Token: 0x06001D37 RID: 7479
		[DispId(125)]
		int BitmapVirtualCacheSize { [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001D3A RID: 7482
		// (set) Token: 0x06001D39 RID: 7481
		[DispId(175)]
		int ScaleBitmapCachesByBPP { [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001D3C RID: 7484
		// (set) Token: 0x06001D3B RID: 7483
		[DispId(126)]
		int NumBitmapCaches { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001D3E RID: 7486
		// (set) Token: 0x06001D3D RID: 7485
		[DispId(127)]
		int CachePersistenceActive { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000588 RID: 1416
		// (set) Token: 0x06001D3F RID: 7487
		[DispId(138)]
		string PersistCacheDirectory { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001D41 RID: 7489
		// (set) Token: 0x06001D40 RID: 7488
		[DispId(156)]
		int brushSupportLevel { [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001D43 RID: 7491
		// (set) Token: 0x06001D42 RID: 7490
		[DispId(157)]
		int minInputSendInterval { [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001D45 RID: 7493
		// (set) Token: 0x06001D44 RID: 7492
		[DispId(158)]
		int InputEventsAtOnce { [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001D47 RID: 7495
		// (set) Token: 0x06001D46 RID: 7494
		[DispId(159)]
		int maxEventCount { [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001D49 RID: 7497
		// (set) Token: 0x06001D48 RID: 7496
		[DispId(160)]
		int keepAliveInterval { [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001D4B RID: 7499
		// (set) Token: 0x06001D4A RID: 7498
		[DispId(163)]
		int shutdownTimeout { [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001D4D RID: 7501
		// (set) Token: 0x06001D4C RID: 7500
		[DispId(164)]
		int overallConnectionTimeout { [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001D4F RID: 7503
		// (set) Token: 0x06001D4E RID: 7502
		[DispId(165)]
		int singleConnectionTimeout { [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001D51 RID: 7505
		// (set) Token: 0x06001D50 RID: 7504
		[DispId(166)]
		int KeyboardType { [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001D53 RID: 7507
		// (set) Token: 0x06001D52 RID: 7506
		[DispId(167)]
		int KeyboardSubType { [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001D55 RID: 7509
		// (set) Token: 0x06001D54 RID: 7508
		[DispId(168)]
		int KeyboardFunctionKey { [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001D57 RID: 7511
		// (set) Token: 0x06001D56 RID: 7510
		[DispId(169)]
		int WinceFixedPalette { [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001D59 RID: 7513
		// (set) Token: 0x06001D58 RID: 7512
		[DispId(178)]
		bool ConnectToServerConsole { [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001D5B RID: 7515
		// (set) Token: 0x06001D5A RID: 7514
		[DispId(182)]
		int BitmapPersistence { [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001D5D RID: 7517
		// (set) Token: 0x06001D5C RID: 7516
		[DispId(183)]
		int MinutesToIdleTimeout { [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001D5F RID: 7519
		// (set) Token: 0x06001D5E RID: 7518
		[DispId(184)]
		bool SmartSizing { [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001D61 RID: 7521
		// (set) Token: 0x06001D60 RID: 7520
		[DispId(185)]
		string RdpdrLocalPrintingDocName { [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001D63 RID: 7523
		// (set) Token: 0x06001D62 RID: 7522
		[DispId(201)]
		string RdpdrClipCleanTempDirString { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001D65 RID: 7525
		// (set) Token: 0x06001D64 RID: 7524
		[DispId(202)]
		string RdpdrClipPasteInfoString { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700059C RID: 1436
		// (set) Token: 0x06001D66 RID: 7526
		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001D68 RID: 7528
		// (set) Token: 0x06001D67 RID: 7527
		[DispId(187)]
		bool DisplayConnectionBar { [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001D6A RID: 7530
		// (set) Token: 0x06001D69 RID: 7529
		[DispId(188)]
		bool PinConnectionBar { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001D6C RID: 7532
		// (set) Token: 0x06001D6B RID: 7531
		[DispId(189)]
		bool GrabFocusOnConnect { [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001D6E RID: 7534
		// (set) Token: 0x06001D6D RID: 7533
		[DispId(190)]
		string LoadBalanceInfo { [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001D70 RID: 7536
		// (set) Token: 0x06001D6F RID: 7535
		[DispId(191)]
		bool RedirectDrives { [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001D72 RID: 7538
		// (set) Token: 0x06001D71 RID: 7537
		[DispId(192)]
		bool RedirectPrinters { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001D74 RID: 7540
		// (set) Token: 0x06001D73 RID: 7539
		[DispId(193)]
		bool RedirectPorts { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001D76 RID: 7542
		// (set) Token: 0x06001D75 RID: 7541
		[DispId(194)]
		bool RedirectSmartCards { [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001D78 RID: 7544
		// (set) Token: 0x06001D77 RID: 7543
		[DispId(195)]
		int BitmapVirtualCache16BppSize { [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001D7A RID: 7546
		// (set) Token: 0x06001D79 RID: 7545
		[DispId(196)]
		int BitmapVirtualCache24BppSize { [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001D7C RID: 7548
		// (set) Token: 0x06001D7B RID: 7547
		[DispId(200)]
		int PerformanceFlags { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005A8 RID: 1448
		// (set) Token: 0x06001D7D RID: 7549
		[DispId(203)]
		ref object ConnectWithEndpoint { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001D7F RID: 7551
		// (set) Token: 0x06001D7E RID: 7550
		[DispId(204)]
		bool NotifyTSPublicKey { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
