using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("92B4A539-7115-4B7C-A5A9-E5D9EFC2780A")]
	[CoClass(typeof(MsRdpClientNotSafeForScriptingClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClientNotSafeForScripting : IMsRdpClient, IMsTscAxEvents_Event
	{
	}
}
