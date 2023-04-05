using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("EAB16C5D-EED1-4E95-868B-0FBA1B42C092")]
	[TypeLibType(2)]
	[ComSourceInterfaces("MSTSCLib.IRemoteDesktopClientEvents\0")]
	[ClassInterface(0)]
	[ComVisible(true)]
	[ComImport]
	public class RemoteDesktopClientClass : IRemoteDesktopClient, RemoteDesktopClient, IRemoteDesktopClientEvents_Event
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern RemoteDesktopClientClass();

		[DispId(701)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		[DispId(703)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Reconnect([In] uint width, [In] uint height);

		[DispId(710)]
		public virtual extern IRemoteDesktopClientSettings Settings { [DispId(710)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(711)]
		public virtual extern IRemoteDesktopClientActions Actions { [DispId(711)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(712)]
		public virtual extern IRemoteDesktopClientTouchPointer TouchPointer { [DispId(712)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(704)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void DeleteSavedCredentials([MarshalAs(UnmanagedType.BStr)] [In] string serverName);

		[DispId(705)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void UpdateSessionDisplaySettings([In] uint width, [In] uint height);

		[DispId(706)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		[DispId(707)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		public virtual extern event IRemoteDesktopClientEvents_OnConnectingEventHandler OnConnecting;

		public virtual extern event IRemoteDesktopClientEvents_OnConnectedEventHandler OnConnected;

		public virtual extern event IRemoteDesktopClientEvents_OnLoginCompletedEventHandler OnLoginCompleted;

		public virtual extern event IRemoteDesktopClientEvents_OnDisconnectedEventHandler OnDisconnected;

		public virtual extern event IRemoteDesktopClientEvents_OnStatusChangedEventHandler OnStatusChanged;

		public virtual extern event IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		public virtual extern event IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		public virtual extern event IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler OnDialogDisplaying;

		public virtual extern event IRemoteDesktopClientEvents_OnDialogDismissedEventHandler OnDialogDismissed;

		public virtual extern event IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		public virtual extern event IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler OnAdminMessageReceived;

		public virtual extern event IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler OnKeyCombinationPressed;

		public virtual extern event IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler OnRemoteDesktopSizeChanged;

		public virtual extern event IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler OnTouchPointerCursorMoved;
	}
}
