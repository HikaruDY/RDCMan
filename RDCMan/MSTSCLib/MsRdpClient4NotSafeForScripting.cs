using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001AB RID: 427
	[Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
	[CoClass(typeof(MsRdpClient4NotSafeForScriptingClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient4NotSafeForScripting : IMsRdpClient4, IMsTscAxEvents_Event
	{
	}
}
