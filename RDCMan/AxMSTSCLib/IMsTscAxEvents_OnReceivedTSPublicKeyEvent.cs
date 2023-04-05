using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	// Token: 0x02000100 RID: 256
	[ComVisible(true)]
	public class IMsTscAxEvents_OnReceivedTSPublicKeyEvent
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x000251E8 File Offset: 0x000233E8
		public IMsTscAxEvents_OnReceivedTSPublicKeyEvent(string publicKey)
		{
			this.publicKey = publicKey;
		}

		// Token: 0x04000395 RID: 917
		public string publicKey;

		// Token: 0x04000396 RID: 918
		public bool pfContinueLogon;
	}
}
