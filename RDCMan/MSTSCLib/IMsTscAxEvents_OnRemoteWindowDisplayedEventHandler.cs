using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler([In] bool vbDisplayed, [ComAliasName("MSTSCLib.wireHWND")] [In] ref _RemotableHandle hwnd, [ComAliasName("MSTSCLib.RemoteWindowDisplayedAttribute")] [In] RemoteWindowDisplayedAttribute windowAttribute);
}
