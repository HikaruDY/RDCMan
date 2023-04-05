using System;

namespace RdcMan
{
	public interface INodePropertiesPage
	{
		event Action<GroupBase> ParentGroupChanged;

		GroupBase ParentGroup { get; }

		bool PopulateParentDropDown(GroupBase excludeGroup, GroupBase defaultParent);

		void SetParentDropDown(GroupBase group);
	}
}
