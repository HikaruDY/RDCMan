using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent
	{
		public IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int x;

		public int y;
	}
}
