using System;

namespace RdcMan
{
	// Token: 0x020000BB RID: 187
	internal class ConnectedServerRef : ServerRef
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00004585 File Offset: 0x00002785
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0000458D File Offset: 0x0000278D
		public DateTime LastFocusTime { get; set; }

		// Token: 0x06000431 RID: 1073 RVA: 0x00004596 File Offset: 0x00002796
		public ConnectedServerRef(Server server) : base(server)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000459F File Offset: 0x0000279F
		public override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Disconnect the server to remove it from the Connected group");
			return false;
		}
	}
}
