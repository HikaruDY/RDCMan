using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000178 RID: 376
	// (Invoke) Token: 0x06001C68 RID: 7272
	[TypeLibType(16)]
	[ComVisible(false)]
	public delegate void IMsTscAxEvents_OnRemoteProgramResultEventHandler([MarshalAs(UnmanagedType.BStr)] [In] string bstrRemoteProgram, [ComAliasName("MSTSCLib.RemoteProgramResult")] [In] RemoteProgramResult lError, [In] bool vbIsExecutable);
}
