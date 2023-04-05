using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200019F RID: 415
	[Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
	[CoClass(typeof(MsRdpClient2Class))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient2 : IMsRdpClient2, IMsTscAxEvents_Event
	{
	}
}
