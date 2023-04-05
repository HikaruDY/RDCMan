using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000116 RID: 278
	[ComVisible(true)]
	public class IMsTscAxEvents_OnAutoReconnecting2Event
	{
		// Token: 0x06000947 RID: 2375 RVA: 0x000252D8 File Offset: 0x000234D8
		public IMsTscAxEvents_OnAutoReconnecting2Event(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			this.disconnectReason = disconnectReason;
			this.networkAvailable = networkAvailable;
			this.attemptCount = attemptCount;
			this.maxAttemptCount = maxAttemptCount;
		}

		// Token: 0x040003AA RID: 938
		public int disconnectReason;

		// Token: 0x040003AB RID: 939
		public bool networkAvailable;

		// Token: 0x040003AC RID: 940
		public int attemptCount;

		// Token: 0x040003AD RID: 941
		public int maxAttemptCount;
	}
}
