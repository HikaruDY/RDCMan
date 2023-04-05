using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class SaveCredentialsDialog : RdcDialog
	{
		public string ProfileName
		{
			get
			{
				return this._profileNameTextBox.Text;
			}
		}

		public ProfileScope ProfileScope
		{
			get
			{
				return this._locationComboBox.SelectedValue;
			}
		}

		public SaveCredentialsDialog(FileGroup file, string name) : base("Save profile for " + name, "Save")
		{
			this._file = file;
			this.InitializeComponent(name);
		}

		private void InitializeComponent(string name)
		{
			base.Size = new Size(512, 150);
			int num = 0;
			int num2 = 0;
			this._profileNameTextBox = FormTools.AddLabeledTextBox(this, "Profile &name", ref num, ref num2);
			this._profileNameTextBox.Enabled = true;
			this._profileNameTextBox.Text = name;
			this._profileNameTextBox.Validate = new Func<string>(this.ValidateProfileName);
			this._locationComboBox = FormTools.AddLabeledValueDropDown<ProfileScope>(this, "&Location", ref num, ref num2, null, null);
			this._locationComboBox.AddItem("Global", ProfileScope.Global);
			this._locationComboBox.SelectedIndex = 0;
			if (this._file != null)
			{
				this._locationComboBox.AddItem(this._file.Text, ProfileScope.File);
				this._locationComboBox.SelectedIndex = 1;
			}
			this.InitButtons();
			this.ScaleAndLayout();
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

		private RdcTextBox _profileNameTextBox;

		private ValueComboBox<ProfileScope> _locationComboBox;

		private FileGroup _file;
	}
}
