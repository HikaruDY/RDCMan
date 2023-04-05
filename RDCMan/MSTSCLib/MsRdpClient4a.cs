using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001B2 RID: 434
	[Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
	[CoClass(typeof(MsRdpClient4aClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient4a : IMsRdpClient4, IMsTscAxEvents_Event
	{
	}
}
