using System;

namespace RdcMan
{
	// Token: 0x020000ED RID: 237
	internal class SmartServerRef : ServerRef
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00004596 File Offset: 0x00002796
		public SmartServerRef(Server server) : base(server)
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000059F0 File Offset: 0x00003BF0
		public override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Smart group members are specified by inclusion criteria; manual removal is not allowed");
			return false;
		}
	}
}
