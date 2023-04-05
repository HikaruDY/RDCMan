using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[CoClass(typeof(MsRdpClient3Class))]
	[Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient3 : IMsRdpClient3, IMsTscAxEvents_Event
	{
	}
}
