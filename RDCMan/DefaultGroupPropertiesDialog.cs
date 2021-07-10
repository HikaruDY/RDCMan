using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200005E RID: 94
	internal partial class DefaultGroupPropertiesDialog : GroupBasePropertiesDialog
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00002D49 File Offset: 0x00000F49
		protected DefaultGroupPropertiesDialog(GroupBase group, Form parentForm) : base(group, "Default Settings Group Properties", "OK", parentForm)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000E200 File Offset: 0x0000C400
		public static DefaultGroupPropertiesDialog NewPropertiesDialog(GroupBase group, Form parentForm)
		{
			DefaultGroupPropertiesDialog defaultGroupPropertiesDialog = new DefaultGroupPropertiesDialog(group, parentForm);
			defaultGroupPropertiesDialog.CreateControls(group);
			defaultGroupPropertiesDialog.PopulateCredentialsProfiles(null);
			defaultGroupPropertiesDialog.PopulateCredentialsManagementTab(Program.CredentialsProfiles);
			return defaultGroupPropertiesDialog;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002D5D File Offset: 0x00000F5D
		public override void CreateControls(RdcTreeNode settingsNode)
		{
			base.CreateControls(settingsNode);
			base.AddTabPage(settingsNode.EncryptionSettings.CreateTabPage(this));
			base.CreateProfileManagementTabPage();
		}
	}
}
