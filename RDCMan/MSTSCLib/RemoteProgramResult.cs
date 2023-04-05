using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(true)]
	public enum RemoteProgramResult
	{
		remoteAppResultOk,
		remoteAppResultLocked,
		remoteAppResultProtocolError,
		remoteAppResultNotInWhitelist,
		remoteAppResultNetworkPathDenied,
		remoteAppResultFileNotFound,
		remoteAppResultFailure,
		remoteAppResultHookNotLoaded
	}
}
