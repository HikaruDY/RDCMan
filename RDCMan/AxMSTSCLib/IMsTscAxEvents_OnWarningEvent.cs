using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x020000FA RID: 250
	[ComVisible(true)]
	public class IMsTscAxEvents_OnWarningEvent
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x000251B8 File Offset: 0x000233B8
		public IMsTscAxEvents_OnWarningEvent(int warningCode)
		{
			this.warningCode = warningCode;
		}

		// Token: 0x04000391 RID: 913
		public int warningCode;
	}
}
