using System;

namespace RdcMan
{
	// Token: 0x02000083 RID: 131
	public class ConnectionStateChangedEventArgs : EventArgs
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x00014A04 File Offset: 0x00012C04
		public ConnectionStateChangedEventArgs(Server server, RdpClient.ConnectionState state)
		{
			this.Server = server;
			this.State = state;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00014A1C File Offset: 0x00012C1C
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00014A24 File Offset: 0x00012C24
		public Server Server { get; private set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00014A30 File Offset: 0x00012C30
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00014A38 File Offset: 0x00012C38
		public RdpClient.ConnectionState State { get; private set; }
	}
}
