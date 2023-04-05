using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public class Util
	{
		[DllImport("user32.dll")]
		public static extern uint MapVirtualKey(uint uCode, uint uMapType);

		public const uint MvkVkeyToScanCode = 0U;
	}
}
