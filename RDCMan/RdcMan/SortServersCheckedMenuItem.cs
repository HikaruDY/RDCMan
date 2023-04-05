using System;

namespace RdcMan
{
	internal class SortServersCheckedMenuItem : EnumMenuItem<SortOrder>
	{
		public SortServersCheckedMenuItem(string text, SortOrder value) : base(text, value)
		{
		}

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
