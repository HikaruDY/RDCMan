using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001E8 RID: 488
	[CoClass(typeof(MsRdpClient9Class))]
	[Guid("28904001-04B6-436C-A55B-0AF1A0883DC9")]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient9 : IMsRdpClient9, IMsTscAxEvents_Event
	{
	}
}
