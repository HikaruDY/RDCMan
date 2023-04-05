using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IMsTscAxEvents_OnServiceMessageReceivedEventHandler(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e);
}
