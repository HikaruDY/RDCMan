using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000038 RID: 56
	internal partial class DefaultGroupPropertiesDialog : GroupBasePropertiesDialog
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00008ADC File Offset: 0x00006CDC
		protected DefaultGroupPropertiesDialog(GroupBase group, Form parentForm) : base(group, "Default Settings Group Properties", "OK", parentForm)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public static DefaultGroupPropertiesDialog NewPropertiesDialog(GroupBase group, Form parentForm)
		{
			DefaultGroupPropertiesDialog defaultGroupPropertiesDialog = new DefaultGroupPropertiesDialog(group, parentForm);
			defaultGroupPropertiesDialog.CreateControls(group);
			defaultGroupPropertiesDialog.PopulateCredentialsProfiles(null);
			defaultGroupPropertiesDialog.PopulateCredentialsManagementTab(Program.CredentialsProfiles);
			return defaultGroupPropertiesDialog;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00008B24 File Offset: 0x00006D24
		public override void CreateControls(RdcTreeNode settingsNode)
		{
			base.CreateControls(settingsNode);
			base.AddTabPage(settingsNode.EncryptionSettings.CreateTabPage(this));
			base.CreateProfileManagementTabPage();
		}
	}
}
