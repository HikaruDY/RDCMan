﻿using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler([In] int x, [In] int y);
}