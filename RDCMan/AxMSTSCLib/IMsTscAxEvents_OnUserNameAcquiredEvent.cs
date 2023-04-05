using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x0200010E RID: 270
	[ComVisible(true)]
	public class IMsTscAxEvents_OnUserNameAcquiredEvent
	{
		// Token: 0x06000933 RID: 2355 RVA: 0x00025288 File Offset: 0x00023488
		public IMsTscAxEvents_OnUserNameAcquiredEvent(string bstrUserName)
		{
			this.bstrUserName = bstrUserName;
		}

		// Token: 0x040003A4 RID: 932
		public string bstrUserName;
	}
}
