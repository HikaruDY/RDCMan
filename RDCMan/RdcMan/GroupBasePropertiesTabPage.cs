using System;

namespace RdcMan
{
	internal class GroupBasePropertiesTabPage<TSettingsGroup> : NodePropertiesPage<TSettingsGroup> where TSettingsGroup : GroupSettings
	{
		protected GroupBasePropertiesTabPage(TabbedSettingsDialog dialog, TSettingsGroup settings, string name) : base(dialog, settings, name)
		{
		}

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

		protected override bool CanBeParent(GroupBase group)
		{
			return group.CanAddGroups();
		}

		private RdcTextBox _groupNameTextBox;
	}
}
