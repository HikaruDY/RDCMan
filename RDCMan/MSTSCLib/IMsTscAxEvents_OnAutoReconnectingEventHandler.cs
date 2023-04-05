using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnAutoReconnectingEventHandler([In] int disconnectReason, [In] int attemptCount, [ComAliasName("MSTSCLib.AutoReconnectContinueState")] out AutoReconnectContinueState pArcContinueStatus);
}
