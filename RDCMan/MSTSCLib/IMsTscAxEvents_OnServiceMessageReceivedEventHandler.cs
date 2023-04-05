using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200017F RID: 383
	// (Invoke) Token: 0x06001C76 RID: 7286
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnServiceMessageReceivedEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string serviceMessage);
}
