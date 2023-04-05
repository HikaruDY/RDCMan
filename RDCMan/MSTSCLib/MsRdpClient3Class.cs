using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001A6 RID: 422
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[Guid("7584C670-2274-4EFB-B00B-D6AABA6D3850")]
	[TypeLibType(34)]
	[ClassInterface(0)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient3Class : IMsRdpClient3, MsRdpClient3, IMsTscAxEvents_Event, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x0600242E RID: 9262
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient3Class();

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002430 RID: 9264
		// (set) Token: 0x0600242F RID: 9263
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002432 RID: 9266
		// (set) Token: 0x06002431 RID: 9265
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002434 RID: 9268
		// (set) Token: 0x06002433 RID: 9267
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002436 RID: 9270
		// (set) Token: 0x06002435 RID: 9269
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06002438 RID: 9272
		// (set) Token: 0x06002437 RID: 9271
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002439 RID: 9273
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600243B RID: 9275
		// (set) Token: 0x0600243A RID: 9274
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600243D RID: 9277
		// (set) Token: 0x0600243C RID: 9276
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x0600243F RID: 9279
		// (set) Token: 0x0600243E RID: 9278
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002440 RID: 9280
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002441 RID: 9281
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700086C RID: 2156
		// (set) Token: 0x06002442 RID: 9282
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002443 RID: 9283
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002444 RID: 9284
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002445 RID: 9285
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002446 RID: 9286
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002447 RID: 9287
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002448 RID: 9288
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002449 RID: 9289
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x0600244A RID: 9290
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x0600244B RID: 9291
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600244C RID: 9292
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600244E RID: 9294
		// (set) Token: 0x0600244D RID: 9293
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x0600244F RID: 9295
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002450 RID: 9296
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002451 RID: 9297
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002453 RID: 9299
		// (set) Token: 0x06002452 RID: 9298
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002454 RID: 9300
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002455 RID: 9301
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002456 RID: 9302
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002457 RID: 9303
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002459 RID: 9305
		// (set) Token: 0x06002458 RID: 9304
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600245A RID: 9306
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600245C RID: 9308
		// (set) Token: 0x0600245B RID: 9307
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x0600245E RID: 9310
		// (set) Token: 0x0600245D RID: 9309
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002460 RID: 9312
		// (set) Token: 0x0600245F RID: 9311
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002462 RID: 9314
		// (set) Token: 0x06002461 RID: 9313
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002464 RID: 9316
		// (set) Token: 0x06002463 RID: 9315
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002465 RID: 9317
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002467 RID: 9319
		// (set) Token: 0x06002466 RID: 9318
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002469 RID: 9321
		// (set) Token: 0x06002468 RID: 9320
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x0600246B RID: 9323
		// (set) Token: 0x0600246A RID: 9322
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x0600246C RID: 9324
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x0600246D RID: 9325
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000886 RID: 2182
		// (set) Token: 0x0600246E RID: 9326
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x0600246F RID: 9327
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002470 RID: 9328
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002471 RID: 9329
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002472 RID: 9330
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002473 RID: 9331
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002474 RID: 9332
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002475 RID: 9333
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x06002476 RID: 9334
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x06002477 RID: 9335
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002478 RID: 9336
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600247A RID: 9338
		// (set) Token: 0x06002479 RID: 9337
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600247B RID: 9339
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600247C RID: 9340
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600247D RID: 9341
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x0600247F RID: 9343
		// (set) Token: 0x0600247E RID: 9342
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002480 RID: 9344
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002481 RID: 9345
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002482 RID: 9346
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002483 RID: 9347
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002485 RID: 9349
		// (set) Token: 0x06002484 RID: 9348
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002487 RID: 9351
		// (set) Token: 0x06002486 RID: 9350
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002489 RID: 9353
		// (set) Token: 0x06002488 RID: 9352
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600248B RID: 9355
		// (set) Token: 0x0600248A RID: 9354
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600248D RID: 9357
		// (set) Token: 0x0600248C RID: 9356
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600248F RID: 9359
		// (set) Token: 0x0600248E RID: 9358
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002490 RID: 9360
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002492 RID: 9362
		// (set) Token: 0x06002491 RID: 9361
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002494 RID: 9364
		// (set) Token: 0x06002493 RID: 9363
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002496 RID: 9366
		// (set) Token: 0x06002495 RID: 9365
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002497 RID: 9367
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002498 RID: 9368
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700089F RID: 2207
		// (set) Token: 0x06002499 RID: 9369
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600249A RID: 9370
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600249B RID: 9371
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600249C RID: 9372
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600249D RID: 9373
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600249E RID: 9374
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600249F RID: 9375
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060024A0 RID: 9376
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x060024A1 RID: 9377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x060024A2 RID: 9378
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060024A3 RID: 9379
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060024A5 RID: 9381
		// (set) Token: 0x060024A4 RID: 9380
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060024A6 RID: 9382
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060024A7 RID: 9383
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060024A8 RID: 9384
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060024AA RID: 9386
		// (set) Token: 0x060024A9 RID: 9385
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060024AB RID: 9387
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060024AC RID: 9388
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060024AD RID: 9389
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060024AF RID: 9391
		// (set) Token: 0x060024AE RID: 9390
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060024B1 RID: 9393
		// (set) Token: 0x060024B0 RID: 9392
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060024B3 RID: 9395
		// (set) Token: 0x060024B2 RID: 9394
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060024B5 RID: 9397
		// (set) Token: 0x060024B4 RID: 9396
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060024B7 RID: 9399
		// (set) Token: 0x060024B6 RID: 9398
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060024B8 RID: 9400
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060024BA RID: 9402
		// (set) Token: 0x060024B9 RID: 9401
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060024BC RID: 9404
		// (set) Token: 0x060024BB RID: 9403
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060024BE RID: 9406
		// (set) Token: 0x060024BD RID: 9405
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060024BF RID: 9407
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060024C0 RID: 9408
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008B6 RID: 2230
		// (set) Token: 0x060024C1 RID: 9409
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060024C2 RID: 9410
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060024C3 RID: 9411
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060024C4 RID: 9412
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060024C5 RID: 9413
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060024C6 RID: 9414
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060024C7 RID: 9415
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060024C8 RID: 9416
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x060024C9 RID: 9417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x060024CA RID: 9418
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060024CB RID: 9419
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170008BD RID: 2237
		// (set) Token: 0x060024CC RID: 9420
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060024CE RID: 9422
		// (set) Token: 0x060024CD RID: 9421
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060024D0 RID: 9424
		// (set) Token: 0x060024CF RID: 9423
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060024D2 RID: 9426
		// (set) Token: 0x060024D1 RID: 9425
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060024D4 RID: 9428
		// (set) Token: 0x060024D3 RID: 9427
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060024D5 RID: 9429
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x170008C2 RID: 2242
		// (set) Token: 0x060024D6 RID: 9430
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060024D8 RID: 9432
		// (set) Token: 0x060024D7 RID: 9431
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060024DA RID: 9434
		// (set) Token: 0x060024D9 RID: 9433
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060024DC RID: 9436
		// (set) Token: 0x060024DB RID: 9435
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060024DE RID: 9438
		// (set) Token: 0x060024DD RID: 9437
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060024DF RID: 9439
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x060024E0 RID: 9440
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060024E1 RID: 9441
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x14000457 RID: 1111
		// (add) Token: 0x060024E2 RID: 9442
		// (remove) Token: 0x060024E3 RID: 9443
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000458 RID: 1112
		// (add) Token: 0x060024E4 RID: 9444
		// (remove) Token: 0x060024E5 RID: 9445
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000459 RID: 1113
		// (add) Token: 0x060024E6 RID: 9446
		// (remove) Token: 0x060024E7 RID: 9447
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400045A RID: 1114
		// (add) Token: 0x060024E8 RID: 9448
		// (remove) Token: 0x060024E9 RID: 9449
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400045B RID: 1115
		// (add) Token: 0x060024EA RID: 9450
		// (remove) Token: 0x060024EB RID: 9451
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400045C RID: 1116
		// (add) Token: 0x060024EC RID: 9452
		// (remove) Token: 0x060024ED RID: 9453
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400045D RID: 1117
		// (add) Token: 0x060024EE RID: 9454
		// (remove) Token: 0x060024EF RID: 9455
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400045E RID: 1118
		// (add) Token: 0x060024F0 RID: 9456
		// (remove) Token: 0x060024F1 RID: 9457
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400045F RID: 1119
		// (add) Token: 0x060024F2 RID: 9458
		// (remove) Token: 0x060024F3 RID: 9459
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000460 RID: 1120
		// (add) Token: 0x060024F4 RID: 9460
		// (remove) Token: 0x060024F5 RID: 9461
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000461 RID: 1121
		// (add) Token: 0x060024F6 RID: 9462
		// (remove) Token: 0x060024F7 RID: 9463
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000462 RID: 1122
		// (add) Token: 0x060024F8 RID: 9464
		// (remove) Token: 0x060024F9 RID: 9465
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000463 RID: 1123
		// (add) Token: 0x060024FA RID: 9466
		// (remove) Token: 0x060024FB RID: 9467
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000464 RID: 1124
		// (add) Token: 0x060024FC RID: 9468
		// (remove) Token: 0x060024FD RID: 9469
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000465 RID: 1125
		// (add) Token: 0x060024FE RID: 9470
		// (remove) Token: 0x060024FF RID: 9471
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000466 RID: 1126
		// (add) Token: 0x06002500 RID: 9472
		// (remove) Token: 0x06002501 RID: 9473
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000467 RID: 1127
		// (add) Token: 0x06002502 RID: 9474
		// (remove) Token: 0x06002503 RID: 9475
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000468 RID: 1128
		// (add) Token: 0x06002504 RID: 9476
		// (remove) Token: 0x06002505 RID: 9477
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000469 RID: 1129
		// (add) Token: 0x06002506 RID: 9478
		// (remove) Token: 0x06002507 RID: 9479
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400046A RID: 1130
		// (add) Token: 0x06002508 RID: 9480
		// (remove) Token: 0x06002509 RID: 9481
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400046B RID: 1131
		// (add) Token: 0x0600250A RID: 9482
		// (remove) Token: 0x0600250B RID: 9483
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400046C RID: 1132
		// (add) Token: 0x0600250C RID: 9484
		// (remove) Token: 0x0600250D RID: 9485
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400046D RID: 1133
		// (add) Token: 0x0600250E RID: 9486
		// (remove) Token: 0x0600250F RID: 9487
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400046E RID: 1134
		// (add) Token: 0x06002510 RID: 9488
		// (remove) Token: 0x06002511 RID: 9489
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400046F RID: 1135
		// (add) Token: 0x06002512 RID: 9490
		// (remove) Token: 0x06002513 RID: 9491
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000470 RID: 1136
		// (add) Token: 0x06002514 RID: 9492
		// (remove) Token: 0x06002515 RID: 9493
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000471 RID: 1137
		// (add) Token: 0x06002516 RID: 9494
		// (remove) Token: 0x06002517 RID: 9495
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000472 RID: 1138
		// (add) Token: 0x06002518 RID: 9496
		// (remove) Token: 0x06002519 RID: 9497
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000473 RID: 1139
		// (add) Token: 0x0600251A RID: 9498
		// (remove) Token: 0x0600251B RID: 9499
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000474 RID: 1140
		// (add) Token: 0x0600251C RID: 9500
		// (remove) Token: 0x0600251D RID: 9501
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000475 RID: 1141
		// (add) Token: 0x0600251E RID: 9502
		// (remove) Token: 0x0600251F RID: 9503
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000476 RID: 1142
		// (add) Token: 0x06002520 RID: 9504
		// (remove) Token: 0x06002521 RID: 9505
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
