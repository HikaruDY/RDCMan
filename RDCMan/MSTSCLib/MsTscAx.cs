using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000195 RID: 405
	[Guid("8C11EFAE-92C3-11D1-BC1E-00C04FA31489")]
	[CoClass(typeof(MsTscAxClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsTscAx : IMsTscAx, IMsTscAxEvents_Event
	{
	}
}
