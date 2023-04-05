using System;

namespace RdcMan
{
	// Token: 0x020000C0 RID: 192
	public class ServerChangedEventArgs : EventArgs
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x00020988 File Offset: 0x0001EB88
		public ServerChangedEventArgs(ServerBase server, ChangeType changeType)
		{
			this.Server = server;
			this.ChangeType = changeType;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x000209A0 File Offset: 0x0001EBA0
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000209A8 File Offset: 0x0001EBA8
		public ServerBase Server { get; private set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x000209B4 File Offset: 0x0001EBB4
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x000209BC File Offset: 0x0001EBBC
		public ChangeType ChangeType { get; private set; }
	}
}
