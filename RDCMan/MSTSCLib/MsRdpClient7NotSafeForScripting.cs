using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001CC RID: 460
	[Guid("B2A5B5CE-3461-444A-91D4-ADD26D070638")]
	[CoClass(typeof(MsRdpClient7NotSafeForScriptingClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient7NotSafeForScripting : IMsRdpClient7, IMsTscAxEvents_Event
	{
	}
}
