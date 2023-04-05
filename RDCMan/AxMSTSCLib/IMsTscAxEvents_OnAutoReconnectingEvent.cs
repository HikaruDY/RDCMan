using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnAutoReconnectingEvent
	{
		public IMsTscAxEvents_OnAutoReconnectingEvent(int disconnectReason, int attemptCount)
		{
			this.disconnectReason = disconnectReason;
			this.attemptCount = attemptCount;
		}

		public int disconnectReason;

		public int attemptCount;

		public AutoReconnectContinueState pArcContinueStatus;
	}
}
