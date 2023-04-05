using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000206 RID: 518
	// (Invoke) Token: 0x060054F5 RID: 21749
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);
}
