using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent
	{
		public IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent(int keyCombination)
		{
			this.keyCombination = keyCombination;
		}

		public int keyCombination;
	}
}
