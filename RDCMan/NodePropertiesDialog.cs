using System;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000063 RID: 99
	public abstract partial class NodePropertiesDialog : TabbedSettingsDialog
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002E72 File Offset: 0x00001072
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002E7A File Offset: 0x0000107A
		public RdcTreeNode AssociatedNode { get; private set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002E83 File Offset: 0x00001083
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002E8B File Offset: 0x0000108B
		public INodePropertiesPage PropertiesPage { get; protected set; }

		// Token: 0x060001AD RID: 429 RVA: 0x00002E94 File Offset: 0x00001094
		public override void InitButtons()
		{
			base.InitButtons();
			if (this.AssociatedNode != null)
			{
				this._acceptButton.Enabled = this.AssociatedNode.AllowEdit(true);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002EBB File Offset: 0x000010BB
		protected NodePropertiesDialog(RdcTreeNode associatedNode, string dialogTitle, string acceptButtonText, Form parentForm) : base(dialogTitle, acceptButtonText, parentForm)
		{
			this.AssociatedNode = associatedNode;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
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

		// Token: 0x060001B0 RID: 432 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
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
