using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200017D RID: 381
	// (Invoke) Token: 0x06001C72 RID: 7282
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IMsTscAxEvents_OnUserNameAcquiredEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string bstrUserName);
}
