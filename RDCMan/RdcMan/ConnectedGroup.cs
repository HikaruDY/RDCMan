using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ConnectedGroup : BuiltInVirtualGroup<ConnectedServerRef>, IServerRefFactory
	{
		public static ConnectedGroup Instance { get; private set; }

		static ConnectedGroup()
		{
			Server.ConnectionStateChanged += ConnectedGroup.Server_ConnectionStateChanged;
			Server.FocusReceived += ConnectedGroup.Server_FocusReceived;
		}

		private ConnectedGroup()
		{
			base.Text = "Connected";
			ConnectedGroup.Instance = this;
		}

		private static void Server_FocusReceived(Server server)
		{
			ConnectedServerRef connectedServerRef = server.FindServerRef<ConnectedServerRef>();
			if (connectedServerRef != null)
			{
				connectedServerRef.LastFocusTime = DateTime.Now;
				if (ServerTree.Instance.SortGroup(ConnectedGroup.Instance))
				{
					ServerTree.Instance.OnGroupChanged(ConnectedGroup.Instance, ChangeType.InvalidateUI);
				}
			}
		}

		private static void Server_ConnectionStateChanged(ConnectionStateChangedEventArgs args)
		{
			RdpClient.ConnectionState state = args.State;
			if (state != RdpClient.ConnectionState.Disconnected)
			{
				if (state == RdpClient.ConnectionState.Connected)
				{
					ConnectedGroup.Instance.AddReference(args.Server);
					return;
				}
			}
			else
			{
				RdcTreeNode rdcTreeNode = args.Server.FindServerRef<ConnectedServerRef>();
				if (rdcTreeNode != null)
				{
					ServerTree.Instance.RemoveNode(rdcTreeNode);
				}
			}
		}

		protected override bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return file == null;
		}

		public override bool CanRemoveChildren()
		{
			return false;
		}

		public override void Disconnect()
		{
			this.Hide();
			base.Disconnect();
		}

		public ServerRef Create(Server server)
		{
			return new ConnectedServerRef(server);
		}

		protected override string XmlNodeName
		{
			get
			{
				return "connected";
			}
		}
	}
}
