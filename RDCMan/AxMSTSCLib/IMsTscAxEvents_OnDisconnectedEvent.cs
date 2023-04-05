using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x020000F4 RID: 244
	[ComVisible(true)]
	public class IMsTscAxEvents_OnDisconnectedEvent
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x00025180 File Offset: 0x00023380
		public IMsTscAxEvents_OnDisconnectedEvent(int discReason)
		{
			this.discReason = discReason;
		}

		// Token: 0x0400038D RID: 909
		public int discReason;
	}
}
