using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000061 RID: 97
	internal partial class FileGroupPropertiesDialog : GroupBasePropertiesDialog
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00002D7F File Offset: 0x00000F7F
		protected FileGroupPropertiesDialog(FileGroup group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000E374 File Offset: 0x0000C574
		public static FileGroupPropertiesDialog NewPropertiesDialog(FileGroup group, Form parentForm)
		{
			FileGroupPropertiesDialog fileGroupPropertiesDialog = new FileGroupPropertiesDialog(group, group.Text + " File Properties", "OK", parentForm);
			fileGroupPropertiesDialog.CreateControls(group);
			return fileGroupPropertiesDialog;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		public override void CreateControls(RdcTreeNode settings)
		{
			FileGroupPropertiesTabPage fileGroupPropertiesTabPage = settings.Properties.CreateTabPage(this) as FileGroupPropertiesTabPage;
			base.PropertiesPage = fileGroupPropertiesTabPage;
			base.AddTabPage(fileGroupPropertiesTabPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
			base.CreateControls(settings);
			base.AddTabPage(settings.EncryptionSettings.CreateTabPage(this));
			base.CreateProfileManagementTabPage();
			base.PopulateCredentialsProfiles(base.AssociatedNode as FileGroup);
			base.PopulateCredentialsManagementTab((base.AssociatedNode as FileGroup).CredentialsProfiles);
		}
	}
}
