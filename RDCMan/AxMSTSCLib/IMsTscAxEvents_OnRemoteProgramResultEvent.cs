using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnRemoteProgramResultEvent
	{
		public IMsTscAxEvents_OnRemoteProgramResultEvent(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
		{
			this.bstrRemoteProgram = bstrRemoteProgram;
			this.lError = lError;
			this.vbIsExecutable = vbIsExecutable;
		}

		public string bstrRemoteProgram;

		public RemoteProgramResult lError;

		public bool vbIsExecutable;
	}
}
