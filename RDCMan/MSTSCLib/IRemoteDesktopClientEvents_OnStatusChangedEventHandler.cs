using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000201 RID: 513
	// (Invoke) Token: 0x060054EB RID: 21739
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IRemoteDesktopClientEvents_OnStatusChangedEventHandler([In] int statusCode, [MarshalAs(UnmanagedType.BStr)] [In] string statusMessage);
}
