using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x020000F8 RID: 248
	[ComVisible(true)]
	public class IMsTscAxEvents_OnFatalErrorEvent
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x000251A8 File Offset: 0x000233A8
		public IMsTscAxEvents_OnFatalErrorEvent(int errorCode)
		{
			this.errorCode = errorCode;
		}

		// Token: 0x04000390 RID: 912
		public int errorCode;
	}
}
