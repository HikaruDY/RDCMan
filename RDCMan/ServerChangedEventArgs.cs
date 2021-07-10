using System;

namespace RdcMan
{
	// Token: 0x02000156 RID: 342
	public class ServerChangedEventArgs : EventArgs
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x000073C9 File Offset: 0x000055C9
		public ServerChangedEventArgs(ServerBase server, ChangeType changeType)
		{
			this.Server = server;
			this.ChangeType = changeType;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x000073DF File Offset: 0x000055DF
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x000073E7 File Offset: 0x000055E7
		public ServerBase Server { get; private set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x000073F0 File Offset: 0x000055F0
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x000073F8 File Offset: 0x000055F8
		public ChangeType ChangeType { get; private set; }
	}
}
