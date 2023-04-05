using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000158 RID: 344
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent
	{
		// Token: 0x06001B34 RID: 6964 RVA: 0x00057D58 File Offset: 0x00055F58
		public IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x04000732 RID: 1842
		public int x;

		// Token: 0x04000733 RID: 1843
		public int y;
	}
}
