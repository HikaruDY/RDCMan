using System;

namespace RdcMan
{
	// Token: 0x02000071 RID: 113
	internal class ConnectedServerRef : ServerRef
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00012D14 File Offset: 0x00010F14
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00012D1C File Offset: 0x00010F1C
		public DateTime LastFocusTime { get; set; }

		// Token: 0x06000352 RID: 850 RVA: 0x00012D28 File Offset: 0x00010F28
		public ConnectedServerRef(Server server) : base(server)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00012D34 File Offset: 0x00010F34
		public override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Disconnect the server to remove it from the Connected group");
			return false;
		}
	}
}
