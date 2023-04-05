using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001B7 RID: 439
	[Guid("FBA7F64E-6783-4405-DA45-FA4A763DABD0")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings5 : IMsRdpClientAdvancedSettings4
	{
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002C2E RID: 11310
		// (set) Token: 0x06002C2D RID: 11309
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002C30 RID: 11312
		// (set) Token: 0x06002C2F RID: 11311
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002C32 RID: 11314
		// (set) Token: 0x06002C31 RID: 11313
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C0E RID: 3086
		// (set) Token: 0x06002C33 RID: 11315
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C0F RID: 3087
		// (set) Token: 0x06002C34 RID: 11316
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C10 RID: 3088
		// (set) Token: 0x06002C35 RID: 11317
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C11 RID: 3089
		// (set) Token: 0x06002C36 RID: 11318
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002C38 RID: 11320
		// (set) Token: 0x06002C37 RID: 11319
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002C3A RID: 11322
		// (set) Token: 0x06002C39 RID: 11321
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002C3C RID: 11324
		// (set) Token: 0x06002C3B RID: 11323
		[DispId(101)]
		int SmoothScroll { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002C3E RID: 11326
		// (set) Token: 0x06002C3D RID: 11325
		[DispId(102)]
		int AcceleratorPassthrough { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002C40 RID: 11328
		// (set) Token: 0x06002C3F RID: 11327
		[DispId(103)]
		int ShadowBitmap { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002C42 RID: 11330
		// (set) Token: 0x06002C41 RID: 11329
		[DispId(104)]
		int TransportType { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002C44 RID: 11332
		// (set) Token: 0x06002C43 RID: 11331
		[DispId(105)]
		int SasSequence { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002C46 RID: 11334
		// (set) Token: 0x06002C45 RID: 11333
		[DispId(106)]
		int EncryptionEnabled { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002C48 RID: 11336
		// (set) Token: 0x06002C47 RID: 11335
		[DispId(107)]
		int DedicatedTerminal { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002C4A RID: 11338
		// (set) Token: 0x06002C49 RID: 11337
		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002C4C RID: 11340
		// (set) Token: 0x06002C4B RID: 11339
		[DispId(109)]
		int EnableMouse { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002C4E RID: 11342
		// (set) Token: 0x06002C4D RID: 11341
		[DispId(110)]
		int DisableCtrlAltDel { [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002C50 RID: 11344
		// (set) Token: 0x06002C4F RID: 11343
		[DispId(111)]
		int EnableWindowsKey { [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002C52 RID: 11346
		// (set) Token: 0x06002C51 RID: 11345
		[DispId(112)]
		int DoubleClickDetect { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002C54 RID: 11348
		// (set) Token: 0x06002C53 RID: 11347
		[DispId(113)]
		int MaximizeShell { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002C56 RID: 11350
		// (set) Token: 0x06002C55 RID: 11349
		[DispId(114)]
		int HotKeyFullScreen { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002C58 RID: 11352
		// (set) Token: 0x06002C57 RID: 11351
		[DispId(115)]
		int HotKeyCtrlEsc { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002C5A RID: 11354
		// (set) Token: 0x06002C59 RID: 11353
		[DispId(116)]
		int HotKeyAltEsc { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002C5C RID: 11356
		// (set) Token: 0x06002C5B RID: 11355
		[DispId(117)]
		int HotKeyAltTab { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002C5E RID: 11358
		// (set) Token: 0x06002C5D RID: 11357
		[DispId(118)]
		int HotKeyAltShiftTab { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002C60 RID: 11360
		// (set) Token: 0x06002C5F RID: 11359
		[DispId(119)]
		int HotKeyAltSpace { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002C62 RID: 11362
		// (set) Token: 0x06002C61 RID: 11361
		[DispId(120)]
		int HotKeyCtrlAltDel { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002C64 RID: 11364
		// (set) Token: 0x06002C63 RID: 11363
		[DispId(123)]
		int orderDrawThreshold { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002C66 RID: 11366
		// (set) Token: 0x06002C65 RID: 11365
		[DispId(124)]
		int BitmapCacheSize { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002C68 RID: 11368
		// (set) Token: 0x06002C67 RID: 11367
		[DispId(125)]
		int BitmapVirtualCacheSize { [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002C6A RID: 11370
		// (set) Token: 0x06002C69 RID: 11369
		[DispId(175)]
		int ScaleBitmapCachesByBPP { [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002C6C RID: 11372
		// (set) Token: 0x06002C6B RID: 11371
		[DispId(126)]
		int NumBitmapCaches { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002C6E RID: 11374
		// (set) Token: 0x06002C6D RID: 11373
		[DispId(127)]
		int CachePersistenceActive { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C2E RID: 3118
		// (set) Token: 0x06002C6F RID: 11375
		[DispId(138)]
		string PersistCacheDirectory { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002C71 RID: 11377
		// (set) Token: 0x06002C70 RID: 11376
		[DispId(156)]
		int brushSupportLevel { [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002C73 RID: 11379
		// (set) Token: 0x06002C72 RID: 11378
		[DispId(157)]
		int minInputSendInterval { [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002C75 RID: 11381
		// (set) Token: 0x06002C74 RID: 11380
		[DispId(158)]
		int InputEventsAtOnce { [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002C77 RID: 11383
		// (set) Token: 0x06002C76 RID: 11382
		[DispId(159)]
		int maxEventCount { [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002C79 RID: 11385
		// (set) Token: 0x06002C78 RID: 11384
		[DispId(160)]
		int keepAliveInterval { [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002C7B RID: 11387
		// (set) Token: 0x06002C7A RID: 11386
		[DispId(163)]
		int shutdownTimeout { [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002C7D RID: 11389
		// (set) Token: 0x06002C7C RID: 11388
		[DispId(164)]
		int overallConnectionTimeout { [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002C7F RID: 11391
		// (set) Token: 0x06002C7E RID: 11390
		[DispId(165)]
		int singleConnectionTimeout { [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002C81 RID: 11393
		// (set) Token: 0x06002C80 RID: 11392
		[DispId(166)]
		int KeyboardType { [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002C83 RID: 11395
		// (set) Token: 0x06002C82 RID: 11394
		[DispId(167)]
		int KeyboardSubType { [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002C85 RID: 11397
		// (set) Token: 0x06002C84 RID: 11396
		[DispId(168)]
		int KeyboardFunctionKey { [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002C87 RID: 11399
		// (set) Token: 0x06002C86 RID: 11398
		[DispId(169)]
		int WinceFixedPalette { [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002C89 RID: 11401
		// (set) Token: 0x06002C88 RID: 11400
		[DispId(178)]
		bool ConnectToServerConsole { [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002C8B RID: 11403
		// (set) Token: 0x06002C8A RID: 11402
		[DispId(182)]
		int BitmapPersistence { [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002C8D RID: 11405
		// (set) Token: 0x06002C8C RID: 11404
		[DispId(183)]
		int MinutesToIdleTimeout { [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002C8F RID: 11407
		// (set) Token: 0x06002C8E RID: 11406
		[DispId(184)]
		bool SmartSizing { [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002C91 RID: 11409
		// (set) Token: 0x06002C90 RID: 11408
		[DispId(185)]
		string RdpdrLocalPrintingDocName { [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002C93 RID: 11411
		// (set) Token: 0x06002C92 RID: 11410
		[DispId(201)]
		string RdpdrClipCleanTempDirString { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002C95 RID: 11413
		// (set) Token: 0x06002C94 RID: 11412
		[DispId(202)]
		string RdpdrClipPasteInfoString { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C42 RID: 3138
		// (set) Token: 0x06002C96 RID: 11414
		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002C98 RID: 11416
		// (set) Token: 0x06002C97 RID: 11415
		[DispId(187)]
		bool DisplayConnectionBar { [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002C9A RID: 11418
		// (set) Token: 0x06002C99 RID: 11417
		[DispId(188)]
		bool PinConnectionBar { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002C9C RID: 11420
		// (set) Token: 0x06002C9B RID: 11419
		[DispId(189)]
		bool GrabFocusOnConnect { [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002C9E RID: 11422
		// (set) Token: 0x06002C9D RID: 11421
		[DispId(190)]
		string LoadBalanceInfo { [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002CA0 RID: 11424
		// (set) Token: 0x06002C9F RID: 11423
		[DispId(191)]
		bool RedirectDrives { [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002CA2 RID: 11426
		// (set) Token: 0x06002CA1 RID: 11425
		[DispId(192)]
		bool RedirectPrinters { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002CA4 RID: 11428
		// (set) Token: 0x06002CA3 RID: 11427
		[DispId(193)]
		bool RedirectPorts { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002CA6 RID: 11430
		// (set) Token: 0x06002CA5 RID: 11429
		[DispId(194)]
		bool RedirectSmartCards { [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002CA8 RID: 11432
		// (set) Token: 0x06002CA7 RID: 11431
		[DispId(195)]
		int BitmapVirtualCache16BppSize { [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002CAA RID: 11434
		// (set) Token: 0x06002CA9 RID: 11433
		[DispId(196)]
		int BitmapVirtualCache24BppSize { [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002CAC RID: 11436
		// (set) Token: 0x06002CAB RID: 11435
		[DispId(200)]
		int PerformanceFlags { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C4E RID: 3150
		// (set) Token: 0x06002CAD RID: 11437
		[DispId(203)]
		ref object ConnectWithEndpoint { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002CAF RID: 11439
		// (set) Token: 0x06002CAE RID: 11438
		[DispId(204)]
		bool NotifyTSPublicKey { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002CB0 RID: 11440
		[DispId(205)]
		bool CanAutoReconnect { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002CB2 RID: 11442
		// (set) Token: 0x06002CB1 RID: 11441
		[DispId(206)]
		bool EnableAutoReconnect { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002CB4 RID: 11444
		// (set) Token: 0x06002CB3 RID: 11443
		[DispId(207)]
		int MaxReconnectAttempts { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002CB6 RID: 11446
		// (set) Token: 0x06002CB5 RID: 11445
		[DispId(210)]
		bool ConnectionBarShowMinimizeButton { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002CB8 RID: 11448
		// (set) Token: 0x06002CB7 RID: 11447
		[DispId(211)]
		bool ConnectionBarShowRestoreButton { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002CBA RID: 11450
		// (set) Token: 0x06002CB9 RID: 11449
		[DispId(212)]
		uint AuthenticationLevel { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002CBC RID: 11452
		// (set) Token: 0x06002CBB RID: 11451
		[DispId(213)]
		bool RedirectClipboard { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002CBE RID: 11454
		// (set) Token: 0x06002CBD RID: 11453
		[DispId(215)]
		uint AudioRedirectionMode { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002CC0 RID: 11456
		// (set) Token: 0x06002CBF RID: 11455
		[DispId(216)]
		bool ConnectionBarShowPinButton { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002CC2 RID: 11458
		// (set) Token: 0x06002CC1 RID: 11457
		[DispId(217)]
		bool PublicMode { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002CC4 RID: 11460
		// (set) Token: 0x06002CC3 RID: 11459
		[DispId(218)]
		bool RedirectDevices { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002CC6 RID: 11462
		// (set) Token: 0x06002CC5 RID: 11461
		[DispId(219)]
		bool RedirectPOSDevices { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002CC8 RID: 11464
		// (set) Token: 0x06002CC7 RID: 11463
		[DispId(220)]
		int BitmapVirtualCache32BppSize { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
