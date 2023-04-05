using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x020000F6 RID: 246
	[ComVisible(true)]
	public class IMsTscAxEvents_OnChannelReceivedDataEvent
	{
		// Token: 0x060008F7 RID: 2295 RVA: 0x00025190 File Offset: 0x00023390
		public IMsTscAxEvents_OnChannelReceivedDataEvent(string chanName, string data)
		{
			this.chanName = chanName;
			this.data = data;
		}

		// Token: 0x0400038E RID: 910
		public string chanName;

		// Token: 0x0400038F RID: 911
		public string data;
	}
}
