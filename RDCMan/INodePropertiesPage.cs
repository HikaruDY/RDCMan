using System;

namespace RdcMan
{
	// Token: 0x02000088 RID: 136
	public interface INodePropertiesPage
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600028A RID: 650
		// (remove) Token: 0x0600028B RID: 651
		event Action<GroupBase> ParentGroupChanged;

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600028C RID: 652
		GroupBase ParentGroup { get; }

		// Token: 0x0600028D RID: 653
		bool PopulateParentDropDown(GroupBase excludeGroup, GroupBase defaultParent);

		// Token: 0x0600028E RID: 654
		void SetParentDropDown(GroupBase group);
	}
}
