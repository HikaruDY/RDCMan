using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001A8 RID: 424
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[TypeLibType(34)]
	[ClassInterface(0)]
	[Guid("6A6F4B83-45C5-4CA9-BDD9-0D81C12295E4")]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient3aClass : IMsRdpClient3, MsRdpClient3a, IMsTscAxEvents_Event, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x06002522 RID: 9506
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient3aClass();

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002524 RID: 9508
		// (set) Token: 0x06002523 RID: 9507
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002526 RID: 9510
		// (set) Token: 0x06002525 RID: 9509
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002528 RID: 9512
		// (set) Token: 0x06002527 RID: 9511
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x0600252A RID: 9514
		// (set) Token: 0x06002529 RID: 9513
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600252C RID: 9516
		// (set) Token: 0x0600252B RID: 9515
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600252D RID: 9517
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600252F RID: 9519
		// (set) Token: 0x0600252E RID: 9518
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002531 RID: 9521
		// (set) Token: 0x06002530 RID: 9520
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002533 RID: 9523
		// (set) Token: 0x06002532 RID: 9522
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06002534 RID: 9524
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002535 RID: 9525
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008D2 RID: 2258
		// (set) Token: 0x06002536 RID: 9526
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002537 RID: 9527
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002538 RID: 9528
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002539 RID: 9529
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600253A RID: 9530
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600253B RID: 9531
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600253C RID: 9532
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600253D RID: 9533
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x0600253E RID: 9534
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x0600253F RID: 9535
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002540 RID: 9536
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002542 RID: 9538
		// (set) Token: 0x06002541 RID: 9537
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002543 RID: 9539
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002544 RID: 9540
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002545 RID: 9541
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002547 RID: 9543
		// (set) Token: 0x06002546 RID: 9542
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002548 RID: 9544
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002549 RID: 9545
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600254A RID: 9546
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600254B RID: 9547
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x0600254D RID: 9549
		// (set) Token: 0x0600254C RID: 9548
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x0600254E RID: 9550
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002550 RID: 9552
		// (set) Token: 0x0600254F RID: 9551
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002552 RID: 9554
		// (set) Token: 0x06002551 RID: 9553
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002554 RID: 9556
		// (set) Token: 0x06002553 RID: 9555
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002556 RID: 9558
		// (set) Token: 0x06002555 RID: 9557
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002558 RID: 9560
		// (set) Token: 0x06002557 RID: 9559
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002559 RID: 9561
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600255B RID: 9563
		// (set) Token: 0x0600255A RID: 9562
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600255D RID: 9565
		// (set) Token: 0x0600255C RID: 9564
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600255F RID: 9567
		// (set) Token: 0x0600255E RID: 9566
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002560 RID: 9568
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002561 RID: 9569
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008EC RID: 2284
		// (set) Token: 0x06002562 RID: 9570
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002563 RID: 9571
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002564 RID: 9572
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002565 RID: 9573
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002566 RID: 9574
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002567 RID: 9575
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002568 RID: 9576
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002569 RID: 9577
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x0600256A RID: 9578
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x0600256B RID: 9579
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600256C RID: 9580
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600256E RID: 9582
		// (set) Token: 0x0600256D RID: 9581
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x0600256F RID: 9583
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002570 RID: 9584
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002571 RID: 9585
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002573 RID: 9587
		// (set) Token: 0x06002572 RID: 9586
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002574 RID: 9588
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002575 RID: 9589
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002576 RID: 9590
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002577 RID: 9591
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002579 RID: 9593
		// (set) Token: 0x06002578 RID: 9592
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600257B RID: 9595
		// (set) Token: 0x0600257A RID: 9594
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600257D RID: 9597
		// (set) Token: 0x0600257C RID: 9596
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600257F RID: 9599
		// (set) Token: 0x0600257E RID: 9598
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002581 RID: 9601
		// (set) Token: 0x06002580 RID: 9600
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002583 RID: 9603
		// (set) Token: 0x06002582 RID: 9602
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002584 RID: 9604
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002586 RID: 9606
		// (set) Token: 0x06002585 RID: 9605
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002588 RID: 9608
		// (set) Token: 0x06002587 RID: 9607
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x0600258A RID: 9610
		// (set) Token: 0x06002589 RID: 9609
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x0600258B RID: 9611
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600258C RID: 9612
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000905 RID: 2309
		// (set) Token: 0x0600258D RID: 9613
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600258E RID: 9614
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600258F RID: 9615
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002590 RID: 9616
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002591 RID: 9617
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002592 RID: 9618
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002593 RID: 9619
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002594 RID: 9620
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06002595 RID: 9621
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06002596 RID: 9622
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002597 RID: 9623
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002599 RID: 9625
		// (set) Token: 0x06002598 RID: 9624
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600259A RID: 9626
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600259B RID: 9627
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600259C RID: 9628
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x0600259E RID: 9630
		// (set) Token: 0x0600259D RID: 9629
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600259F RID: 9631
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060025A0 RID: 9632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060025A1 RID: 9633
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060025A3 RID: 9635
		// (set) Token: 0x060025A2 RID: 9634
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060025A5 RID: 9637
		// (set) Token: 0x060025A4 RID: 9636
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060025A7 RID: 9639
		// (set) Token: 0x060025A6 RID: 9638
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060025A9 RID: 9641
		// (set) Token: 0x060025A8 RID: 9640
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060025AB RID: 9643
		// (set) Token: 0x060025AA RID: 9642
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060025AC RID: 9644
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060025AE RID: 9646
		// (set) Token: 0x060025AD RID: 9645
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060025B0 RID: 9648
		// (set) Token: 0x060025AF RID: 9647
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060025B2 RID: 9650
		// (set) Token: 0x060025B1 RID: 9649
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060025B3 RID: 9651
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060025B4 RID: 9652
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700091C RID: 2332
		// (set) Token: 0x060025B5 RID: 9653
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060025B6 RID: 9654
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060025B7 RID: 9655
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060025B8 RID: 9656
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060025B9 RID: 9657
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060025BA RID: 9658
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060025BB RID: 9659
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060025BC RID: 9660
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x060025BD RID: 9661
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x060025BE RID: 9662
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060025BF RID: 9663
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000923 RID: 2339
		// (set) Token: 0x060025C0 RID: 9664
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060025C2 RID: 9666
		// (set) Token: 0x060025C1 RID: 9665
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060025C4 RID: 9668
		// (set) Token: 0x060025C3 RID: 9667
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060025C6 RID: 9670
		// (set) Token: 0x060025C5 RID: 9669
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060025C8 RID: 9672
		// (set) Token: 0x060025C7 RID: 9671
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060025C9 RID: 9673
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17000928 RID: 2344
		// (set) Token: 0x060025CA RID: 9674
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060025CC RID: 9676
		// (set) Token: 0x060025CB RID: 9675
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060025CE RID: 9678
		// (set) Token: 0x060025CD RID: 9677
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060025D0 RID: 9680
		// (set) Token: 0x060025CF RID: 9679
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060025D2 RID: 9682
		// (set) Token: 0x060025D1 RID: 9681
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060025D3 RID: 9683
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x060025D4 RID: 9684
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060025D5 RID: 9685
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x14000477 RID: 1143
		// (add) Token: 0x060025D6 RID: 9686
		// (remove) Token: 0x060025D7 RID: 9687
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000478 RID: 1144
		// (add) Token: 0x060025D8 RID: 9688
		// (remove) Token: 0x060025D9 RID: 9689
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000479 RID: 1145
		// (add) Token: 0x060025DA RID: 9690
		// (remove) Token: 0x060025DB RID: 9691
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400047A RID: 1146
		// (add) Token: 0x060025DC RID: 9692
		// (remove) Token: 0x060025DD RID: 9693
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400047B RID: 1147
		// (add) Token: 0x060025DE RID: 9694
		// (remove) Token: 0x060025DF RID: 9695
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400047C RID: 1148
		// (add) Token: 0x060025E0 RID: 9696
		// (remove) Token: 0x060025E1 RID: 9697
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400047D RID: 1149
		// (add) Token: 0x060025E2 RID: 9698
		// (remove) Token: 0x060025E3 RID: 9699
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400047E RID: 1150
		// (add) Token: 0x060025E4 RID: 9700
		// (remove) Token: 0x060025E5 RID: 9701
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400047F RID: 1151
		// (add) Token: 0x060025E6 RID: 9702
		// (remove) Token: 0x060025E7 RID: 9703
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000480 RID: 1152
		// (add) Token: 0x060025E8 RID: 9704
		// (remove) Token: 0x060025E9 RID: 9705
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000481 RID: 1153
		// (add) Token: 0x060025EA RID: 9706
		// (remove) Token: 0x060025EB RID: 9707
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000482 RID: 1154
		// (add) Token: 0x060025EC RID: 9708
		// (remove) Token: 0x060025ED RID: 9709
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000483 RID: 1155
		// (add) Token: 0x060025EE RID: 9710
		// (remove) Token: 0x060025EF RID: 9711
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000484 RID: 1156
		// (add) Token: 0x060025F0 RID: 9712
		// (remove) Token: 0x060025F1 RID: 9713
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000485 RID: 1157
		// (add) Token: 0x060025F2 RID: 9714
		// (remove) Token: 0x060025F3 RID: 9715
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000486 RID: 1158
		// (add) Token: 0x060025F4 RID: 9716
		// (remove) Token: 0x060025F5 RID: 9717
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000487 RID: 1159
		// (add) Token: 0x060025F6 RID: 9718
		// (remove) Token: 0x060025F7 RID: 9719
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000488 RID: 1160
		// (add) Token: 0x060025F8 RID: 9720
		// (remove) Token: 0x060025F9 RID: 9721
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000489 RID: 1161
		// (add) Token: 0x060025FA RID: 9722
		// (remove) Token: 0x060025FB RID: 9723
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400048A RID: 1162
		// (add) Token: 0x060025FC RID: 9724
		// (remove) Token: 0x060025FD RID: 9725
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400048B RID: 1163
		// (add) Token: 0x060025FE RID: 9726
		// (remove) Token: 0x060025FF RID: 9727
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400048C RID: 1164
		// (add) Token: 0x06002600 RID: 9728
		// (remove) Token: 0x06002601 RID: 9729
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400048D RID: 1165
		// (add) Token: 0x06002602 RID: 9730
		// (remove) Token: 0x06002603 RID: 9731
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400048E RID: 1166
		// (add) Token: 0x06002604 RID: 9732
		// (remove) Token: 0x06002605 RID: 9733
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400048F RID: 1167
		// (add) Token: 0x06002606 RID: 9734
		// (remove) Token: 0x06002607 RID: 9735
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000490 RID: 1168
		// (add) Token: 0x06002608 RID: 9736
		// (remove) Token: 0x06002609 RID: 9737
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000491 RID: 1169
		// (add) Token: 0x0600260A RID: 9738
		// (remove) Token: 0x0600260B RID: 9739
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000492 RID: 1170
		// (add) Token: 0x0600260C RID: 9740
		// (remove) Token: 0x0600260D RID: 9741
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000493 RID: 1171
		// (add) Token: 0x0600260E RID: 9742
		// (remove) Token: 0x0600260F RID: 9743
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000494 RID: 1172
		// (add) Token: 0x06002610 RID: 9744
		// (remove) Token: 0x06002611 RID: 9745
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000495 RID: 1173
		// (add) Token: 0x06002612 RID: 9746
		// (remove) Token: 0x06002613 RID: 9747
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000496 RID: 1174
		// (add) Token: 0x06002614 RID: 9748
		// (remove) Token: 0x06002615 RID: 9749
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
