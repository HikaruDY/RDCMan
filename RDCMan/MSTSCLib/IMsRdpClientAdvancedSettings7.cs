using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001CE RID: 462
	[Guid("26036036-4010-4578-8091-0DB9A1EDF9C3")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings7 : IMsRdpClientAdvancedSettings6
	{
		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06003627 RID: 13863
		// (set) Token: 0x06003626 RID: 13862
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06003629 RID: 13865
		// (set) Token: 0x06003628 RID: 13864
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x0600362B RID: 13867
		// (set) Token: 0x0600362A RID: 13866
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700111A RID: 4378
		// (set) Token: 0x0600362C RID: 13868
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700111B RID: 4379
		// (set) Token: 0x0600362D RID: 13869
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700111C RID: 4380
		// (set) Token: 0x0600362E RID: 13870
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700111D RID: 4381
		// (set) Token: 0x0600362F RID: 13871
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06003631 RID: 13873
		// (set) Token: 0x06003630 RID: 13872
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06003633 RID: 13875
		// (set) Token: 0x06003632 RID: 13874
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06003635 RID: 13877
		// (set) Token: 0x06003634 RID: 13876
		[DispId(101)]
		int SmoothScroll { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06003637 RID: 13879
		// (set) Token: 0x06003636 RID: 13878
		[DispId(102)]
		int AcceleratorPassthrough { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06003639 RID: 13881
		// (set) Token: 0x06003638 RID: 13880
		[DispId(103)]
		int ShadowBitmap { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600363B RID: 13883
		// (set) Token: 0x0600363A RID: 13882
		[DispId(104)]
		int TransportType { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x0600363D RID: 13885
		// (set) Token: 0x0600363C RID: 13884
		[DispId(105)]
		int SasSequence { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x0600363F RID: 13887
		// (set) Token: 0x0600363E RID: 13886
		[DispId(106)]
		int EncryptionEnabled { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06003641 RID: 13889
		// (set) Token: 0x06003640 RID: 13888
		[DispId(107)]
		int DedicatedTerminal { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06003643 RID: 13891
		// (set) Token: 0x06003642 RID: 13890
		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06003645 RID: 13893
		// (set) Token: 0x06003644 RID: 13892
		[DispId(109)]
		int EnableMouse { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06003647 RID: 13895
		// (set) Token: 0x06003646 RID: 13894
		[DispId(110)]
		int DisableCtrlAltDel { [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06003649 RID: 13897
		// (set) Token: 0x06003648 RID: 13896
		[DispId(111)]
		int EnableWindowsKey { [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x0600364B RID: 13899
		// (set) Token: 0x0600364A RID: 13898
		[DispId(112)]
		int DoubleClickDetect { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x0600364D RID: 13901
		// (set) Token: 0x0600364C RID: 13900
		[DispId(113)]
		int MaximizeShell { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x0600364F RID: 13903
		// (set) Token: 0x0600364E RID: 13902
		[DispId(114)]
		int HotKeyFullScreen { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06003651 RID: 13905
		// (set) Token: 0x06003650 RID: 13904
		[DispId(115)]
		int HotKeyCtrlEsc { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06003653 RID: 13907
		// (set) Token: 0x06003652 RID: 13906
		[DispId(116)]
		int HotKeyAltEsc { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06003655 RID: 13909
		// (set) Token: 0x06003654 RID: 13908
		[DispId(117)]
		int HotKeyAltTab { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06003657 RID: 13911
		// (set) Token: 0x06003656 RID: 13910
		[DispId(118)]
		int HotKeyAltShiftTab { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06003659 RID: 13913
		// (set) Token: 0x06003658 RID: 13912
		[DispId(119)]
		int HotKeyAltSpace { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x0600365B RID: 13915
		// (set) Token: 0x0600365A RID: 13914
		[DispId(120)]
		int HotKeyCtrlAltDel { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x0600365D RID: 13917
		// (set) Token: 0x0600365C RID: 13916
		[DispId(123)]
		int orderDrawThreshold { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600365F RID: 13919
		// (set) Token: 0x0600365E RID: 13918
		[DispId(124)]
		int BitmapCacheSize { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06003661 RID: 13921
		// (set) Token: 0x06003660 RID: 13920
		[DispId(125)]
		int BitmapVirtualCacheSize { [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06003663 RID: 13923
		// (set) Token: 0x06003662 RID: 13922
		[DispId(175)]
		int ScaleBitmapCachesByBPP { [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06003665 RID: 13925
		// (set) Token: 0x06003664 RID: 13924
		[DispId(126)]
		int NumBitmapCaches { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06003667 RID: 13927
		// (set) Token: 0x06003666 RID: 13926
		[DispId(127)]
		int CachePersistenceActive { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700113A RID: 4410
		// (set) Token: 0x06003668 RID: 13928
		[DispId(138)]
		string PersistCacheDirectory { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x0600366A RID: 13930
		// (set) Token: 0x06003669 RID: 13929
		[DispId(156)]
		int brushSupportLevel { [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600366C RID: 13932
		// (set) Token: 0x0600366B RID: 13931
		[DispId(157)]
		int minInputSendInterval { [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600366E RID: 13934
		// (set) Token: 0x0600366D RID: 13933
		[DispId(158)]
		int InputEventsAtOnce { [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06003670 RID: 13936
		// (set) Token: 0x0600366F RID: 13935
		[DispId(159)]
		int maxEventCount { [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06003672 RID: 13938
		// (set) Token: 0x06003671 RID: 13937
		[DispId(160)]
		int keepAliveInterval { [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06003674 RID: 13940
		// (set) Token: 0x06003673 RID: 13939
		[DispId(163)]
		int shutdownTimeout { [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06003676 RID: 13942
		// (set) Token: 0x06003675 RID: 13941
		[DispId(164)]
		int overallConnectionTimeout { [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06003678 RID: 13944
		// (set) Token: 0x06003677 RID: 13943
		[DispId(165)]
		int singleConnectionTimeout { [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600367A RID: 13946
		// (set) Token: 0x06003679 RID: 13945
		[DispId(166)]
		int KeyboardType { [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x0600367C RID: 13948
		// (set) Token: 0x0600367B RID: 13947
		[DispId(167)]
		int KeyboardSubType { [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x0600367E RID: 13950
		// (set) Token: 0x0600367D RID: 13949
		[DispId(168)]
		int KeyboardFunctionKey { [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06003680 RID: 13952
		// (set) Token: 0x0600367F RID: 13951
		[DispId(169)]
		int WinceFixedPalette { [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06003682 RID: 13954
		// (set) Token: 0x06003681 RID: 13953
		[DispId(178)]
		bool ConnectToServerConsole { [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06003684 RID: 13956
		// (set) Token: 0x06003683 RID: 13955
		[DispId(182)]
		int BitmapPersistence { [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06003686 RID: 13958
		// (set) Token: 0x06003685 RID: 13957
		[DispId(183)]
		int MinutesToIdleTimeout { [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06003688 RID: 13960
		// (set) Token: 0x06003687 RID: 13959
		[DispId(184)]
		bool SmartSizing { [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x0600368A RID: 13962
		// (set) Token: 0x06003689 RID: 13961
		[DispId(185)]
		string RdpdrLocalPrintingDocName { [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x0600368C RID: 13964
		// (set) Token: 0x0600368B RID: 13963
		[DispId(201)]
		string RdpdrClipCleanTempDirString { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x0600368E RID: 13966
		// (set) Token: 0x0600368D RID: 13965
		[DispId(202)]
		string RdpdrClipPasteInfoString { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700114E RID: 4430
		// (set) Token: 0x0600368F RID: 13967
		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06003691 RID: 13969
		// (set) Token: 0x06003690 RID: 13968
		[DispId(187)]
		bool DisplayConnectionBar { [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06003693 RID: 13971
		// (set) Token: 0x06003692 RID: 13970
		[DispId(188)]
		bool PinConnectionBar { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06003695 RID: 13973
		// (set) Token: 0x06003694 RID: 13972
		[DispId(189)]
		bool GrabFocusOnConnect { [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06003697 RID: 13975
		// (set) Token: 0x06003696 RID: 13974
		[DispId(190)]
		string LoadBalanceInfo { [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06003699 RID: 13977
		// (set) Token: 0x06003698 RID: 13976
		[DispId(191)]
		bool RedirectDrives { [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600369B RID: 13979
		// (set) Token: 0x0600369A RID: 13978
		[DispId(192)]
		bool RedirectPrinters { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600369D RID: 13981
		// (set) Token: 0x0600369C RID: 13980
		[DispId(193)]
		bool RedirectPorts { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x0600369F RID: 13983
		// (set) Token: 0x0600369E RID: 13982
		[DispId(194)]
		bool RedirectSmartCards { [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x060036A1 RID: 13985
		// (set) Token: 0x060036A0 RID: 13984
		[DispId(195)]
		int BitmapVirtualCache16BppSize { [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060036A3 RID: 13987
		// (set) Token: 0x060036A2 RID: 13986
		[DispId(196)]
		int BitmapVirtualCache24BppSize { [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060036A5 RID: 13989
		// (set) Token: 0x060036A4 RID: 13988
		[DispId(200)]
		int PerformanceFlags { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700115A RID: 4442
		// (set) Token: 0x060036A6 RID: 13990
		[DispId(203)]
		ref object ConnectWithEndpoint { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060036A8 RID: 13992
		// (set) Token: 0x060036A7 RID: 13991
		[DispId(204)]
		bool NotifyTSPublicKey { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x060036A9 RID: 13993
		[DispId(205)]
		bool CanAutoReconnect { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x060036AB RID: 13995
		// (set) Token: 0x060036AA RID: 13994
		[DispId(206)]
		bool EnableAutoReconnect { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x060036AD RID: 13997
		// (set) Token: 0x060036AC RID: 13996
		[DispId(207)]
		int MaxReconnectAttempts { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x060036AF RID: 13999
		// (set) Token: 0x060036AE RID: 13998
		[DispId(210)]
		bool ConnectionBarShowMinimizeButton { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x060036B1 RID: 14001
		// (set) Token: 0x060036B0 RID: 14000
		[DispId(211)]
		bool ConnectionBarShowRestoreButton { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x060036B3 RID: 14003
		// (set) Token: 0x060036B2 RID: 14002
		[DispId(212)]
		uint AuthenticationLevel { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x060036B5 RID: 14005
		// (set) Token: 0x060036B4 RID: 14004
		[DispId(213)]
		bool RedirectClipboard { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x060036B7 RID: 14007
		// (set) Token: 0x060036B6 RID: 14006
		[DispId(215)]
		uint AudioRedirectionMode { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060036B9 RID: 14009
		// (set) Token: 0x060036B8 RID: 14008
		[DispId(216)]
		bool ConnectionBarShowPinButton { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x060036BB RID: 14011
		// (set) Token: 0x060036BA RID: 14010
		[DispId(217)]
		bool PublicMode { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x060036BD RID: 14013
		// (set) Token: 0x060036BC RID: 14012
		[DispId(218)]
		bool RedirectDevices { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x060036BF RID: 14015
		// (set) Token: 0x060036BE RID: 14014
		[DispId(219)]
		bool RedirectPOSDevices { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x060036C1 RID: 14017
		// (set) Token: 0x060036C0 RID: 14016
		[DispId(220)]
		int BitmapVirtualCache32BppSize { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x060036C3 RID: 14019
		// (set) Token: 0x060036C2 RID: 14018
		[DispId(221)]
		bool RelativeMouseMode { [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x060036C4 RID: 14020
		// (set) Token: 0x060036C5 RID: 14021
		[DispId(222)]
		string AuthenticationServiceClass { [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x060036C6 RID: 14022
		// (set) Token: 0x060036C7 RID: 14023
		[DispId(223)]
		string PCB { [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x060036C9 RID: 14025
		// (set) Token: 0x060036C8 RID: 14024
		[DispId(224)]
		int HotKeyFocusReleaseLeft { [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x060036CB RID: 14027
		// (set) Token: 0x060036CA RID: 14026
		[DispId(225)]
		int HotKeyFocusReleaseRight { [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x060036CD RID: 14029
		// (set) Token: 0x060036CC RID: 14028
		[DispId(17)]
		bool EnableCredSspSupport { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x060036CE RID: 14030
		[DispId(226)]
		uint AuthenticationType { [DispId(226)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x060036D0 RID: 14032
		// (set) Token: 0x060036CF RID: 14031
		[DispId(227)]
		bool ConnectToAdministerServer { [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(227)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060036D2 RID: 14034
		// (set) Token: 0x060036D1 RID: 14033
		[DispId(228)]
		bool AudioCaptureRedirectionMode { [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(228)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060036D4 RID: 14036
		// (set) Token: 0x060036D3 RID: 14035
		[DispId(229)]
		uint VideoPlaybackMode { [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(229)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x060036D6 RID: 14038
		// (set) Token: 0x060036D5 RID: 14037
		[DispId(230)]
		bool EnableSuperPan { [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(230)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x060036D8 RID: 14040
		// (set) Token: 0x060036D7 RID: 14039
		[DispId(231)]
		uint SuperPanAccelerationFactor { [DispId(231)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(231)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x060036DA RID: 14042
		// (set) Token: 0x060036D9 RID: 14041
		[DispId(232)]
		bool NegotiateSecurityLayer { [DispId(232)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(232)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060036DC RID: 14044
		// (set) Token: 0x060036DB RID: 14043
		[DispId(233)]
		uint AudioQualityMode { [DispId(233)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(233)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060036DE RID: 14046
		// (set) Token: 0x060036DD RID: 14045
		[DispId(234)]
		bool RedirectDirectX { [DispId(234)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(234)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060036E0 RID: 14048
		// (set) Token: 0x060036DF RID: 14047
		[DispId(235)]
		uint NetworkConnectionType { [DispId(235)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(235)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
