using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000112 RID: 274
	[ComVisible(true)]
	public class IMsTscAxEvents_OnServiceMessageReceivedEvent
	{
		// Token: 0x0600093D RID: 2365 RVA: 0x000252A8 File Offset: 0x000234A8
		public IMsTscAxEvents_OnServiceMessageReceivedEvent(string serviceMessage)
		{
			this.serviceMessage = serviceMessage;
		}

		// Token: 0x040003A6 RID: 934
		public string serviceMessage;
	}
}
