using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x0200014C RID: 332
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnStatusChangedEvent
	{
		// Token: 0x06001B16 RID: 6934 RVA: 0x00057CB0 File Offset: 0x00055EB0
		public IRemoteDesktopClientEvents_OnStatusChangedEvent(int statusCode, string statusMessage)
		{
			this.statusCode = statusCode;
			this.statusMessage = statusMessage;
		}

		// Token: 0x04000723 RID: 1827
		public int statusCode;

		// Token: 0x04000724 RID: 1828
		public string statusMessage;
	}
}
