using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000185 RID: 389
	[CoClass(typeof(MsTscAxNotSafeForScriptingClass))]
	[Guid("8C11EFAE-92C3-11D1-BC1E-00C04FA31489")]
	[ComVisible(true)]
	[ComImport]
	public interface MsTscAxNotSafeForScripting : IMsTscAx, IMsTscAxEvents_Event
	{
	}
}
