using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001CD RID: 461
	[TypeLibType(4160)]
	[Guid("B2A5B5CE-3461-444A-91D4-ADD26D070638")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClient7 : IMsRdpClient6
	{
		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x060035EE RID: 13806
		// (set) Token: 0x060035ED RID: 13805
		[DispId(1)]
		string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x060035F0 RID: 13808
		// (set) Token: 0x060035EF RID: 13807
		[DispId(2)]
		string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x060035F2 RID: 13810
		// (set) Token: 0x060035F1 RID: 13809
		[DispId(3)]
		string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x060035F4 RID: 13812
		// (set) Token: 0x060035F3 RID: 13811
		[DispId(4)]
		string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x060035F6 RID: 13814
		// (set) Token: 0x060035F5 RID: 13813
		[DispId(5)]
		string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x060035F7 RID: 13815
		[DispId(6)]
		short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x060035F9 RID: 13817
		// (set) Token: 0x060035F8 RID: 13816
		[DispId(12)]
		int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x060035FB RID: 13819
		// (set) Token: 0x060035FA RID: 13818
		[DispId(13)]
		int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x060035FD RID: 13821
		// (set) Token: 0x060035FC RID: 13820
		[DispId(16)]
		int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x060035FE RID: 13822
		[DispId(17)]
		int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x060035FF RID: 13823
		[DispId(18)]
		int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170010FD RID: 4349
		// (set) Token: 0x06003600 RID: 13824
		[DispId(19)]
		string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06003601 RID: 13825
		[DispId(20)]
		int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06003602 RID: 13826
		[DispId(21)]
		string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06003603 RID: 13827
		[DispId(22)]
		int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06003604 RID: 13828
		[DispId(97)]
		IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06003605 RID: 13829
		[DispId(98)]
		IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06003606 RID: 13830
		[DispId(99)]
		IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06003607 RID: 13831
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Connect();

		// Token: 0x06003608 RID: 13832
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnect();

		// Token: 0x06003609 RID: 13833
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600360A RID: 13834
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x0600360C RID: 13836
		// (set) Token: 0x0600360B RID: 13835
		[DispId(100)]
		int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x0600360D RID: 13837
		[DispId(101)]
		IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x0600360E RID: 13838
		[DispId(102)]
		IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x0600360F RID: 13839
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		[DispId(103)]
		ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06003611 RID: 13841
		// (set) Token: 0x06003610 RID: 13840
		[DispId(104)]
		bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06003612 RID: 13842
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06003613 RID: 13843
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06003614 RID: 13844
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		ControlCloseStatus RequestClose();

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06003615 RID: 13845
		[DispId(200)]
		IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06003617 RID: 13847
		// (set) Token: 0x06003616 RID: 13846
		[DispId(201)]
		string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06003618 RID: 13848
		[DispId(300)]
		IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06003619 RID: 13849
		[DispId(400)]
		IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x0600361A RID: 13850
		[DispId(500)]
		IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x0600361B RID: 13851
		[DispId(502)]
		IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600361C RID: 13852
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x0600361D RID: 13853
		[DispId(504)]
		ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x0600361E RID: 13854
		[DispId(505)]
		IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x0600361F RID: 13855
		[DispId(507)]
		IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06003620 RID: 13856
		[DispId(506)]
		IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06003621 RID: 13857
		[DispId(600)]
		IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06003622 RID: 13858
		[DispId(601)]
		IMsRdpClientTransportSettings3 TransportSettings3 { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06003623 RID: 13859
		[DispId(602)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetStatusText([In] uint statusCode);

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06003624 RID: 13860
		[DispId(603)]
		IMsRdpClientSecuredSettings2 SecuredSettings3 { [DispId(603)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06003625 RID: 13861
		[DispId(604)]
		ITSRemoteProgram2 RemoteProgram2 { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
