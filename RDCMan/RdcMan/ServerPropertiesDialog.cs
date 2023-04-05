using System;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class ServerPropertiesDialog : NodePropertiesDialog
	{
		private ServerPropertiesDialog(Server server, string dialogTitle, string acceptButtonText, Form parentForm) : base(server, dialogTitle, acceptButtonText, parentForm)
		{
		}

		private void CreateServerPropertiesPage(RdcTreeNode settings)
		{
			ServerPropertiesTabPage serverPropertiesTabPage = settings.Properties.CreateTabPage(this) as ServerPropertiesTabPage;
			base.PropertiesPage = serverPropertiesTabPage;
			base.AddTabPage(serverPropertiesTabPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
		}

		private void CreateImportServersPage(RdcTreeNode settings)
		{
			ImportServersPropertiesPage importServersPropertiesPage = new ImportServersPropertiesPage(this);
			base.PropertiesPage = importServersPropertiesPage;
			base.AddTabPage(importServersPropertiesPage);
			base.PropertiesPage.ParentGroupChanged += base.PopulateCredentialsProfiles;
		}

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
