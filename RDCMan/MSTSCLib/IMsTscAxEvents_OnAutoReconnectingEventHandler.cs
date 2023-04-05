using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000175 RID: 373
	// (Invoke) Token: 0x06001C62 RID: 7266
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnAutoReconnectingEventHandler([In] int disconnectReason, [In] int attemptCount, [ComAliasName("MSTSCLib.AutoReconnectContinueState")] out AutoReconnectContinueState pArcContinueStatus);
}
