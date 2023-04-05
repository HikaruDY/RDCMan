using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001AD RID: 429
	[Guid("FBA7F64E-7345-4405-AE50-FA4A763DC0DE")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings4 : IMsRdpClientAdvancedSettings3
	{
		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002773 RID: 10099
		// (set) Token: 0x06002772 RID: 10098
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002775 RID: 10101
		// (set) Token: 0x06002774 RID: 10100
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002777 RID: 10103
		// (set) Token: 0x06002776 RID: 10102
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009D2 RID: 2514
		// (set) Token: 0x06002778 RID: 10104
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009D3 RID: 2515
		// (set) Token: 0x06002779 RID: 10105
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009D4 RID: 2516
		// (set) Token: 0x0600277A RID: 10106
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009D5 RID: 2517
		// (set) Token: 0x0600277B RID: 10107
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600277D RID: 10109
		// (set) Token: 0x0600277C RID: 10108
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x0600277F RID: 10111
		// (set) Token: 0x0600277E RID: 10110
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002781 RID: 10113
		// (set) Token: 0x06002780 RID: 10112
		[DispId(101)]
		int SmoothScroll { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002783 RID: 10115
		// (set) Token: 0x06002782 RID: 10114
		[DispId(102)]
		int AcceleratorPassthrough { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002785 RID: 10117
		// (set) Token: 0x06002784 RID: 10116
		[DispId(103)]
		int ShadowBitmap { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002787 RID: 10119
		// (set) Token: 0x06002786 RID: 10118
		[DispId(104)]
		int TransportType { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002789 RID: 10121
		// (set) Token: 0x06002788 RID: 10120
		[DispId(105)]
		int SasSequence { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x0600278B RID: 10123
		// (set) Token: 0x0600278A RID: 10122
		[DispId(106)]
		int EncryptionEnabled { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x0600278D RID: 10125
		// (set) Token: 0x0600278C RID: 10124
		[DispId(107)]
		int DedicatedTerminal { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600278F RID: 10127
		// (set) Token: 0x0600278E RID: 10126
		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002791 RID: 10129
		// (set) Token: 0x06002790 RID: 10128
		[DispId(109)]
		int EnableMouse { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002793 RID: 10131
		// (set) Token: 0x06002792 RID: 10130
		[DispId(110)]
		int DisableCtrlAltDel { [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002795 RID: 10133
		// (set) Token: 0x06002794 RID: 10132
		[DispId(111)]
		int EnableWindowsKey { [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002797 RID: 10135
		// (set) Token: 0x06002796 RID: 10134
		[DispId(112)]
		int DoubleClickDetect { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002799 RID: 10137
		// (set) Token: 0x06002798 RID: 10136
		[DispId(113)]
		int MaximizeShell { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600279B RID: 10139
		// (set) Token: 0x0600279A RID: 10138
		[DispId(114)]
		int HotKeyFullScreen { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600279D RID: 10141
		// (set) Token: 0x0600279C RID: 10140
		[DispId(115)]
		int HotKeyCtrlEsc { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600279F RID: 10143
		// (set) Token: 0x0600279E RID: 10142
		[DispId(116)]
		int HotKeyAltEsc { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060027A1 RID: 10145
		// (set) Token: 0x060027A0 RID: 10144
		[DispId(117)]
		int HotKeyAltTab { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060027A3 RID: 10147
		// (set) Token: 0x060027A2 RID: 10146
		[DispId(118)]
		int HotKeyAltShiftTab { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060027A5 RID: 10149
		// (set) Token: 0x060027A4 RID: 10148
		[DispId(119)]
		int HotKeyAltSpace { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060027A7 RID: 10151
		// (set) Token: 0x060027A6 RID: 10150
		[DispId(120)]
		int HotKeyCtrlAltDel { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060027A9 RID: 10153
		// (set) Token: 0x060027A8 RID: 10152
		[DispId(123)]
		int orderDrawThreshold { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060027AB RID: 10155
		// (set) Token: 0x060027AA RID: 10154
		[DispId(124)]
		int BitmapCacheSize { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060027AD RID: 10157
		// (set) Token: 0x060027AC RID: 10156
		[DispId(125)]
		int BitmapVirtualCacheSize { [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060027AF RID: 10159
		// (set) Token: 0x060027AE RID: 10158
		[DispId(175)]
		int ScaleBitmapCachesByBPP { [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060027B1 RID: 10161
		// (set) Token: 0x060027B0 RID: 10160
		[DispId(126)]
		int NumBitmapCaches { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060027B3 RID: 10163
		// (set) Token: 0x060027B2 RID: 10162
		[DispId(127)]
		int CachePersistenceActive { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F2 RID: 2546
		// (set) Token: 0x060027B4 RID: 10164
		[DispId(138)]
		string PersistCacheDirectory { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060027B6 RID: 10166
		// (set) Token: 0x060027B5 RID: 10165
		[DispId(156)]
		int brushSupportLevel { [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060027B8 RID: 10168
		// (set) Token: 0x060027B7 RID: 10167
		[DispId(157)]
		int minInputSendInterval { [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060027BA RID: 10170
		// (set) Token: 0x060027B9 RID: 10169
		[DispId(158)]
		int InputEventsAtOnce { [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060027BC RID: 10172
		// (set) Token: 0x060027BB RID: 10171
		[DispId(159)]
		int maxEventCount { [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060027BE RID: 10174
		// (set) Token: 0x060027BD RID: 10173
		[DispId(160)]
		int keepAliveInterval { [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060027C0 RID: 10176
		// (set) Token: 0x060027BF RID: 10175
		[DispId(163)]
		int shutdownTimeout { [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060027C2 RID: 10178
		// (set) Token: 0x060027C1 RID: 10177
		[DispId(164)]
		int overallConnectionTimeout { [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060027C4 RID: 10180
		// (set) Token: 0x060027C3 RID: 10179
		[DispId(165)]
		int singleConnectionTimeout { [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060027C6 RID: 10182
		// (set) Token: 0x060027C5 RID: 10181
		[DispId(166)]
		int KeyboardType { [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060027C8 RID: 10184
		// (set) Token: 0x060027C7 RID: 10183
		[DispId(167)]
		int KeyboardSubType { [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060027CA RID: 10186
		// (set) Token: 0x060027C9 RID: 10185
		[DispId(168)]
		int KeyboardFunctionKey { [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060027CC RID: 10188
		// (set) Token: 0x060027CB RID: 10187
		[DispId(169)]
		int WinceFixedPalette { [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060027CE RID: 10190
		// (set) Token: 0x060027CD RID: 10189
		[DispId(178)]
		bool ConnectToServerConsole { [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060027D0 RID: 10192
		// (set) Token: 0x060027CF RID: 10191
		[DispId(182)]
		int BitmapPersistence { [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060027D2 RID: 10194
		// (set) Token: 0x060027D1 RID: 10193
		[DispId(183)]
		int MinutesToIdleTimeout { [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060027D4 RID: 10196
		// (set) Token: 0x060027D3 RID: 10195
		[DispId(184)]
		bool SmartSizing { [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060027D6 RID: 10198
		// (set) Token: 0x060027D5 RID: 10197
		[DispId(185)]
		string RdpdrLocalPrintingDocName { [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060027D8 RID: 10200
		// (set) Token: 0x060027D7 RID: 10199
		[DispId(201)]
		string RdpdrClipCleanTempDirString { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060027DA RID: 10202
		// (set) Token: 0x060027D9 RID: 10201
		[DispId(202)]
		string RdpdrClipPasteInfoString { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A06 RID: 2566
		// (set) Token: 0x060027DB RID: 10203
		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060027DD RID: 10205
		// (set) Token: 0x060027DC RID: 10204
		[DispId(187)]
		bool DisplayConnectionBar { [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060027DF RID: 10207
		// (set) Token: 0x060027DE RID: 10206
		[DispId(188)]
		bool PinConnectionBar { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060027E1 RID: 10209
		// (set) Token: 0x060027E0 RID: 10208
		[DispId(189)]
		bool GrabFocusOnConnect { [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060027E3 RID: 10211
		// (set) Token: 0x060027E2 RID: 10210
		[DispId(190)]
		string LoadBalanceInfo { [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060027E5 RID: 10213
		// (set) Token: 0x060027E4 RID: 10212
		[DispId(191)]
		bool RedirectDrives { [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060027E7 RID: 10215
		// (set) Token: 0x060027E6 RID: 10214
		[DispId(192)]
		bool RedirectPrinters { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060027E9 RID: 10217
		// (set) Token: 0x060027E8 RID: 10216
		[DispId(193)]
		bool RedirectPorts { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x060027EB RID: 10219
		// (set) Token: 0x060027EA RID: 10218
		[DispId(194)]
		bool RedirectSmartCards { [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x060027ED RID: 10221
		// (set) Token: 0x060027EC RID: 10220
		[DispId(195)]
		int BitmapVirtualCache16BppSize { [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060027EF RID: 10223
		// (set) Token: 0x060027EE RID: 10222
		[DispId(196)]
		int BitmapVirtualCache24BppSize { [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x060027F1 RID: 10225
		// (set) Token: 0x060027F0 RID: 10224
		[DispId(200)]
		int PerformanceFlags { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A12 RID: 2578
		// (set) Token: 0x060027F2 RID: 10226
		[DispId(203)]
		ref object ConnectWithEndpoint { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x060027F4 RID: 10228
		// (set) Token: 0x060027F3 RID: 10227
		[DispId(204)]
		bool NotifyTSPublicKey { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060027F5 RID: 10229
		[DispId(205)]
		bool CanAutoReconnect { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060027F7 RID: 10231
		// (set) Token: 0x060027F6 RID: 10230
		[DispId(206)]
		bool EnableAutoReconnect { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060027F9 RID: 10233
		// (set) Token: 0x060027F8 RID: 10232
		[DispId(207)]
		int MaxReconnectAttempts { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060027FB RID: 10235
		// (set) Token: 0x060027FA RID: 10234
		[DispId(210)]
		bool ConnectionBarShowMinimizeButton { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x060027FD RID: 10237
		// (set) Token: 0x060027FC RID: 10236
		[DispId(211)]
		bool ConnectionBarShowRestoreButton { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x060027FF RID: 10239
		// (set) Token: 0x060027FE RID: 10238
		[DispId(212)]
		uint AuthenticationLevel { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
