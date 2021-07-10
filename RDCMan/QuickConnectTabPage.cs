using System;

namespace RdcMan
{
	// Token: 0x0200007D RID: 125
	public class QuickConnectTabPage : LogonCredentialsTabPage
	{
		// Token: 0x06000248 RID: 584 RVA: 0x000034AA File Offset: 0x000016AA
		public QuickConnectTabPage(TabbedSettingsDialog dialog, LogonCredentials settings) : base(dialog, settings)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000034B4 File Offset: 0x000016B4
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000034BC File Offset: 0x000016BC
		public RdcTextBox ServerNameTextBox { get; private set; }

		// Token: 0x0600024B RID: 587 RVA: 0x00010B14 File Offset: 0x0000ED14
		public void CreateControls(bool serverName, FileGroup fileGroup)
		{
			int num = 0;
			int num2 = 0;
			if (serverName)
			{
				this.ServerNameTextBox = FormTools.AddLabeledTextBox(this, "&Server name:", ref num2, ref num);
				this.ServerNameTextBox.Enabled = true;
			}
			this._credentialsUI = new CredentialsUI(base.InheritanceControl);
			this._credentialsUI.AddControlsToParent(this, LogonCredentialsDialogOptions.ShowProfiles, ref num2, ref num);
			this._credentialsUI.PopulateCredentialsProfiles(fileGroup);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000034C5 File Offset: 0x000016C5
		public void OnShown()
		{
			if (this.ServerNameTextBox != null)
			{
				this.ServerNameTextBox.Focus();
				return;
			}
			this._credentialsUI.ProfileComboBox.Focus();
		}
	}
}
