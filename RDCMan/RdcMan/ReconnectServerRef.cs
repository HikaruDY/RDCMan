using System;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200007B RID: 123
	internal class ReconnectServerRef : ServerRef
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00014284 File Offset: 0x00012484
		// (set) Token: 0x060003CB RID: 971 RVA: 0x0001428C File Offset: 0x0001248C
		public bool NeedToReconnect { get; private set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00014298 File Offset: 0x00012498
		// (set) Token: 0x060003CD RID: 973 RVA: 0x000142A0 File Offset: 0x000124A0
		private bool RemoveAfterConnection { get; set; }

		// Token: 0x060003CE RID: 974 RVA: 0x000142AC File Offset: 0x000124AC
		static ReconnectServerRef()
		{
			Server.ConnectionStateChanged += ReconnectServerRef.Server_ConnectionStateChanged;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000142C0 File Offset: 0x000124C0
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

		// Token: 0x060003D0 RID: 976 RVA: 0x00014314 File Offset: 0x00012514
		public ReconnectServerRef(Server server) : base(server)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00014320 File Offset: 0x00012520
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

		// Token: 0x060003D2 RID: 978 RVA: 0x000143A0 File Offset: 0x000125A0
		public override bool CanRemove(bool popUI)
		{
			return true;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000143A4 File Offset: 0x000125A4
		public override void Reconnect()
		{
			this.NeedToReconnect = true;
			this.ServerNode.Disconnect();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000143B8 File Offset: 0x000125B8
		public override void Disconnect()
		{
			this.NeedToReconnect = false;
			base.Disconnect();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000143C8 File Offset: 0x000125C8
		public override void LogOff()
		{
			this.NeedToReconnect = false;
			base.LogOff();
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000143D8 File Offset: 0x000125D8
		private void OnConnecting()
		{
			if (this.RemoveAfterConnection)
			{
				this.NeedToReconnect = false;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000143EC File Offset: 0x000125EC
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

		// Token: 0x060003D8 RID: 984 RVA: 0x00014474 File Offset: 0x00012674
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

		// Token: 0x040001AF RID: 431
		private bool _selectedInConnectedGroup;
	}
}
