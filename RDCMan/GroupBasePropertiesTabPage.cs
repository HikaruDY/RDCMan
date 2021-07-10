using System;

namespace RdcMan
{
	// Token: 0x02000059 RID: 89
	internal class GroupBasePropertiesTabPage<TSettingsGroup> : NodePropertiesPage<TSettingsGroup> where TSettingsGroup : GroupSettings
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00002CD6 File Offset: 0x00000ED6
		protected GroupBasePropertiesTabPage(TabbedSettingsDialog dialog, TSettingsGroup settings, string name) : base(dialog, settings, name)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000DA20 File Offset: 0x0000BC20
		protected void AddGroupName(ref int rowIndex, ref int tabIndex)
		{
			this._groupNameTextBox = FormTools.AddLabeledTextBox(this, "&Group name:", base.Settings.GroupName, ref rowIndex, ref tabIndex);
			this._groupNameTextBox.Enabled = true;
			this._groupNameTextBox.Validate = delegate()
			{
				this._groupNameTextBox.Text = this._groupNameTextBox.Text.Trim();
				string text = this._groupNameTextBox.Text;
				if (text.Length == 0)
				{
					return "Please enter a group name";
				}
				string pathSeparator = ServerTree.Instance.PathSeparator;
				if (text.IndexOf(pathSeparator) != -1)
				{
					return "Group name may not contain the path separator \"" + pathSeparator + "\"";
				}
				return null;
			};
			base.FocusControl = this._groupNameTextBox;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002CE1 File Offset: 0x00000EE1
		protected override bool CanBeParent(GroupBase group)
		{
			return group.CanAddGroups();
		}

		// Token: 0x040002D7 RID: 727
		private RdcTextBox _groupNameTextBox;
	}
}
