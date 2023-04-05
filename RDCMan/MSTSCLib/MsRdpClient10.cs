using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001EE RID: 494
	[Guid("7ED92C39-EB38-4927-A70A-708AC5A59321")]
	[CoClass(typeof(MsRdpClient10Class))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient10 : IMsRdpClient10, IMsTscAxEvents_Event
	{
	}
}
