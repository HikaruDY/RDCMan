using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler([In] int disconnectReason, [In] int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] [In] string disconnectErrorMessage, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
}
