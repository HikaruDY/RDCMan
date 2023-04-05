using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[InterfaceType(1)]
	[Guid("AE45252B-AAAB-4504-B681-649D6073A37A")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpCameraRedirConfigCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Rescan();

		[DispId(2)]
		uint Count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(3)]
		IMsRdpCameraRedirConfig ByIndex { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(4)]
		IMsRdpCameraRedirConfig BySymbolicLink { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(5)]
		IMsRdpCameraRedirConfig ByInstanceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddConfig([MarshalAs(UnmanagedType.BStr)] [In] string SymbolicLink, [In] bool fRedirected);

		[DispId(7)]
		bool RedirectByDefault { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(8)]
		bool EncodeVideo { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(9)]
		[ComAliasName("MSTSCLib.CameraRedirEncodingQuality")]
		CameraRedirEncodingQuality EncodingQuality { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.CameraRedirEncodingQuality")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.CameraRedirEncodingQuality")] [param: In] set; }
	}
}
