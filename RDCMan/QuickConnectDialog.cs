using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200004E RID: 78
	public partial class QuickConnectDialog : TabbedSettingsDialog
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00002AD8 File Offset: 0x00000CD8
		protected QuickConnectDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00002AE3 File Offset: 0x00000CE3
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002AEB File Offset: 0x00000CEB
		public QuickConnectTabPage QuickConnectTabPage { get; private set; }

		// Token: 0x06000142 RID: 322 RVA: 0x0000BF64 File Offset: 0x0000A164
		public void CreateControls(bool inputServerName, LogonCredentials logonCredentials, ConnectionSettings connectionSettings, FileGroup fileGroup)
		{
			this.QuickConnectTabPage = new QuickConnectTabPage(this, logonCredentials);
			this.QuickConnectTabPage.CreateControls(inputServerName, fileGroup);
			base.AddTabPage(this.QuickConnectTabPage);
			connectionSettings.InheritSettingsType.Mode = InheritanceMode.Disabled;
			base.AddTabPage(connectionSettings.CreateTabPage(this));
			this.InitButtons();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002AF4 File Offset: 0x00000CF4
		protected override void ShownCallback(object sender, EventArgs e)
		{
			base.ShownCallback(sender, e);
			this.QuickConnectTabPage.OnShown();
		}
	}
}
