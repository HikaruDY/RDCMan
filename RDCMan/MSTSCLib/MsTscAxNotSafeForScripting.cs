using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[CoClass(typeof(MsTscAxNotSafeForScriptingClass))]
	[Guid("8C11EFAE-92C3-11D1-BC1E-00C04FA31489")]
	[ComVisible(true)]
	[ComImport]
	public interface MsTscAxNotSafeForScripting : IMsTscAx, IMsTscAxEvents_Event
	{
	}
}
