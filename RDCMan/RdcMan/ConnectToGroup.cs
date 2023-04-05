using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ConnectToGroup : BuiltInVirtualGroup<ServerRef>, IServerRefFactory
	{
		public static ConnectToGroup Instance { get; private set; }

		private ConnectToGroup()
		{
			base.Text = "Connect To";
			ConnectToGroup.Instance = this;
		}

		public override ServerRef AddReference(ServerBase serverBase)
		{
			throw new InvalidOperationException();
		}

		public override void InvalidateNode()
		{
			base.InvalidateNode();
			if (base.Nodes.Count == 0)
			{
				base.IsInTree = false;
			}
		}

		public ServerRef Create(Server server)
		{
			throw new NotImplementedException("ConnectTo does not contain ServerRef");
		}

		protected override bool IsVisibilityConfigurable
		{
			get
			{
				return false;
			}
		}
	}
}
