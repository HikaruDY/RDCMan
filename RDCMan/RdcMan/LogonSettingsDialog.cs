using System;

namespace RdcMan
{
	public partial class LogonSettingsDialog : RdcDialog
	{
		protected LogonSettingsDialog(string title, string buttonText) : base(title, buttonText, null)
		{
			base.SuspendLayout();
			this._logonCredentialsUI = new CredentialsUI(null);
		}

		public bool PasswordChanged
		{
			get
			{
				return this._logonCredentialsUI.PasswordChanged;
			}
		}

		public string ProfileName
		{
			get
			{
				return this._logonCredentialsUI.ProfileComboBox.SelectedValue.ProfileName;
			}
		}

		public ProfileScope ProfileScope
		{
			get
			{
				return this._logonCredentialsUI.ProfileComboBox.SelectedValue.ProfileScope;
			}
		}

		public string UserName
		{
			get
			{
				return this._logonCredentialsUI.UserNameTextBox.Text;
			}
		}

		public PasswordSetting Password
		{
			get
			{
				return new PasswordSetting(this._logonCredentialsUI.PasswordTextBox.Text)
				{
					IsDecrypted = true
				};
			}
		}

		public string Domain
		{
			get
			{
				return this._logonCredentialsUI.DomainTextBox.Text;
			}
		}

		protected override void ShownCallback(object sender, EventArgs e)
		{
			this._logonCredentialsUI.UserNameTextBox.Focus();
		}

		public static LogonSettingsDialog NewEditCredentialsDialog(CredentialsProfile credentials)
		{
			LogonSettingsDialog logonSettingsDialog = new LogonSettingsDialog("Edit Credentials", "Save");
			int rowIndex = 0;
			int tabIndex = 0;
			logonSettingsDialog._logonCredentialsUI.AddControlsToParent(logonSettingsDialog, LogonCredentialsDialogOptions.None, ref rowIndex, ref tabIndex);
			logonSettingsDialog._logonCredentialsUI.EnableDisableControls(true);
			logonSettingsDialog._logonCredentialsUI.InitFromCredentials(credentials);
			logonSettingsDialog.FinalizeLayout(rowIndex, tabIndex);
			return logonSettingsDialog;
		}

		protected void FinalizeLayout(int rowIndex, int tabIndex)
		{
			int height = FormTools.YPos(rowIndex + 1) + 16;
			base.Height = height;
			this.InitButtons();
			this.ScaleAndLayout();
		}

		protected CredentialsUI _logonCredentialsUI;
	}
}
