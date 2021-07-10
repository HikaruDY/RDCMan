using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000002 RID: 2
	public class Util
	{
		// Token: 0x06000001 RID: 1
		[DllImport("user32.dll")]
		public static extern uint MapVirtualKey(uint uCode, uint uMapType);

		// Token: 0x04000001 RID: 1
		public const uint MvkVkeyToScanCode = 0u;
	}
}
