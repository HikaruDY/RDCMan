using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x0200010A RID: 266
	[ComVisible(true)]
	public class IMsTscAxEvents_OnLogonErrorEvent
	{
		// Token: 0x06000929 RID: 2345 RVA: 0x00025268 File Offset: 0x00023468
		public IMsTscAxEvents_OnLogonErrorEvent(int lError)
		{
			this.lError = lError;
		}

		// Token: 0x040003A2 RID: 930
		public int lError;
	}
}
