using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IMsTscAxEvents_OnNetworkStatusChangedEventHandler([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);
}
