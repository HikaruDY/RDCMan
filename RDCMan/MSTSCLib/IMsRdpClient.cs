using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000186 RID: 390
	[Guid("92B4A539-7115-4B7C-A5A9-E5D9EFC2780A")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClient : IMsTscAx
	{
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001C82 RID: 7298
		// (set) Token: 0x06001C81 RID: 7297
		[DispId(1)]
		string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001C84 RID: 7300
		// (set) Token: 0x06001C83 RID: 7299
		[DispId(2)]
		string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001C86 RID: 7302
		// (set) Token: 0x06001C85 RID: 7301
		[DispId(3)]
		string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001C88 RID: 7304
		// (set) Token: 0x06001C87 RID: 7303
		[DispId(4)]
		string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001C8A RID: 7306
		// (set) Token: 0x06001C89 RID: 7305
		[DispId(5)]
		string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001C8B RID: 7307
		[DispId(6)]
		short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001C8D RID: 7309
		// (set) Token: 0x06001C8C RID: 7308
		[DispId(12)]
		int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001C8F RID: 7311
		// (set) Token: 0x06001C8E RID: 7310
		[DispId(13)]
		int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001C91 RID: 7313
		// (set) Token: 0x06001C90 RID: 7312
		[DispId(16)]
		int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001C92 RID: 7314
		[DispId(17)]
		int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001C93 RID: 7315
		[DispId(18)]
		int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000529 RID: 1321
		// (set) Token: 0x06001C94 RID: 7316
		[DispId(19)]
		string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001C95 RID: 7317
		[DispId(20)]
		int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001C96 RID: 7318
		[DispId(21)]
		string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001C97 RID: 7319
		[DispId(22)]
		int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001C98 RID: 7320
		[DispId(97)]
		IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001C99 RID: 7321
		[DispId(98)]
		IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001C9A RID: 7322
		[DispId(99)]
		IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001C9B RID: 7323
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Connect();

		// Token: 0x06001C9C RID: 7324
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnect();

		// Token: 0x06001C9D RID: 7325
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001C9E RID: 7326
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001CA0 RID: 7328
		// (set) Token: 0x06001C9F RID: 7327
		[DispId(100)]
		int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001CA1 RID: 7329
		[DispId(101)]
		IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001CA2 RID: 7330
		[DispId(102)]
		IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001CA3 RID: 7331
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001CA5 RID: 7333
		// (set) Token: 0x06001CA4 RID: 7332
		[DispId(104)]
		bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06001CA6 RID: 7334
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06001CA7 RID: 7335
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06001CA8 RID: 7336
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		ControlCloseStatus RequestClose();
	}
}
