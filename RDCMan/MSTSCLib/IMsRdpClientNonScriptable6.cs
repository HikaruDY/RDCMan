using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("05293249-B28B-4BD8-BE64-1B2F496B910E")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable6 : IMsRdpClientNonScriptable5
	{
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		[DispId(13)]
		[ComAliasName("MSTSCLib.wireHWND")]
		IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		[DispId(14)]
		bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(15)]
		bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(16)]
		bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(17)]
		bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(21)]
		bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(20)]
		bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(18)]
		IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(19)]
		IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(23)]
		bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(22)]
		bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(24)]
		string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(25)]
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		[DispId(28)]
		bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(26)]
		object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		[DispId(27)]
		bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(29)]
		bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(30)]
		bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(31)]
		bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(32)]
		bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(33)]
		bool UseMultimon { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(35)]
		uint RemoteMonitorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

		[DispId(37)]
		bool RemoteMonitorLayoutMatchesLocal { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(38)]
		bool DisableConnectionBar { [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(39)]
		bool DisableRemoteAppCapsCheck { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(40)]
		bool WarnAboutDirectXRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(41)]
		bool AllowPromptingForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendLocation2D([In] double latitude, [In] double longitude);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendLocation3D([In] double latitude, [In] double longitude, [In] int altitude);
	}
}
