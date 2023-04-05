using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnRemoteWindowDisplayedEvent
	{
		public IMsTscAxEvents_OnRemoteWindowDisplayedEvent(bool vbDisplayed, _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
		{
			this.vbDisplayed = vbDisplayed;
			this.hwnd = hwnd;
			this.windowAttribute = windowAttribute;
		}

		public bool vbDisplayed;

		public _RemotableHandle hwnd;

		public RemoteWindowDisplayedAttribute windowAttribute;
	}
}
