﻿using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001A1 RID: 417
	[Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
	[CoClass(typeof(MsRdpClient2aClass))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient2a : IMsRdpClient2, IMsTscAxEvents_Event
	{
	}
}
