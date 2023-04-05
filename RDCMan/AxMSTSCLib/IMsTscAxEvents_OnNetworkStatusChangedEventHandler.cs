using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IMsTscAxEvents_OnNetworkStatusChangedEventHandler(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e);
}
