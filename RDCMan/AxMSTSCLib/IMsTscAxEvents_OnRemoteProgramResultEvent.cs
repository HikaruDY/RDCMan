using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000104 RID: 260
	[ComVisible(true)]
	public class IMsTscAxEvents_OnRemoteProgramResultEvent
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x00025210 File Offset: 0x00023410
		public IMsTscAxEvents_OnRemoteProgramResultEvent(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
		{
			this.bstrRemoteProgram = bstrRemoteProgram;
			this.lError = lError;
			this.vbIsExecutable = vbIsExecutable;
		}

		// Token: 0x0400039A RID: 922
		public string bstrRemoteProgram;

		// Token: 0x0400039B RID: 923
		public RemoteProgramResult lError;

		// Token: 0x0400039C RID: 924
		public bool vbIsExecutable;
	}
}
