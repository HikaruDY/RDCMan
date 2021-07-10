using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000071 RID: 113
	internal partial class ServerPropertiesDialog : NodePropertiesDialog
	{
		// Token: 0x0600020D RID: 525 RVA: 0x00002CE9 File Offset: 0x00000EE9
		private ServerPropertiesDialog(Server server, string dialogTitle, string acceptButtonText, Form parentForm) : base(server, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000FC44 File Offset: 0x0000DE44
		private void CreateServerPropertiesPage(RdcTreeNode settings)
		{
			ServerPropertiesTabPage serverPropertiesTabPage = settings.Properties.CreateTabPage(this) as ServerPropertiesTabPage;
			base.PropertiesPage = serverPropertiesTabPage;
			base.AddTabPage(serverPropertiesTabPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000FC88 File Offset: 0x0000DE88
		private void CreateImportServersPage(RdcTreeNode settings)
		{
			ImportServersPropertiesPage importServersPropertiesPage = new ImportServersPropertiesPage(this);
			base.PropertiesPage = importServersPropertiesPage;
			base.AddTabPage(importServersPropertiesPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000FCC4 File Offset: 0x0000DEC4
		public static ServerPropertiesDialog NewAddDialog(GroupBase parent)
		{
			Server server = Server.CreateForAddDialog();
			ServerPropertiesDialog serverPropertiesDialog = new ServerPropertiesDialog(server, "Add Server", "Add", null);
			serverPropertiesDialog.CreateServerPropertiesPage(server);
			serverPropertiesDialog.CreateControls(server);
			if (!serverPropertiesDialog.PropertiesPage.PopulateParentDropDown(null, parent))
			{
				serverPropertiesDialog.Dispose();
				return null;
			}
			return serverPropertiesDialog;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000FD10 File Offset: 0x0000DF10
		public static ServerPropertiesDialog NewImportDialog(GroupBase parent)
		{
			Server server = Server.CreateForAddDialog();
			ServerPropertiesDialog serverPropertiesDialog = new ServerPropertiesDialog(server, "Import Servers", "Import", null);
			serverPropertiesDialog.CreateImportServersPage(server);
			serverPropertiesDialog.CreateControls(server);
			if (!serverPropertiesDialog.PropertiesPage.PopulateParentDropDown(null, parent))
			{
				serverPropertiesDialog.Dispose();
				return null;
			}
			return serverPropertiesDialog;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000FD5C File Offset: 0x0000DF5C
		public static ServerPropertiesDialog NewPropertiesDialog(Server server, Form parentForm)
		{
			ServerPropertiesDialog serverPropertiesDialog = new ServerPropertiesDialog(server, server.DisplayName + " Server Properties", "OK", parentForm);
			serverPropertiesDialog.CreateServerPropertiesPage(server);
			serverPropertiesDialog.CreateControls(server);
			if (server.FileGroup == null)
			{
				serverPropertiesDialog.PropertiesPage.SetParentDropDown(server.Parent as GroupBase);
			}
			serverPropertiesDialog.PropertiesPage.PopulateParentDropDown(null, server.Parent as GroupBase);
			return serverPropertiesDialog;
		}
	}
}
