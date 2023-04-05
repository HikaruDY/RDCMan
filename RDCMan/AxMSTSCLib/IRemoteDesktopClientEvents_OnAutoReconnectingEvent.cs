using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnAutoReconnectingEvent
	{
		public IRemoteDesktopClientEvents_OnAutoReconnectingEvent(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			this.disconnectReason = disconnectReason;
			this.extendedDisconnectReason = extendedDisconnectReason;
			this.disconnectErrorMessage = disconnectErrorMessage;
			this.networkAvailable = networkAvailable;
			this.attemptCount = attemptCount;
			this.maxAttemptCount = maxAttemptCount;
		}

		public int disconnectReason;

		public int extendedDisconnectReason;

		public string disconnectErrorMessage;

		public bool networkAvailable;

		public int attemptCount;

		public int maxAttemptCount;
	}
}
