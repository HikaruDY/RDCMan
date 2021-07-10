using System;

namespace RdcMan
{
	// Token: 0x02000155 RID: 341
	public class GroupChangedEventArgs : EventArgs
	{
		// Token: 0x0600084A RID: 2122 RVA: 0x00007391 File Offset: 0x00005591
		public GroupChangedEventArgs(GroupBase group, ChangeType changeType)
		{
			this.Group = group;
			this.ChangeType = changeType;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x000073A7 File Offset: 0x000055A7
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x000073AF File Offset: 0x000055AF
		public GroupBase Group { get; private set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x000073B8 File Offset: 0x000055B8
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x000073C0 File Offset: 0x000055C0
		public ChangeType ChangeType { get; private set; }
	}
}
