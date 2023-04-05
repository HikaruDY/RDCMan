using System;

namespace RdcMan
{
	// Token: 0x02000073 RID: 115
	internal class FavoriteServerRef : ServerRef
	{
		// Token: 0x0600035D RID: 861 RVA: 0x00012F0C File Offset: 0x0001110C
		public FavoriteServerRef(Server server) : base(server)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00012F18 File Offset: 0x00011118
		public override bool CanRemove(bool popUI)
		{
			return this.AllowEdit(popUI);
		}
	}
}
