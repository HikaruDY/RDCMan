using System;

namespace RdcMan
{
	// Token: 0x0200008A RID: 138
	internal class SmartServerRef : ServerRef
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x00018070 File Offset: 0x00016270
		public SmartServerRef(Server server) : base(server)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001807C File Offset: 0x0001627C
		public override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Smart group members are specified by inclusion criteria; manual removal is not allowed");
			return false;
		}
	}
}
