using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IMsTscAxEvents_OnChannelReceivedDataEventHandler(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e);
}
