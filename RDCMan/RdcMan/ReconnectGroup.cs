using System;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200007A RID: 122
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ReconnectGroup : BuiltInVirtualGroup<ReconnectServerRef>, IServerRefFactory
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00014220 File Offset: 0x00012420
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00014228 File Offset: 0x00012428
		public static ReconnectGroup Instance { get; private set; }

		// Token: 0x060003C5 RID: 965 RVA: 0x00014230 File Offset: 0x00012430
		private ReconnectGroup()
		{
			base.Text = "Reconnect";
			ReconnectGroup.Instance = this;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0001424C File Offset: 0x0001244C
		public override bool CanDropServers()
		{
			return true;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00014250 File Offset: 0x00012450
		public override DragDropEffects DropBehavior()
		{
			return DragDropEffects.Copy;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00014254 File Offset: 0x00012454
		public override bool HandleMove(RdcTreeNode childNode)
		{
			ReconnectServerRef reconnectServerRef = this.AddReference(childNode as ServerBase);
			reconnectServerRef.Start(false);
			return true;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001427C File Offset: 0x0001247C
		public ServerRef Create(Server server)
		{
			return new ReconnectServerRef(server);
		}
	}
}
