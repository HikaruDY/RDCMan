using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001F1 RID: 497
	[Guid("05293249-B28B-4BD8-BE64-1B2F496B910E")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable6 : IMsRdpClientNonScriptable5
	{
		// Token: 0x17001EF0 RID: 7920
		// (set) Token: 0x06005053 RID: 20563
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x06005055 RID: 20565
		// (set) Token: 0x06005054 RID: 20564
		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x06005057 RID: 20567
		// (set) Token: 0x06005056 RID: 20566
		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06005059 RID: 20569
		// (set) Token: 0x06005058 RID: 20568
		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600505B RID: 20571
		// (set) Token: 0x0600505A RID: 20570
		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600505C RID: 20572
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();

		// Token: 0x0600505D RID: 20573
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600505E RID: 20574
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06005060 RID: 20576
		// (set) Token: 0x0600505F RID: 20575
		[DispId(13)]
		[ComAliasName("MSTSCLib.wireHWND")]
		IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06005062 RID: 20578
		// (set) Token: 0x06005061 RID: 20577
		[DispId(14)]
		bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06005064 RID: 20580
		// (set) Token: 0x06005063 RID: 20579
		[DispId(15)]
		bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x06005066 RID: 20582
		// (set) Token: 0x06005065 RID: 20581
		[DispId(16)]
		bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06005068 RID: 20584
		// (set) Token: 0x06005067 RID: 20583
		[DispId(17)]
		bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x0600506A RID: 20586
		// (set) Token: 0x06005069 RID: 20585
		[DispId(21)]
		bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x0600506C RID: 20588
		// (set) Token: 0x0600506B RID: 20587
		[DispId(20)]
		bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x0600506D RID: 20589
		[DispId(18)]
		IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x0600506E RID: 20590
		[DispId(19)]
		IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x06005070 RID: 20592
		// (set) Token: 0x0600506F RID: 20591
		[DispId(23)]
		bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06005072 RID: 20594
		// (set) Token: 0x06005071 RID: 20593
		[DispId(22)]
		bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06005074 RID: 20596
		// (set) Token: 0x06005073 RID: 20595
		[DispId(24)]
		string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06005076 RID: 20598
		// (set) Token: 0x06005075 RID: 20597
		[DispId(25)]
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06005078 RID: 20600
		// (set) Token: 0x06005077 RID: 20599
		[DispId(28)]
		bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x0600507A RID: 20602
		// (set) Token: 0x06005079 RID: 20601
		[DispId(26)]
		object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x0600507C RID: 20604
		// (set) Token: 0x0600507B RID: 20603
		[DispId(27)]
		bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x0600507E RID: 20606
		// (set) Token: 0x0600507D RID: 20605
		[DispId(29)]
		bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06005080 RID: 20608
		// (set) Token: 0x0600507F RID: 20607
		[DispId(30)]
		bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06005082 RID: 20610
		// (set) Token: 0x06005081 RID: 20609
		[DispId(31)]
		bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x06005084 RID: 20612
		// (set) Token: 0x06005083 RID: 20611
		[DispId(32)]
		bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06005086 RID: 20614
		// (set) Token: 0x06005085 RID: 20613
		[DispId(33)]
		bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06005087 RID: 20615
		[DispId(35)]
		uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06005088 RID: 20616
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06005089 RID: 20617
		[DispId(37)]
		bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F0C RID: 7948
		// (set) Token: 0x0600508A RID: 20618
		[DispId(38)]
		bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x0600508C RID: 20620
		// (set) Token: 0x0600508B RID: 20619
		[DispId(39)]
		bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x0600508E RID: 20622
		// (set) Token: 0x0600508D RID: 20621
		[DispId(40)]
		bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06005090 RID: 20624
		// (set) Token: 0x0600508F RID: 20623
		[DispId(41)]
		bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005091 RID: 20625
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendLocation2D([In] double latitude, [In] double longitude);

		// Token: 0x06005092 RID: 20626
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendLocation3D([In] double latitude, [In] double longitude, [In] int altitude);
	}
}
