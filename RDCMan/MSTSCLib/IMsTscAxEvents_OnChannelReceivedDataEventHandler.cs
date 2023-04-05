using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200016B RID: 363
	// (Invoke) Token: 0x06001C4E RID: 7246
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnChannelReceivedDataEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string data);
}
