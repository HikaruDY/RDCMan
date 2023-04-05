using System;
using System.Runtime.InteropServices;

namespace AxMSTSCLib
{
	[ComVisible(true)]
	public class IMsTscAxEvents_OnWarningEvent
	{
		public IMsTscAxEvents_OnWarningEvent(int warningCode)
		{
			this.warningCode = warningCode;
		}

		public int warningCode;
	}
}
