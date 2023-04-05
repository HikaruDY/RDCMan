using System;

namespace RdcMan
{
	// Token: 0x0200004B RID: 75
	public abstract class CredentialsTabPage<TSettingGroup> : SettingsTabPage<TSettingGroup>, ICredentialsTabPage where TSettingGroup : LogonCredentials
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0000B61C File Offset: 0x0000981C
		protected CredentialsTabPage(TabbedSettingsDialog dialog, TSettingGroup settings) : base(dialog, settings)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000B628 File Offset: 0x00009828
		public CredentialsProfile Credentials
		{
			get
			{
				return this._credentialsUI.ProfileComboBox.SelectedValue;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000B63C File Offset: 0x0000983C
		public void PopulateCredentialsProfiles(FileGroup file)
		{
			if (this._credentialsUI != null)
			{
				this._credentialsUI.PopulateCredentialsProfiles(file);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000B658 File Offset: 0x00009858
		protected override void UpdateControls()
		{
			base.UpdateControls();
			if (this._credentialsUI != null)
			{
				this._credentialsUI.InitFromCredentials(base.Settings);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000B684 File Offset: 0x00009884
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

		// Token: 0x0400010F RID: 271
		protected CredentialsUI _credentialsUI;
	}
}
