using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200015D RID: 349
	[ComVisible(true)]
	public enum RemoteProgramResult
	{
		// Token: 0x0400073E RID: 1854
		remoteAppResultOk,
		// Token: 0x0400073F RID: 1855
		remoteAppResultLocked,
		// Token: 0x04000740 RID: 1856
		remoteAppResultProtocolError,
		// Token: 0x04000741 RID: 1857
		remoteAppResultNotInWhitelist,
		// Token: 0x04000742 RID: 1858
		remoteAppResultNetworkPathDenied,
		// Token: 0x04000743 RID: 1859
		remoteAppResultFileNotFound,
		// Token: 0x04000744 RID: 1860
		remoteAppResultFailure,
		// Token: 0x04000745 RID: 1861
		remoteAppResultHookNotLoaded
	}
}
