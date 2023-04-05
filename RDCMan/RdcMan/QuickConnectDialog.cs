using System;
using System.Windows.Forms;

namespace RdcMan
{
	public partial class QuickConnectDialog : TabbedSettingsDialog
	{
		protected QuickConnectDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		public QuickConnectTabPage QuickConnectTabPage { get; private set; }

		public void CreateControls(bool inputServerName, LogonCredentials logonCredentials, ConnectionSettings connectionSettings, FileGroup fileGroup)
		{
			this.QuickConnectTabPage = new QuickConnectTabPage(this, logonCredentials);
			this.QuickConnectTabPage.CreateControls(inputServerName, fileGroup);
			base.AddTabPage(this.QuickConnectTabPage);
			connectionSettings.InheritSettingsType.Mode = InheritanceMode.Disabled;
			base.AddTabPage(connectionSettings.CreateTabPage(this));
			this.InitButtons();
		}

		protected override void ShownCallback(object sender, EventArgs e)
		{
			base.ShownCallback(sender, e);
			this.QuickConnectTabPage.OnShown();
		}
	}
}
