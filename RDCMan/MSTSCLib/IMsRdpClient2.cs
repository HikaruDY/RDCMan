using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200019C RID: 412
	[Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClient2 : IMsRdpClient
	{
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002040 RID: 8256
		// (set) Token: 0x0600203F RID: 8255
		[DispId(1)]
		string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002042 RID: 8258
		// (set) Token: 0x06002041 RID: 8257
		[DispId(2)]
		string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002044 RID: 8260
		// (set) Token: 0x06002043 RID: 8259
		[DispId(3)]
		string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002046 RID: 8262
		// (set) Token: 0x06002045 RID: 8261
		[DispId(4)]
		string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002048 RID: 8264
		// (set) Token: 0x06002047 RID: 8263
		[DispId(5)]
		string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002049 RID: 8265
		[DispId(6)]
		short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600204B RID: 8267
		// (set) Token: 0x0600204A RID: 8266
		[DispId(12)]
		int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600204D RID: 8269
		// (set) Token: 0x0600204C RID: 8268
		[DispId(13)]
		int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600204F RID: 8271
		// (set) Token: 0x0600204E RID: 8270
		[DispId(16)]
		int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002050 RID: 8272
		[DispId(17)]
		int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06002051 RID: 8273
		[DispId(18)]
		int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006A9 RID: 1705
		// (set) Token: 0x06002052 RID: 8274
		[DispId(19)]
		string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002053 RID: 8275
		[DispId(20)]
		int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002054 RID: 8276
		[DispId(21)]
		string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002055 RID: 8277
		[DispId(22)]
		int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002056 RID: 8278
		[DispId(97)]
		IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002057 RID: 8279
		[DispId(98)]
		IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002058 RID: 8280
		[DispId(99)]
		IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002059 RID: 8281
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Connect();

		// Token: 0x0600205A RID: 8282
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnect();

		// Token: 0x0600205B RID: 8283
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600205C RID: 8284
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600205E RID: 8286
		// (set) Token: 0x0600205D RID: 8285
		[DispId(100)]
		int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600205F RID: 8287
		[DispId(101)]
		IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002060 RID: 8288
		[DispId(102)]
		IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002061 RID: 8289
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002063 RID: 8291
		// (set) Token: 0x06002062 RID: 8290
		[DispId(104)]
		bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002064 RID: 8292
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002065 RID: 8293
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002066 RID: 8294
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		ControlCloseStatus RequestClose();

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002067 RID: 8295
		[DispId(200)]
		IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002069 RID: 8297
		// (set) Token: 0x06002068 RID: 8296
		[DispId(201)]
		string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
