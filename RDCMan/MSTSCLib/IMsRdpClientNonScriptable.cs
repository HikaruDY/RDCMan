using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000193 RID: 403
	[Guid("2F079C4C-87B2-4AFD-97AB-20CDB43038AE")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable : IMsTscNonScriptable
	{
		// Token: 0x170005B4 RID: 1460
		// (set) Token: 0x06001D94 RID: 7572
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001D96 RID: 7574
		// (set) Token: 0x06001D95 RID: 7573
		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001D98 RID: 7576
		// (set) Token: 0x06001D97 RID: 7575
		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001D9A RID: 7578
		// (set) Token: 0x06001D99 RID: 7577
		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001D9C RID: 7580
		// (set) Token: 0x06001D9B RID: 7579
		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001D9D RID: 7581
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();

		// Token: 0x06001D9E RID: 7582
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06001D9F RID: 7583
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
	}
}
