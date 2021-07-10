using System;

namespace RdcMan
{
	// Token: 0x020000D6 RID: 214
	public class ConnectionStateChangedEventArgs : EventArgs
	{
		// Token: 0x060004FC RID: 1276 RVA: 0x00004E08 File Offset: 0x00003008
		public ConnectionStateChangedEventArgs(Server server, RdpClient.ConnectionState state)
		{
			this.Server = server;
			this.State = state;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00004E1E File Offset: 0x0000301E
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004E26 File Offset: 0x00003026
		public Server Server { get; private set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00004E2F File Offset: 0x0000302F
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00004E37 File Offset: 0x00003037
		public RdpClient.ConnectionState State { get; private set; }
	}
}
