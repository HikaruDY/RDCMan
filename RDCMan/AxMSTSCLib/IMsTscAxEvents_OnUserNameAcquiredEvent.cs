using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnUserNameAcquiredEvent
	{
		public IMsTscAxEvents_OnUserNameAcquiredEvent(string bstrUserName)
		{
			this.bstrUserName = bstrUserName;
		}

		public string bstrUserName;
	}
}
