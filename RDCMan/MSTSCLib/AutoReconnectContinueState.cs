using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(true)]
	public enum AutoReconnectContinueState
	{
		autoReconnectContinueAutomatic,
		autoReconnectContinueStop,
		autoReconnectContinueManual
	}
}
