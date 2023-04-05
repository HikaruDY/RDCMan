using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[InterfaceType(1)]
	[Guid("17A5E535-4072-4FA4-AF32-C8D0D47345E9")]
	[ComConversionLoss]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientNonScriptable2 : IMsRdpClientNonScriptable
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
	}
}
