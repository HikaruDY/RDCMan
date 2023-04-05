using System;

namespace RdcMan
{
	// Token: 0x0200004D RID: 77
	public class QuickConnectTabPage : LogonCredentialsTabPage
	{
		// Token: 0x060001DC RID: 476 RVA: 0x0000B7E0 File Offset: 0x000099E0
		public QuickConnectTabPage(TabbedSettingsDialog dialog, LogonCredentials settings) : base(dialog, settings)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000B7EC File Offset: 0x000099EC
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000B7F4 File Offset: 0x000099F4
		public RdcTextBox ServerNameTextBox { get; private set; }

		// Token: 0x060001DF RID: 479 RVA: 0x0000B800 File Offset: 0x00009A00
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

		// Token: 0x060001E0 RID: 480 RVA: 0x0000B86C File Offset: 0x00009A6C
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
