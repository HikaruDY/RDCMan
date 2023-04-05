using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200002F RID: 47
	internal partial class AddCredentialsDialog : LogonSettingsDialog
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00006398 File Offset: 0x00004598
		public AddCredentialsDialog(RdcTreeNode node) : base("Add Credentials", "Save")
		{
			this._file = node.FileGroup;
			int rowIndex = 0;
			int tabIndex = 0;
			this._profileNameTextBox = FormTools.AddLabeledTextBox(this, "Profile &name:", ref rowIndex, ref tabIndex);
			this._profileNameTextBox.Enabled = true;
			this._profileNameTextBox.TextChanged += delegate(object s, EventArgs e)
			{
				this._profileNameUserCreated = true;
			};
			this._profileNameTextBox.Validate = new Func<string>(this.ValidateProfileName);
			this._logonCredentialsUI.AddControlsToParent(this, LogonCredentialsDialogOptions.None, ref rowIndex, ref tabIndex);
			this._logonCredentialsUI.UserNameTextBox.TextChanged += this.CredentialsChanged;
			this._logonCredentialsUI.DomainTextBox.TextChanged += this.CredentialsChanged;
			this._logonCredentialsUI.EnableDisableControls(true);
			base.FinalizeLayout(rowIndex, tabIndex);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00006478 File Offset: 0x00004678
		public new string ProfileName
		{
			get
			{
				return this._profileNameTextBox.Text;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00006488 File Offset: 0x00004688
		public new ProfileScope ProfileScope
		{
			get
			{
				if (this._file != null)
				{
					return ProfileScope.File;
				}
				return ProfileScope.Global;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006498 File Offset: 0x00004698
		private string ValidateProfileName()
		{
			this._profileNameTextBox.Text = this._profileNameTextBox.Text.Trim();
			if (string.IsNullOrEmpty(this._profileNameTextBox.Text))
			{
				return "Please enter a profile name";
			}
			if (LogonCredentials.IsCustomProfile(this.ProfileName))
			{
				return "'{0}' is a reserved profile name".InvariantFormat(new object[]
				{
					"Custom"
				});
			}
			CredentialsStore credentialsProfiles = Program.CredentialsProfiles;
			string text = "Global";
			if (this.ProfileScope == ProfileScope.File)
			{
				credentialsProfiles = this._file.CredentialsProfiles;
				text = this._file.Text;
			}
			if (credentialsProfiles.Contains(this.ProfileName))
			{
				DialogResult dialogResult = FormTools.YesNoDialog(string.Concat(new string[]
				{
					this.ProfileName,
					" already exists in ",
					text,
					Environment.NewLine,
					"Update?"
				}), MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.Yes)
				{
					return "Profile exists";
				}
			}
			return null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006594 File Offset: 0x00004794
		private void CredentialsChanged(object sender, EventArgs e)
		{
			if (!this._profileNameUserCreated)
			{
				this._profileNameTextBox.Text = CredentialsUI.GetQualifiedUserName(this._logonCredentialsUI.UserNameTextBox.Text, this._logonCredentialsUI.DomainTextBox.Text);
				this._profileNameUserCreated = false;
			}
		}

		// Token: 0x040000C0 RID: 192
		private FileGroup _file;

		// Token: 0x040000C1 RID: 193
		private RdcTextBox _profileNameTextBox;

		// Token: 0x040000C2 RID: 194
		private bool _profileNameUserCreated;
	}
}
