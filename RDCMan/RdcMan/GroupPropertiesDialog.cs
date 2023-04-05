using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000039 RID: 57
	internal partial class GroupPropertiesDialog : GroupBasePropertiesDialog
	{
		// Token: 0x0600015F RID: 351 RVA: 0x00008B58 File Offset: 0x00006D58
		protected GroupPropertiesDialog(GroupBase group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00008B68 File Offset: 0x00006D68
		public override void CreateControls(RdcTreeNode settingsNode)
		{
			GroupPropertiesTabPage groupPropertiesTabPage = settingsNode.Properties.CreateTabPage(this) as GroupPropertiesTabPage;
			base.PropertiesPage = groupPropertiesTabPage;
			base.AddTabPage(groupPropertiesTabPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
			base.CreateControls(settingsNode);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008BB8 File Offset: 0x00006DB8
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

		// Token: 0x06000162 RID: 354 RVA: 0x00008C18 File Offset: 0x00006E18
		public static GroupPropertiesDialog NewPropertiesDialog(Group group, Form parentForm)
		{
			GroupPropertiesDialog groupPropertiesDialog = new GroupPropertiesDialog(group, group.Text + " Group Properties", "OK", parentForm);
			groupPropertiesDialog.CreateControls(group);
			groupPropertiesDialog.PropertiesPage.PopulateParentDropDown(group, group.Parent as GroupBase);
			return groupPropertiesDialog;
		}
	}
}
