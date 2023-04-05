using System;

namespace RdcMan
{
	// Token: 0x0200003C RID: 60
	public partial class LogonSettingsDialog : RdcDialog
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00008DE4 File Offset: 0x00006FE4
		protected LogonSettingsDialog(string title, string buttonText) : base(title, buttonText, null)
		{
			base.SuspendLayout();
			this._logonCredentialsUI = new CredentialsUI(null);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00008E04 File Offset: 0x00007004
		public bool PasswordChanged
		{
			get
			{
				return this._logonCredentialsUI.PasswordChanged;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00008E14 File Offset: 0x00007014
		public string ProfileName
		{
			get
			{
				return this._logonCredentialsUI.ProfileComboBox.SelectedValue.ProfileName;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00008E2C File Offset: 0x0000702C
		public ProfileScope ProfileScope
		{
			get
			{
				return this._logonCredentialsUI.ProfileComboBox.SelectedValue.ProfileScope;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00008E44 File Offset: 0x00007044
		public string UserName
		{
			get
			{
				return this._logonCredentialsUI.UserNameTextBox.Text;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00008E58 File Offset: 0x00007058
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00008E78 File Offset: 0x00007078
		public string Domain
		{
			get
			{
				return this._logonCredentialsUI.DomainTextBox.Text;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008E8C File Offset: 0x0000708C
		protected override void ShownCallback(object sender, EventArgs e)
		{
			this._logonCredentialsUI.UserNameTextBox.Focus();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008EA0 File Offset: 0x000070A0
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

		// Token: 0x06000171 RID: 369 RVA: 0x00008EF8 File Offset: 0x000070F8
		protected void FinalizeLayout(int rowIndex, int tabIndex)
		{
			int height = FormTools.YPos(rowIndex + 1) + 16;
			base.Height = height;
			this.InitButtons();
			this.ScaleAndLayout();
		}

		// Token: 0x040000E9 RID: 233
		protected CredentialsUI _logonCredentialsUI;
	}
}
