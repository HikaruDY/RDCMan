using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	// Token: 0x020000B9 RID: 185
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ConnectToGroup : BuiltInVirtualGroup<ServerRef>, IServerRefFactory
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x000044C6 File Offset: 0x000026C6
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x000044CD File Offset: 0x000026CD
		public static ConnectToGroup Instance { get; private set; }

		// Token: 0x0600041F RID: 1055 RVA: 0x000044D5 File Offset: 0x000026D5
		private ConnectToGroup()
		{
			base.Text = "Connect To";
			ConnectToGroup.Instance = this;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002515 File Offset: 0x00000715
		public override ServerRef AddReference(ServerBase serverBase)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000044EE File Offset: 0x000026EE
		public override void InvalidateNode()
		{
			base.InvalidateNode();
			if (base.Nodes.Count == 0)
			{
				base.IsInTree = false;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000450A File Offset: 0x0000270A
		public ServerRef Create(Server server)
		{
			throw new NotImplementedException("ConnectTo does not contain ServerRef");
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00004460 File Offset: 0x00002660
		protected override bool IsVisibilityConfigurable
		{
			get
			{
				return false;
			}
		}
	}
}
