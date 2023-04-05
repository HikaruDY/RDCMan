using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000152 RID: 338
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent
	{
		// Token: 0x06001B25 RID: 6949 RVA: 0x00057D20 File Offset: 0x00055F20
		public IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent(string adminMessage)
		{
			this.adminMessage = adminMessage;
		}

		// Token: 0x0400072E RID: 1838
		public string adminMessage;
	}
}
