using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[CoClass(typeof(MsRdpClient9NotSafeForScriptingClass))]
	[Guid("28904001-04B6-436C-A55B-0AF1A0883DC9")]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient9NotSafeForScripting : IMsRdpClient9, IMsTscAxEvents_Event
	{
	}
}
