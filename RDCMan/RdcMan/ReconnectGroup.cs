using System;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace RdcMan
{
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ReconnectGroup : BuiltInVirtualGroup<ReconnectServerRef>, IServerRefFactory
	{
		public static ReconnectGroup Instance { get; private set; }

		private ReconnectGroup()
		{
			base.Text = "Reconnect";
			ReconnectGroup.Instance = this;
		}

		public override bool CanDropServers()
		{
			return true;
		}

		public override DragDropEffects DropBehavior()
		{
			return DragDropEffects.Copy;
		}

		public override bool HandleMove(RdcTreeNode childNode)
		{
			ReconnectServerRef reconnectServerRef = this.AddReference(childNode as ServerBase);
			reconnectServerRef.Start(false);
			return true;
		}

		public ServerRef Create(Server server)
		{
			return new ReconnectServerRef(server);
		}
	}
}
