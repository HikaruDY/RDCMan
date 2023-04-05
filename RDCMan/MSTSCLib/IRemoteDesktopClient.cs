using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(4160)]
	[Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClient
	{
		[DispId(701)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Connect();

		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnect();

		[DispId(703)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reconnect([In] uint width, [In] uint height);

		[DispId(710)]
		IRemoteDesktopClientSettings Settings { [DispId(710)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(711)]
		IRemoteDesktopClientActions Actions { [DispId(711)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(712)]
		IRemoteDesktopClientTouchPointer TouchPointer { [DispId(712)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(704)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void DeleteSavedCredentials([MarshalAs(UnmanagedType.BStr)] [In] string serverName);

		[DispId(705)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void UpdateSessionDisplaySettings([In] uint width, [In] uint height);

		[DispId(706)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		[DispId(707)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);
	}
}
