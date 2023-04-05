using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnServiceMessageReceivedEvent
	{
		public IMsTscAxEvents_OnServiceMessageReceivedEvent(string serviceMessage)
		{
			this.serviceMessage = serviceMessage;
		}

		public string serviceMessage;
	}
}
