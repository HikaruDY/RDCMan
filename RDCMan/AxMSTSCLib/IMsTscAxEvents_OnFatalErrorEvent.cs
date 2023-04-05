using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnFatalErrorEvent
	{
		public IMsTscAxEvents_OnFatalErrorEvent(int errorCode)
		{
			this.errorCode = errorCode;
		}

		public int errorCode;
	}
}
