using System;

namespace RdcMan
{
	internal abstract class VirtualGroup : GroupBase
	{
		protected VirtualGroup()
		{
			this.ChangeImageIndex(ImageConstants.Group);
		}

		protected override void InitSettings()
		{
			base.Properties = new GroupSettings();
			base.InitSettings();
		}

		public sealed override bool CanAddServers()
		{
			return false;
		}

		public sealed override bool CanAddGroups()
		{
			return false;
		}

		public sealed override bool CanDropGroups()
		{
			return false;
		}

		protected IServerRefFactory ServerRefFactory
		{
			get
			{
				return this as IServerRefFactory;
			}
		}
	}
}
