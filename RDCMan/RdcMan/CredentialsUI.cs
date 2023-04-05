using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public class CredentialsUI
	{
		public ValueComboBox<CredentialsProfile> ProfileComboBox { get; private set; }

		public RdcTextBox UserNameTextBox { get; private set; }

		public RdcTextBox DomainTextBox { get; private set; }

		public RdcTextBox PasswordTextBox { get; private set; }

		public bool PasswordChanged { get; private set; }

		private static bool HasDomainUser(string userName)
		{
			return userName.IndexOf('\\') != -1;
		}

		public static string GetUserName(string userName)
		{
			int num = userName.IndexOf('\\');
			if (num == -1)
			{
				return userName;
			}
			return userName.Substring(num + 1);
		}

		public static string GetQualifiedUserName(string userName, string domain)
		{
			string text = userName;
			if (!CredentialsUI.HasDomainUser(text) && !string.IsNullOrEmpty(domain))
			{
				text = domain + "\\" + text;
			}
			return text;
		}

		public static string GetLoggedInUser()
		{
			return CredentialsUI.GetQualifiedUserName(Environment.UserName, Environment.UserDomainName);
		}

		public CredentialsUI(InheritanceControl inheritSettings)
		{
			this._inheritSettings = inheritSettings;
			this.PasswordChanged = true;
		}

		public void AddControlsToParent(Control parent, LogonCredentialsDialogOptions options, ref int rowIndex, ref int tabIndex)
		{
			if ((options & LogonCredentialsDialogOptions.ShowProfiles) != LogonCredentialsDialogOptions.None)
			{
				this.ProfileComboBox = FormTools.AddLabeledValueDropDown<CredentialsProfile>(parent, "Profile", ref rowIndex, ref tabIndex, null, null);
				this.ProfileComboBox.SelectedIndexChanged += this.OnProfileChanged;
				this.ProfileComboBox.VisibleChanged += this.OnProfileVisible;
				Button button = new Button();
				int num = tabIndex;
				tabIndex = num + 1;
				button.TabIndex = num;
				button.Text = "Save";
				this._saveProfileButton = button;
				this._saveProfileButton.Location = new Point(this.ProfileComboBox.Right - this._saveProfileButton.Width, this.ProfileComboBox.Location.Y - 1);
				this._saveProfileButton.Click += this.SaveProfileButton_Click;
				parent.Controls.Add(this._saveProfileButton);
				this.ProfileComboBox.Width -= this._saveProfileButton.Width;
			}
			this.UserNameTextBox = FormTools.AddLabeledTextBox(parent, "&User name:", ref rowIndex, ref tabIndex);
			this.UserNameTextBox.TextChanged += this.OnUserNameChanged;
			this.PasswordTextBox = FormTools.AddLabeledTextBox(parent, "&Password:", ref rowIndex, ref tabIndex);
			this.PasswordTextBox.PasswordChar = '●';
			this.PasswordTextBox.TextChanged += this.OnPasswordChanged;
			this.DomainTextBox = FormTools.AddLabeledTextBox(parent, "&Domain:", ref rowIndex, ref tabIndex);
		}

		public void PopulateCredentialsProfiles(FileGroup file)
		{
			if (file != null && this._file == file)
			{
				return;
			}
			this._file = file;
			this.PopulateCredentialsProfilesWorker();
		}

		public void InitFromCredentials(ILogonCredentials credentials)
		{
			if (this.ProfileComboBox != null)
			{
				this._usingCustomCredentials = LogonCredentials.IsCustomProfile(credentials.ProfileName);
				this.ProfileComboBox.SelectedIndex = this.ProfileComboBox.FindItem(LogonCredentials.ConstructQualifiedName(credentials));
			}
			this.UserNameTextBox.Text = credentials.UserName;
			this.InitPassword(credentials.Password);
			this.DomainTextBox.Text = credentials.Domain;
		}

		public void InitPassword(PasswordSetting password)
		{
			if (password != null && password.IsDecrypted && !string.IsNullOrEmpty(password.Value))
			{
				this.PasswordTextBox.Text = "Placeholder1234567890";
				this.PasswordChanged = false;
				return;
			}
			this.PasswordTextBox.Text = string.Empty;
		}

		public void EnableDisableControls(bool enable)
		{
			enable &= (this._inheritSettings == null || !this._inheritSettings.FromParentCheck.Checked);
			if (this.ProfileComboBox != null)
			{
				this.ProfileComboBox.Enabled = enable;
				enable &= this._usingCustomCredentials;
			}
			if (this._saveProfileButton != null)
			{
				this._saveProfileButton.Enabled = enable;
			}
			this.UserNameTextBox.Enabled = enable;
			this.DomainTextBox.Enabled = enable;
			this.PasswordTextBox.Enabled = enable;
			this.OnUserNameChanged(null, null);
		}

		private void OnUserNameChanged(object sender, EventArgs e)
		{
			if (this._inheritSettings != null && this._inheritSettings.FromParentCheck.Checked)
			{
				return;
			}
			int num = this.UserNameTextBox.Text.IndexOf('\\');
			if (num == -1)
			{
				this.DomainTextBox.Enabled = this.UserNameTextBox.Enabled;
				return;
			}
			this.DomainTextBox.Enabled = false;
			this.DomainTextBox.Text = this.UserNameTextBox.Text.Substring(0, num);
		}

		private void OnPasswordChanged(object sender, EventArgs e)
		{
			this.PasswordChanged = true;
		}

		private void OnProfileChanged(object sender, EventArgs e)
		{
			if (this._inheritSettings != null && this._inheritSettings.FromParentCheck.Checked)
			{
				return;
			}
			ILogonCredentials selectedValue = this.ProfileComboBox.SelectedValue;
			this._usingCustomCredentials = LogonCredentials.IsCustomProfile(selectedValue.ProfileName);
			this.EnableDisableControls(true);
			if (this._usingCustomCredentials)
			{
				this.UserNameTextBox.Text = Environment.UserName;
				this.InitPassword(null);
				this.DomainTextBox.Text = Environment.UserDomainName;
				return;
			}
			this.UserNameTextBox.Text = selectedValue.UserName;
			this.InitPassword(selectedValue.Password);
			this.DomainTextBox.Text = selectedValue.Domain;
		}

		private void OnProfileVisible(object sender, EventArgs e)
		{
			this.PopulateCredentialsProfilesIfChanged();
		}

		private void PopulateCredentialsProfilesIfChanged()
		{
			if (this._globalStoreChangeId != Program.CredentialsProfiles.ChangeId || (this._file != null && this._fileStoreChangeId != this._file.CredentialsProfiles.ChangeId))
			{
				this.PopulateCredentialsProfilesWorker();
			}
		}

		private void PopulateCredentialsProfilesWorker()
		{
			CredentialsProfile selectedValue = this.ProfileComboBox.SelectedValue;
			this.ProfileComboBox.ClearItems();
			this.ProfileComboBox.AddItem("Custom", new CredentialsProfile("Custom", ProfileScope.Local, string.Empty, string.Empty, string.Empty));
			this.ProfileComboBox.SelectedIndex = 0;
			this.PopulateComboFromStore(Program.CredentialsProfiles);
			this._globalStoreChangeId = Program.CredentialsProfiles.ChangeId;
			if (this._file != null)
			{
				this.PopulateComboFromStore(this._file.CredentialsProfiles);
				this._fileStoreChangeId = this._file.CredentialsProfiles.ChangeId;
			}
			this.ProfileComboBox.SelectedValue = selectedValue;
		}

		private void PopulateComboFromStore(CredentialsStore store)
		{
			foreach (CredentialsProfile credentialsProfile in store.Profiles)
			{
				string qualifiedName = credentialsProfile.QualifiedName;
				this.ProfileComboBox.AddItem(qualifiedName, credentialsProfile);
			}
		}

		private void SaveProfileButton_Click(object sender, EventArgs e)
		{
			string text = CredentialsUI.GetQualifiedUserName(this.UserNameTextBox.Text, this.DomainTextBox.Text);
			using (SaveCredentialsDialog saveCredentialsDialog = new SaveCredentialsDialog(this._file, text))
			{
				if (saveCredentialsDialog.ShowDialog() == DialogResult.OK)
				{
					ProfileScope profileScope = saveCredentialsDialog.ProfileScope;
					CredentialsStore credentialsProfiles = Program.CredentialsProfiles;
					if (profileScope == ProfileScope.File)
					{
						credentialsProfiles = this._file.CredentialsProfiles;
					}
					text = saveCredentialsDialog.ProfileName;
					bool flag = !credentialsProfiles.Contains(text);
					CredentialsProfile credentialsProfile = new CredentialsProfile(text, profileScope, this.UserNameTextBox.Text, this.PasswordTextBox.Text, this.DomainTextBox.Text);
					credentialsProfiles[text] = credentialsProfile;
					string qualifiedName = credentialsProfile.QualifiedName;
					if (flag)
					{
						this.ProfileComboBox.AddItem(qualifiedName, credentialsProfile);
					}
					else
					{
						this.ProfileComboBox.ReplaceItem(qualifiedName, credentialsProfile);
					}
					this.ProfileComboBox.SelectedValue = credentialsProfile;
				}
			}
			this.ProfileComboBox.Focus();
		}

		public const char DomainSeparator = '\\';

		private const string DummyPassword = "Placeholder1234567890";

		private FileGroup _file;

		private bool _usingCustomCredentials;

		private Button _saveProfileButton;

		private InheritanceControl _inheritSettings;

		private int _globalStoreChangeId;

		private int _fileStoreChangeId;
	}
}
