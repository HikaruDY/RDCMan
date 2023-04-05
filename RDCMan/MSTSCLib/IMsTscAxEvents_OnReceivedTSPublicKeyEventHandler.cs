using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000174 RID: 372
	// (Invoke) Token: 0x06001C60 RID: 7264
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string publicKey, out bool pfContinueLogon);
}
