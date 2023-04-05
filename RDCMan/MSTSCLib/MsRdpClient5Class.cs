using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001BF RID: 447
	[ClassInterface(0)]
	[Guid("4EB89FF4-7F78-4A0F-8B8D-2BF02E94E4B2")]
	[TypeLibType(34)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient5Class : IMsRdpClient5, MsRdpClient5, IMsTscAxEvents_Event, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3
	{
		// Token: 0x06002D06 RID: 11526
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient5Class();

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002D08 RID: 11528
		// (set) Token: 0x06002D07 RID: 11527
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002D0A RID: 11530
		// (set) Token: 0x06002D09 RID: 11529
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002D0C RID: 11532
		// (set) Token: 0x06002D0B RID: 11531
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002D0E RID: 11534
		// (set) Token: 0x06002D0D RID: 11533
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002D10 RID: 11536
		// (set) Token: 0x06002D0F RID: 11535
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002D11 RID: 11537
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002D13 RID: 11539
		// (set) Token: 0x06002D12 RID: 11538
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002D15 RID: 11541
		// (set) Token: 0x06002D14 RID: 11540
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002D17 RID: 11543
		// (set) Token: 0x06002D16 RID: 11542
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002D18 RID: 11544
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002D19 RID: 11545
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000C88 RID: 3208
		// (set) Token: 0x06002D1A RID: 11546
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002D1B RID: 11547
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002D1C RID: 11548
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06002D1D RID: 11549
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002D1E RID: 11550
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002D1F RID: 11551
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002D20 RID: 11552
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002D21 RID: 11553
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06002D22 RID: 11554
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06002D23 RID: 11555
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002D24 RID: 11556
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002D26 RID: 11558
		// (set) Token: 0x06002D25 RID: 11557
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06002D27 RID: 11559
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06002D28 RID: 11560
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002D29 RID: 11561
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002D2B RID: 11563
		// (set) Token: 0x06002D2A RID: 11562
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002D2C RID: 11564
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002D2D RID: 11565
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002D2E RID: 11566
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002D2F RID: 11567
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002D31 RID: 11569
		// (set) Token: 0x06002D30 RID: 11568
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002D32 RID: 11570
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002D33 RID: 11571
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002D34 RID: 11572
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002D35 RID: 11573
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002D36 RID: 11574
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002D37 RID: 11575
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002D38 RID: 11576
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002D3A RID: 11578
		// (set) Token: 0x06002D39 RID: 11577
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002D3C RID: 11580
		// (set) Token: 0x06002D3B RID: 11579
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002D3E RID: 11582
		// (set) Token: 0x06002D3D RID: 11581
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002D40 RID: 11584
		// (set) Token: 0x06002D3F RID: 11583
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002D42 RID: 11586
		// (set) Token: 0x06002D41 RID: 11585
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002D43 RID: 11587
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002D45 RID: 11589
		// (set) Token: 0x06002D44 RID: 11588
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002D47 RID: 11591
		// (set) Token: 0x06002D46 RID: 11590
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002D49 RID: 11593
		// (set) Token: 0x06002D48 RID: 11592
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002D4A RID: 11594
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002D4B RID: 11595
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CA7 RID: 3239
		// (set) Token: 0x06002D4C RID: 11596
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002D4D RID: 11597
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002D4E RID: 11598
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002D4F RID: 11599
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002D50 RID: 11600
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002D51 RID: 11601
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002D52 RID: 11602
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002D53 RID: 11603
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x06002D54 RID: 11604
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x06002D55 RID: 11605
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002D56 RID: 11606
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002D58 RID: 11608
		// (set) Token: 0x06002D57 RID: 11607
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002D59 RID: 11609
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002D5A RID: 11610
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002D5B RID: 11611
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002D5D RID: 11613
		// (set) Token: 0x06002D5C RID: 11612
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002D5E RID: 11614
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002D5F RID: 11615
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002D60 RID: 11616
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002D61 RID: 11617
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002D63 RID: 11619
		// (set) Token: 0x06002D62 RID: 11618
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002D64 RID: 11620
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06002D65 RID: 11621
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002D67 RID: 11623
		// (set) Token: 0x06002D66 RID: 11622
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002D69 RID: 11625
		// (set) Token: 0x06002D68 RID: 11624
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002D6B RID: 11627
		// (set) Token: 0x06002D6A RID: 11626
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002D6D RID: 11629
		// (set) Token: 0x06002D6C RID: 11628
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002D6F RID: 11631
		// (set) Token: 0x06002D6E RID: 11630
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002D70 RID: 11632
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002D72 RID: 11634
		// (set) Token: 0x06002D71 RID: 11633
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002D74 RID: 11636
		// (set) Token: 0x06002D73 RID: 11635
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002D76 RID: 11638
		// (set) Token: 0x06002D75 RID: 11637
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002D77 RID: 11639
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002D78 RID: 11640
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CC2 RID: 3266
		// (set) Token: 0x06002D79 RID: 11641
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002D7A RID: 11642
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002D7B RID: 11643
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06002D7C RID: 11644
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06002D7D RID: 11645
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002D7E RID: 11646
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002D7F RID: 11647
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002D80 RID: 11648
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x06002D81 RID: 11649
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x06002D82 RID: 11650
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002D83 RID: 11651
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002D85 RID: 11653
		// (set) Token: 0x06002D84 RID: 11652
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002D86 RID: 11654
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002D87 RID: 11655
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002D88 RID: 11656
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002D8A RID: 11658
		// (set) Token: 0x06002D89 RID: 11657
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002D8B RID: 11659
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002D8C RID: 11660
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002D8D RID: 11661
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002D8E RID: 11662
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002D90 RID: 11664
		// (set) Token: 0x06002D8F RID: 11663
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002D91 RID: 11665
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002D93 RID: 11667
		// (set) Token: 0x06002D92 RID: 11666
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002D95 RID: 11669
		// (set) Token: 0x06002D94 RID: 11668
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002D97 RID: 11671
		// (set) Token: 0x06002D96 RID: 11670
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002D99 RID: 11673
		// (set) Token: 0x06002D98 RID: 11672
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002D9B RID: 11675
		// (set) Token: 0x06002D9A RID: 11674
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002D9C RID: 11676
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002D9E RID: 11678
		// (set) Token: 0x06002D9D RID: 11677
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002DA0 RID: 11680
		// (set) Token: 0x06002D9F RID: 11679
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002DA2 RID: 11682
		// (set) Token: 0x06002DA1 RID: 11681
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002DA3 RID: 11683
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002DA4 RID: 11684
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CDC RID: 3292
		// (set) Token: 0x06002DA5 RID: 11685
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002DA6 RID: 11686
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002DA7 RID: 11687
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002DA8 RID: 11688
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002DA9 RID: 11689
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002DAA RID: 11690
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002DAB RID: 11691
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002DAC RID: 11692
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x06002DAD RID: 11693
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x06002DAE RID: 11694
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002DAF RID: 11695
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002DB1 RID: 11697
		// (set) Token: 0x06002DB0 RID: 11696
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002DB2 RID: 11698
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002DB3 RID: 11699
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002DB4 RID: 11700
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002DB6 RID: 11702
		// (set) Token: 0x06002DB5 RID: 11701
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002DB7 RID: 11703
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002DB8 RID: 11704
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002DB9 RID: 11705
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002DBA RID: 11706
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002DBC RID: 11708
		// (set) Token: 0x06002DBB RID: 11707
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002DBE RID: 11710
		// (set) Token: 0x06002DBD RID: 11709
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002DC0 RID: 11712
		// (set) Token: 0x06002DBF RID: 11711
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002DC2 RID: 11714
		// (set) Token: 0x06002DC1 RID: 11713
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002DC4 RID: 11716
		// (set) Token: 0x06002DC3 RID: 11715
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002DC6 RID: 11718
		// (set) Token: 0x06002DC5 RID: 11717
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002DC7 RID: 11719
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002DC9 RID: 11721
		// (set) Token: 0x06002DC8 RID: 11720
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002DCB RID: 11723
		// (set) Token: 0x06002DCA RID: 11722
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002DCD RID: 11725
		// (set) Token: 0x06002DCC RID: 11724
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002DCE RID: 11726
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002DCF RID: 11727
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CF5 RID: 3317
		// (set) Token: 0x06002DD0 RID: 11728
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002DD1 RID: 11729
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06002DD2 RID: 11730
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06002DD3 RID: 11731
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002DD4 RID: 11732
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002DD5 RID: 11733
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002DD6 RID: 11734
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002DD7 RID: 11735
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06002DD8 RID: 11736
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06002DD9 RID: 11737
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002DDA RID: 11738
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002DDC RID: 11740
		// (set) Token: 0x06002DDB RID: 11739
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002DDD RID: 11741
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06002DDE RID: 11742
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06002DDF RID: 11743
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002DE1 RID: 11745
		// (set) Token: 0x06002DE0 RID: 11744
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002DE2 RID: 11746
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002DE3 RID: 11747
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002DE4 RID: 11748
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002DE6 RID: 11750
		// (set) Token: 0x06002DE5 RID: 11749
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002DE8 RID: 11752
		// (set) Token: 0x06002DE7 RID: 11751
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002DEA RID: 11754
		// (set) Token: 0x06002DE9 RID: 11753
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002DEC RID: 11756
		// (set) Token: 0x06002DEB RID: 11755
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002DEE RID: 11758
		// (set) Token: 0x06002DED RID: 11757
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06002DEF RID: 11759
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06002DF1 RID: 11761
		// (set) Token: 0x06002DF0 RID: 11760
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002DF3 RID: 11763
		// (set) Token: 0x06002DF2 RID: 11762
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002DF5 RID: 11765
		// (set) Token: 0x06002DF4 RID: 11764
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002DF6 RID: 11766
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002DF7 RID: 11767
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D0C RID: 3340
		// (set) Token: 0x06002DF8 RID: 11768
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002DF9 RID: 11769
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06002DFA RID: 11770
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06002DFB RID: 11771
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002DFC RID: 11772
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002DFD RID: 11773
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002DFE RID: 11774
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002DFF RID: 11775
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06002E00 RID: 11776
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06002E01 RID: 11777
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002E02 RID: 11778
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000D13 RID: 3347
		// (set) Token: 0x06002E03 RID: 11779
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002E05 RID: 11781
		// (set) Token: 0x06002E04 RID: 11780
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002E07 RID: 11783
		// (set) Token: 0x06002E06 RID: 11782
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002E09 RID: 11785
		// (set) Token: 0x06002E08 RID: 11784
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002E0B RID: 11787
		// (set) Token: 0x06002E0A RID: 11786
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002E0C RID: 11788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17000D18 RID: 3352
		// (set) Token: 0x06002E0D RID: 11789
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002E0F RID: 11791
		// (set) Token: 0x06002E0E RID: 11790
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002E11 RID: 11793
		// (set) Token: 0x06002E10 RID: 11792
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002E13 RID: 11795
		// (set) Token: 0x06002E12 RID: 11794
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002E15 RID: 11797
		// (set) Token: 0x06002E14 RID: 11796
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002E16 RID: 11798
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06002E17 RID: 11799
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002E18 RID: 11800
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000D1D RID: 3357
		// (set) Token: 0x06002E19 RID: 11801
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002E1B RID: 11803
		// (set) Token: 0x06002E1A RID: 11802
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002E1D RID: 11805
		// (set) Token: 0x06002E1C RID: 11804
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002E1F RID: 11807
		// (set) Token: 0x06002E1E RID: 11806
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002E21 RID: 11809
		// (set) Token: 0x06002E20 RID: 11808
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002E22 RID: 11810
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06002E23 RID: 11811
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002E24 RID: 11812
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002E26 RID: 11814
		// (set) Token: 0x06002E25 RID: 11813
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000D23 RID: 3363
		// (set) Token: 0x06002E27 RID: 11815
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002E29 RID: 11817
		// (set) Token: 0x06002E28 RID: 11816
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06002E2B RID: 11819
		// (set) Token: 0x06002E2A RID: 11818
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002E2D RID: 11821
		// (set) Token: 0x06002E2C RID: 11820
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002E2F RID: 11823
		// (set) Token: 0x06002E2E RID: 11822
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002E30 RID: 11824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x06002E31 RID: 11825
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002E32 RID: 11826
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002E34 RID: 11828
		// (set) Token: 0x06002E33 RID: 11827
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002E36 RID: 11830
		// (set) Token: 0x06002E35 RID: 11829
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002E38 RID: 11832
		// (set) Token: 0x06002E37 RID: 11831
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002E3A RID: 11834
		// (set) Token: 0x06002E39 RID: 11833
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002E3C RID: 11836
		// (set) Token: 0x06002E3B RID: 11835
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002E3E RID: 11838
		// (set) Token: 0x06002E3D RID: 11837
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002E40 RID: 11840
		// (set) Token: 0x06002E3F RID: 11839
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002E41 RID: 11841
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002E42 RID: 11842
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06002E44 RID: 11844
		// (set) Token: 0x06002E43 RID: 11843
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002E46 RID: 11846
		// (set) Token: 0x06002E45 RID: 11845
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002E48 RID: 11848
		// (set) Token: 0x06002E47 RID: 11847
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x14000517 RID: 1303
		// (add) Token: 0x06002E49 RID: 11849
		// (remove) Token: 0x06002E4A RID: 11850
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000518 RID: 1304
		// (add) Token: 0x06002E4B RID: 11851
		// (remove) Token: 0x06002E4C RID: 11852
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000519 RID: 1305
		// (add) Token: 0x06002E4D RID: 11853
		// (remove) Token: 0x06002E4E RID: 11854
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400051A RID: 1306
		// (add) Token: 0x06002E4F RID: 11855
		// (remove) Token: 0x06002E50 RID: 11856
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400051B RID: 1307
		// (add) Token: 0x06002E51 RID: 11857
		// (remove) Token: 0x06002E52 RID: 11858
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400051C RID: 1308
		// (add) Token: 0x06002E53 RID: 11859
		// (remove) Token: 0x06002E54 RID: 11860
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400051D RID: 1309
		// (add) Token: 0x06002E55 RID: 11861
		// (remove) Token: 0x06002E56 RID: 11862
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400051E RID: 1310
		// (add) Token: 0x06002E57 RID: 11863
		// (remove) Token: 0x06002E58 RID: 11864
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400051F RID: 1311
		// (add) Token: 0x06002E59 RID: 11865
		// (remove) Token: 0x06002E5A RID: 11866
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000520 RID: 1312
		// (add) Token: 0x06002E5B RID: 11867
		// (remove) Token: 0x06002E5C RID: 11868
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000521 RID: 1313
		// (add) Token: 0x06002E5D RID: 11869
		// (remove) Token: 0x06002E5E RID: 11870
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000522 RID: 1314
		// (add) Token: 0x06002E5F RID: 11871
		// (remove) Token: 0x06002E60 RID: 11872
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000523 RID: 1315
		// (add) Token: 0x06002E61 RID: 11873
		// (remove) Token: 0x06002E62 RID: 11874
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000524 RID: 1316
		// (add) Token: 0x06002E63 RID: 11875
		// (remove) Token: 0x06002E64 RID: 11876
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000525 RID: 1317
		// (add) Token: 0x06002E65 RID: 11877
		// (remove) Token: 0x06002E66 RID: 11878
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000526 RID: 1318
		// (add) Token: 0x06002E67 RID: 11879
		// (remove) Token: 0x06002E68 RID: 11880
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000527 RID: 1319
		// (add) Token: 0x06002E69 RID: 11881
		// (remove) Token: 0x06002E6A RID: 11882
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000528 RID: 1320
		// (add) Token: 0x06002E6B RID: 11883
		// (remove) Token: 0x06002E6C RID: 11884
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000529 RID: 1321
		// (add) Token: 0x06002E6D RID: 11885
		// (remove) Token: 0x06002E6E RID: 11886
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400052A RID: 1322
		// (add) Token: 0x06002E6F RID: 11887
		// (remove) Token: 0x06002E70 RID: 11888
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400052B RID: 1323
		// (add) Token: 0x06002E71 RID: 11889
		// (remove) Token: 0x06002E72 RID: 11890
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400052C RID: 1324
		// (add) Token: 0x06002E73 RID: 11891
		// (remove) Token: 0x06002E74 RID: 11892
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400052D RID: 1325
		// (add) Token: 0x06002E75 RID: 11893
		// (remove) Token: 0x06002E76 RID: 11894
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400052E RID: 1326
		// (add) Token: 0x06002E77 RID: 11895
		// (remove) Token: 0x06002E78 RID: 11896
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400052F RID: 1327
		// (add) Token: 0x06002E79 RID: 11897
		// (remove) Token: 0x06002E7A RID: 11898
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000530 RID: 1328
		// (add) Token: 0x06002E7B RID: 11899
		// (remove) Token: 0x06002E7C RID: 11900
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000531 RID: 1329
		// (add) Token: 0x06002E7D RID: 11901
		// (remove) Token: 0x06002E7E RID: 11902
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000532 RID: 1330
		// (add) Token: 0x06002E7F RID: 11903
		// (remove) Token: 0x06002E80 RID: 11904
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000533 RID: 1331
		// (add) Token: 0x06002E81 RID: 11905
		// (remove) Token: 0x06002E82 RID: 11906
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000534 RID: 1332
		// (add) Token: 0x06002E83 RID: 11907
		// (remove) Token: 0x06002E84 RID: 11908
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000535 RID: 1333
		// (add) Token: 0x06002E85 RID: 11909
		// (remove) Token: 0x06002E86 RID: 11910
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000536 RID: 1334
		// (add) Token: 0x06002E87 RID: 11911
		// (remove) Token: 0x06002E88 RID: 11912
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
