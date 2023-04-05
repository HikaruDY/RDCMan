using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x0200014A RID: 330
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnDisconnectedEvent
	{
		// Token: 0x06001B11 RID: 6929 RVA: 0x00057C90 File Offset: 0x00055E90
		public IRemoteDesktopClientEvents_OnDisconnectedEvent(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage)
		{
			this.disconnectReason = disconnectReason;
			this.extendedDisconnectReason = extendedDisconnectReason;
			this.disconnectErrorMessage = disconnectErrorMessage;
		}

		// Token: 0x04000720 RID: 1824
		public int disconnectReason;

		// Token: 0x04000721 RID: 1825
		public int extendedDisconnectReason;

		// Token: 0x04000722 RID: 1826
		public string disconnectErrorMessage;
	}
}
