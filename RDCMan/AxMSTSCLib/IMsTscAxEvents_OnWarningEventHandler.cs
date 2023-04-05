using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IMsTscAxEvents_OnWarningEventHandler(object sender, IMsTscAxEvents_OnWarningEvent e);
}
