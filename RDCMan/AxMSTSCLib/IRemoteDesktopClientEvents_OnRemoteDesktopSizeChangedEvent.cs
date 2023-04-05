using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent
	{
		public IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		public int width;

		public int height;
	}
}
