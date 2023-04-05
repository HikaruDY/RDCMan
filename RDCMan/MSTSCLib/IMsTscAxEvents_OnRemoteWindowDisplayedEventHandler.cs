using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200017A RID: 378
	// (Invoke) Token: 0x06001C6C RID: 7276
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler([In] bool vbDisplayed, [ComAliasName("MSTSCLib.wireHWND")] [In] ref _RemotableHandle hwnd, [ComAliasName("MSTSCLib.RemoteWindowDisplayedAttribute")] [In] RemoteWindowDisplayedAttribute windowAttribute);
}
