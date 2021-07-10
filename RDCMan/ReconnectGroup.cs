using System;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000CC RID: 204
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ReconnectGroup : BuiltInVirtualGroup<ReconnectServerRef>, IServerRefFactory
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00004BFF File Offset: 0x00002DFF
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00004C06 File Offset: 0x00002E06
		public static ReconnectGroup Instance { get; private set; }

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004C0E File Offset: 0x00002E0E
		private ReconnectGroup()
		{
			base.Text = "Reconnect";
			ReconnectGroup.Instance = this;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000044A3 File Offset: 0x000026A3
		public override bool CanDropServers()
		{
			return true;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000044A3 File Offset: 0x000026A3
		public override DragDropEffects DropBehavior()
		{
			return DragDropEffects.Copy;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00017DB8 File Offset: 0x00015FB8
		public override bool HandleMove(RdcTreeNode childNode)
		{
			ReconnectServerRef reconnectServerRef = this.AddReference(childNode as ServerBase);
			reconnectServerRef.Start(false);
			return true;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00004C27 File Offset: 0x00002E27
		public ServerRef Create(Server server)
		{
			return new ReconnectServerRef(server);
		}
	}
}
