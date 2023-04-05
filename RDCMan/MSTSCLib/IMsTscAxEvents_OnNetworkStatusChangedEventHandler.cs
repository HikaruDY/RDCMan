using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000181 RID: 385
	// (Invoke) Token: 0x06001C7A RID: 7290
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IMsTscAxEvents_OnNetworkStatusChangedEventHandler([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);
}
