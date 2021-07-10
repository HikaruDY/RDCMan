using System;

namespace RdcMan
{
	// Token: 0x020000EF RID: 239
	internal abstract class VirtualGroup : GroupBase
	{
		// Token: 0x060005F4 RID: 1524 RVA: 0x000059FD File Offset: 0x00003BFD
		protected VirtualGroup()
		{
			this.ChangeImageIndex(ImageConstants.Group);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00005A0C File Offset: 0x00003C0C
		protected override void InitSettings()
		{
			base.Properties = new GroupSettings();
			base.InitSettings();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00004460 File Offset: 0x00002660
		public sealed override bool CanAddServers()
		{
			return false;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00004460 File Offset: 0x00002660
		public sealed override bool CanAddGroups()
		{
			return false;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00004460 File Offset: 0x00002660
		public sealed override bool CanDropGroups()
		{
			return false;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00005A1F File Offset: 0x00003C1F
		protected IServerRefFactory ServerRefFactory
		{
			get
			{
				return this as IServerRefFactory;
			}
		}
	}
}
