using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000156 RID: 342
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent
	{
		// Token: 0x06001B2F RID: 6959 RVA: 0x00057D40 File Offset: 0x00055F40
		public IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		// Token: 0x04000730 RID: 1840
		public int width;

		// Token: 0x04000731 RID: 1841
		public int height;
	}
}
