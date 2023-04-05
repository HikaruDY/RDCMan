using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200020B RID: 523
	[Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
	[CoClass(typeof(RemoteDesktopClientClass))]
	[ComVisible(true)]
	[ComImport]
	public interface RemoteDesktopClient : IRemoteDesktopClient, IRemoteDesktopClientEvents_Event
	{
	}
}
