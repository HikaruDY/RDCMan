using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000066 RID: 102
	internal partial class SaveCredentialsDialog : RdcDialog
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00002F53 File Offset: 0x00001153
		public string ProfileName
		{
			get
			{
				return this._profileNameTextBox.Text;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002F60 File Offset: 0x00001160
		public ProfileScope ProfileScope
		{
			get
			{
				return this._locationComboBox.SelectedValue;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002F6D File Offset: 0x0000116D
		public SaveCredentialsDialog(FileGroup file, string name) : base("Save profile for " + name, "Save")
		{
			this._file = file;
			this.InitializeComponent(name);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000E838 File Offset: 0x0000CA38
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

		// Token: 0x060001C3 RID: 451 RVA: 0x0000E910 File Offset: 0x0000CB10
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

		// Token: 0x040002E7 RID: 743
		private RdcTextBox _profileNameTextBox;

		// Token: 0x040002E8 RID: 744
		private ValueComboBox<ProfileScope> _locationComboBox;

		// Token: 0x040002E9 RID: 745
		private FileGroup _file;
	}
}
