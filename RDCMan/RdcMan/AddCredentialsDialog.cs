using System;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class AddCredentialsDialog : LogonSettingsDialog
	{
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

		public new string ProfileName
		{
			get
			{
				return this._profileNameTextBox.Text;
			}
		}

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

		private void CredentialsChanged(object sender, EventArgs e)
		{
			if (!this._profileNameUserCreated)
			{
				this._profileNameTextBox.Text = CredentialsUI.GetQualifiedUserName(this._logonCredentialsUI.UserNameTextBox.Text, this._logonCredentialsUI.DomainTextBox.Text);
				this._profileNameUserCreated = false;
			}
		}

		private FileGroup _file;

		private RdcTextBox _profileNameTextBox;

		private bool _profileNameUserCreated;
	}
}
