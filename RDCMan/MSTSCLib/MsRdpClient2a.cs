using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
	[CoClass(typeof(MsRdpClient2aClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient2a : IMsRdpClient2, IMsTscAxEvents_Event
	{
	}
}
