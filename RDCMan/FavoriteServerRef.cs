using System;

namespace RdcMan
{
	// Token: 0x020000BD RID: 189
	internal class FavoriteServerRef : ServerRef
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00004596 File Offset: 0x00002796
		public FavoriteServerRef(Server server) : base(server)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000045F2 File Offset: 0x000027F2
		public override bool CanRemove(bool popUI)
		{
			return this.AllowEdit(popUI);
		}
	}
}
