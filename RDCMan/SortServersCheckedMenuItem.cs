using System;

namespace RdcMan
{
	// Token: 0x02000115 RID: 277
	internal class SortServersCheckedMenuItem : EnumMenuItem<SortOrder>
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x00006729 File Offset: 0x00004929
		public SortServersCheckedMenuItem(string text, SortOrder value) : base(text, value)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0000676B File Offset: 0x0000496B
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00006777 File Offset: 0x00004977
		protected override SortOrder Value
		{
			get
			{
				return Program.Preferences.ServerSortOrder;
			}
			set
			{
				Program.Preferences.ServerSortOrder = value;
				ServerTree.Instance.SortAllNodes();
				ServerTree.Instance.OnGroupChanged(ServerTree.Instance.RootNode, ChangeType.PropertyChanged);
			}
		}
	}
}
