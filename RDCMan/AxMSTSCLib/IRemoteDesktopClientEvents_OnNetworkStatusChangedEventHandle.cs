using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler(object sender, IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent e);
}
