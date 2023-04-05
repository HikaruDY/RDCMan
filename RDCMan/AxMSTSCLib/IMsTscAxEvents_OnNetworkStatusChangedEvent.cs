using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnNetworkStatusChangedEvent
	{
		public IMsTscAxEvents_OnNetworkStatusChangedEvent(uint qualityLevel, int bandwidth, int rtt)
		{
			this.qualityLevel = qualityLevel;
			this.bandwidth = bandwidth;
			this.rtt = rtt;
		}

		public uint qualityLevel;

		public int bandwidth;

		public int rtt;
	}
}
