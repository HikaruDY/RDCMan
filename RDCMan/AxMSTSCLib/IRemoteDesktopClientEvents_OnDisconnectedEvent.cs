using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnDisconnectedEvent
	{
		public IRemoteDesktopClientEvents_OnDisconnectedEvent(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage)
		{
			this.disconnectReason = disconnectReason;
			this.extendedDisconnectReason = extendedDisconnectReason;
			this.disconnectErrorMessage = disconnectErrorMessage;
		}

		public int disconnectReason;

		public int extendedDisconnectReason;

		public string disconnectErrorMessage;
	}
}
