using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class FavoritesGroup : BuiltInVirtualGroup<FavoriteServerRef>, IServerRefFactory
	{
		public static FavoritesGroup Instance { get; private set; }

		private FavoritesGroup()
		{
			base.Text = "Favorites";
			FavoritesGroup.Instance = this;
		}

		public override FavoriteServerRef AddReference(ServerBase serverBase)
		{
			base.IsInTree = true;
			return base.AddReference(serverBase);
		}

		protected override string XmlNodeName
		{
			get
			{
				return "favorites";
			}
		}

		public override bool CanDropServers()
		{
			return true;
		}

		public override bool HandleMove(RdcTreeNode childNode)
		{
			this.AddReference(childNode as ServerBase);
			return true;
		}

		public ServerRef Create(Server server)
		{
			return new FavoriteServerRef(server);
		}
	}
}
