using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IRemoteDesktopClientEvents_OnStatusChangedEventHandler([In] int statusCode, [MarshalAs(UnmanagedType.BStr)] [In] string statusMessage);
}
