using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("D43B7D80-8517-4B6D-9EAC-96AD6800D7F2")]
	[CoClass(typeof(MsRdpClient6NotSafeForScriptingClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient6NotSafeForScripting : IMsRdpClient6, IMsTscAxEvents_Event
	{
	}
}
