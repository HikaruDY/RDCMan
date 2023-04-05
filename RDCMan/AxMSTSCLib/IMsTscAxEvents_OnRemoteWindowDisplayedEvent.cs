using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000108 RID: 264
	[ComVisible(true)]
	public class IMsTscAxEvents_OnRemoteWindowDisplayedEvent
	{
		// Token: 0x06000924 RID: 2340 RVA: 0x00025248 File Offset: 0x00023448
		public IMsTscAxEvents_OnRemoteWindowDisplayedEvent(bool vbDisplayed, _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
		{
			this.vbDisplayed = vbDisplayed;
			this.hwnd = hwnd;
			this.windowAttribute = windowAttribute;
		}

		// Token: 0x0400039F RID: 927
		public bool vbDisplayed;

		// Token: 0x040003A0 RID: 928
		public _RemotableHandle hwnd;

		// Token: 0x040003A1 RID: 929
		public RemoteWindowDisplayedAttribute windowAttribute;
	}
}
