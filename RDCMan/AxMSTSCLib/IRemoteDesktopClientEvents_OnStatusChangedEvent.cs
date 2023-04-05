using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnStatusChangedEvent
	{
		public IRemoteDesktopClientEvents_OnStatusChangedEvent(int statusCode, string statusMessage)
		{
			this.statusCode = statusCode;
			this.statusMessage = statusMessage;
		}

		public int statusCode;

		public string statusMessage;
	}
}
