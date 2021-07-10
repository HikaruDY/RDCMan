using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200005F RID: 95
	internal partial class GroupPropertiesDialog : GroupBasePropertiesDialog
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00002D7F File Offset: 0x00000F7F
		protected GroupPropertiesDialog(GroupBase group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000E230 File Offset: 0x0000C430
		public override void CreateControls(RdcTreeNode settingsNode)
		{
			GroupPropertiesTabPage groupPropertiesTabPage = settingsNode.Properties.CreateTabPage(this) as GroupPropertiesTabPage;
			base.PropertiesPage = groupPropertiesTabPage;
			base.AddTabPage(groupPropertiesTabPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
			base.CreateControls(settingsNode);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000E27C File Offset: 0x0000C47C
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

		// Token: 0x06000199 RID: 409 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
		public static GroupPropertiesDialog NewPropertiesDialog(Group group, Form parentForm)
		{
			GroupPropertiesDialog groupPropertiesDialog = new GroupPropertiesDialog(group, group.Text + " Group Properties", "OK", parentForm);
			groupPropertiesDialog.CreateControls(group);
			groupPropertiesDialog.PropertiesPage.PopulateParentDropDown(group, group.Parent as GroupBase);
			return groupPropertiesDialog;
		}
	}
}
