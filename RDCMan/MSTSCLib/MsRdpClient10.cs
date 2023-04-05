using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("7ED92C39-EB38-4927-A70A-708AC5A59321")]
	[CoClass(typeof(MsRdpClient10Class))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient10 : IMsRdpClient10, IMsTscAxEvents_Event
	{
	}
}
