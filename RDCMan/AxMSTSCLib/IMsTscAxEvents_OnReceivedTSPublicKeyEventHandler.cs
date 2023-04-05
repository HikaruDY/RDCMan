using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public delegate void IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e);
}
