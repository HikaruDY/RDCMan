using System;

namespace RdcMan
{
	// Token: 0x02000062 RID: 98
	public partial class LogonSettingsDialog : RdcDialog
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00002DC5 File Offset: 0x00000FC5
		protected LogonSettingsDialog(string title, string buttonText) : base(title, buttonText, null)
		{
			base.SuspendLayout();
			this._logonCredentialsUI = new CredentialsUI(null);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002DE2 File Offset: 0x00000FE2
		public bool PasswordChanged
		{
			get
			{
				return this._logonCredentialsUI.PasswordChanged;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00002DEF File Offset: 0x00000FEF
		public string ProfileName
		{
			get
			{
				return this._logonCredentialsUI.ProfileComboBox.SelectedValue.ProfileName;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002E06 File Offset: 0x00001006
		public ProfileScope ProfileScope
		{
			get
			{
				return this._logonCredentialsUI.ProfileComboBox.SelectedValue.ProfileScope;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002E1D File Offset: 0x0000101D
		public string UserName
		{
			get
			{
				return this._logonCredentialsUI.UserNameTextBox.Text;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002E2F File Offset: 0x0000102F
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002E4D File Offset: 0x0000104D
		public string Domain
		{
			get
			{
				return this._logonCredentialsUI.DomainTextBox.Text;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002E5F File Offset: 0x0000105F
		protected override void ShownCallback(object sender, EventArgs e)
		{
			this._logonCredentialsUI.UserNameTextBox.Focus();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000E434 File Offset: 0x0000C634
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

		// Token: 0x060001A8 RID: 424 RVA: 0x0000E488 File Offset: 0x0000C688
		protected void FinalizeLayout(int rowIndex, int tabIndex)
		{
			int height = FormTools.YPos(rowIndex + 1) + 16;
			base.Height = height;
			this.InitButtons();
			this.ScaleAndLayout();
		}

		// Token: 0x040002DF RID: 735
		protected CredentialsUI _logonCredentialsUI;
	}
}
