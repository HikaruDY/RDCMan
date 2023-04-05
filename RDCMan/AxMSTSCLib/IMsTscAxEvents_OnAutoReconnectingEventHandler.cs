using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IMsTscAxEvents_OnAutoReconnectingEventHandler(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e);
}
