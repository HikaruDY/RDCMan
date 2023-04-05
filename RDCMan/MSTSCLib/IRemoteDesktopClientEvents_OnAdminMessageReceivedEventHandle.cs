using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string adminMessage);
}
