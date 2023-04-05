using System;

namespace RdcMan
{
	// Token: 0x02000035 RID: 53
	internal class GroupBasePropertiesTabPage<TSettingsGroup> : NodePropertiesPage<TSettingsGroup> where TSettingsGroup : GroupSettings
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00008304 File Offset: 0x00006504
		protected GroupBasePropertiesTabPage(TabbedSettingsDialog dialog, TSettingsGroup settings, string name) : base(dialog, settings, name)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00008310 File Offset: 0x00006510
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

		// Token: 0x0600014C RID: 332 RVA: 0x00008374 File Offset: 0x00006574
		protected override bool CanBeParent(GroupBase group)
		{
			return group.CanAddGroups();
		}

		// Token: 0x040000E4 RID: 228
		private RdcTextBox _groupNameTextBox;
	}
}
