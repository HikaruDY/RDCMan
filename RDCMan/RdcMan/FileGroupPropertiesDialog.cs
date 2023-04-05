using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200003B RID: 59
	internal partial class FileGroupPropertiesDialog : GroupBasePropertiesDialog
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00008D0C File Offset: 0x00006F0C
		protected FileGroupPropertiesDialog(FileGroup group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00008D1C File Offset: 0x00006F1C
		public static FileGroupPropertiesDialog NewPropertiesDialog(FileGroup group, Form parentForm)
		{
			FileGroupPropertiesDialog fileGroupPropertiesDialog = new FileGroupPropertiesDialog(group, group.Text + " File Properties", "OK", parentForm);
			fileGroupPropertiesDialog.CreateControls(group);
			return fileGroupPropertiesDialog;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00008D54 File Offset: 0x00006F54
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
