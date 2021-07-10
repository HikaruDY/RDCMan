using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	// Token: 0x020000BA RID: 186
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ConnectedGroup : BuiltInVirtualGroup<ConnectedServerRef>, IServerRefFactory
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00004516 File Offset: 0x00002716
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x0000451D File Offset: 0x0000271D
		public static ConnectedGroup Instance { get; private set; }

		// Token: 0x06000426 RID: 1062 RVA: 0x00004525 File Offset: 0x00002725
		static ConnectedGroup()
		{
			Server.ConnectionStateChanged += ConnectedGroup.Server_ConnectionStateChanged;
			Server.FocusReceived += ConnectedGroup.Server_FocusReceived;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00004549 File Offset: 0x00002749
		private ConnectedGroup()
		{
			base.Text = "Connected";
			ConnectedGroup.Instance = this;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00016D60 File Offset: 0x00014F60
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

		// Token: 0x06000429 RID: 1065 RVA: 0x00016DA4 File Offset: 0x00014FA4
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

		// Token: 0x0600042A RID: 1066 RVA: 0x00004562 File Offset: 0x00002762
		protected override bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return file == null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00004460 File Offset: 0x00002660
		public override bool CanRemoveChildren()
		{
			return false;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00004568 File Offset: 0x00002768
		public override void Disconnect()
		{
			this.Hide();
			base.Disconnect();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00004576 File Offset: 0x00002776
		public ServerRef Create(Server server)
		{
			return new ConnectedServerRef(server);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000457E File Offset: 0x0000277E
		protected override string XmlNodeName
		{
			get
			{
				return "connected";
			}
		}
	}
}
