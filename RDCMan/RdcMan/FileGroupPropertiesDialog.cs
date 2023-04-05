using System;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class FileGroupPropertiesDialog : GroupBasePropertiesDialog
	{
		protected FileGroupPropertiesDialog(FileGroup group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		public static FileGroupPropertiesDialog NewPropertiesDialog(FileGroup group, Form parentForm)
		{
			FileGroupPropertiesDialog fileGroupPropertiesDialog = new FileGroupPropertiesDialog(group, group.Text + " File Properties", "OK", parentForm);
			fileGroupPropertiesDialog.CreateControls(group);
			return fileGroupPropertiesDialog;
		}

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
