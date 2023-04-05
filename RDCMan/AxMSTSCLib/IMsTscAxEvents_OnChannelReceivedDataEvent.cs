using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnChannelReceivedDataEvent
	{
		public IMsTscAxEvents_OnChannelReceivedDataEvent(string chanName, string data)
		{
			this.chanName = chanName;
			this.data = data;
		}

		public string chanName;

		public string data;
	}
}
