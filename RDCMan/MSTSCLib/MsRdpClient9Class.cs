using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001E7 RID: 487
	[Guid("301B94BA-5D25-4A12-BFFE-3B6E7A616585")]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[ClassInterface(0)]
	[TypeLibType(2)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient9Class : IMsRdpClient9, MsRdpClient9, IMsTscAxEvents_Event, IMsRdpClient8, IMsRdpClient7, IMsRdpClient6, IMsRdpClient5, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3, IMsRdpClientNonScriptable4, IMsRdpClientNonScriptable5, IMsRdpPreferredRedirectionInfo
	{
		// Token: 0x06004341 RID: 17217
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient9Class();

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06004343 RID: 17219
		// (set) Token: 0x06004342 RID: 17218
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06004345 RID: 17221
		// (set) Token: 0x06004344 RID: 17220
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06004347 RID: 17223
		// (set) Token: 0x06004346 RID: 17222
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06004349 RID: 17225
		// (set) Token: 0x06004348 RID: 17224
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x0600434B RID: 17227
		// (set) Token: 0x0600434A RID: 17226
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x0600434C RID: 17228
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600434E RID: 17230
		// (set) Token: 0x0600434D RID: 17229
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06004350 RID: 17232
		// (set) Token: 0x0600434F RID: 17231
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06004352 RID: 17234
		// (set) Token: 0x06004351 RID: 17233
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06004353 RID: 17235
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06004354 RID: 17236
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001803 RID: 6147
		// (set) Token: 0x06004355 RID: 17237
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06004356 RID: 17238
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06004357 RID: 17239
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06004358 RID: 17240
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06004359 RID: 17241
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x0600435A RID: 17242
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x0600435B RID: 17243
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600435C RID: 17244
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x0600435D RID: 17245
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x0600435E RID: 17246
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600435F RID: 17247
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06004361 RID: 17249
		// (set) Token: 0x06004360 RID: 17248
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06004362 RID: 17250
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06004363 RID: 17251
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06004364 RID: 17252
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06004366 RID: 17254
		// (set) Token: 0x06004365 RID: 17253
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004367 RID: 17255
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004368 RID: 17256
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004369 RID: 17257
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x0600436A RID: 17258
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x0600436C RID: 17260
		// (set) Token: 0x0600436B RID: 17259
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x0600436D RID: 17261
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x0600436E RID: 17262
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x0600436F RID: 17263
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06004370 RID: 17264
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004371 RID: 17265
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06004372 RID: 17266
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06004373 RID: 17267
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06004374 RID: 17268
		[DispId(507)]
		public virtual extern IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06004375 RID: 17269
		[DispId(506)]
		public virtual extern IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06004376 RID: 17270
		[DispId(600)]
		public virtual extern IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06004377 RID: 17271
		[DispId(601)]
		public virtual extern IMsRdpClientTransportSettings3 TransportSettings3 { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004378 RID: 17272
		[DispId(602)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetStatusText([In] uint statusCode);

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06004379 RID: 17273
		[DispId(603)]
		public virtual extern IMsRdpClientSecuredSettings2 SecuredSettings3 { [DispId(603)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x0600437A RID: 17274
		[DispId(604)]
		public virtual extern ITSRemoteProgram2 RemoteProgram2 { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600437B RID: 17275
		[DispId(700)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x0600437C RID: 17276
		[DispId(701)]
		public virtual extern IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600437D RID: 17277
		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x0600437E RID: 17278
		[DispId(800)]
		public virtual extern IMsRdpClientTransportSettings4 TransportSettings4 { [DispId(800)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600437F RID: 17279
		[DispId(801)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SyncSessionDisplaySettings();

		// Token: 0x06004380 RID: 17280
		[DispId(802)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

		// Token: 0x06004381 RID: 17281
		[DispId(803)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x06004382 RID: 17282
		[DispId(804)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06004384 RID: 17284
		// (set) Token: 0x06004383 RID: 17283
		public virtual extern string IMsRdpClient8_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06004386 RID: 17286
		// (set) Token: 0x06004385 RID: 17285
		public virtual extern string IMsRdpClient8_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06004388 RID: 17288
		// (set) Token: 0x06004387 RID: 17287
		public virtual extern string IMsRdpClient8_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600438A RID: 17290
		// (set) Token: 0x06004389 RID: 17289
		public virtual extern string IMsRdpClient8_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x0600438C RID: 17292
		// (set) Token: 0x0600438B RID: 17291
		public virtual extern string IMsRdpClient8_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x0600438D RID: 17293
		public virtual extern short IMsRdpClient8_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600438F RID: 17295
		// (set) Token: 0x0600438E RID: 17294
		public virtual extern int IMsRdpClient8_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06004391 RID: 17297
		// (set) Token: 0x06004390 RID: 17296
		public virtual extern int IMsRdpClient8_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06004393 RID: 17299
		// (set) Token: 0x06004392 RID: 17298
		public virtual extern int IMsRdpClient8_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06004394 RID: 17300
		public virtual extern int IMsRdpClient8_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06004395 RID: 17301
		public virtual extern int IMsRdpClient8_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700182A RID: 6186
		// (set) Token: 0x06004396 RID: 17302
		public virtual extern string IMsRdpClient8_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06004397 RID: 17303
		public virtual extern int IMsRdpClient8_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06004398 RID: 17304
		public virtual extern string IMsRdpClient8_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06004399 RID: 17305
		public virtual extern int IMsRdpClient8_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x0600439A RID: 17306
		public virtual extern IMsTscSecuredSettings IMsRdpClient8_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x0600439B RID: 17307
		public virtual extern IMsTscAdvancedSettings IMsRdpClient8_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x0600439C RID: 17308
		public virtual extern IMsTscDebug IMsRdpClient8_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600439D RID: 17309
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Connect();

		// Token: 0x0600439E RID: 17310
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_Disconnect();

		// Token: 0x0600439F RID: 17311
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060043A0 RID: 17312
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x060043A2 RID: 17314
		// (set) Token: 0x060043A1 RID: 17313
		public virtual extern int IMsRdpClient8_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x060043A3 RID: 17315
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient8_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x060043A4 RID: 17316
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient8_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x060043A5 RID: 17317
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient8_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x060043A7 RID: 17319
		// (set) Token: 0x060043A6 RID: 17318
		public virtual extern bool IMsRdpClient8_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060043A8 RID: 17320
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060043A9 RID: 17321
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient8_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060043AA RID: 17322
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient8_RequestClose();

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x060043AB RID: 17323
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient8_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x060043AD RID: 17325
		// (set) Token: 0x060043AC RID: 17324
		public virtual extern string IMsRdpClient8_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x060043AE RID: 17326
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient8_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x060043AF RID: 17327
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient8_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x060043B0 RID: 17328
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient8_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x060043B1 RID: 17329
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient8_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060043B2 RID: 17330
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x060043B3 RID: 17331
		public virtual extern ITSRemoteProgram IMsRdpClient8_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x060043B4 RID: 17332
		public virtual extern IMsRdpClientShell IMsRdpClient8_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x060043B5 RID: 17333
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient8_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x060043B6 RID: 17334
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient8_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x060043B7 RID: 17335
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient8_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x060043B8 RID: 17336
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient8_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060043B9 RID: 17337
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient8_GetStatusText([In] uint statusCode);

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x060043BA RID: 17338
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient8_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x060043BB RID: 17339
		public virtual extern ITSRemoteProgram2 IMsRdpClient8_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060043BC RID: 17340
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient8_SendRemoteAction([ComAliasName("MSTSCLib.RemoteSessionActionType")] [In] RemoteSessionActionType actionType);

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x060043BD RID: 17341
		public virtual extern IMsRdpClientAdvancedSettings8 IMsRdpClient8_AdvancedSettings9 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060043BE RID: 17342
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
		public virtual extern ControlReconnectStatus IMsRdpClient8_Reconnect([In] uint ulWidth, [In] uint ulHeight);

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x060043C0 RID: 17344
		// (set) Token: 0x060043BF RID: 17343
		public virtual extern string IMsRdpClient7_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x060043C2 RID: 17346
		// (set) Token: 0x060043C1 RID: 17345
		public virtual extern string IMsRdpClient7_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x060043C4 RID: 17348
		// (set) Token: 0x060043C3 RID: 17347
		public virtual extern string IMsRdpClient7_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x060043C6 RID: 17350
		// (set) Token: 0x060043C5 RID: 17349
		public virtual extern string IMsRdpClient7_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x060043C8 RID: 17352
		// (set) Token: 0x060043C7 RID: 17351
		public virtual extern string IMsRdpClient7_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x060043C9 RID: 17353
		public virtual extern short IMsRdpClient7_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x060043CB RID: 17355
		// (set) Token: 0x060043CA RID: 17354
		public virtual extern int IMsRdpClient7_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x060043CD RID: 17357
		// (set) Token: 0x060043CC RID: 17356
		public virtual extern int IMsRdpClient7_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x060043CF RID: 17359
		// (set) Token: 0x060043CE RID: 17358
		public virtual extern int IMsRdpClient7_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x060043D0 RID: 17360
		public virtual extern int IMsRdpClient7_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x060043D1 RID: 17361
		public virtual extern int IMsRdpClient7_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001850 RID: 6224
		// (set) Token: 0x060043D2 RID: 17362
		public virtual extern string IMsRdpClient7_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x060043D3 RID: 17363
		public virtual extern int IMsRdpClient7_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x060043D4 RID: 17364
		public virtual extern string IMsRdpClient7_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x060043D5 RID: 17365
		public virtual extern int IMsRdpClient7_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x060043D6 RID: 17366
		public virtual extern IMsTscSecuredSettings IMsRdpClient7_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x060043D7 RID: 17367
		public virtual extern IMsTscAdvancedSettings IMsRdpClient7_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x060043D8 RID: 17368
		public virtual extern IMsTscDebug IMsRdpClient7_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060043D9 RID: 17369
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Connect();

		// Token: 0x060043DA RID: 17370
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_Disconnect();

		// Token: 0x060043DB RID: 17371
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060043DC RID: 17372
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x060043DE RID: 17374
		// (set) Token: 0x060043DD RID: 17373
		public virtual extern int IMsRdpClient7_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x060043DF RID: 17375
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient7_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x060043E0 RID: 17376
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient7_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x060043E1 RID: 17377
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient7_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x060043E3 RID: 17379
		// (set) Token: 0x060043E2 RID: 17378
		public virtual extern bool IMsRdpClient7_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060043E4 RID: 17380
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient7_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060043E5 RID: 17381
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient7_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060043E6 RID: 17382
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient7_RequestClose();

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x060043E7 RID: 17383
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient7_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x060043E9 RID: 17385
		// (set) Token: 0x060043E8 RID: 17384
		public virtual extern string IMsRdpClient7_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x060043EA RID: 17386
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient7_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x060043EB RID: 17387
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient7_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x060043EC RID: 17388
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient7_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x060043ED RID: 17389
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient7_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060043EE RID: 17390
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x060043EF RID: 17391
		public virtual extern ITSRemoteProgram IMsRdpClient7_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x060043F0 RID: 17392
		public virtual extern IMsRdpClientShell IMsRdpClient7_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x060043F1 RID: 17393
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient7_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x060043F2 RID: 17394
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient7_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x060043F3 RID: 17395
		public virtual extern IMsRdpClientAdvancedSettings7 IMsRdpClient7_AdvancedSettings8 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x060043F4 RID: 17396
		public virtual extern IMsRdpClientTransportSettings3 IMsRdpClient7_TransportSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060043F5 RID: 17397
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient7_GetStatusText([In] uint statusCode);

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x060043F6 RID: 17398
		public virtual extern IMsRdpClientSecuredSettings2 IMsRdpClient7_SecuredSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x060043F7 RID: 17399
		public virtual extern ITSRemoteProgram2 IMsRdpClient7_RemoteProgram2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x060043F9 RID: 17401
		// (set) Token: 0x060043F8 RID: 17400
		public virtual extern string IMsRdpClient6_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x060043FB RID: 17403
		// (set) Token: 0x060043FA RID: 17402
		public virtual extern string IMsRdpClient6_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x060043FD RID: 17405
		// (set) Token: 0x060043FC RID: 17404
		public virtual extern string IMsRdpClient6_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x060043FF RID: 17407
		// (set) Token: 0x060043FE RID: 17406
		public virtual extern string IMsRdpClient6_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06004401 RID: 17409
		// (set) Token: 0x06004400 RID: 17408
		public virtual extern string IMsRdpClient6_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06004402 RID: 17410
		public virtual extern short IMsRdpClient6_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06004404 RID: 17412
		// (set) Token: 0x06004403 RID: 17411
		public virtual extern int IMsRdpClient6_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06004406 RID: 17414
		// (set) Token: 0x06004405 RID: 17413
		public virtual extern int IMsRdpClient6_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06004408 RID: 17416
		// (set) Token: 0x06004407 RID: 17415
		public virtual extern int IMsRdpClient6_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06004409 RID: 17417
		public virtual extern int IMsRdpClient6_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x0600440A RID: 17418
		public virtual extern int IMsRdpClient6_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001875 RID: 6261
		// (set) Token: 0x0600440B RID: 17419
		public virtual extern string IMsRdpClient6_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x0600440C RID: 17420
		public virtual extern int IMsRdpClient6_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x0600440D RID: 17421
		public virtual extern string IMsRdpClient6_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x0600440E RID: 17422
		public virtual extern int IMsRdpClient6_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x0600440F RID: 17423
		public virtual extern IMsTscSecuredSettings IMsRdpClient6_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06004410 RID: 17424
		public virtual extern IMsTscAdvancedSettings IMsRdpClient6_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06004411 RID: 17425
		public virtual extern IMsTscDebug IMsRdpClient6_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004412 RID: 17426
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Connect();

		// Token: 0x06004413 RID: 17427
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_Disconnect();

		// Token: 0x06004414 RID: 17428
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004415 RID: 17429
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06004417 RID: 17431
		// (set) Token: 0x06004416 RID: 17430
		public virtual extern int IMsRdpClient6_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06004418 RID: 17432
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient6_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06004419 RID: 17433
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient6_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x0600441A RID: 17434
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient6_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x0600441C RID: 17436
		// (set) Token: 0x0600441B RID: 17435
		public virtual extern bool IMsRdpClient6_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600441D RID: 17437
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient6_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600441E RID: 17438
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient6_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600441F RID: 17439
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient6_RequestClose();

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06004420 RID: 17440
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient6_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06004422 RID: 17442
		// (set) Token: 0x06004421 RID: 17441
		public virtual extern string IMsRdpClient6_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06004423 RID: 17443
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient6_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06004424 RID: 17444
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient6_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06004425 RID: 17445
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient6_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06004426 RID: 17446
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient6_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004427 RID: 17447
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient6_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06004428 RID: 17448
		public virtual extern ITSRemoteProgram IMsRdpClient6_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06004429 RID: 17449
		public virtual extern IMsRdpClientShell IMsRdpClient6_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x0600442A RID: 17450
		public virtual extern IMsRdpClientAdvancedSettings6 IMsRdpClient6_AdvancedSettings7 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x0600442B RID: 17451
		public virtual extern IMsRdpClientTransportSettings2 IMsRdpClient6_TransportSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x0600442D RID: 17453
		// (set) Token: 0x0600442C RID: 17452
		public virtual extern string IMsRdpClient5_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x0600442F RID: 17455
		// (set) Token: 0x0600442E RID: 17454
		public virtual extern string IMsRdpClient5_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06004431 RID: 17457
		// (set) Token: 0x06004430 RID: 17456
		public virtual extern string IMsRdpClient5_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06004433 RID: 17459
		// (set) Token: 0x06004432 RID: 17458
		public virtual extern string IMsRdpClient5_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06004435 RID: 17461
		// (set) Token: 0x06004434 RID: 17460
		public virtual extern string IMsRdpClient5_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06004436 RID: 17462
		public virtual extern short IMsRdpClient5_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06004438 RID: 17464
		// (set) Token: 0x06004437 RID: 17463
		public virtual extern int IMsRdpClient5_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x0600443A RID: 17466
		// (set) Token: 0x06004439 RID: 17465
		public virtual extern int IMsRdpClient5_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x0600443C RID: 17468
		// (set) Token: 0x0600443B RID: 17467
		public virtual extern int IMsRdpClient5_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x0600443D RID: 17469
		public virtual extern int IMsRdpClient5_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x0600443E RID: 17470
		public virtual extern int IMsRdpClient5_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001896 RID: 6294
		// (set) Token: 0x0600443F RID: 17471
		public virtual extern string IMsRdpClient5_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06004440 RID: 17472
		public virtual extern int IMsRdpClient5_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06004441 RID: 17473
		public virtual extern string IMsRdpClient5_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06004442 RID: 17474
		public virtual extern int IMsRdpClient5_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06004443 RID: 17475
		public virtual extern IMsTscSecuredSettings IMsRdpClient5_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06004444 RID: 17476
		public virtual extern IMsTscAdvancedSettings IMsRdpClient5_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06004445 RID: 17477
		public virtual extern IMsTscDebug IMsRdpClient5_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004446 RID: 17478
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Connect();

		// Token: 0x06004447 RID: 17479
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Disconnect();

		// Token: 0x06004448 RID: 17480
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004449 RID: 17481
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x0600444B RID: 17483
		// (set) Token: 0x0600444A RID: 17482
		public virtual extern int IMsRdpClient5_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x0600444C RID: 17484
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient5_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x0600444D RID: 17485
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient5_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x0600444E RID: 17486
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient5_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06004450 RID: 17488
		// (set) Token: 0x0600444F RID: 17487
		public virtual extern bool IMsRdpClient5_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004451 RID: 17489
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004452 RID: 17490
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient5_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004453 RID: 17491
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient5_RequestClose();

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06004454 RID: 17492
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient5_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06004456 RID: 17494
		// (set) Token: 0x06004455 RID: 17493
		public virtual extern string IMsRdpClient5_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06004457 RID: 17495
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient5_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06004458 RID: 17496
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient5_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06004459 RID: 17497
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient5_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600445A RID: 17498
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient5_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600445B RID: 17499
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient5_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600445C RID: 17500
		public virtual extern ITSRemoteProgram IMsRdpClient5_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x0600445D RID: 17501
		public virtual extern IMsRdpClientShell IMsRdpClient5_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x0600445F RID: 17503
		// (set) Token: 0x0600445E RID: 17502
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06004461 RID: 17505
		// (set) Token: 0x06004460 RID: 17504
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06004463 RID: 17507
		// (set) Token: 0x06004462 RID: 17506
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06004465 RID: 17509
		// (set) Token: 0x06004464 RID: 17508
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06004467 RID: 17511
		// (set) Token: 0x06004466 RID: 17510
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06004468 RID: 17512
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600446A RID: 17514
		// (set) Token: 0x06004469 RID: 17513
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x0600446C RID: 17516
		// (set) Token: 0x0600446B RID: 17515
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x0600446E RID: 17518
		// (set) Token: 0x0600446D RID: 17517
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x0600446F RID: 17519
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06004470 RID: 17520
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018B5 RID: 6325
		// (set) Token: 0x06004471 RID: 17521
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06004472 RID: 17522
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06004473 RID: 17523
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06004474 RID: 17524
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06004475 RID: 17525
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06004476 RID: 17526
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06004477 RID: 17527
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004478 RID: 17528
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x06004479 RID: 17529
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x0600447A RID: 17530
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600447B RID: 17531
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x0600447D RID: 17533
		// (set) Token: 0x0600447C RID: 17532
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x0600447E RID: 17534
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x0600447F RID: 17535
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06004480 RID: 17536
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06004482 RID: 17538
		// (set) Token: 0x06004481 RID: 17537
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004483 RID: 17539
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004484 RID: 17540
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004485 RID: 17541
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06004486 RID: 17542
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06004488 RID: 17544
		// (set) Token: 0x06004487 RID: 17543
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x06004489 RID: 17545
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x0600448A RID: 17546
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x0600448C RID: 17548
		// (set) Token: 0x0600448B RID: 17547
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x0600448E RID: 17550
		// (set) Token: 0x0600448D RID: 17549
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06004490 RID: 17552
		// (set) Token: 0x0600448F RID: 17551
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06004492 RID: 17554
		// (set) Token: 0x06004491 RID: 17553
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06004494 RID: 17556
		// (set) Token: 0x06004493 RID: 17555
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x06004495 RID: 17557
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x06004497 RID: 17559
		// (set) Token: 0x06004496 RID: 17558
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x06004499 RID: 17561
		// (set) Token: 0x06004498 RID: 17560
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x0600449B RID: 17563
		// (set) Token: 0x0600449A RID: 17562
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x0600449C RID: 17564
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x0600449D RID: 17565
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018D0 RID: 6352
		// (set) Token: 0x0600449E RID: 17566
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x0600449F RID: 17567
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x060044A0 RID: 17568
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x060044A1 RID: 17569
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060044A2 RID: 17570
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x060044A3 RID: 17571
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x060044A4 RID: 17572
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060044A5 RID: 17573
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x060044A6 RID: 17574
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x060044A7 RID: 17575
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060044A8 RID: 17576
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x060044AA RID: 17578
		// (set) Token: 0x060044A9 RID: 17577
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x060044AB RID: 17579
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x060044AC RID: 17580
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x060044AD RID: 17581
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x060044AF RID: 17583
		// (set) Token: 0x060044AE RID: 17582
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060044B0 RID: 17584
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060044B1 RID: 17585
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060044B2 RID: 17586
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x060044B3 RID: 17587
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x060044B5 RID: 17589
		// (set) Token: 0x060044B4 RID: 17588
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x060044B6 RID: 17590
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x060044B8 RID: 17592
		// (set) Token: 0x060044B7 RID: 17591
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x060044BA RID: 17594
		// (set) Token: 0x060044B9 RID: 17593
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x060044BC RID: 17596
		// (set) Token: 0x060044BB RID: 17595
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x060044BE RID: 17598
		// (set) Token: 0x060044BD RID: 17597
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x060044C0 RID: 17600
		// (set) Token: 0x060044BF RID: 17599
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x060044C1 RID: 17601
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x060044C3 RID: 17603
		// (set) Token: 0x060044C2 RID: 17602
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x060044C5 RID: 17605
		// (set) Token: 0x060044C4 RID: 17604
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x060044C7 RID: 17607
		// (set) Token: 0x060044C6 RID: 17606
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x060044C8 RID: 17608
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x060044C9 RID: 17609
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018EA RID: 6378
		// (set) Token: 0x060044CA RID: 17610
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x060044CB RID: 17611
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x060044CC RID: 17612
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x060044CD RID: 17613
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x060044CE RID: 17614
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x060044CF RID: 17615
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x060044D0 RID: 17616
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060044D1 RID: 17617
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x060044D2 RID: 17618
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x060044D3 RID: 17619
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060044D4 RID: 17620
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x060044D6 RID: 17622
		// (set) Token: 0x060044D5 RID: 17621
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x060044D7 RID: 17623
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x060044D8 RID: 17624
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x060044D9 RID: 17625
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x060044DB RID: 17627
		// (set) Token: 0x060044DA RID: 17626
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060044DC RID: 17628
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060044DD RID: 17629
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060044DE RID: 17630
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x060044DF RID: 17631
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x060044E1 RID: 17633
		// (set) Token: 0x060044E0 RID: 17632
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x060044E3 RID: 17635
		// (set) Token: 0x060044E2 RID: 17634
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x060044E5 RID: 17637
		// (set) Token: 0x060044E4 RID: 17636
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x060044E7 RID: 17639
		// (set) Token: 0x060044E6 RID: 17638
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x060044E9 RID: 17641
		// (set) Token: 0x060044E8 RID: 17640
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x060044EB RID: 17643
		// (set) Token: 0x060044EA RID: 17642
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x060044EC RID: 17644
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x060044EE RID: 17646
		// (set) Token: 0x060044ED RID: 17645
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x060044F0 RID: 17648
		// (set) Token: 0x060044EF RID: 17647
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x060044F2 RID: 17650
		// (set) Token: 0x060044F1 RID: 17649
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x060044F3 RID: 17651
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060044F4 RID: 17652
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001903 RID: 6403
		// (set) Token: 0x060044F5 RID: 17653
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x060044F6 RID: 17654
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060044F7 RID: 17655
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060044F8 RID: 17656
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060044F9 RID: 17657
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060044FA RID: 17658
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060044FB RID: 17659
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060044FC RID: 17660
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x060044FD RID: 17661
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x060044FE RID: 17662
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060044FF RID: 17663
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06004501 RID: 17665
		// (set) Token: 0x06004500 RID: 17664
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x06004502 RID: 17666
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x06004503 RID: 17667
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x06004504 RID: 17668
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x06004506 RID: 17670
		// (set) Token: 0x06004505 RID: 17669
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06004507 RID: 17671
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06004508 RID: 17672
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06004509 RID: 17673
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x0600450B RID: 17675
		// (set) Token: 0x0600450A RID: 17674
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x0600450D RID: 17677
		// (set) Token: 0x0600450C RID: 17676
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x0600450F RID: 17679
		// (set) Token: 0x0600450E RID: 17678
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x06004511 RID: 17681
		// (set) Token: 0x06004510 RID: 17680
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x06004513 RID: 17683
		// (set) Token: 0x06004512 RID: 17682
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06004514 RID: 17684
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06004516 RID: 17686
		// (set) Token: 0x06004515 RID: 17685
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x06004518 RID: 17688
		// (set) Token: 0x06004517 RID: 17687
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x0600451A RID: 17690
		// (set) Token: 0x06004519 RID: 17689
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x0600451B RID: 17691
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x0600451C RID: 17692
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700191A RID: 6426
		// (set) Token: 0x0600451D RID: 17693
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x0600451E RID: 17694
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x0600451F RID: 17695
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06004520 RID: 17696
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06004521 RID: 17697
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06004522 RID: 17698
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06004523 RID: 17699
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06004524 RID: 17700
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06004525 RID: 17701
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06004526 RID: 17702
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06004527 RID: 17703
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001921 RID: 6433
		// (set) Token: 0x06004528 RID: 17704
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x0600452A RID: 17706
		// (set) Token: 0x06004529 RID: 17705
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x0600452C RID: 17708
		// (set) Token: 0x0600452B RID: 17707
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x0600452E RID: 17710
		// (set) Token: 0x0600452D RID: 17709
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06004530 RID: 17712
		// (set) Token: 0x0600452F RID: 17711
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004531 RID: 17713
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17001926 RID: 6438
		// (set) Token: 0x06004532 RID: 17714
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06004534 RID: 17716
		// (set) Token: 0x06004533 RID: 17715
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06004536 RID: 17718
		// (set) Token: 0x06004535 RID: 17717
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06004538 RID: 17720
		// (set) Token: 0x06004537 RID: 17719
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x0600453A RID: 17722
		// (set) Token: 0x06004539 RID: 17721
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600453B RID: 17723
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x0600453C RID: 17724
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600453D RID: 17725
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x1700192B RID: 6443
		// (set) Token: 0x0600453E RID: 17726
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06004540 RID: 17728
		// (set) Token: 0x0600453F RID: 17727
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06004542 RID: 17730
		// (set) Token: 0x06004541 RID: 17729
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06004544 RID: 17732
		// (set) Token: 0x06004543 RID: 17731
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06004546 RID: 17734
		// (set) Token: 0x06004545 RID: 17733
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004547 RID: 17735
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06004548 RID: 17736
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004549 RID: 17737
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x0600454B RID: 17739
		// (set) Token: 0x0600454A RID: 17738
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001931 RID: 6449
		// (set) Token: 0x0600454C RID: 17740
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x0600454E RID: 17742
		// (set) Token: 0x0600454D RID: 17741
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06004550 RID: 17744
		// (set) Token: 0x0600454F RID: 17743
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06004552 RID: 17746
		// (set) Token: 0x06004551 RID: 17745
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x06004554 RID: 17748
		// (set) Token: 0x06004553 RID: 17747
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004555 RID: 17749
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x06004556 RID: 17750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004557 RID: 17751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06004559 RID: 17753
		// (set) Token: 0x06004558 RID: 17752
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x0600455B RID: 17755
		// (set) Token: 0x0600455A RID: 17754
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x0600455D RID: 17757
		// (set) Token: 0x0600455C RID: 17756
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x0600455F RID: 17759
		// (set) Token: 0x0600455E RID: 17758
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06004561 RID: 17761
		// (set) Token: 0x06004560 RID: 17760
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06004563 RID: 17763
		// (set) Token: 0x06004562 RID: 17762
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06004565 RID: 17765
		// (set) Token: 0x06004564 RID: 17764
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06004566 RID: 17766
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06004567 RID: 17767
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06004569 RID: 17769
		// (set) Token: 0x06004568 RID: 17768
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x0600456B RID: 17771
		// (set) Token: 0x0600456A RID: 17770
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x0600456D RID: 17773
		// (set) Token: 0x0600456C RID: 17772
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001942 RID: 6466
		// (set) Token: 0x0600456E RID: 17774
		public virtual extern string IMsRdpClientNonScriptable4_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06004570 RID: 17776
		// (set) Token: 0x0600456F RID: 17775
		public virtual extern string IMsRdpClientNonScriptable4_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06004572 RID: 17778
		// (set) Token: 0x06004571 RID: 17777
		public virtual extern string IMsRdpClientNonScriptable4_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06004574 RID: 17780
		// (set) Token: 0x06004573 RID: 17779
		public virtual extern string IMsRdpClientNonScriptable4_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06004576 RID: 17782
		// (set) Token: 0x06004575 RID: 17781
		public virtual extern string IMsRdpClientNonScriptable4_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06004577 RID: 17783
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_ResetPassword();

		// Token: 0x06004578 RID: 17784
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06004579 RID: 17785
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x0600457B RID: 17787
		// (set) Token: 0x0600457A RID: 17786
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable4_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x0600457D RID: 17789
		// (set) Token: 0x0600457C RID: 17788
		public virtual extern bool IMsRdpClientNonScriptable4_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x0600457F RID: 17791
		// (set) Token: 0x0600457E RID: 17790
		public virtual extern bool IMsRdpClientNonScriptable4_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06004581 RID: 17793
		// (set) Token: 0x06004580 RID: 17792
		public virtual extern bool IMsRdpClientNonScriptable4_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06004583 RID: 17795
		// (set) Token: 0x06004582 RID: 17794
		public virtual extern bool IMsRdpClientNonScriptable4_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06004585 RID: 17797
		// (set) Token: 0x06004584 RID: 17796
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06004587 RID: 17799
		// (set) Token: 0x06004586 RID: 17798
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06004588 RID: 17800
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable4_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06004589 RID: 17801
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable4_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x0600458B RID: 17803
		// (set) Token: 0x0600458A RID: 17802
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x0600458D RID: 17805
		// (set) Token: 0x0600458C RID: 17804
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x0600458F RID: 17807
		// (set) Token: 0x0600458E RID: 17806
		public virtual extern string IMsRdpClientNonScriptable4_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06004591 RID: 17809
		// (set) Token: 0x06004590 RID: 17808
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06004593 RID: 17811
		// (set) Token: 0x06004592 RID: 17810
		public virtual extern bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06004595 RID: 17813
		// (set) Token: 0x06004594 RID: 17812
		public virtual extern object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06004597 RID: 17815
		// (set) Token: 0x06004596 RID: 17814
		public virtual extern bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06004599 RID: 17817
		// (set) Token: 0x06004598 RID: 17816
		public virtual extern bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x0600459B RID: 17819
		// (set) Token: 0x0600459A RID: 17818
		public virtual extern bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x0600459D RID: 17821
		// (set) Token: 0x0600459C RID: 17820
		public virtual extern bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x0600459F RID: 17823
		// (set) Token: 0x0600459E RID: 17822
		public virtual extern bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700195B RID: 6491
		// (set) Token: 0x060045A0 RID: 17824
		public virtual extern string IMsRdpClientNonScriptable5_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x060045A2 RID: 17826
		// (set) Token: 0x060045A1 RID: 17825
		public virtual extern string IMsRdpClientNonScriptable5_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x060045A4 RID: 17828
		// (set) Token: 0x060045A3 RID: 17827
		public virtual extern string IMsRdpClientNonScriptable5_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x060045A6 RID: 17830
		// (set) Token: 0x060045A5 RID: 17829
		public virtual extern string IMsRdpClientNonScriptable5_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x060045A8 RID: 17832
		// (set) Token: 0x060045A7 RID: 17831
		public virtual extern string IMsRdpClientNonScriptable5_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060045A9 RID: 17833
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_ResetPassword();

		// Token: 0x060045AA RID: 17834
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060045AB RID: 17835
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable5_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x060045AD RID: 17837
		// (set) Token: 0x060045AC RID: 17836
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable5_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x060045AF RID: 17839
		// (set) Token: 0x060045AE RID: 17838
		public virtual extern bool IMsRdpClientNonScriptable5_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x060045B1 RID: 17841
		// (set) Token: 0x060045B0 RID: 17840
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x060045B3 RID: 17843
		// (set) Token: 0x060045B2 RID: 17842
		public virtual extern bool IMsRdpClientNonScriptable5_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x060045B5 RID: 17845
		// (set) Token: 0x060045B4 RID: 17844
		public virtual extern bool IMsRdpClientNonScriptable5_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x060045B7 RID: 17847
		// (set) Token: 0x060045B6 RID: 17846
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x060045B9 RID: 17849
		// (set) Token: 0x060045B8 RID: 17848
		public virtual extern bool IMsRdpClientNonScriptable5_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x060045BA RID: 17850
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable5_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x060045BB RID: 17851
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable5_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x060045BD RID: 17853
		// (set) Token: 0x060045BC RID: 17852
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x060045BF RID: 17855
		// (set) Token: 0x060045BE RID: 17854
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x060045C1 RID: 17857
		// (set) Token: 0x060045C0 RID: 17856
		public virtual extern string IMsRdpClientNonScriptable5_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x060045C3 RID: 17859
		// (set) Token: 0x060045C2 RID: 17858
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType IMsRdpClientNonScriptable5_RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x060045C5 RID: 17861
		// (set) Token: 0x060045C4 RID: 17860
		public virtual extern bool IMsRdpClientNonScriptable5_MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x060045C7 RID: 17863
		// (set) Token: 0x060045C6 RID: 17862
		public virtual extern object IMsRdpClientNonScriptable5_PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x060045C9 RID: 17865
		// (set) Token: 0x060045C8 RID: 17864
		public virtual extern bool IMsRdpClientNonScriptable5_WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x060045CB RID: 17867
		// (set) Token: 0x060045CA RID: 17866
		public virtual extern bool IMsRdpClientNonScriptable5_AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x060045CD RID: 17869
		// (set) Token: 0x060045CC RID: 17868
		public virtual extern bool IMsRdpClientNonScriptable5_PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x060045CF RID: 17871
		// (set) Token: 0x060045CE RID: 17870
		public virtual extern bool IMsRdpClientNonScriptable5_LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060045D1 RID: 17873
		// (set) Token: 0x060045D0 RID: 17872
		public virtual extern bool IMsRdpClientNonScriptable5_TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x060045D3 RID: 17875
		// (set) Token: 0x060045D2 RID: 17874
		public virtual extern bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060045D4 RID: 17876
		public virtual extern uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060045D5 RID: 17877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060045D6 RID: 17878
		public virtual extern bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001977 RID: 6519
		// (set) Token: 0x060045D7 RID: 17879
		public virtual extern bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060045D9 RID: 17881
		// (set) Token: 0x060045D8 RID: 17880
		public virtual extern bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060045DB RID: 17883
		// (set) Token: 0x060045DA RID: 17882
		public virtual extern bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060045DD RID: 17885
		// (set) Token: 0x060045DC RID: 17884
		public virtual extern bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060045DF RID: 17887
		// (set) Token: 0x060045DE RID: 17886
		public virtual extern bool UseRedirectionServerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x14000617 RID: 1559
		// (add) Token: 0x060045E0 RID: 17888
		// (remove) Token: 0x060045E1 RID: 17889
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000618 RID: 1560
		// (add) Token: 0x060045E2 RID: 17890
		// (remove) Token: 0x060045E3 RID: 17891
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000619 RID: 1561
		// (add) Token: 0x060045E4 RID: 17892
		// (remove) Token: 0x060045E5 RID: 17893
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400061A RID: 1562
		// (add) Token: 0x060045E6 RID: 17894
		// (remove) Token: 0x060045E7 RID: 17895
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400061B RID: 1563
		// (add) Token: 0x060045E8 RID: 17896
		// (remove) Token: 0x060045E9 RID: 17897
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400061C RID: 1564
		// (add) Token: 0x060045EA RID: 17898
		// (remove) Token: 0x060045EB RID: 17899
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400061D RID: 1565
		// (add) Token: 0x060045EC RID: 17900
		// (remove) Token: 0x060045ED RID: 17901
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400061E RID: 1566
		// (add) Token: 0x060045EE RID: 17902
		// (remove) Token: 0x060045EF RID: 17903
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400061F RID: 1567
		// (add) Token: 0x060045F0 RID: 17904
		// (remove) Token: 0x060045F1 RID: 17905
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000620 RID: 1568
		// (add) Token: 0x060045F2 RID: 17906
		// (remove) Token: 0x060045F3 RID: 17907
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000621 RID: 1569
		// (add) Token: 0x060045F4 RID: 17908
		// (remove) Token: 0x060045F5 RID: 17909
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000622 RID: 1570
		// (add) Token: 0x060045F6 RID: 17910
		// (remove) Token: 0x060045F7 RID: 17911
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000623 RID: 1571
		// (add) Token: 0x060045F8 RID: 17912
		// (remove) Token: 0x060045F9 RID: 17913
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000624 RID: 1572
		// (add) Token: 0x060045FA RID: 17914
		// (remove) Token: 0x060045FB RID: 17915
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000625 RID: 1573
		// (add) Token: 0x060045FC RID: 17916
		// (remove) Token: 0x060045FD RID: 17917
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000626 RID: 1574
		// (add) Token: 0x060045FE RID: 17918
		// (remove) Token: 0x060045FF RID: 17919
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000627 RID: 1575
		// (add) Token: 0x06004600 RID: 17920
		// (remove) Token: 0x06004601 RID: 17921
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000628 RID: 1576
		// (add) Token: 0x06004602 RID: 17922
		// (remove) Token: 0x06004603 RID: 17923
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000629 RID: 1577
		// (add) Token: 0x06004604 RID: 17924
		// (remove) Token: 0x06004605 RID: 17925
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400062A RID: 1578
		// (add) Token: 0x06004606 RID: 17926
		// (remove) Token: 0x06004607 RID: 17927
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400062B RID: 1579
		// (add) Token: 0x06004608 RID: 17928
		// (remove) Token: 0x06004609 RID: 17929
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400062C RID: 1580
		// (add) Token: 0x0600460A RID: 17930
		// (remove) Token: 0x0600460B RID: 17931
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400062D RID: 1581
		// (add) Token: 0x0600460C RID: 17932
		// (remove) Token: 0x0600460D RID: 17933
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400062E RID: 1582
		// (add) Token: 0x0600460E RID: 17934
		// (remove) Token: 0x0600460F RID: 17935
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400062F RID: 1583
		// (add) Token: 0x06004610 RID: 17936
		// (remove) Token: 0x06004611 RID: 17937
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000630 RID: 1584
		// (add) Token: 0x06004612 RID: 17938
		// (remove) Token: 0x06004613 RID: 17939
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000631 RID: 1585
		// (add) Token: 0x06004614 RID: 17940
		// (remove) Token: 0x06004615 RID: 17941
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000632 RID: 1586
		// (add) Token: 0x06004616 RID: 17942
		// (remove) Token: 0x06004617 RID: 17943
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000633 RID: 1587
		// (add) Token: 0x06004618 RID: 17944
		// (remove) Token: 0x06004619 RID: 17945
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000634 RID: 1588
		// (add) Token: 0x0600461A RID: 17946
		// (remove) Token: 0x0600461B RID: 17947
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000635 RID: 1589
		// (add) Token: 0x0600461C RID: 17948
		// (remove) Token: 0x0600461D RID: 17949
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000636 RID: 1590
		// (add) Token: 0x0600461E RID: 17950
		// (remove) Token: 0x0600461F RID: 17951
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
