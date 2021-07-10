using System;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000CD RID: 205
	internal class ReconnectServerRef : ServerRef
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00004C2F File Offset: 0x00002E2F
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00004C37 File Offset: 0x00002E37
		public bool NeedToReconnect { get; private set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00004C40 File Offset: 0x00002E40
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00004C48 File Offset: 0x00002E48
		private bool RemoveAfterConnection { get; set; }

		// Token: 0x060004D0 RID: 1232 RVA: 0x00004C51 File Offset: 0x00002E51
		static ReconnectServerRef()
		{
			Server.ConnectionStateChanged += ReconnectServerRef.Server_ConnectionStateChanged;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00017DDC File Offset: 0x00015FDC
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

		// Token: 0x060004D2 RID: 1234 RVA: 0x00004596 File Offset: 0x00002796
		public ReconnectServerRef(Server server) : base(server)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00017E28 File Offset: 0x00016028
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

		// Token: 0x060004D4 RID: 1236 RVA: 0x000044A3 File Offset: 0x000026A3
		public override bool CanRemove(bool popUI)
		{
			return true;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00004C64 File Offset: 0x00002E64
		public override void Reconnect()
		{
			this.NeedToReconnect = true;
			this.ServerNode.Disconnect();
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00004C78 File Offset: 0x00002E78
		public override void Disconnect()
		{
			this.NeedToReconnect = false;
			base.Disconnect();
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00004C87 File Offset: 0x00002E87
		public override void LogOff()
		{
			this.NeedToReconnect = false;
			base.LogOff();
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00004C96 File Offset: 0x00002E96
		private void OnConnecting()
		{
			if (this.RemoveAfterConnection)
			{
				this.NeedToReconnect = false;
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00017E9C File Offset: 0x0001609C
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

		// Token: 0x060004DA RID: 1242 RVA: 0x00004CA7 File Offset: 0x00002EA7
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

		// Token: 0x0400043B RID: 1083
		private bool _selectedInConnectedGroup;
	}
}
