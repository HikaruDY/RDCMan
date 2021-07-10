using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200004D RID: 77
	internal partial class AddCredentialsDialog : LogonSettingsDialog
	{
		// Token: 0x06000139 RID: 313 RVA: 0x0000BD54 File Offset: 0x00009F54
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002AB5 File Offset: 0x00000CB5
		public new string ProfileName
		{
			get
			{
				return this._profileNameTextBox.Text;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002AC2 File Offset: 0x00000CC2
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

		// Token: 0x0600013C RID: 316 RVA: 0x0000BE30 File Offset: 0x0000A030
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

		// Token: 0x0600013D RID: 317 RVA: 0x0000BF18 File Offset: 0x0000A118
		private void CredentialsChanged(object sender, EventArgs e)
		{
			if (!this._profileNameUserCreated)
			{
				this._profileNameTextBox.Text = CredentialsUI.GetQualifiedUserName(this._logonCredentialsUI.UserNameTextBox.Text, this._logonCredentialsUI.DomainTextBox.Text);
				this._profileNameUserCreated = false;
			}
		}

		// Token: 0x040002A4 RID: 676
		private FileGroup _file;

		// Token: 0x040002A5 RID: 677
		private RdcTextBox _profileNameTextBox;

		// Token: 0x040002A6 RID: 678
		private bool _profileNameUserCreated;
	}
}
