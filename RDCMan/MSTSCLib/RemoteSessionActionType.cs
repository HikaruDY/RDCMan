using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(true)]
	public enum RemoteSessionActionType
	{
		RemoteSessionActionCharms,
		RemoteSessionActionAppbar,
		RemoteSessionActionSnap,
		RemoteSessionActionStartScreen,
		RemoteSessionActionAppSwitch,
		RemoteSessionActionActionCenter
	}
}
