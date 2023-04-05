using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000102 RID: 258
	[ComVisible(true)]
	public class IMsTscAxEvents_OnAutoReconnectingEvent
	{
		// Token: 0x06000915 RID: 2325 RVA: 0x000251F8 File Offset: 0x000233F8
		public IMsTscAxEvents_OnAutoReconnectingEvent(int disconnectReason, int attemptCount)
		{
			this.disconnectReason = disconnectReason;
			this.attemptCount = attemptCount;
		}

		// Token: 0x04000397 RID: 919
		public int disconnectReason;

		// Token: 0x04000398 RID: 920
		public int attemptCount;

		// Token: 0x04000399 RID: 921
		public AutoReconnectContinueState pArcContinueStatus;
	}
}
