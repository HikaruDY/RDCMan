using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001F2 RID: 498
	[Guid("71B4A60A-FE21-46D8-A39B-8E32BA0C5ECC")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable7 : IMsRdpClientNonScriptable6
	{
		// Token: 0x17001F10 RID: 7952
		// (set) Token: 0x06005093 RID: 20627
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x06005095 RID: 20629
		// (set) Token: 0x06005094 RID: 20628
		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06005097 RID: 20631
		// (set) Token: 0x06005096 RID: 20630
		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06005099 RID: 20633
		// (set) Token: 0x06005098 RID: 20632
		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x0600509B RID: 20635
		// (set) Token: 0x0600509A RID: 20634
		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600509C RID: 20636
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();

		// Token: 0x0600509D RID: 20637
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600509E RID: 20638
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x060050A0 RID: 20640
		// (set) Token: 0x0600509F RID: 20639
		[DispId(13)]
		[ComAliasName("MSTSCLib.wireHWND")]
		IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x060050A2 RID: 20642
		// (set) Token: 0x060050A1 RID: 20641
		[DispId(14)]
		bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x060050A4 RID: 20644
		// (set) Token: 0x060050A3 RID: 20643
		[DispId(15)]
		bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x060050A6 RID: 20646
		// (set) Token: 0x060050A5 RID: 20645
		[DispId(16)]
		bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x060050A8 RID: 20648
		// (set) Token: 0x060050A7 RID: 20647
		[DispId(17)]
		bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x060050AA RID: 20650
		// (set) Token: 0x060050A9 RID: 20649
		[DispId(21)]
		bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x060050AC RID: 20652
		// (set) Token: 0x060050AB RID: 20651
		[DispId(20)]
		bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x060050AD RID: 20653
		[DispId(18)]
		IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x060050AE RID: 20654
		[DispId(19)]
		IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x060050B0 RID: 20656
		// (set) Token: 0x060050AF RID: 20655
		[DispId(23)]
		bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x060050B2 RID: 20658
		// (set) Token: 0x060050B1 RID: 20657
		[DispId(22)]
		bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x060050B4 RID: 20660
		// (set) Token: 0x060050B3 RID: 20659
		[DispId(24)]
		string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x060050B6 RID: 20662
		// (set) Token: 0x060050B5 RID: 20661
		[DispId(25)]
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x060050B8 RID: 20664
		// (set) Token: 0x060050B7 RID: 20663
		[DispId(28)]
		bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x060050BA RID: 20666
		// (set) Token: 0x060050B9 RID: 20665
		[DispId(26)]
		object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x060050BC RID: 20668
		// (set) Token: 0x060050BB RID: 20667
		[DispId(27)]
		bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x060050BE RID: 20670
		// (set) Token: 0x060050BD RID: 20669
		[DispId(29)]
		bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x060050C0 RID: 20672
		// (set) Token: 0x060050BF RID: 20671
		[DispId(30)]
		bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x060050C2 RID: 20674
		// (set) Token: 0x060050C1 RID: 20673
		[DispId(31)]
		bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x060050C4 RID: 20676
		// (set) Token: 0x060050C3 RID: 20675
		[DispId(32)]
		bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x060050C6 RID: 20678
		// (set) Token: 0x060050C5 RID: 20677
		[DispId(33)]
		bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x060050C7 RID: 20679
		[DispId(35)]
		uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060050C8 RID: 20680
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x060050C9 RID: 20681
		[DispId(37)]
		bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001F2C RID: 7980
		// (set) Token: 0x060050CA RID: 20682
		[DispId(38)]
		bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x060050CC RID: 20684
		// (set) Token: 0x060050CB RID: 20683
		[DispId(39)]
		bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x060050CE RID: 20686
		// (set) Token: 0x060050CD RID: 20685
		[DispId(40)]
		bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x060050D0 RID: 20688
		// (set) Token: 0x060050CF RID: 20687
		[DispId(41)]
		bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060050D1 RID: 20689
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendLocation2D([In] double latitude, [In] double longitude);

		// Token: 0x060050D2 RID: 20690
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendLocation3D([In] double latitude, [In] double longitude, [In] int altitude);

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x060050D3 RID: 20691
		[DispId(44)]
		IMsRdpCameraRedirConfigCollection CameraRedirConfigCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060050D4 RID: 20692
		[MethodImpl(MethodImplOptions.InternalCall)]
		void DisableDpiCursorScalingForProcess();

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x060050D5 RID: 20693
		[DispId(46)]
		IMsRdpClipboard Clipboard { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
