﻿using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler([In] bool vbDisplayed, [In] uint uDisplayInformation);
}