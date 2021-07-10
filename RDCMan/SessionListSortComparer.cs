using System;
using System.Collections;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200009C RID: 156
	public class SessionListSortComparer : IComparer
	{
		// Token: 0x0600030E RID: 782 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public SessionListSortComparer(int[] sortOrder)
		{
			this._sortOrder = sortOrder;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00013570 File Offset: 0x00011770
		public int Compare(object obj1, object obj2)
		{
			ListViewItem listViewItem = obj1 as ListViewItem;
			ListViewItem listViewItem2 = obj2 as ListViewItem;
			foreach (int index in this._sortOrder)
			{
				int num = string.Compare(listViewItem.SubItems[index].Text, listViewItem2.SubItems[index].Text);
				if (num != 0)
				{
					return num;
				}
			}
			return string.Compare(listViewItem.SubItems[0].Text, listViewItem2.SubItems[0].Text);
		}

		// Token: 0x04000376 RID: 886
		private readonly int[] _sortOrder;
	}
}
