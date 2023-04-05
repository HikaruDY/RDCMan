using System;

namespace RdcMan
{
	// Token: 0x020000BF RID: 191
	public class GroupChangedEventArgs : EventArgs
	{
		// Token: 0x060006A9 RID: 1705 RVA: 0x00020948 File Offset: 0x0001EB48
		public GroupChangedEventArgs(GroupBase group, ChangeType changeType)
		{
			this.Group = group;
			this.ChangeType = changeType;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00020960 File Offset: 0x0001EB60
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00020968 File Offset: 0x0001EB68
		public GroupBase Group { get; private set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00020974 File Offset: 0x0001EB74
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x0002097C File Offset: 0x0001EB7C
		public ChangeType ChangeType { get; private set; }
	}
}
