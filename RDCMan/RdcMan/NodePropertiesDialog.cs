using System;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	public abstract partial class NodePropertiesDialog : TabbedSettingsDialog
	{
		public RdcTreeNode AssociatedNode { get; private set; }

		public INodePropertiesPage PropertiesPage { get; protected set; }

		public override void InitButtons()
		{
			base.InitButtons();
			if (this.AssociatedNode != null)
			{
				this._acceptButton.Enabled = this.AssociatedNode.AllowEdit(true);
			}
		}

		protected NodePropertiesDialog(RdcTreeNode associatedNode, string dialogTitle, string acceptButtonText, Form parentForm) : base(dialogTitle, acceptButtonText, parentForm)
		{
			this.AssociatedNode = associatedNode;
		}

		public virtual void CreateControls(RdcTreeNode settings)
		{
			LogonCredentialsTabPage logonCredentialsTabPage = (LogonCredentialsTabPage)settings.LogonCredentials.CreateTabPage(this);
			LogonCredentialsDialogOptions logonCredentialsDialogOptions = LogonCredentialsDialogOptions.ShowProfiles;
			if (settings.LogonCredentials.InheritSettingsType.Mode != InheritanceMode.Disabled)
			{
				logonCredentialsDialogOptions |= LogonCredentialsDialogOptions.AllowInheritance;
			}
			logonCredentialsTabPage.CreateControls(logonCredentialsDialogOptions);
			base.AddTabPage(logonCredentialsTabPage);
			GatewaySettingsTabPage gatewaySettingsTabPage = (GatewaySettingsTabPage)settings.GatewaySettings.CreateTabPage(this);
			logonCredentialsDialogOptions = LogonCredentialsDialogOptions.ShowProfiles;
			if (settings.GatewaySettings.InheritSettingsType.Mode != InheritanceMode.Disabled)
			{
				logonCredentialsDialogOptions |= LogonCredentialsDialogOptions.AllowInheritance;
			}
			gatewaySettingsTabPage.CreateControls(logonCredentialsDialogOptions);
			base.AddTabPage(gatewaySettingsTabPage);
			base.AddTabPage(settings.ConnectionSettings.CreateTabPage(this));
			base.AddTabPage(settings.RemoteDesktopSettings.CreateTabPage(this));
			base.AddTabPage(settings.LocalResourceSettings.CreateTabPage(this));
			base.AddTabPage(settings.SecuritySettings.CreateTabPage(this));
			base.AddTabPage(settings.DisplaySettings.CreateTabPage(this));
			this.InitButtons();
			this.ScaleAndLayout();
			settings.InheritSettings();
			settings.ResolveCredentials();
		}

		protected void PopulateCredentialsProfiles(GroupBase group)
		{
			FileGroup file = (group != null) ? group.FileGroup : null;
			foreach (ICredentialsTabPage credentialsTabPage in base.TabPages.OfType<ICredentialsTabPage>())
			{
				credentialsTabPage.PopulateCredentialsProfiles(file);
			}
		}
	}
}
