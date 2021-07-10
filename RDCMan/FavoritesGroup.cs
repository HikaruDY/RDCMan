using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	// Token: 0x020000BE RID: 190
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class FavoritesGroup : BuiltInVirtualGroup<FavoriteServerRef>, IServerRefFactory
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x000045FB File Offset: 0x000027FB
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00004602 File Offset: 0x00002802
		public static FavoritesGroup Instance { get; private set; }

		// Token: 0x06000440 RID: 1088 RVA: 0x0000460A File Offset: 0x0000280A
		private FavoritesGroup()
		{
			base.Text = "Favorites";
			FavoritesGroup.Instance = this;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00004623 File Offset: 0x00002823
		public override FavoriteServerRef AddReference(ServerBase serverBase)
		{
			base.IsInTree = true;
			return base.AddReference(serverBase);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00004633 File Offset: 0x00002833
		protected override string XmlNodeName
		{
			get
			{
				return "favorites";
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000044A3 File Offset: 0x000026A3
		public override bool CanDropServers()
		{
			return true;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000463A File Offset: 0x0000283A
		public override bool HandleMove(RdcTreeNode childNode)
		{
			this.AddReference(childNode as ServerBase);
			return true;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000464A File Offset: 0x0000284A
		public ServerRef Create(Server server)
		{
			return new FavoriteServerRef(server);
		}
	}
}
