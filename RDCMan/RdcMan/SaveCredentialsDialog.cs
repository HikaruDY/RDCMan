using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200003F RID: 63
	internal partial class SaveCredentialsDialog : RdcDialog
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000093DC File Offset: 0x000075DC
		public string ProfileName
		{
			get
			{
				return this._profileNameTextBox.Text;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000093EC File Offset: 0x000075EC
		public ProfileScope ProfileScope
		{
			get
			{
				return this._locationComboBox.SelectedValue;
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000093FC File Offset: 0x000075FC
		public SaveCredentialsDialog(FileGroup file, string name) : base("Save profile for " + name, "Save")
		{
			this._file = file;
			this.InitializeComponent(name);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00009424 File Offset: 0x00007624
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

		// Token: 0x06000189 RID: 393 RVA: 0x00009500 File Offset: 0x00007700
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

		// Token: 0x040000EF RID: 239
		private RdcTextBox _profileNameTextBox;

		// Token: 0x040000F0 RID: 240
		private ValueComboBox<ProfileScope> _locationComboBox;

		// Token: 0x040000F1 RID: 241
		private FileGroup _file;
	}
}
