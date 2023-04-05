using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnFocusReleasedEvent
	{
		public IMsTscAxEvents_OnFocusReleasedEvent(int iDirection)
		{
			this.iDirection = iDirection;
		}

		public int iDirection;
	}
}
