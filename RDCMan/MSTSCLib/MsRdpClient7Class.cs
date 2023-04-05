using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001D5 RID: 469
	[TypeLibType(2)]
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[Guid("A9D7038D-B5ED-472E-9C47-94BEA90A5910")]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient7Class : IMsRdpClient7, MsRdpClient7, IMsTscAxEvents_Event, IMsRdpClient6, IMsRdpClient5, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3, IMsRdpClientNonScriptable4, IMsRdpClientNonScriptable5, IMsRdpPreferredRedirectionInfo
	{
		// Token: 0x0600375C RID: 14172
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient7Class();

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600375E RID: 14174
		// (set) Token: 0x0600375D RID: 14173
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06003760 RID: 14176
		// (set) Token: 0x0600375F RID: 14175
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06003762 RID: 14178
		// (set) Token: 0x06003761 RID: 14177
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06003764 RID: 14180
		// (set) Token: 0x06003763 RID: 14179
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06003766 RID: 14182
		// (set) Token: 0x06003765 RID: 14181
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06003767 RID: 14183
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06003769 RID: 14185
		// (set) Token: 0x06003768 RID: 14184
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600376B RID: 14187
		// (set) Token: 0x0600376A RID: 14186
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600376D RID: 14189
		// (set) Token: 0x0600376C RID: 14188
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600376E RID: 14190
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x0600376F RID: 14191
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011C5 RID: 4549
		// (set) Token: 0x06003770 RID: 14192
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06003771 RID: 14193
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06003772 RID: 14194
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06003773 RID: 14195
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06003774 RID: 14196
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06003775 RID: 14197
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06003776 RID: 14198
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06003777 RID: 14199
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06003778 RID: 14200
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06003779 RID: 14201
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600377A RID: 14202
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600377C RID: 14204
		// (set) Token: 0x0600377B RID: 14203
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600377D RID: 14205
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600377E RID: 14206
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x0600377F RID: 14207
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06003781 RID: 14209
		// (set) Token: 0x06003780 RID: 14208
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06003782 RID: 14210
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06003783 RID: 14211
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06003784 RID: 14212
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06003785 RID: 14213
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06003787 RID: 14215
		// (set) Token: 0x06003786 RID: 14214
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06003788 RID: 14216
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06003789 RID: 14217
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x0600378A RID: 14218
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x0600378B RID: 14219
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600378C RID: 14220
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600378D RID: 14221
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600378E RID: 14222
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600378F RID: 14223
		[DispId(507)]
		public virtual extern IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06003790 RID: 14224
		[DispId(506)]
		public virtual extern IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06003791 RID: 14225
		[DispId(600)]
		public virtual extern IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06003792 RID: 14226
		[DispId(601)]
		public virtual extern IMsRdpClientTransportSettings3 TransportSettings3 { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06003793 RID: 14227
		[DispId(602)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetStatusText([In] uint statusCode);

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06003794 RID: 14228
		[DispId(603)]
		public virtual extern IMsRdpClientSecuredSettings2 SecuredSettings3 { [DispId(603)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06003795 RID: 14229
		[DispId(604)]
		public virtual extern ITSRemoteProgram2 RemoteProgram2 { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06003797 RID: 14231
		// (set) Token: 0x06003796 RID: 14230
		public virtual extern string IMsRdpClient6_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06003799 RID: 14233
		// (set) Token: 0x06003798 RID: 14232
		public virtual extern string IMsRdpClient6_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600379B RID: 14235
		// (set) Token: 0x0600379A RID: 14234
		public virtual extern string IMsRdpClient6_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x0600379D RID: 14237
		// (set) Token: 0x0600379C RID: 14236
		public virtual extern string IMsRdpClient6_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x0600379F RID: 14239
		// (set) Token: 0x0600379E RID: 14238
		public virtual extern string IMsRdpClient6_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060037A0 RID: 14240
		public virtual extern short IMsRdpClient6_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060037A2 RID: 14242
		// (set) Token: 0x060037A1 RID: 14241
		public virtual extern int IMsRdpClient6_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060037A4 RID: 14244
		// (set) Token: 0x060037A3 RID: 14243
		public virtual extern int IMsRdpClient6_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060037A6 RID: 14246
		// (set) Token: 0x060037A5 RID: 14245
		public virtual extern int IMsRdpClient6_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060037A7 RID: 14247
		public virtual extern int IMsRdpClient6_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060037A8 RID: 14248
		public virtual extern int IMsRdpClient6_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011EA RID: 4586
		// (set) Token: 0x060037A9 RID: 14249
		public virtual extern string IMsRdpClient6_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060037AA RID: 14250
		public virtual extern int IMsRdpClient6_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060037AB RID: 14251
		public virtual extern string IMsRdpClient6_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060037AC RID: 14252
		public virtual extern int IMsRdpClient6_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060037AD RID: 14253
		public virtual extern IMsTscSecuredSettings IMsRdpClient6_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060037AE RID: 14254
		public virtual extern IMsTscAdvancedSettings IMsRdpClient6_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060037AF RID: 14255
		public virtual extern IMsTscDebug IMsRdpClient6_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060037B0 RID: 14256
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Connect();

		// Token: 0x060037B1 RID: 14257
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Disconnect();

		// Token: 0x060037B2 RID: 14258
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060037B3 RID: 14259
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060037B5 RID: 14261
		// (set) Token: 0x060037B4 RID: 14260
		public virtual extern int IMsRdpClient6_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x060037B6 RID: 14262
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient6_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060037B7 RID: 14263
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient6_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060037B8 RID: 14264
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient6_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060037BA RID: 14266
		// (set) Token: 0x060037B9 RID: 14265
		public virtual extern bool IMsRdpClient6_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060037BB RID: 14267
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060037BC RID: 14268
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient6_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060037BD RID: 14269
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient6_RequestClose();

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060037BE RID: 14270
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient6_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060037C0 RID: 14272
		// (set) Token: 0x060037BF RID: 14271
		public virtual extern string IMsRdpClient6_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060037C1 RID: 14273
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient6_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060037C2 RID: 14274
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient6_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060037C3 RID: 14275
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient6_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060037C4 RID: 14276
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient6_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060037C5 RID: 14277
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient6_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060037C6 RID: 14278
		public virtual extern ITSRemoteProgram IMsRdpClient6_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060037C7 RID: 14279
		public virtual extern IMsRdpClientShell IMsRdpClient6_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060037C8 RID: 14280
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient6_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060037C9 RID: 14281
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient6_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060037CB RID: 14283
		// (set) Token: 0x060037CA RID: 14282
		public virtual extern string IMsRdpClient5_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060037CD RID: 14285
		// (set) Token: 0x060037CC RID: 14284
		public virtual extern string IMsRdpClient5_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060037CF RID: 14287
		// (set) Token: 0x060037CE RID: 14286
		public virtual extern string IMsRdpClient5_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060037D1 RID: 14289
		// (set) Token: 0x060037D0 RID: 14288
		public virtual extern string IMsRdpClient5_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060037D3 RID: 14291
		// (set) Token: 0x060037D2 RID: 14290
		public virtual extern string IMsRdpClient5_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060037D4 RID: 14292
		public virtual extern short IMsRdpClient5_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060037D6 RID: 14294
		// (set) Token: 0x060037D5 RID: 14293
		public virtual extern int IMsRdpClient5_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060037D8 RID: 14296
		// (set) Token: 0x060037D7 RID: 14295
		public virtual extern int IMsRdpClient5_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060037DA RID: 14298
		// (set) Token: 0x060037D9 RID: 14297
		public virtual extern int IMsRdpClient5_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060037DB RID: 14299
		public virtual extern int IMsRdpClient5_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060037DC RID: 14300
		public virtual extern int IMsRdpClient5_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700120B RID: 4619
		// (set) Token: 0x060037DD RID: 14301
		public virtual extern string IMsRdpClient5_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060037DE RID: 14302
		public virtual extern int IMsRdpClient5_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060037DF RID: 14303
		public virtual extern string IMsRdpClient5_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060037E0 RID: 14304
		public virtual extern int IMsRdpClient5_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060037E1 RID: 14305
		public virtual extern IMsTscSecuredSettings IMsRdpClient5_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060037E2 RID: 14306
		public virtual extern IMsTscAdvancedSettings IMsRdpClient5_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060037E3 RID: 14307
		public virtual extern IMsTscDebug IMsRdpClient5_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060037E4 RID: 14308
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Connect();

		// Token: 0x060037E5 RID: 14309
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Disconnect();

		// Token: 0x060037E6 RID: 14310
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060037E7 RID: 14311
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060037E9 RID: 14313
		// (set) Token: 0x060037E8 RID: 14312
		public virtual extern int IMsRdpClient5_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060037EA RID: 14314
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient5_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060037EB RID: 14315
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient5_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060037EC RID: 14316
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient5_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060037EE RID: 14318
		// (set) Token: 0x060037ED RID: 14317
		public virtual extern bool IMsRdpClient5_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060037EF RID: 14319
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060037F0 RID: 14320
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient5_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060037F1 RID: 14321
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient5_RequestClose();

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060037F2 RID: 14322
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient5_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060037F4 RID: 14324
		// (set) Token: 0x060037F3 RID: 14323
		public virtual extern string IMsRdpClient5_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060037F5 RID: 14325
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient5_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060037F6 RID: 14326
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient5_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060037F7 RID: 14327
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient5_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060037F8 RID: 14328
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient5_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060037F9 RID: 14329
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient5_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060037FA RID: 14330
		public virtual extern ITSRemoteProgram IMsRdpClient5_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060037FB RID: 14331
		public virtual extern IMsRdpClientShell IMsRdpClient5_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060037FD RID: 14333
		// (set) Token: 0x060037FC RID: 14332
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060037FF RID: 14335
		// (set) Token: 0x060037FE RID: 14334
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06003801 RID: 14337
		// (set) Token: 0x06003800 RID: 14336
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06003803 RID: 14339
		// (set) Token: 0x06003802 RID: 14338
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06003805 RID: 14341
		// (set) Token: 0x06003804 RID: 14340
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06003806 RID: 14342
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06003808 RID: 14344
		// (set) Token: 0x06003807 RID: 14343
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600380A RID: 14346
		// (set) Token: 0x06003809 RID: 14345
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600380C RID: 14348
		// (set) Token: 0x0600380B RID: 14347
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600380D RID: 14349
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x0600380E RID: 14350
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700122A RID: 4650
		// (set) Token: 0x0600380F RID: 14351
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06003810 RID: 14352
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06003811 RID: 14353
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06003812 RID: 14354
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06003813 RID: 14355
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06003814 RID: 14356
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06003815 RID: 14357
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06003816 RID: 14358
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x06003817 RID: 14359
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x06003818 RID: 14360
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06003819 RID: 14361
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600381B RID: 14363
		// (set) Token: 0x0600381A RID: 14362
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600381C RID: 14364
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600381D RID: 14365
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x0600381E RID: 14366
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06003820 RID: 14368
		// (set) Token: 0x0600381F RID: 14367
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06003821 RID: 14369
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06003822 RID: 14370
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06003823 RID: 14371
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06003824 RID: 14372
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06003826 RID: 14374
		// (set) Token: 0x06003825 RID: 14373
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06003827 RID: 14375
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06003828 RID: 14376
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x0600382A RID: 14378
		// (set) Token: 0x06003829 RID: 14377
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x0600382C RID: 14380
		// (set) Token: 0x0600382B RID: 14379
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x0600382E RID: 14382
		// (set) Token: 0x0600382D RID: 14381
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06003830 RID: 14384
		// (set) Token: 0x0600382F RID: 14383
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06003832 RID: 14386
		// (set) Token: 0x06003831 RID: 14385
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06003833 RID: 14387
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06003835 RID: 14389
		// (set) Token: 0x06003834 RID: 14388
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06003837 RID: 14391
		// (set) Token: 0x06003836 RID: 14390
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06003839 RID: 14393
		// (set) Token: 0x06003838 RID: 14392
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600383A RID: 14394
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600383B RID: 14395
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001245 RID: 4677
		// (set) Token: 0x0600383C RID: 14396
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x0600383D RID: 14397
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x0600383E RID: 14398
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x0600383F RID: 14399
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06003840 RID: 14400
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06003841 RID: 14401
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06003842 RID: 14402
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06003843 RID: 14403
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x06003844 RID: 14404
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x06003845 RID: 14405
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06003846 RID: 14406
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06003848 RID: 14408
		// (set) Token: 0x06003847 RID: 14407
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06003849 RID: 14409
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600384A RID: 14410
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600384B RID: 14411
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600384D RID: 14413
		// (set) Token: 0x0600384C RID: 14412
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600384E RID: 14414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600384F RID: 14415
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06003850 RID: 14416
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06003851 RID: 14417
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003853 RID: 14419
		// (set) Token: 0x06003852 RID: 14418
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003854 RID: 14420
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06003856 RID: 14422
		// (set) Token: 0x06003855 RID: 14421
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06003858 RID: 14424
		// (set) Token: 0x06003857 RID: 14423
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x0600385A RID: 14426
		// (set) Token: 0x06003859 RID: 14425
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x0600385C RID: 14428
		// (set) Token: 0x0600385B RID: 14427
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x0600385E RID: 14430
		// (set) Token: 0x0600385D RID: 14429
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600385F RID: 14431
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06003861 RID: 14433
		// (set) Token: 0x06003860 RID: 14432
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06003863 RID: 14435
		// (set) Token: 0x06003862 RID: 14434
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06003865 RID: 14437
		// (set) Token: 0x06003864 RID: 14436
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06003866 RID: 14438
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06003867 RID: 14439
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700125F RID: 4703
		// (set) Token: 0x06003868 RID: 14440
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06003869 RID: 14441
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600386A RID: 14442
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x0600386B RID: 14443
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x0600386C RID: 14444
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x0600386D RID: 14445
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x0600386E RID: 14446
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600386F RID: 14447
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x06003870 RID: 14448
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x06003871 RID: 14449
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06003872 RID: 14450
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06003874 RID: 14452
		// (set) Token: 0x06003873 RID: 14451
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06003875 RID: 14453
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06003876 RID: 14454
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06003877 RID: 14455
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06003879 RID: 14457
		// (set) Token: 0x06003878 RID: 14456
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600387A RID: 14458
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600387B RID: 14459
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600387C RID: 14460
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x0600387D RID: 14461
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x0600387F RID: 14463
		// (set) Token: 0x0600387E RID: 14462
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06003881 RID: 14465
		// (set) Token: 0x06003880 RID: 14464
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06003883 RID: 14467
		// (set) Token: 0x06003882 RID: 14466
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06003885 RID: 14469
		// (set) Token: 0x06003884 RID: 14468
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06003887 RID: 14471
		// (set) Token: 0x06003886 RID: 14470
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06003889 RID: 14473
		// (set) Token: 0x06003888 RID: 14472
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x0600388A RID: 14474
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x0600388C RID: 14476
		// (set) Token: 0x0600388B RID: 14475
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x0600388E RID: 14478
		// (set) Token: 0x0600388D RID: 14477
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06003890 RID: 14480
		// (set) Token: 0x0600388F RID: 14479
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06003891 RID: 14481
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06003892 RID: 14482
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001278 RID: 4728
		// (set) Token: 0x06003893 RID: 14483
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06003894 RID: 14484
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06003895 RID: 14485
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06003896 RID: 14486
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06003897 RID: 14487
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06003898 RID: 14488
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06003899 RID: 14489
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600389A RID: 14490
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x0600389B RID: 14491
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x0600389C RID: 14492
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600389D RID: 14493
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x0600389F RID: 14495
		// (set) Token: 0x0600389E RID: 14494
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x060038A0 RID: 14496
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x060038A1 RID: 14497
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x060038A2 RID: 14498
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x060038A4 RID: 14500
		// (set) Token: 0x060038A3 RID: 14499
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060038A5 RID: 14501
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060038A6 RID: 14502
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060038A7 RID: 14503
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x060038A9 RID: 14505
		// (set) Token: 0x060038A8 RID: 14504
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x060038AB RID: 14507
		// (set) Token: 0x060038AA RID: 14506
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x060038AD RID: 14509
		// (set) Token: 0x060038AC RID: 14508
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x060038AF RID: 14511
		// (set) Token: 0x060038AE RID: 14510
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x060038B1 RID: 14513
		// (set) Token: 0x060038B0 RID: 14512
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x060038B2 RID: 14514
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x060038B4 RID: 14516
		// (set) Token: 0x060038B3 RID: 14515
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x060038B6 RID: 14518
		// (set) Token: 0x060038B5 RID: 14517
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x060038B8 RID: 14520
		// (set) Token: 0x060038B7 RID: 14519
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x060038B9 RID: 14521
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x060038BA RID: 14522
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700128F RID: 4751
		// (set) Token: 0x060038BB RID: 14523
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060038BC RID: 14524
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x060038BD RID: 14525
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x060038BE RID: 14526
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x060038BF RID: 14527
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x060038C0 RID: 14528
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x060038C1 RID: 14529
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060038C2 RID: 14530
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x060038C3 RID: 14531
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x060038C4 RID: 14532
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060038C5 RID: 14533
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001296 RID: 4758
		// (set) Token: 0x060038C6 RID: 14534
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x060038C8 RID: 14536
		// (set) Token: 0x060038C7 RID: 14535
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x060038CA RID: 14538
		// (set) Token: 0x060038C9 RID: 14537
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x060038CC RID: 14540
		// (set) Token: 0x060038CB RID: 14539
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x060038CE RID: 14542
		// (set) Token: 0x060038CD RID: 14541
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060038CF RID: 14543
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x1700129B RID: 4763
		// (set) Token: 0x060038D0 RID: 14544
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x060038D2 RID: 14546
		// (set) Token: 0x060038D1 RID: 14545
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060038D4 RID: 14548
		// (set) Token: 0x060038D3 RID: 14547
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x060038D6 RID: 14550
		// (set) Token: 0x060038D5 RID: 14549
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x060038D8 RID: 14552
		// (set) Token: 0x060038D7 RID: 14551
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060038D9 RID: 14553
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x060038DA RID: 14554
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060038DB RID: 14555
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170012A0 RID: 4768
		// (set) Token: 0x060038DC RID: 14556
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x060038DE RID: 14558
		// (set) Token: 0x060038DD RID: 14557
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x060038E0 RID: 14560
		// (set) Token: 0x060038DF RID: 14559
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x060038E2 RID: 14562
		// (set) Token: 0x060038E1 RID: 14561
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x060038E4 RID: 14564
		// (set) Token: 0x060038E3 RID: 14563
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060038E5 RID: 14565
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x060038E6 RID: 14566
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060038E7 RID: 14567
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x060038E9 RID: 14569
		// (set) Token: 0x060038E8 RID: 14568
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170012A6 RID: 4774
		// (set) Token: 0x060038EA RID: 14570
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x060038EC RID: 14572
		// (set) Token: 0x060038EB RID: 14571
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x060038EE RID: 14574
		// (set) Token: 0x060038ED RID: 14573
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x060038F0 RID: 14576
		// (set) Token: 0x060038EF RID: 14575
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x060038F2 RID: 14578
		// (set) Token: 0x060038F1 RID: 14577
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060038F3 RID: 14579
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x060038F4 RID: 14580
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060038F5 RID: 14581
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x060038F7 RID: 14583
		// (set) Token: 0x060038F6 RID: 14582
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x060038F9 RID: 14585
		// (set) Token: 0x060038F8 RID: 14584
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x060038FB RID: 14587
		// (set) Token: 0x060038FA RID: 14586
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x060038FD RID: 14589
		// (set) Token: 0x060038FC RID: 14588
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x060038FF RID: 14591
		// (set) Token: 0x060038FE RID: 14590
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06003901 RID: 14593
		// (set) Token: 0x06003900 RID: 14592
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06003903 RID: 14595
		// (set) Token: 0x06003902 RID: 14594
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06003904 RID: 14596
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06003905 RID: 14597
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06003907 RID: 14599
		// (set) Token: 0x06003906 RID: 14598
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06003909 RID: 14601
		// (set) Token: 0x06003908 RID: 14600
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x0600390B RID: 14603
		// (set) Token: 0x0600390A RID: 14602
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012B7 RID: 4791
		// (set) Token: 0x0600390C RID: 14604
		public virtual extern string IMsRdpClientNonScriptable4_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x0600390E RID: 14606
		// (set) Token: 0x0600390D RID: 14605
		public virtual extern string IMsRdpClientNonScriptable4_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06003910 RID: 14608
		// (set) Token: 0x0600390F RID: 14607
		public virtual extern string IMsRdpClientNonScriptable4_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06003912 RID: 14610
		// (set) Token: 0x06003911 RID: 14609
		public virtual extern string IMsRdpClientNonScriptable4_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06003914 RID: 14612
		// (set) Token: 0x06003913 RID: 14611
		public virtual extern string IMsRdpClientNonScriptable4_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06003915 RID: 14613
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_ResetPassword();

		// Token: 0x06003916 RID: 14614
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06003917 RID: 14615
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06003919 RID: 14617
		// (set) Token: 0x06003918 RID: 14616
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable4_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x0600391B RID: 14619
		// (set) Token: 0x0600391A RID: 14618
		public virtual extern bool IMsRdpClientNonScriptable4_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600391D RID: 14621
		// (set) Token: 0x0600391C RID: 14620
		public virtual extern bool IMsRdpClientNonScriptable4_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x0600391F RID: 14623
		// (set) Token: 0x0600391E RID: 14622
		public virtual extern bool IMsRdpClientNonScriptable4_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06003921 RID: 14625
		// (set) Token: 0x06003920 RID: 14624
		public virtual extern bool IMsRdpClientNonScriptable4_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06003923 RID: 14627
		// (set) Token: 0x06003922 RID: 14626
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06003925 RID: 14629
		// (set) Token: 0x06003924 RID: 14628
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06003926 RID: 14630
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable4_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06003927 RID: 14631
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable4_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06003929 RID: 14633
		// (set) Token: 0x06003928 RID: 14632
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600392B RID: 14635
		// (set) Token: 0x0600392A RID: 14634
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x0600392D RID: 14637
		// (set) Token: 0x0600392C RID: 14636
		public virtual extern string IMsRdpClientNonScriptable4_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600392F RID: 14639
		// (set) Token: 0x0600392E RID: 14638
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06003931 RID: 14641
		// (set) Token: 0x06003930 RID: 14640
		public virtual extern bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06003933 RID: 14643
		// (set) Token: 0x06003932 RID: 14642
		public virtual extern object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06003935 RID: 14645
		// (set) Token: 0x06003934 RID: 14644
		public virtual extern bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06003937 RID: 14647
		// (set) Token: 0x06003936 RID: 14646
		public virtual extern bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06003939 RID: 14649
		// (set) Token: 0x06003938 RID: 14648
		public virtual extern bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x0600393B RID: 14651
		// (set) Token: 0x0600393A RID: 14650
		public virtual extern bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x0600393D RID: 14653
		// (set) Token: 0x0600393C RID: 14652
		public virtual extern bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012D0 RID: 4816
		// (set) Token: 0x0600393E RID: 14654
		public virtual extern string IMsRdpClientNonScriptable5_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06003940 RID: 14656
		// (set) Token: 0x0600393F RID: 14655
		public virtual extern string IMsRdpClientNonScriptable5_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06003942 RID: 14658
		// (set) Token: 0x06003941 RID: 14657
		public virtual extern string IMsRdpClientNonScriptable5_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06003944 RID: 14660
		// (set) Token: 0x06003943 RID: 14659
		public virtual extern string IMsRdpClientNonScriptable5_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06003946 RID: 14662
		// (set) Token: 0x06003945 RID: 14661
		public virtual extern string IMsRdpClientNonScriptable5_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06003947 RID: 14663
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_ResetPassword();

		// Token: 0x06003948 RID: 14664
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06003949 RID: 14665
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x0600394B RID: 14667
		// (set) Token: 0x0600394A RID: 14666
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable5_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x0600394D RID: 14669
		// (set) Token: 0x0600394C RID: 14668
		public virtual extern bool IMsRdpClientNonScriptable5_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x0600394F RID: 14671
		// (set) Token: 0x0600394E RID: 14670
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06003951 RID: 14673
		// (set) Token: 0x06003950 RID: 14672
		public virtual extern bool IMsRdpClientNonScriptable5_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06003953 RID: 14675
		// (set) Token: 0x06003952 RID: 14674
		public virtual extern bool IMsRdpClientNonScriptable5_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06003955 RID: 14677
		// (set) Token: 0x06003954 RID: 14676
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06003957 RID: 14679
		// (set) Token: 0x06003956 RID: 14678
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06003958 RID: 14680
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable5_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06003959 RID: 14681
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable5_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x0600395B RID: 14683
		// (set) Token: 0x0600395A RID: 14682
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x0600395D RID: 14685
		// (set) Token: 0x0600395C RID: 14684
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x0600395F RID: 14687
		// (set) Token: 0x0600395E RID: 14686
		public virtual extern string IMsRdpClientNonScriptable5_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06003961 RID: 14689
		// (set) Token: 0x06003960 RID: 14688
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable5_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06003963 RID: 14691
		// (set) Token: 0x06003962 RID: 14690
		public virtual extern bool IMsRdpClientNonScriptable5_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06003965 RID: 14693
		// (set) Token: 0x06003964 RID: 14692
		public virtual extern object IMsRdpClientNonScriptable5_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06003967 RID: 14695
		// (set) Token: 0x06003966 RID: 14694
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06003969 RID: 14697
		// (set) Token: 0x06003968 RID: 14696
		public virtual extern bool IMsRdpClientNonScriptable5_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x0600396B RID: 14699
		// (set) Token: 0x0600396A RID: 14698
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x0600396D RID: 14701
		// (set) Token: 0x0600396C RID: 14700
		public virtual extern bool IMsRdpClientNonScriptable5_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x0600396F RID: 14703
		// (set) Token: 0x0600396E RID: 14702
		public virtual extern bool IMsRdpClientNonScriptable5_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06003971 RID: 14705
		// (set) Token: 0x06003970 RID: 14704
		public virtual extern bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06003972 RID: 14706
		public virtual extern uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06003973 RID: 14707
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06003974 RID: 14708
		public virtual extern bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170012EC RID: 4844
		// (set) Token: 0x06003975 RID: 14709
		public virtual extern bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06003977 RID: 14711
		// (set) Token: 0x06003976 RID: 14710
		public virtual extern bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06003979 RID: 14713
		// (set) Token: 0x06003978 RID: 14712
		public virtual extern bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x0600397B RID: 14715
		// (set) Token: 0x0600397A RID: 14714
		public virtual extern bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x0600397D RID: 14717
		// (set) Token: 0x0600397C RID: 14716
		public virtual extern bool UseRedirectionServerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x14000597 RID: 1431
		// (add) Token: 0x0600397E RID: 14718
		// (remove) Token: 0x0600397F RID: 14719
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000598 RID: 1432
		// (add) Token: 0x06003980 RID: 14720
		// (remove) Token: 0x06003981 RID: 14721
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000599 RID: 1433
		// (add) Token: 0x06003982 RID: 14722
		// (remove) Token: 0x06003983 RID: 14723
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400059A RID: 1434
		// (add) Token: 0x06003984 RID: 14724
		// (remove) Token: 0x06003985 RID: 14725
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400059B RID: 1435
		// (add) Token: 0x06003986 RID: 14726
		// (remove) Token: 0x06003987 RID: 14727
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400059C RID: 1436
		// (add) Token: 0x06003988 RID: 14728
		// (remove) Token: 0x06003989 RID: 14729
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400059D RID: 1437
		// (add) Token: 0x0600398A RID: 14730
		// (remove) Token: 0x0600398B RID: 14731
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400059E RID: 1438
		// (add) Token: 0x0600398C RID: 14732
		// (remove) Token: 0x0600398D RID: 14733
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400059F RID: 1439
		// (add) Token: 0x0600398E RID: 14734
		// (remove) Token: 0x0600398F RID: 14735
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x140005A0 RID: 1440
		// (add) Token: 0x06003990 RID: 14736
		// (remove) Token: 0x06003991 RID: 14737
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140005A1 RID: 1441
		// (add) Token: 0x06003992 RID: 14738
		// (remove) Token: 0x06003993 RID: 14739
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140005A2 RID: 1442
		// (add) Token: 0x06003994 RID: 14740
		// (remove) Token: 0x06003995 RID: 14741
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140005A3 RID: 1443
		// (add) Token: 0x06003996 RID: 14742
		// (remove) Token: 0x06003997 RID: 14743
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x140005A4 RID: 1444
		// (add) Token: 0x06003998 RID: 14744
		// (remove) Token: 0x06003999 RID: 14745
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x140005A5 RID: 1445
		// (add) Token: 0x0600399A RID: 14746
		// (remove) Token: 0x0600399B RID: 14747
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140005A6 RID: 1446
		// (add) Token: 0x0600399C RID: 14748
		// (remove) Token: 0x0600399D RID: 14749
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140005A7 RID: 1447
		// (add) Token: 0x0600399E RID: 14750
		// (remove) Token: 0x0600399F RID: 14751
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140005A8 RID: 1448
		// (add) Token: 0x060039A0 RID: 14752
		// (remove) Token: 0x060039A1 RID: 14753
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140005A9 RID: 1449
		// (add) Token: 0x060039A2 RID: 14754
		// (remove) Token: 0x060039A3 RID: 14755
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140005AA RID: 1450
		// (add) Token: 0x060039A4 RID: 14756
		// (remove) Token: 0x060039A5 RID: 14757
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140005AB RID: 1451
		// (add) Token: 0x060039A6 RID: 14758
		// (remove) Token: 0x060039A7 RID: 14759
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140005AC RID: 1452
		// (add) Token: 0x060039A8 RID: 14760
		// (remove) Token: 0x060039A9 RID: 14761
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140005AD RID: 1453
		// (add) Token: 0x060039AA RID: 14762
		// (remove) Token: 0x060039AB RID: 14763
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140005AE RID: 1454
		// (add) Token: 0x060039AC RID: 14764
		// (remove) Token: 0x060039AD RID: 14765
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140005AF RID: 1455
		// (add) Token: 0x060039AE RID: 14766
		// (remove) Token: 0x060039AF RID: 14767
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140005B0 RID: 1456
		// (add) Token: 0x060039B0 RID: 14768
		// (remove) Token: 0x060039B1 RID: 14769
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140005B1 RID: 1457
		// (add) Token: 0x060039B2 RID: 14770
		// (remove) Token: 0x060039B3 RID: 14771
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140005B2 RID: 1458
		// (add) Token: 0x060039B4 RID: 14772
		// (remove) Token: 0x060039B5 RID: 14773
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x140005B3 RID: 1459
		// (add) Token: 0x060039B6 RID: 14774
		// (remove) Token: 0x060039B7 RID: 14775
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140005B4 RID: 1460
		// (add) Token: 0x060039B8 RID: 14776
		// (remove) Token: 0x060039B9 RID: 14777
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x140005B5 RID: 1461
		// (add) Token: 0x060039BA RID: 14778
		// (remove) Token: 0x060039BB RID: 14779
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x140005B6 RID: 1462
		// (add) Token: 0x060039BC RID: 14780
		// (remove) Token: 0x060039BD RID: 14781
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
