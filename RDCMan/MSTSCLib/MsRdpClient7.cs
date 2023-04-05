using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001D6 RID: 470
	[CoClass(typeof(MsRdpClient7Class))]
	[Guid("B2A5B5CE-3461-444A-91D4-ADD26D070638")]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient7 : IMsRdpClient7, IMsTscAxEvents_Event
	{
	}
}
