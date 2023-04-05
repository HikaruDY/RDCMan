using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000009 RID: 9
	public class Wts
	{
		// Token: 0x06000024 RID: 36
		[DllImport("wtsapi32.dll", EntryPoint = "WTSOpenServer")]
		public static extern IntPtr OpenServer(string serverName);

		// Token: 0x06000025 RID: 37
		[DllImport("wtsapi32.dll", EntryPoint = "WTSCloseServer")]
		public static extern void CloseServer(IntPtr hServer);

		// Token: 0x06000026 RID: 38
		[DllImport("wtsapi32.dll", EntryPoint = "WTSEnumerateSessionsW")]
		public static extern bool EnumerateSessions(IntPtr hServer, int reserved, int version, out IntPtr pSessionInfo, out int count);

		// Token: 0x06000027 RID: 39
		[DllImport("wtsapi32.dll", EntryPoint = "WTSFreeMemory")]
		public static extern void FreeMemory(IntPtr pMemory);

		// Token: 0x06000028 RID: 40
		[DllImport("wtsapi32.dll", EntryPoint = "WTSQuerySessionInformationW")]
		public static extern bool QuerySessionInformation(IntPtr hServer, int sessionId, Wts.InfoClass infoClass, out IntPtr pBuffer, out int bytesReturned);

		// Token: 0x06000029 RID: 41
		[DllImport("wtsapi32.dll", EntryPoint = "WTSDisconnectSession")]
		public static extern bool DisconnectSession(IntPtr hServer, int sessionId, bool wait);

		// Token: 0x0600002A RID: 42
		[DllImport("wtsapi32.dll", EntryPoint = "WTSLogoffSession")]
		public static extern bool LogOffSession(IntPtr hServer, int sessionId, bool wait);

		// Token: 0x0600002B RID: 43
		[DllImport("wtsapi32.dll", EntryPoint = "WTSShutdownSystem")]
		public static extern bool ShutdownSystem(IntPtr hServer, int mode);

		// Token: 0x0200022A RID: 554
		public enum ConnectstateClass
		{
			// Token: 0x040009C0 RID: 2496
			Active,
			// Token: 0x040009C1 RID: 2497
			Connected,
			// Token: 0x040009C2 RID: 2498
			ConnectQuery,
			// Token: 0x040009C3 RID: 2499
			Shadow,
			// Token: 0x040009C4 RID: 2500
			Disconnected,
			// Token: 0x040009C5 RID: 2501
			Idle,
			// Token: 0x040009C6 RID: 2502
			Listen,
			// Token: 0x040009C7 RID: 2503
			Reset,
			// Token: 0x040009C8 RID: 2504
			Down,
			// Token: 0x040009C9 RID: 2505
			Init
		}

		// Token: 0x0200022B RID: 555
		public enum InfoClass
		{
			// Token: 0x040009CB RID: 2507
			InitialProgram,
			// Token: 0x040009CC RID: 2508
			ApplicationName,
			// Token: 0x040009CD RID: 2509
			WorkingDirectory,
			// Token: 0x040009CE RID: 2510
			OEMId,
			// Token: 0x040009CF RID: 2511
			SessionId,
			// Token: 0x040009D0 RID: 2512
			UserName,
			// Token: 0x040009D1 RID: 2513
			WinStationName,
			// Token: 0x040009D2 RID: 2514
			DomainName,
			// Token: 0x040009D3 RID: 2515
			ConnectState,
			// Token: 0x040009D4 RID: 2516
			ClientBuildNumber,
			// Token: 0x040009D5 RID: 2517
			ClientName,
			// Token: 0x040009D6 RID: 2518
			ClientDirectory,
			// Token: 0x040009D7 RID: 2519
			ClientProductId,
			// Token: 0x040009D8 RID: 2520
			ClientHardwareId,
			// Token: 0x040009D9 RID: 2521
			ClientAddress,
			// Token: 0x040009DA RID: 2522
			ClientDisplay,
			// Token: 0x040009DB RID: 2523
			ClientProtocolType,
			// Token: 0x040009DC RID: 2524
			IdleTime,
			// Token: 0x040009DD RID: 2525
			LogonTime,
			// Token: 0x040009DE RID: 2526
			IncomingBytes,
			// Token: 0x040009DF RID: 2527
			OutgoingBytes,
			// Token: 0x040009E0 RID: 2528
			IncomingFrames,
			// Token: 0x040009E1 RID: 2529
			OutgoingFrames
		}

		// Token: 0x0200022C RID: 556
		public enum ShutdownMode
		{
			// Token: 0x040009E3 RID: 2531
			Reboot = 4,
			// Token: 0x040009E4 RID: 2532
			PowerOff = 8
		}

		// Token: 0x0200022D RID: 557
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public class SessionInfo
		{
			// Token: 0x040009E5 RID: 2533
			public int SessionId;

			// Token: 0x040009E6 RID: 2534
			[MarshalAs(UnmanagedType.LPWStr)]
			public string WinStationName;

			// Token: 0x040009E7 RID: 2535
			public Wts.ConnectstateClass State;
		}
	}
}
