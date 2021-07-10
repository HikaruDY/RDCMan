using System;

namespace RdcMan
{
	// Token: 0x02000095 RID: 149
	public interface IServerTree
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002E9 RID: 745
		GroupBase RootNode { get; }

		// Token: 0x060002EA RID: 746
		void AddNode(RdcTreeNode node, GroupBase parent);

		// Token: 0x060002EB RID: 747
		void RemoveNode(RdcTreeNode node);
	}
}
