using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000110 RID: 272
	[ComVisible(true)]
	public class IMsTscAxEvents_OnMouseInputModeChangedEvent
	{
		// Token: 0x06000938 RID: 2360 RVA: 0x00025298 File Offset: 0x00023498
		public IMsTscAxEvents_OnMouseInputModeChangedEvent(bool fMouseModeRelative)
		{
			this.fMouseModeRelative = fMouseModeRelative;
		}

		// Token: 0x040003A5 RID: 933
		public bool fMouseModeRelative;
	}
}
