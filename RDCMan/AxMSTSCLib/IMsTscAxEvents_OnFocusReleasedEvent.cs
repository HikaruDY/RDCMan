using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x0200010C RID: 268
	[ComVisible(true)]
	public class IMsTscAxEvents_OnFocusReleasedEvent
	{
		// Token: 0x0600092E RID: 2350 RVA: 0x00025278 File Offset: 0x00023478
		public IMsTscAxEvents_OnFocusReleasedEvent(int iDirection)
		{
			this.iDirection = iDirection;
		}

		// Token: 0x040003A3 RID: 931
		public int iDirection;
	}
}
