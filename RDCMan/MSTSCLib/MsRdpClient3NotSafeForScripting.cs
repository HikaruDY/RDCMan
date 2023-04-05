using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001A3 RID: 419
	[Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
	[CoClass(typeof(MsRdpClient3NotSafeForScriptingClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient3NotSafeForScripting : IMsRdpClient3, IMsTscAxEvents_Event
	{
	}
}
