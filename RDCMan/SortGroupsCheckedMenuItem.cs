using System;

namespace RdcMan
{
	// Token: 0x02000114 RID: 276
	internal class SortGroupsCheckedMenuItem : EnumMenuItem<SortOrder>
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x00006729 File Offset: 0x00004929
		public SortGroupsCheckedMenuItem(string text, SortOrder value) : base(text, value)
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00006733 File Offset: 0x00004933
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0000673F File Offset: 0x0000493F
		protected override SortOrder Value
		{
			get
			{
				return Program.Preferences.GroupSortOrder;
			}
			set
			{
				Program.Preferences.GroupSortOrder = value;
				ServerTree.Instance.SortAllNodes();
				ServerTree.Instance.OnGroupChanged(ServerTree.Instance.RootNode, ChangeType.PropertyChanged);
			}
		}
	}
}
