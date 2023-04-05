using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IRemoteDesktopClientEvents_OnStatusChangedEventHandler(object sender, IRemoteDesktopClientEvents_OnStatusChangedEvent e);
}
