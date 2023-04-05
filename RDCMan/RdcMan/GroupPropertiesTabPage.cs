using System;

namespace RdcMan
{
	internal class GroupPropertiesTabPage : GroupBasePropertiesTabPage<GroupSettings>
	{
		public GroupPropertiesTabPage(TabbedSettingsDialog dialog, GroupSettings settings) : base(dialog, settings, settings.Name)
		{
			int num = 0;
			int num2 = 0;
			base.AddGroupName(ref num, ref num2);
			base.AddParentCombo(ref num, ref num2);
			base.AddComment(ref num, ref num2).Setting = base.Settings.Comment;
		}
	}
}
