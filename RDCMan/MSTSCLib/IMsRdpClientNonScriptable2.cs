using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001AE RID: 430
	[InterfaceType(1)]
	[Guid("17A5E535-4072-4FA4-AF32-C8D0D47345E9")]
	[ComConversionLoss]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable2 : IMsRdpClientNonScriptable
	{
		// Token: 0x17000A1A RID: 2586
		// (set) Token: 0x06002800 RID: 10240
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002802 RID: 10242
		// (set) Token: 0x06002801 RID: 10241
		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002804 RID: 10244
		// (set) Token: 0x06002803 RID: 10243
		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002806 RID: 10246
		// (set) Token: 0x06002805 RID: 10245
		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002808 RID: 10248
		// (set) Token: 0x06002807 RID: 10247
		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002809 RID: 10249
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();

		// Token: 0x0600280A RID: 10250
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600280B RID: 10251
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600280D RID: 10253
		// (set) Token: 0x0600280C RID: 10252
		[DispId(13)]
		[ComAliasName("MSTSCLib.wireHWND")]
		IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }
	}
}
