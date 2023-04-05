using System;
using System.ComponentModel.Composition;

namespace RdcMan
{
	// Token: 0x0200006F RID: 111
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class ConnectToGroup : BuiltInVirtualGroup<ServerRef>, IServerRefFactory
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00012B90 File Offset: 0x00010D90
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00012B98 File Offset: 0x00010D98
		public static ConnectToGroup Instance { get; private set; }

		// Token: 0x06000340 RID: 832 RVA: 0x00012BA0 File Offset: 0x00010DA0
		private ConnectToGroup()
		{
			base.Text = "Connect To";
			ConnectToGroup.Instance = this;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00012BBC File Offset: 0x00010DBC
		public override ServerRef AddReference(ServerBase serverBase)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00012BC4 File Offset: 0x00010DC4
		public override void InvalidateNode()
		{
			base.InvalidateNode();
			if (base.Nodes.Count == 0)
			{
				base.IsInTree = false;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00012BE4 File Offset: 0x00010DE4
		public ServerRef Create(Server server)
		{
			throw new NotImplementedException("ConnectTo does not contain ServerRef");
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00012BF0 File Offset: 0x00010DF0
		protected override bool IsVisibilityConfigurable
		{
			get
			{
				return false;
			}
		}
	}
}
