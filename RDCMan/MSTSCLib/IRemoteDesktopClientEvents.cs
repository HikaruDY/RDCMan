using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(4096)]
	[InterfaceType(2)]
	[Guid("079863B7-6D47-4105-8BFE-0CDCB360E67D")]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClientEvents
	{
		[DispId(750)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnecting();

		[DispId(751)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnected();

		[DispId(752)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnLoginCompleted();

		[DispId(753)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDisconnected([In] int disconnectReason, [In] int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] [In] string disconnectErrorMessage);

		[DispId(754)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnStatusChanged([In] int statusCode, [MarshalAs(UnmanagedType.BStr)] [In] string statusMessage);

		[DispId(755)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnecting([In] int disconnectReason, [In] int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] [In] string disconnectErrorMessage, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);

		[DispId(756)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnected();

		[DispId(757)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDialogDisplaying();

		[DispId(758)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDialogDismissed();

		[DispId(759)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnNetworkStatusChanged([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);

		[DispId(760)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAdminMessageReceived([MarshalAs(UnmanagedType.BStr)] [In] string adminMessage);

		[DispId(761)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnKeyCombinationPressed([In] int keyCombination);

		[DispId(762)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteDesktopSizeChanged([In] int width, [In] int height);

		[DispId(800)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnTouchPointerCursorMoved([In] int x, [In] int y);
	}
}
