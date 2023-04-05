using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000184 RID: 388
	// (Invoke) Token: 0x06001C80 RID: 7296
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnAutoReconnecting2EventHandler([In] int disconnectReason, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
}
