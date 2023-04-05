using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[CoClass(typeof(MsRdpClient6Class))]
	[Guid("D43B7D80-8517-4B6D-9EAC-96AD6800D7F2")]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient6 : IMsRdpClient6, IMsTscAxEvents_Event
	{
	}
}
