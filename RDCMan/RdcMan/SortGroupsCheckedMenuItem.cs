using System;

namespace RdcMan
{
	// Token: 0x020000A1 RID: 161
	internal class SortGroupsCheckedMenuItem : EnumMenuItem<SortOrder>
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x0001ABE4 File Offset: 0x00018DE4
		public SortGroupsCheckedMenuItem(string text, SortOrder value) : base(text, value)
		{
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001ABF0 File Offset: 0x00018DF0
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0001ABFC File Offset: 0x00018DFC
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
