using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000199 RID: 409
	[Guid("92B4A539-7115-4B7C-A5A9-E5D9EFC2780A")]
	[CoClass(typeof(MsRdpClientClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient : IMsRdpClient, IMsTscAxEvents_Event
	{
	}
}
