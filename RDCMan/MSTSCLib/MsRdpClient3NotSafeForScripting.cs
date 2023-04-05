using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
	[CoClass(typeof(MsRdpClient3NotSafeForScriptingClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient3NotSafeForScripting : IMsRdpClient3, IMsTscAxEvents_Event
	{
	}
}
