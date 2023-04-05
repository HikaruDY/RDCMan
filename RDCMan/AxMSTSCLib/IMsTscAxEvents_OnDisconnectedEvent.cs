using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnDisconnectedEvent
	{
		public IMsTscAxEvents_OnDisconnectedEvent(int discReason)
		{
			this.discReason = discReason;
		}

		public int discReason;
	}
}
