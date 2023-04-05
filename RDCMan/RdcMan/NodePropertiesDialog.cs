using System;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200003D RID: 61
	public abstract partial class NodePropertiesDialog : TabbedSettingsDialog
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00008F28 File Offset: 0x00007128
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00008F30 File Offset: 0x00007130
		public RdcTreeNode AssociatedNode { get; private set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00008F3C File Offset: 0x0000713C
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00008F44 File Offset: 0x00007144
		public INodePropertiesPage PropertiesPage { get; protected set; }

		// Token: 0x06000176 RID: 374 RVA: 0x00008F50 File Offset: 0x00007150
		public override void InitButtons()
		{
			base.InitButtons();
			if (this.AssociatedNode != null)
			{
				this._acceptButton.Enabled = this.AssociatedNode.AllowEdit(true);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008F8C File Offset: 0x0000718C
		protected NodePropertiesDialog(RdcTreeNode associatedNode, string dialogTitle, string acceptButtonText, Form parentForm) : base(dialogTitle, acceptButtonText, parentForm)
		{
			this.AssociatedNode = associatedNode;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008FA0 File Offset: 0x000071A0
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

		// Token: 0x06000179 RID: 377 RVA: 0x0000909C File Offset: 0x0000729C
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
