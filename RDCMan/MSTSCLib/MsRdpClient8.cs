﻿using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("4247E044-9271-43A9-BC49-E2AD9E855D62")]
	[CoClass(typeof(MsRdpClient8Class))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient8 : IMsRdpClient8, IMsTscAxEvents_Event
	{
	}
}
