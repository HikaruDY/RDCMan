using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000106 RID: 262
	[ComVisible(true)]
	public class IMsTscAxEvents_OnRemoteProgramDisplayedEvent
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00025230 File Offset: 0x00023430
		public IMsTscAxEvents_OnRemoteProgramDisplayedEvent(bool vbDisplayed, uint uDisplayInformation)
		{
			this.vbDisplayed = vbDisplayed;
			this.uDisplayInformation = uDisplayInformation;
		}

		// Token: 0x0400039D RID: 925
		public bool vbDisplayed;

		// Token: 0x0400039E RID: 926
		public uint uDisplayInformation;
	}
}
