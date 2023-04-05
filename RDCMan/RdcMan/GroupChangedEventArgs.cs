using System;

namespace RdcMan
{
	public class GroupChangedEventArgs : EventArgs
	{
		public GroupChangedEventArgs(GroupBase group, ChangeType changeType)
		{
			this.Group = group;
			this.ChangeType = changeType;
		}

		public GroupBase Group { get; private set; }

		public ChangeType ChangeType { get; private set; }
	}
}
