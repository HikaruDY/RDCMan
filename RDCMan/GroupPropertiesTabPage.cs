using System;

namespace RdcMan
{
	// Token: 0x0200005A RID: 90
	internal class GroupPropertiesTabPage : GroupBasePropertiesTabPage<GroupSettings>
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0000DAEC File Offset: 0x0000BCEC
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
