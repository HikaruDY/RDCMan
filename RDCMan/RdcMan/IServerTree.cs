using System;

namespace RdcMan
{
	// Token: 0x0200005F RID: 95
	public interface IServerTree
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600026C RID: 620
		GroupBase RootNode { get; }

		// Token: 0x0600026D RID: 621
		void AddNode(RdcTreeNode node, GroupBase parent);

		// Token: 0x0600026E RID: 622
		void RemoveNode(RdcTreeNode node);
	}
}
