﻿using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler([In] int width, [In] int height);
}
