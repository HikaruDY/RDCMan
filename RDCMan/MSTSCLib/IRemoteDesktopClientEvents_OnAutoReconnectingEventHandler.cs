using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000202 RID: 514
	// (Invoke) Token: 0x060054ED RID: 21741
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler([In] int disconnectReason, [In] int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] [In] string disconnectErrorMessage, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
}
