using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
	[CoClass(typeof(RemoteDesktopClientClass))]
	[ComVisible(true)]
	[ComImport]
	public interface RemoteDesktopClient : IRemoteDesktopClient, IRemoteDesktopClientEvents_Event
	{
	}
}
