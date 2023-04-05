using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000114 RID: 276
	[ComVisible(true)]
	public class IMsTscAxEvents_OnNetworkStatusChangedEvent
	{
		// Token: 0x06000942 RID: 2370 RVA: 0x000252B8 File Offset: 0x000234B8
		public IMsTscAxEvents_OnNetworkStatusChangedEvent(uint qualityLevel, int bandwidth, int rtt)
		{
			this.qualityLevel = qualityLevel;
			this.bandwidth = bandwidth;
			this.rtt = rtt;
		}

		// Token: 0x040003A7 RID: 935
		public uint qualityLevel;

		// Token: 0x040003A8 RID: 936
		public int bandwidth;

		// Token: 0x040003A9 RID: 937
		public int rtt;
	}
}
