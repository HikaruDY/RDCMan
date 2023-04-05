using System;

namespace RdcMan
{
	// Token: 0x02000036 RID: 54
	internal class GroupPropertiesTabPage : GroupBasePropertiesTabPage<GroupSettings>
	{
		// Token: 0x0600014E RID: 334 RVA: 0x000083F0 File Offset: 0x000065F0
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
