using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001C6 RID: 454
	[Guid("F50FA8AA-1C7D-4F59-B15C-A90CACAE1FCB")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable4 : IMsRdpClientNonScriptable3
	{
		// Token: 0x17000EB0 RID: 3760
		// (set) Token: 0x0600316E RID: 12654
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06003170 RID: 12656
		// (set) Token: 0x0600316F RID: 12655
		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06003172 RID: 12658
		// (set) Token: 0x06003171 RID: 12657
		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06003174 RID: 12660
		// (set) Token: 0x06003173 RID: 12659
		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06003176 RID: 12662
		// (set) Token: 0x06003175 RID: 12661
		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06003177 RID: 12663
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();

		// Token: 0x06003178 RID: 12664
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06003179 RID: 12665
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x0600317B RID: 12667
		// (set) Token: 0x0600317A RID: 12666
		[ComAliasName("MSTSCLib.wireHWND")]
		[DispId(13)]
		IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x0600317D RID: 12669
		// (set) Token: 0x0600317C RID: 12668
		[DispId(14)]
		bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x0600317F RID: 12671
		// (set) Token: 0x0600317E RID: 12670
		[DispId(15)]
		bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06003181 RID: 12673
		// (set) Token: 0x06003180 RID: 12672
		[DispId(16)]
		bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06003183 RID: 12675
		// (set) Token: 0x06003182 RID: 12674
		[DispId(17)]
		bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06003185 RID: 12677
		// (set) Token: 0x06003184 RID: 12676
		[DispId(21)]
		bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06003187 RID: 12679
		// (set) Token: 0x06003186 RID: 12678
		[DispId(20)]
		bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06003188 RID: 12680
		[DispId(18)]
		IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06003189 RID: 12681
		[DispId(19)]
		IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x0600318B RID: 12683
		// (set) Token: 0x0600318A RID: 12682
		[DispId(23)]
		bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x0600318D RID: 12685
		// (set) Token: 0x0600318C RID: 12684
		[DispId(22)]
		bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x0600318F RID: 12687
		// (set) Token: 0x0600318E RID: 12686
		[DispId(24)]
		string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06003191 RID: 12689
		// (set) Token: 0x06003190 RID: 12688
		[DispId(25)]
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06003193 RID: 12691
		// (set) Token: 0x06003192 RID: 12690
		[DispId(28)]
		bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003195 RID: 12693
		// (set) Token: 0x06003194 RID: 12692
		[DispId(26)]
		object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06003197 RID: 12695
		// (set) Token: 0x06003196 RID: 12694
		[DispId(27)]
		bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06003199 RID: 12697
		// (set) Token: 0x06003198 RID: 12696
		[DispId(29)]
		bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x0600319B RID: 12699
		// (set) Token: 0x0600319A RID: 12698
		[DispId(30)]
		bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x0600319D RID: 12701
		// (set) Token: 0x0600319C RID: 12700
		[DispId(31)]
		bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x0600319F RID: 12703
		// (set) Token: 0x0600319E RID: 12702
		[DispId(32)]
		bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
