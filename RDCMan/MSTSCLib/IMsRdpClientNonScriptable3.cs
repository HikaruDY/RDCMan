using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001BA RID: 442
	[Guid("B3378D90-0728-45C7-8ED7-B6159FB92219")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable3 : IMsRdpClientNonScriptable2
	{
		// Token: 0x17000C61 RID: 3169
		// (set) Token: 0x06002CD5 RID: 11477
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002CD7 RID: 11479
		// (set) Token: 0x06002CD6 RID: 11478
		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002CD9 RID: 11481
		// (set) Token: 0x06002CD8 RID: 11480
		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002CDB RID: 11483
		// (set) Token: 0x06002CDA RID: 11482
		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002CDD RID: 11485
		// (set) Token: 0x06002CDC RID: 11484
		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002CDE RID: 11486
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();

		// Token: 0x06002CDF RID: 11487
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002CE0 RID: 11488
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002CE2 RID: 11490
		// (set) Token: 0x06002CE1 RID: 11489
		[ComAliasName("MSTSCLib.wireHWND")]
		[DispId(13)]
		IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002CE4 RID: 11492
		// (set) Token: 0x06002CE3 RID: 11491
		[DispId(14)]
		bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002CE6 RID: 11494
		// (set) Token: 0x06002CE5 RID: 11493
		[DispId(15)]
		bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002CE8 RID: 11496
		// (set) Token: 0x06002CE7 RID: 11495
		[DispId(16)]
		bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06002CEA RID: 11498
		// (set) Token: 0x06002CE9 RID: 11497
		[DispId(17)]
		bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002CEC RID: 11500
		// (set) Token: 0x06002CEB RID: 11499
		[DispId(21)]
		bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002CEE RID: 11502
		// (set) Token: 0x06002CED RID: 11501
		[DispId(20)]
		bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002CEF RID: 11503
		[DispId(18)]
		IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002CF0 RID: 11504
		[DispId(19)]
		IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002CF2 RID: 11506
		// (set) Token: 0x06002CF1 RID: 11505
		[DispId(23)]
		bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002CF4 RID: 11508
		// (set) Token: 0x06002CF3 RID: 11507
		[DispId(22)]
		bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002CF6 RID: 11510
		// (set) Token: 0x06002CF5 RID: 11509
		[DispId(24)]
		string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
