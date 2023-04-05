using System;

namespace RdcMan
{
	// Token: 0x0200008C RID: 140
	internal abstract class VirtualGroup : GroupBase
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x0001808C File Offset: 0x0001628C
		protected VirtualGroup()
		{
			this.ChangeImageIndex(ImageConstants.Group);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001809C File Offset: 0x0001629C
		protected override void InitSettings()
		{
			base.Properties = new GroupSettings();
			base.InitSettings();
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000180B0 File Offset: 0x000162B0
		public sealed override bool CanAddServers()
		{
			return false;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000180B4 File Offset: 0x000162B4
		public sealed override bool CanAddGroups()
		{
			return false;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000180B8 File Offset: 0x000162B8
		public sealed override bool CanDropGroups()
		{
			return false;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x000180BC File Offset: 0x000162BC
		protected IServerRefFactory ServerRefFactory
		{
			get
			{
				return this as IServerRefFactory;
			}
		}
	}
}
