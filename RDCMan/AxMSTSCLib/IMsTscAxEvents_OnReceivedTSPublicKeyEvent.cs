using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnReceivedTSPublicKeyEvent
	{
		public IMsTscAxEvents_OnReceivedTSPublicKeyEvent(string publicKey)
		{
			this.publicKey = publicKey;
		}

		public string publicKey;

		public bool pfContinueLogon;
	}
}
