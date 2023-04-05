using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000045 RID: 69
	internal partial class ServerPropertiesDialog : NodePropertiesDialog
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		private ServerPropertiesDialog(Server server, string dialogTitle, string acceptButtonText, Form parentForm) : base(server, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		private void CreateServerPropertiesPage(RdcTreeNode settings)
		{
			ServerPropertiesTabPage serverPropertiesTabPage = settings.Properties.CreateTabPage(this) as ServerPropertiesTabPage;
			base.PropertiesPage = serverPropertiesTabPage;
			base.AddTabPage(serverPropertiesTabPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000A9FC File Offset: 0x00008BFC
		private void CreateImportServersPage(RdcTreeNode settings)
		{
			ImportServersPropertiesPage importServersPropertiesPage = new ImportServersPropertiesPage(this);
			base.PropertiesPage = importServersPropertiesPage;
			base.AddTabPage(importServersPropertiesPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000AA3C File Offset: 0x00008C3C
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

		// Token: 0x060001BC RID: 444 RVA: 0x0000AA90 File Offset: 0x00008C90
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

		// Token: 0x060001BD RID: 445 RVA: 0x0000AAE4 File Offset: 0x00008CE4
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
