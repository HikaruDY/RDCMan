using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	// Token: 0x02000074 RID: 116
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class FavoritesGroup : BuiltInVirtualGroup<FavoriteServerRef>, IServerRefFactory
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00012F24 File Offset: 0x00011124
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00012F2C File Offset: 0x0001112C
		public static FavoritesGroup Instance { get; private set; }

		// Token: 0x06000361 RID: 865 RVA: 0x00012F34 File Offset: 0x00011134
		private FavoritesGroup()
		{
			base.Text = "Favorites";
			FavoritesGroup.Instance = this;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00012F50 File Offset: 0x00011150
		public override FavoriteServerRef AddReference(ServerBase serverBase)
		{
			base.IsInTree = true;
			return base.AddReference(serverBase);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00012F60 File Offset: 0x00011160
		protected override string XmlNodeName
		{
			get
			{
				return "favorites";
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00012F68 File Offset: 0x00011168
		public override bool CanDropServers()
		{
			return true;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00012F6C File Offset: 0x0001116C
		public override bool HandleMove(RdcTreeNode childNode)
		{
			this.AddReference(childNode as ServerBase);
			return true;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00012F7C File Offset: 0x0001117C
		public ServerRef Create(Server server)
		{
			return new FavoriteServerRef(server);
		}
	}
}
