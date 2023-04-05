using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent
	{
		public IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent(string adminMessage)
		{
			this.adminMessage = adminMessage;
		}

		public string adminMessage;
	}
}
