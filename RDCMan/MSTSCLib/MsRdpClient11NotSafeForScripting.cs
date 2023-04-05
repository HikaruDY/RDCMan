using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001F0 RID: 496
	[Guid("7ED92C39-EB38-4927-A70A-708AC5A59321")]
	[CoClass(typeof(MsRdpClient11NotSafeForScriptingClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient11NotSafeForScripting : IMsRdpClient10, IMsTscAxEvents_Event
	{
	}
}
