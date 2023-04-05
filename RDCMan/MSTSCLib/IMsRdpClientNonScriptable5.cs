using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001D2 RID: 466
	[Guid("4F6996D5-D7B1-412C-B0FF-063718566907")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable5 : IMsRdpClientNonScriptable4
	{
		// Token: 0x17001198 RID: 4504
		// (set) Token: 0x0600371A RID: 14106
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600371C RID: 14108
		// (set) Token: 0x0600371B RID: 14107
		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x0600371E RID: 14110
		// (set) Token: 0x0600371D RID: 14109
		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06003720 RID: 14112
		// (set) Token: 0x0600371F RID: 14111
		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06003722 RID: 14114
		// (set) Token: 0x06003721 RID: 14113
		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06003723 RID: 14115
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();

		// Token: 0x06003724 RID: 14116
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06003725 RID: 14117
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06003727 RID: 14119
		// (set) Token: 0x06003726 RID: 14118
		[DispId(13)]
		[ComAliasName("MSTSCLib.wireHWND")]
		IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06003729 RID: 14121
		// (set) Token: 0x06003728 RID: 14120
		[DispId(14)]
		bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x0600372B RID: 14123
		// (set) Token: 0x0600372A RID: 14122
		[DispId(15)]
		bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x0600372D RID: 14125
		// (set) Token: 0x0600372C RID: 14124
		[DispId(16)]
		bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600372F RID: 14127
		// (set) Token: 0x0600372E RID: 14126
		[DispId(17)]
		bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06003731 RID: 14129
		// (set) Token: 0x06003730 RID: 14128
		[DispId(21)]
		bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06003733 RID: 14131
		// (set) Token: 0x06003732 RID: 14130
		[DispId(20)]
		bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06003734 RID: 14132
		[DispId(18)]
		IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06003735 RID: 14133
		[DispId(19)]
		IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06003737 RID: 14135
		// (set) Token: 0x06003736 RID: 14134
		[DispId(23)]
		bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06003739 RID: 14137
		// (set) Token: 0x06003738 RID: 14136
		[DispId(22)]
		bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600373B RID: 14139
		// (set) Token: 0x0600373A RID: 14138
		[DispId(24)]
		string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600373D RID: 14141
		// (set) Token: 0x0600373C RID: 14140
		[DispId(25)]
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x0600373F RID: 14143
		// (set) Token: 0x0600373E RID: 14142
		[DispId(28)]
		bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06003741 RID: 14145
		// (set) Token: 0x06003740 RID: 14144
		[DispId(26)]
		object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06003743 RID: 14147
		// (set) Token: 0x06003742 RID: 14146
		[DispId(27)]
		bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06003745 RID: 14149
		// (set) Token: 0x06003744 RID: 14148
		[DispId(29)]
		bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06003747 RID: 14151
		// (set) Token: 0x06003746 RID: 14150
		[DispId(30)]
		bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06003749 RID: 14153
		// (set) Token: 0x06003748 RID: 14152
		[DispId(31)]
		bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x0600374B RID: 14155
		// (set) Token: 0x0600374A RID: 14154
		[DispId(32)]
		bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600374D RID: 14157
		// (set) Token: 0x0600374C RID: 14156
		[DispId(33)]
		bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x0600374E RID: 14158
		[DispId(35)]
		uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600374F RID: 14159
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06003750 RID: 14160
		[DispId(37)]
		bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170011B4 RID: 4532
		// (set) Token: 0x06003751 RID: 14161
		[DispId(38)]
		bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06003753 RID: 14163
		// (set) Token: 0x06003752 RID: 14162
		[DispId(39)]
		bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06003755 RID: 14165
		// (set) Token: 0x06003754 RID: 14164
		[DispId(40)]
		bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06003757 RID: 14167
		// (set) Token: 0x06003756 RID: 14166
		[DispId(41)]
		bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
