using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000200 RID: 512
	// (Invoke) Token: 0x060054E9 RID: 21737
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IRemoteDesktopClientEvents_OnDisconnectedEventHandler([In] int disconnectReason, [In] int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] [In] string disconnectErrorMessage);
}
