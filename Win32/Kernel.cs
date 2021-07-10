using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x0200000B RID: 11
	public class Kernel
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020BF File Offset: 0x000002BF
		public static uint MajorVersion { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020C7 File Offset: 0x000002C7
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020CE File Offset: 0x000002CE
		public static uint MinorVersion { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020D6 File Offset: 0x000002D6
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020DD File Offset: 0x000002DD
		public static uint Build { get; private set; }

		// Token: 0x0600000D RID: 13 RVA: 0x00008608 File Offset: 0x00006808
		static Kernel()
		{
			uint version = Kernel.GetVersion();
			Kernel.MajorVersion = (version & 255u);
			Kernel.MinorVersion = (version & 65280u) >> 8;
			Kernel.Build = (version & 4294901760u) >> 16;
		}

		// Token: 0x0600000E RID: 14
		[DllImport("kernel32.dll")]
		public static extern int GetLastError();

		// Token: 0x0600000F RID: 15
		[DllImport("kernel32")]
		public static extern uint GetVersion();
	}
}
