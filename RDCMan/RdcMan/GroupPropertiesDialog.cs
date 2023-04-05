﻿using System;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class GroupPropertiesDialog : GroupBasePropertiesDialog
	{
		protected GroupPropertiesDialog(GroupBase group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		public override void CreateControls(RdcTreeNode settingsNode)
		{
			GroupPropertiesTabPage groupPropertiesTabPage = settingsNode.Properties.CreateTabPage(this) as GroupPropertiesTabPage;
			base.PropertiesPage = groupPropertiesTabPage;
			base.AddTabPage(groupPropertiesTabPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
			base.CreateControls(settingsNode);
		}

		public static GroupPropertiesDialog NewAddDialog(GroupBase parent)
		{
			Group group = Group.CreateForAddDialog();
			GroupPropertiesDialog groupPropertiesDialog = new GroupPropertiesDialog(group, "Add Group", "Add", null);
			groupPropertiesDialog.CreateControls(group);
			if (parent != null && !parent.CanAddGroups())
			{
				parent = null;
			}
			if (!groupPropertiesDialog.PropertiesPage.PopulateParentDropDown(null, parent))
			{
				groupPropertiesDialog.Dispose();
				return null;
			}
			return groupPropertiesDialog;
		}

		public static GroupPropertiesDialog NewPropertiesDialog(Group group, Form parentForm)
		{
			GroupPropertiesDialog groupPropertiesDialog = new GroupPropertiesDialog(group, group.Text + " Group Properties", "OK", parentForm);
			groupPropertiesDialog.CreateControls(group);
			groupPropertiesDialog.PropertiesPage.PopulateParentDropDown(group, group.Parent as GroupBase);
			return groupPropertiesDialog;
		}
	}
}
