using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000030 RID: 48
	public partial class QuickConnectDialog : TabbedSettingsDialog
	{
		// Token: 0x0600011E RID: 286 RVA: 0x000065F4 File Offset: 0x000047F4
		protected QuickConnectDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00006608 File Offset: 0x00004808
		public QuickConnectTabPage QuickConnectTabPage { get; private set; }

		// Token: 0x06000121 RID: 289 RVA: 0x00006614 File Offset: 0x00004814
		public void CreateControls(bool inputServerName, LogonCredentials logonCredentials, ConnectionSettings connectionSettings, FileGroup fileGroup)
		{
			this.QuickConnectTabPage = new QuickConnectTabPage(this, logonCredentials);
			this.QuickConnectTabPage.CreateControls(inputServerName, fileGroup);
			base.AddTabPage(this.QuickConnectTabPage);
			connectionSettings.InheritSettingsType.Mode = InheritanceMode.Disabled;
			base.AddTabPage(connectionSettings.CreateTabPage(this));
			this.InitButtons();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000666C File Offset: 0x0000486C
		protected override void ShownCallback(object sender, EventArgs e)
		{
			base.ShownCallback(sender, e);
			this.QuickConnectTabPage.OnShown();
		}
	}
}
