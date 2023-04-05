using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000154 RID: 340
	[ComVisible(true)]
	public class IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent
	{
		// Token: 0x06001B2A RID: 6954 RVA: 0x00057D30 File Offset: 0x00055F30
		public IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent(int keyCombination)
		{
			this.keyCombination = keyCombination;
		}

		// Token: 0x0400072F RID: 1839
		public int keyCombination;
	}
}
