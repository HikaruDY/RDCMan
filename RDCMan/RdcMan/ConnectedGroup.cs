using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	// Token: 0x02000070 RID: 112
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ConnectedGroup : BuiltInVirtualGroup<ConnectedServerRef>, IServerRefFactory
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00012BF4 File Offset: 0x00010DF4
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00012BFC File Offset: 0x00010DFC
		public static ConnectedGroup Instance { get; private set; }

		// Token: 0x06000347 RID: 839 RVA: 0x00012C04 File Offset: 0x00010E04
		static ConnectedGroup()
		{
			Server.ConnectionStateChanged += ConnectedGroup.Server_ConnectionStateChanged;
			Server.FocusReceived += ConnectedGroup.Server_FocusReceived;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00012C28 File Offset: 0x00010E28
		private ConnectedGroup()
		{
			base.Text = "Connected";
			ConnectedGroup.Instance = this;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00012C44 File Offset: 0x00010E44
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

		// Token: 0x0600034A RID: 842 RVA: 0x00012C94 File Offset: 0x00010E94
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

		// Token: 0x0600034B RID: 843 RVA: 0x00012CE8 File Offset: 0x00010EE8
		protected override bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return file == null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00012CF0 File Offset: 0x00010EF0
		public override bool CanRemoveChildren()
		{
			return false;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00012CF4 File Offset: 0x00010EF4
		public override void Disconnect()
		{
			this.Hide();
			base.Disconnect();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00012D04 File Offset: 0x00010F04
		public ServerRef Create(Server server)
		{
			return new ConnectedServerRef(server);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00012D0C File Offset: 0x00010F0C
		protected override string XmlNodeName
		{
			get
			{
				return "connected";
			}
		}
	}
}
