using System;

namespace RdcMan
{
	public abstract class CredentialsTabPage<TSettingGroup> : SettingsTabPage<TSettingGroup>, ICredentialsTabPage where TSettingGroup : LogonCredentials
	{
		protected CredentialsTabPage(TabbedSettingsDialog dialog, TSettingGroup settings) : base(dialog, settings)
		{
		}

		public CredentialsProfile Credentials
		{
			get
			{
				return this._credentialsUI.ProfileComboBox.SelectedValue;
			}
		}

		public void PopulateCredentialsProfiles(FileGroup file)
		{
			if (this._credentialsUI != null)
			{
				this._credentialsUI.PopulateCredentialsProfiles(file);
			}
		}

		protected override void UpdateControls()
		{
			base.UpdateControls();
			if (this._credentialsUI != null)
			{
				this._credentialsUI.InitFromCredentials(base.Settings);
			}
		}

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

		protected CredentialsUI _credentialsUI;
	}
}
