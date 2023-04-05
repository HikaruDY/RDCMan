using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnMouseInputModeChangedEvent
	{
		public IMsTscAxEvents_OnMouseInputModeChangedEvent(bool fMouseModeRelative)
		{
			this.fMouseModeRelative = fMouseModeRelative;
		}

		public bool fMouseModeRelative;
	}
}
