using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000207 RID: 519
	// (Invoke) Token: 0x060054F7 RID: 21751
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string adminMessage);
}
