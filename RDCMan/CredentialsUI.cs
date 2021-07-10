using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000045 RID: 69
	public class CredentialsUI
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002907 File Offset: 0x00000B07
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000290F File Offset: 0x00000B0F
		public ValueComboBox<CredentialsProfile> ProfileComboBox { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002918 File Offset: 0x00000B18
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002920 File Offset: 0x00000B20
		public RdcTextBox UserNameTextBox { get; private set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002929 File Offset: 0x00000B29
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002931 File Offset: 0x00000B31
		public RdcTextBox DomainTextBox { get; private set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000293A File Offset: 0x00000B3A
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002942 File Offset: 0x00000B42
		public RdcTextBox PasswordTextBox { get; private set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000294B File Offset: 0x00000B4B
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002953 File Offset: 0x00000B53
		public bool PasswordChanged { get; private set; }

		// Token: 0x0600010C RID: 268 RVA: 0x0000295C File Offset: 0x00000B5C
		private static bool HasDomainUser(string userName)
		{
			return userName.IndexOf('\\') != -1;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000B024 File Offset: 0x00009224
		public static string GetUserName(string userName)
		{
			int num = userName.IndexOf('\\');
			if (num == -1)
			{
				return userName;
			}
			return userName.Substring(num + 1);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000B04C File Offset: 0x0000924C
		public static string GetQualifiedUserName(string userName, string domain)
		{
			string text = userName;
			if (!CredentialsUI.HasDomainUser(text) && !string.IsNullOrEmpty(domain))
			{
				text = domain + "\\" + text;
			}
			return text;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000296C File Offset: 0x00000B6C
		public static string GetLoggedInUser()
		{
			return CredentialsUI.GetQualifiedUserName(Environment.UserName, Environment.UserDomainName);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000297D File Offset: 0x00000B7D
		public CredentialsUI(InheritanceControl inheritSettings)
		{
			this._inheritSettings = inheritSettings;
			this.PasswordChanged = true;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000B07C File Offset: 0x0000927C
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

		// Token: 0x06000112 RID: 274 RVA: 0x00002993 File Offset: 0x00000B93
		public void PopulateCredentialsProfiles(FileGroup file)
		{
			if (file != null && this._file == file)
			{
				return;
			}
			this._file = file;
			this.PopulateCredentialsProfilesWorker();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000B1F8 File Offset: 0x000093F8
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

		// Token: 0x06000114 RID: 276 RVA: 0x0000B268 File Offset: 0x00009468
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

		// Token: 0x06000115 RID: 277 RVA: 0x0000B2B8 File Offset: 0x000094B8
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

		// Token: 0x06000116 RID: 278 RVA: 0x0000B348 File Offset: 0x00009548
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

		// Token: 0x06000117 RID: 279 RVA: 0x000029AF File Offset: 0x00000BAF
		private void OnPasswordChanged(object sender, EventArgs e)
		{
			this.PasswordChanged = true;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000B3C8 File Offset: 0x000095C8
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

		// Token: 0x06000119 RID: 281 RVA: 0x000029B8 File Offset: 0x00000BB8
		private void OnProfileVisible(object sender, EventArgs e)
		{
			this.PopulateCredentialsProfilesIfChanged();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000029C0 File Offset: 0x00000BC0
		private void PopulateCredentialsProfilesIfChanged()
		{
			if (this._globalStoreChangeId != Program.CredentialsProfiles.ChangeId || (this._file != null && this._fileStoreChangeId != this._file.CredentialsProfiles.ChangeId))
			{
				this.PopulateCredentialsProfilesWorker();
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000B474 File Offset: 0x00009674
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

		// Token: 0x0600011C RID: 284 RVA: 0x0000B524 File Offset: 0x00009724
		private void PopulateComboFromStore(CredentialsStore store)
		{
			foreach (CredentialsProfile credentialsProfile in store.Profiles)
			{
				string qualifiedName = credentialsProfile.QualifiedName;
				this.ProfileComboBox.AddItem(qualifiedName, credentialsProfile);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000B580 File Offset: 0x00009780
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

		// Token: 0x04000287 RID: 647
		public const char DomainSeparator = '\\';

		// Token: 0x04000288 RID: 648
		private const string DummyPassword = "Placeholder1234567890";

		// Token: 0x0400028E RID: 654
		private FileGroup _file;

		// Token: 0x0400028F RID: 655
		private bool _usingCustomCredentials;

		// Token: 0x04000290 RID: 656
		private Button _saveProfileButton;

		// Token: 0x04000291 RID: 657
		private InheritanceControl _inheritSettings;

		// Token: 0x04000292 RID: 658
		private int _globalStoreChangeId;

		// Token: 0x04000293 RID: 659
		private int _fileStoreChangeId;
	}
}
