using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IMsTscAxEvents_OnLogonErrorEventHandler(object sender, IMsTscAxEvents_OnLogonErrorEvent e);
}
