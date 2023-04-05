using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000179 RID: 377
	// (Invoke) Token: 0x06001C6A RID: 7274
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler([In] bool vbDisplayed, [In] uint uDisplayInformation);
}
