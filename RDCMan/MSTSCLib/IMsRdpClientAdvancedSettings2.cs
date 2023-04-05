using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200019D RID: 413
	[Guid("9AC42117-2B76-4320-AA44-0E616AB8437B")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings2 : IMsRdpClientAdvancedSettings
	{
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600206B RID: 8299
		// (set) Token: 0x0600206A RID: 8298
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600206D RID: 8301
		// (set) Token: 0x0600206C RID: 8300
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600206F RID: 8303
		// (set) Token: 0x0600206E RID: 8302
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006BA RID: 1722
		// (set) Token: 0x06002070 RID: 8304
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006BB RID: 1723
		// (set) Token: 0x06002071 RID: 8305
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006BC RID: 1724
		// (set) Token: 0x06002072 RID: 8306
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006BD RID: 1725
		// (set) Token: 0x06002073 RID: 8307
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002075 RID: 8309
		// (set) Token: 0x06002074 RID: 8308
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002077 RID: 8311
		// (set) Token: 0x06002076 RID: 8310
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002079 RID: 8313
		// (set) Token: 0x06002078 RID: 8312
		[DispId(101)]
		int SmoothScroll { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600207B RID: 8315
		// (set) Token: 0x0600207A RID: 8314
		[DispId(102)]
		int AcceleratorPassthrough { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600207D RID: 8317
		// (set) Token: 0x0600207C RID: 8316
		[DispId(103)]
		int ShadowBitmap { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600207F RID: 8319
		// (set) Token: 0x0600207E RID: 8318
		[DispId(104)]
		int TransportType { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002081 RID: 8321
		// (set) Token: 0x06002080 RID: 8320
		[DispId(105)]
		int SasSequence { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002083 RID: 8323
		// (set) Token: 0x06002082 RID: 8322
		[DispId(106)]
		int EncryptionEnabled { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002085 RID: 8325
		// (set) Token: 0x06002084 RID: 8324
		[DispId(107)]
		int DedicatedTerminal { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002087 RID: 8327
		// (set) Token: 0x06002086 RID: 8326
		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002089 RID: 8329
		// (set) Token: 0x06002088 RID: 8328
		[DispId(109)]
		int EnableMouse { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600208B RID: 8331
		// (set) Token: 0x0600208A RID: 8330
		[DispId(110)]
		int DisableCtrlAltDel { [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600208D RID: 8333
		// (set) Token: 0x0600208C RID: 8332
		[DispId(111)]
		int EnableWindowsKey { [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600208F RID: 8335
		// (set) Token: 0x0600208E RID: 8334
		[DispId(112)]
		int DoubleClickDetect { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002091 RID: 8337
		// (set) Token: 0x06002090 RID: 8336
		[DispId(113)]
		int MaximizeShell { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002093 RID: 8339
		// (set) Token: 0x06002092 RID: 8338
		[DispId(114)]
		int HotKeyFullScreen { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002095 RID: 8341
		// (set) Token: 0x06002094 RID: 8340
		[DispId(115)]
		int HotKeyCtrlEsc { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002097 RID: 8343
		// (set) Token: 0x06002096 RID: 8342
		[DispId(116)]
		int HotKeyAltEsc { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002099 RID: 8345
		// (set) Token: 0x06002098 RID: 8344
		[DispId(117)]
		int HotKeyAltTab { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600209B RID: 8347
		// (set) Token: 0x0600209A RID: 8346
		[DispId(118)]
		int HotKeyAltShiftTab { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600209D RID: 8349
		// (set) Token: 0x0600209C RID: 8348
		[DispId(119)]
		int HotKeyAltSpace { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600209F RID: 8351
		// (set) Token: 0x0600209E RID: 8350
		[DispId(120)]
		int HotKeyCtrlAltDel { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060020A1 RID: 8353
		// (set) Token: 0x060020A0 RID: 8352
		[DispId(123)]
		int orderDrawThreshold { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060020A3 RID: 8355
		// (set) Token: 0x060020A2 RID: 8354
		[DispId(124)]
		int BitmapCacheSize { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060020A5 RID: 8357
		// (set) Token: 0x060020A4 RID: 8356
		[DispId(125)]
		int BitmapVirtualCacheSize { [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060020A7 RID: 8359
		// (set) Token: 0x060020A6 RID: 8358
		[DispId(175)]
		int ScaleBitmapCachesByBPP { [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060020A9 RID: 8361
		// (set) Token: 0x060020A8 RID: 8360
		[DispId(126)]
		int NumBitmapCaches { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060020AB RID: 8363
		// (set) Token: 0x060020AA RID: 8362
		[DispId(127)]
		int CachePersistenceActive { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006DA RID: 1754
		// (set) Token: 0x060020AC RID: 8364
		[DispId(138)]
		string PersistCacheDirectory { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060020AE RID: 8366
		// (set) Token: 0x060020AD RID: 8365
		[DispId(156)]
		int brushSupportLevel { [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060020B0 RID: 8368
		// (set) Token: 0x060020AF RID: 8367
		[DispId(157)]
		int minInputSendInterval { [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060020B2 RID: 8370
		// (set) Token: 0x060020B1 RID: 8369
		[DispId(158)]
		int InputEventsAtOnce { [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060020B4 RID: 8372
		// (set) Token: 0x060020B3 RID: 8371
		[DispId(159)]
		int maxEventCount { [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060020B6 RID: 8374
		// (set) Token: 0x060020B5 RID: 8373
		[DispId(160)]
		int keepAliveInterval { [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060020B8 RID: 8376
		// (set) Token: 0x060020B7 RID: 8375
		[DispId(163)]
		int shutdownTimeout { [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060020BA RID: 8378
		// (set) Token: 0x060020B9 RID: 8377
		[DispId(164)]
		int overallConnectionTimeout { [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060020BC RID: 8380
		// (set) Token: 0x060020BB RID: 8379
		[DispId(165)]
		int singleConnectionTimeout { [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060020BE RID: 8382
		// (set) Token: 0x060020BD RID: 8381
		[DispId(166)]
		int KeyboardType { [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060020C0 RID: 8384
		// (set) Token: 0x060020BF RID: 8383
		[DispId(167)]
		int KeyboardSubType { [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060020C2 RID: 8386
		// (set) Token: 0x060020C1 RID: 8385
		[DispId(168)]
		int KeyboardFunctionKey { [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060020C4 RID: 8388
		// (set) Token: 0x060020C3 RID: 8387
		[DispId(169)]
		int WinceFixedPalette { [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060020C6 RID: 8390
		// (set) Token: 0x060020C5 RID: 8389
		[DispId(178)]
		bool ConnectToServerConsole { [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060020C8 RID: 8392
		// (set) Token: 0x060020C7 RID: 8391
		[DispId(182)]
		int BitmapPersistence { [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060020CA RID: 8394
		// (set) Token: 0x060020C9 RID: 8393
		[DispId(183)]
		int MinutesToIdleTimeout { [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060020CC RID: 8396
		// (set) Token: 0x060020CB RID: 8395
		[DispId(184)]
		bool SmartSizing { [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060020CE RID: 8398
		// (set) Token: 0x060020CD RID: 8397
		[DispId(185)]
		string RdpdrLocalPrintingDocName { [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060020D0 RID: 8400
		// (set) Token: 0x060020CF RID: 8399
		[DispId(201)]
		string RdpdrClipCleanTempDirString { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060020D2 RID: 8402
		// (set) Token: 0x060020D1 RID: 8401
		[DispId(202)]
		string RdpdrClipPasteInfoString { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006EE RID: 1774
		// (set) Token: 0x060020D3 RID: 8403
		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060020D5 RID: 8405
		// (set) Token: 0x060020D4 RID: 8404
		[DispId(187)]
		bool DisplayConnectionBar { [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060020D7 RID: 8407
		// (set) Token: 0x060020D6 RID: 8406
		[DispId(188)]
		bool PinConnectionBar { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060020D9 RID: 8409
		// (set) Token: 0x060020D8 RID: 8408
		[DispId(189)]
		bool GrabFocusOnConnect { [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060020DB RID: 8411
		// (set) Token: 0x060020DA RID: 8410
		[DispId(190)]
		string LoadBalanceInfo { [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060020DD RID: 8413
		// (set) Token: 0x060020DC RID: 8412
		[DispId(191)]
		bool RedirectDrives { [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060020DF RID: 8415
		// (set) Token: 0x060020DE RID: 8414
		[DispId(192)]
		bool RedirectPrinters { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060020E1 RID: 8417
		// (set) Token: 0x060020E0 RID: 8416
		[DispId(193)]
		bool RedirectPorts { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060020E3 RID: 8419
		// (set) Token: 0x060020E2 RID: 8418
		[DispId(194)]
		bool RedirectSmartCards { [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060020E5 RID: 8421
		// (set) Token: 0x060020E4 RID: 8420
		[DispId(195)]
		int BitmapVirtualCache16BppSize { [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060020E7 RID: 8423
		// (set) Token: 0x060020E6 RID: 8422
		[DispId(196)]
		int BitmapVirtualCache24BppSize { [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060020E9 RID: 8425
		// (set) Token: 0x060020E8 RID: 8424
		[DispId(200)]
		int PerformanceFlags { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006FA RID: 1786
		// (set) Token: 0x060020EA RID: 8426
		[DispId(203)]
		ref object ConnectWithEndpoint { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060020EC RID: 8428
		// (set) Token: 0x060020EB RID: 8427
		[DispId(204)]
		bool NotifyTSPublicKey { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060020ED RID: 8429
		[DispId(205)]
		bool CanAutoReconnect { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060020EF RID: 8431
		// (set) Token: 0x060020EE RID: 8430
		[DispId(206)]
		bool EnableAutoReconnect { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060020F1 RID: 8433
		// (set) Token: 0x060020F0 RID: 8432
		[DispId(207)]
		int MaxReconnectAttempts { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
