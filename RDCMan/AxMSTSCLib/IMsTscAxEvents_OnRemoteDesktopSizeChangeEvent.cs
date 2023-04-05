using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x020000FC RID: 252
	[ComVisible(true)]
	public class IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent
	{
		// Token: 0x06000906 RID: 2310 RVA: 0x000251C8 File Offset: 0x000233C8
		public IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		// Token: 0x04000392 RID: 914
		public int width;

		// Token: 0x04000393 RID: 915
		public int height;
	}
}
