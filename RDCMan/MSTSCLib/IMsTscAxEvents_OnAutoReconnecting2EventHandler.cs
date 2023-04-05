using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnAutoReconnecting2EventHandler([In] int disconnectReason, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
}
