using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000150 RID: 336
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent
	{
		// Token: 0x06001B20 RID: 6944 RVA: 0x00057D00 File Offset: 0x00055F00
		public IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent(uint qualityLevel, int bandwidth, int rtt)
		{
			this.qualityLevel = qualityLevel;
			this.bandwidth = bandwidth;
			this.rtt = rtt;
		}

		// Token: 0x0400072B RID: 1835
		public uint qualityLevel;

		// Token: 0x0400072C RID: 1836
		public int bandwidth;

		// Token: 0x0400072D RID: 1837
		public int rtt;
	}
}
