using System;
using System.Collections;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000063 RID: 99
	public class SessionListSortComparer : IComparer
	{
		// Token: 0x06000289 RID: 649 RVA: 0x0000EA24 File Offset: 0x0000CC24
		public SessionListSortComparer(int[] sortOrder)
		{
			this._sortOrder = sortOrder;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000EA34 File Offset: 0x0000CC34
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

		// Token: 0x04000150 RID: 336
		private readonly int[] _sortOrder;
	}
}
