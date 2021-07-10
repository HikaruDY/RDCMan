using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000019 RID: 25
	public class Wts
	{
		// Token: 0x06000026 RID: 38
		[DllImport("wtsapi32.dll", EntryPoint = "WTSOpenServer")]
		public static extern IntPtr OpenServer(string serverName);

		// Token: 0x06000027 RID: 39
		[DllImport("wtsapi32.dll", EntryPoint = "WTSCloseServer")]
		public static extern void CloseServer(IntPtr hServer);

		// Token: 0x06000028 RID: 40
		[DllImport("wtsapi32.dll", EntryPoint = "WTSEnumerateSessionsW")]
		public static extern bool EnumerateSessions(IntPtr hServer, int reserved, int version, out IntPtr pSessionInfo, out int count);

		// Token: 0x06000029 RID: 41
		[DllImport("wtsapi32.dll", EntryPoint = "WTSFreeMemory")]
		public static extern void FreeMemory(IntPtr pMemory);

		// Token: 0x0600002A RID: 42
		[DllImport("wtsapi32.dll", EntryPoint = "WTSQuerySessionInformationW")]
		public static extern bool QuerySessionInformation(IntPtr hServer, int sessionId, Wts.InfoClass infoClass, out IntPtr pBuffer, out int bytesReturned);

		// Token: 0x0600002B RID: 43
		[DllImport("wtsapi32.dll", EntryPoint = "WTSDisconnectSession")]
		public static extern bool DisconnectSession(IntPtr hServer, int sessionId, bool wait);

		// Token: 0x0600002C RID: 44
		[DllImport("wtsapi32.dll", EntryPoint = "WTSLogoffSession")]
		public static extern bool LogOffSession(IntPtr hServer, int sessionId, bool wait);

		// Token: 0x0600002D RID: 45
		[DllImport("wtsapi32.dll", EntryPoint = "WTSShutdownSystem")]
		public static extern bool ShutdownSystem(IntPtr hServer, int mode);

		// Token: 0x0200001A RID: 26
		public enum ConnectstateClass
		{
			// Token: 0x040001D0 RID: 464
			Active,
			// Token: 0x040001D1 RID: 465
			Connected,
			// Token: 0x040001D2 RID: 466
			ConnectQuery,
			// Token: 0x040001D3 RID: 467
			Shadow,
			// Token: 0x040001D4 RID: 468
			Disconnected,
			// Token: 0x040001D5 RID: 469
			Idle,
			// Token: 0x040001D6 RID: 470
			Listen,
			// Token: 0x040001D7 RID: 471
			Reset,
			// Token: 0x040001D8 RID: 472
			Down,
			// Token: 0x040001D9 RID: 473
			Init
		}

		// Token: 0x0200001B RID: 27
		public enum InfoClass
		{
			// Token: 0x040001DB RID: 475
			InitialProgram,
			// Token: 0x040001DC RID: 476
			ApplicationName,
			// Token: 0x040001DD RID: 477
			WorkingDirectory,
			// Token: 0x040001DE RID: 478
			OEMId,
			// Token: 0x040001DF RID: 479
			SessionId,
			// Token: 0x040001E0 RID: 480
			UserName,
			// Token: 0x040001E1 RID: 481
			WinStationName,
			// Token: 0x040001E2 RID: 482
			DomainName,
			// Token: 0x040001E3 RID: 483
			ConnectState,
			// Token: 0x040001E4 RID: 484
			ClientBuildNumber,
			// Token: 0x040001E5 RID: 485
			ClientName,
			// Token: 0x040001E6 RID: 486
			ClientDirectory,
			// Token: 0x040001E7 RID: 487
			ClientProductId,
			// Token: 0x040001E8 RID: 488
			ClientHardwareId,
			// Token: 0x040001E9 RID: 489
			ClientAddress,
			// Token: 0x040001EA RID: 490
			ClientDisplay,
			// Token: 0x040001EB RID: 491
			ClientProtocolType,
			// Token: 0x040001EC RID: 492
			IdleTime,
			// Token: 0x040001ED RID: 493
			LogonTime,
			// Token: 0x040001EE RID: 494
			IncomingBytes,
			// Token: 0x040001EF RID: 495
			OutgoingBytes,
			// Token: 0x040001F0 RID: 496
			IncomingFrames,
			// Token: 0x040001F1 RID: 497
			OutgoingFrames
		}

		// Token: 0x0200001C RID: 28
		public enum ShutdownMode
		{
			// Token: 0x040001F3 RID: 499
			Reboot = 4,
			// Token: 0x040001F4 RID: 500
			PowerOff = 8
		}

		// Token: 0x0200001D RID: 29
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public class SessionInfo
		{
			// Token: 0x040001F5 RID: 501
			public int SessionId;

			// Token: 0x040001F6 RID: 502
			[MarshalAs(UnmanagedType.LPWStr)]
			public string WinStationName;

			// Token: 0x040001F7 RID: 503
			public Wts.ConnectstateClass State;
		}
	}
}
