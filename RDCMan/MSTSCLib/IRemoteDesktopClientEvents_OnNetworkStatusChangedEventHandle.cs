using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);
}
