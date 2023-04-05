using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IMsTscAxEvents_OnFatalErrorEventHandler(object sender, IMsTscAxEvents_OnFatalErrorEvent e);
}
