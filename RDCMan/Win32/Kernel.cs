using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000006 RID: 6
	public class Kernel
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002070 File Offset: 0x00000270
		public static uint MajorVersion { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002078 File Offset: 0x00000278
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002080 File Offset: 0x00000280
		public static uint MinorVersion { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002090 File Offset: 0x00000290
		public static uint Build { get; private set; }

		// Token: 0x0600000C RID: 12 RVA: 0x00002098 File Offset: 0x00000298
		static Kernel()
		{
			uint version = Kernel.GetVersion();
			Kernel.MajorVersion = (version & 255U);
			Kernel.MinorVersion = (version & 65280U) >> 8;
			Kernel.Build = (version & 4294901760U) >> 16;
		}

		// Token: 0x0600000D RID: 13
		[DllImport("kernel32.dll")]
		public static extern int GetLastError();

		// Token: 0x0600000E RID: 14
		[DllImport("kernel32")]
		public static extern uint GetVersion();
	}
}
