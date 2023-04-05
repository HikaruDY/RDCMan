using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent
	{
		public IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		public int width;

		public int height;
	}
}
