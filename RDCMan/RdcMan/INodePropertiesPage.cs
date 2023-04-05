using System;

namespace RdcMan
{
	// Token: 0x02000057 RID: 87
	public interface INodePropertiesPage
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600021B RID: 539
		// (remove) Token: 0x0600021C RID: 540
		event Action<GroupBase> ParentGroupChanged;

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600021D RID: 541
		GroupBase ParentGroup { get; }

		// Token: 0x0600021E RID: 542
		bool PopulateParentDropDown(GroupBase excludeGroup, GroupBase defaultParent);

		// Token: 0x0600021F RID: 543
		void SetParentDropDown(GroupBase group);
	}
}
