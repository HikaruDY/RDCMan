using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x0200014E RID: 334
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnAutoReconnectingEvent
	{
		// Token: 0x06001B1B RID: 6939 RVA: 0x00057CC8 File Offset: 0x00055EC8
		public IRemoteDesktopClientEvents_OnAutoReconnectingEvent(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			this.disconnectReason = disconnectReason;
			this.extendedDisconnectReason = extendedDisconnectReason;
			this.disconnectErrorMessage = disconnectErrorMessage;
			this.networkAvailable = networkAvailable;
			this.attemptCount = attemptCount;
			this.maxAttemptCount = maxAttemptCount;
		}

		// Token: 0x04000725 RID: 1829
		public int disconnectReason;

		// Token: 0x04000726 RID: 1830
		public int extendedDisconnectReason;

		// Token: 0x04000727 RID: 1831
		public string disconnectErrorMessage;

		// Token: 0x04000728 RID: 1832
		public bool networkAvailable;

		// Token: 0x04000729 RID: 1833
		public int attemptCount;

		// Token: 0x0400072A RID: 1834
		public int maxAttemptCount;
	}
}
