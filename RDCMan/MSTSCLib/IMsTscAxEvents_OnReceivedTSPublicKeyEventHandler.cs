using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(false)]
	[TypeLibType(16)]
	public delegate void IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string publicKey, out bool pfContinueLogon);
}
