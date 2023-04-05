using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnRemoteProgramDisplayedEvent
	{
		public IMsTscAxEvents_OnRemoteProgramDisplayedEvent(bool vbDisplayed, uint uDisplayInformation)
		{
			this.vbDisplayed = vbDisplayed;
			this.uDisplayInformation = uDisplayInformation;
		}

		public bool vbDisplayed;

		public uint uDisplayInformation;
	}
}
