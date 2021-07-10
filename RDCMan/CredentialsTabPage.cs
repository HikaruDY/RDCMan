using System;

namespace RdcMan
{
	// Token: 0x0200007B RID: 123
	public abstract class CredentialsTabPage<TSettingGroup> : SettingsTabPage<TSettingGroup>, ICredentialsTabPage where TSettingGroup : LogonCredentials
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0000343A File Offset: 0x0000163A
		protected CredentialsTabPage(TabbedSettingsDialog dialog, TSettingGroup settings) : base(dialog, settings)
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00003444 File Offset: 0x00001644
		public CredentialsProfile Credentials
		{
			get
			{
				return this._credentialsUI.ProfileComboBox.SelectedValue;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003456 File Offset: 0x00001656
		public void PopulateCredentialsProfiles(FileGroup file)
		{
			if (this._credentialsUI != null)
			{
				this._credentialsUI.PopulateCredentialsProfiles(file);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000346C File Offset: 0x0000166C
		protected override void UpdateControls()
		{
			base.UpdateControls();
			if (this._credentialsUI != null)
			{
				this._credentialsUI.InitFromCredentials(base.Settings);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000109DC File Offset: 0x0000EBDC
		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			if (this._credentialsUI != null)
			{
				base.Settings.ProfileName.UpdateValue(this._credentialsUI.ProfileComboBox.SelectedValue.ProfileName, this._credentialsUI.ProfileComboBox.SelectedValue.ProfileScope);
				base.Settings.UserName.Value = this._credentialsUI.UserNameTextBox.Text;
				if (this._credentialsUI.PasswordChanged)
				{
					base.Settings.Password.SetPlainText(this._credentialsUI.PasswordTextBox.Text);
				}
				base.Settings.Domain.Value = this._credentialsUI.DomainTextBox.Text;
			}
		}

		// Token: 0x04000327 RID: 807
		protected CredentialsUI _credentialsUI;
	}
}
