using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnLogonErrorEvent
	{
		public IMsTscAxEvents_OnLogonErrorEvent(int lError)
		{
			this.lError = lError;
		}

		public int lError;
	}
}
