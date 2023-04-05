using System;

namespace RdcMan
{
	// Token: 0x020000A2 RID: 162
	internal class SortServersCheckedMenuItem : EnumMenuItem<SortOrder>
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x0001AC28 File Offset: 0x00018E28
		public SortServersCheckedMenuItem(string text, SortOrder value) : base(text, value)
		{
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001AC34 File Offset: 0x00018E34
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0001AC40 File Offset: 0x00018E40
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
