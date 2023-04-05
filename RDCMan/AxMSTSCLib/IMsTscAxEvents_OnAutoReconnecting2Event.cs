using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnAutoReconnecting2Event
	{
		public IMsTscAxEvents_OnAutoReconnecting2Event(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			this.disconnectReason = disconnectReason;
			this.networkAvailable = networkAvailable;
			this.attemptCount = attemptCount;
			this.maxAttemptCount = maxAttemptCount;
		}

		public int disconnectReason;

		public bool networkAvailable;

		public int attemptCount;

		public int maxAttemptCount;
	}
}
