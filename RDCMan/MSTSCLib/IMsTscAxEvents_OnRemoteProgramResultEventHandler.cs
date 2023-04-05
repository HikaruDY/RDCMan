using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnRemoteProgramResultEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string bstrRemoteProgram, [ComAliasName("MSTSCLib.RemoteProgramResult")] [In] RemoteProgramResult lError, [In] bool vbIsExecutable);
}
