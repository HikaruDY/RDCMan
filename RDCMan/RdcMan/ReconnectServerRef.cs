using System;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	internal class ReconnectServerRef : ServerRef
	{
		public bool NeedToReconnect { get; private set; }

		private bool RemoveAfterConnection { get; set; }

		static ReconnectServerRef()
		{
			Server.ConnectionStateChanged += ReconnectServerRef.Server_ConnectionStateChanged;
		}

		private static void Server_ConnectionStateChanged(ConnectionStateChangedEventArgs args)
		{
			ReconnectServerRef reconnectServerRef = args.Server.FindServerRef<ReconnectServerRef>();
			if (reconnectServerRef == null)
			{
				return;
			}
			switch (args.State)
			{
			case RdpClient.ConnectionState.Disconnected:
				reconnectServerRef.OnDisconnected();
				return;
			case RdpClient.ConnectionState.Connecting:
				reconnectServerRef.OnConnecting();
				return;
			case RdpClient.ConnectionState.Connected:
				reconnectServerRef.OnConnected();
				return;
			default:
				return;
			}
		}

		public ReconnectServerRef(Server server) : base(server)
		{
		}

		public void Start(bool removeAfterConnection)
		{
			this.RemoveAfterConnection = removeAfterConnection;
			this.NeedToReconnect = true;
			ConnectedServerRef connectedServerRef = this.ServerNode.FindServerRef<ConnectedServerRef>();
			if (connectedServerRef != null)
			{
				this._selectedInConnectedGroup = connectedServerRef.IsSelected;
				if (this._selectedInConnectedGroup)
				{
					ServerTree.Instance.SelectedNode = this.ServerNode;
				}
			}
			if (!this.ServerNode.IsConnected)
			{
				this.ServerNode.Connect();
				return;
			}
			this.ServerNode.Disconnect();
		}

		public override bool CanRemove(bool popUI)
		{
			return true;
		}

		public override void Reconnect()
		{
			this.NeedToReconnect = true;
			this.ServerNode.Disconnect();
		}

		public override void Disconnect()
		{
			this.NeedToReconnect = false;
			base.Disconnect();
		}

		public override void LogOff()
		{
			this.NeedToReconnect = false;
			base.LogOff();
		}

		private void OnConnecting()
		{
			if (this.RemoveAfterConnection)
			{
				this.NeedToReconnect = false;
			}
		}

		private void OnConnected()
		{
			this.NeedToReconnect = false;
			if (this.RemoveAfterConnection)
			{
				if (ServerTree.Instance.SelectedNode == this)
				{
					ServerTree.Instance.SelectedNode = this.ServerNode;
				}
				else if (this._selectedInConnectedGroup && ServerTree.Instance.SelectedNode == this.ServerNode)
				{
					ServerTree.Instance.SelectedNode = this.ServerNode.FindServerRef<ConnectedServerRef>();
				}
				ServerTree.Instance.RemoveNode(this);
			}
		}

		private void OnDisconnected()
		{
			if (this.NeedToReconnect)
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.ServerNode.ParentForm.Invoke(new MethodInvoker(delegate()
					{
						this.ServerNode.Connect();
					}));
				});
				return;
			}
			ServerTree.Instance.RemoveNode(this);
		}

		private bool _selectedInConnectedGroup;
	}
}
