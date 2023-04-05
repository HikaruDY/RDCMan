using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200002A RID: 42
	public class CredentialsUI
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00005434 File Offset: 0x00003634
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000543C File Offset: 0x0000363C
		public ValueComboBox<CredentialsProfile> ProfileComboBox { get; private set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005448 File Offset: 0x00003648
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00005450 File Offset: 0x00003650
		public RdcTextBox UserNameTextBox { get; private set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000545C File Offset: 0x0000365C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00005464 File Offset: 0x00003664
		public RdcTextBox DomainTextBox { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005470 File Offset: 0x00003670
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00005478 File Offset: 0x00003678
		public RdcTextBox PasswordTextBox { get; private set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005484 File Offset: 0x00003684
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000548C File Offset: 0x0000368C
		public bool PasswordChanged { get; private set; }

		// Token: 0x060000F4 RID: 244 RVA: 0x00005498 File Offset: 0x00003698
		private static bool HasDomainUser(string userName)
		{
			return userName.IndexOf('\\') != -1;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000054A8 File Offset: 0x000036A8
		public static string GetUserName(string userName)
		{
			int num = userName.IndexOf('\\');
			if (num == -1)
			{
				return userName;
			}
			return userName.Substring(num + 1);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000054D4 File Offset: 0x000036D4
		public static string GetQualifiedUserName(string userName, string domain)
		{
			string text = userName;
			if (!CredentialsUI.HasDomainUser(text) && !string.IsNullOrEmpty(domain))
			{
				text = domain + "\\" + text;
			}
			return text;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000550C File Offset: 0x0000370C
		public static string GetLoggedInUser()
		{
			return CredentialsUI.GetQualifiedUserName(Environment.UserName, Environment.UserDomainName);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005520 File Offset: 0x00003720
		public CredentialsUI(InheritanceControl inheritSettings)
		{
			this._inheritSettings = inheritSettings;
			this.PasswordChanged = true;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005538 File Offset: 0x00003738
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

		// Token: 0x060000FA RID: 250 RVA: 0x000056B8 File Offset: 0x000038B8
		public void PopulateCredentialsProfiles(FileGroup file)
		{
			if (file != null && this._file == file)
			{
				return;
			}
			this._file = file;
			this.PopulateCredentialsProfilesWorker();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000056DC File Offset: 0x000038DC
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

		// Token: 0x060000FC RID: 252 RVA: 0x00005754 File Offset: 0x00003954
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

		// Token: 0x060000FD RID: 253 RVA: 0x000057B0 File Offset: 0x000039B0
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

		// Token: 0x060000FE RID: 254 RVA: 0x00005850 File Offset: 0x00003A50
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

		// Token: 0x060000FF RID: 255 RVA: 0x000058DC File Offset: 0x00003ADC
		private void OnPasswordChanged(object sender, EventArgs e)
		{
			this.PasswordChanged = true;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000058E8 File Offset: 0x00003AE8
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

		// Token: 0x06000101 RID: 257 RVA: 0x000059A0 File Offset: 0x00003BA0
		private void OnProfileVisible(object sender, EventArgs e)
		{
			this.PopulateCredentialsProfilesIfChanged();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000059A8 File Offset: 0x00003BA8
		private void PopulateCredentialsProfilesIfChanged()
		{
			if (this._globalStoreChangeId != Program.CredentialsProfiles.ChangeId || (this._file != null && this._fileStoreChangeId != this._file.CredentialsProfiles.ChangeId))
			{
				this.PopulateCredentialsProfilesWorker();
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000059FC File Offset: 0x00003BFC
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

		// Token: 0x06000104 RID: 260 RVA: 0x00005AB4 File Offset: 0x00003CB4
		private void PopulateComboFromStore(CredentialsStore store)
		{
			foreach (CredentialsProfile credentialsProfile in store.Profiles)
			{
				string qualifiedName = credentialsProfile.QualifiedName;
				this.ProfileComboBox.AddItem(qualifiedName, credentialsProfile);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005B18 File Offset: 0x00003D18
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

		// Token: 0x040000AC RID: 172
		public const char DomainSeparator = '\\';

		// Token: 0x040000AD RID: 173
		private const string DummyPassword = "Placeholder1234567890";

		// Token: 0x040000B3 RID: 179
		private FileGroup _file;

		// Token: 0x040000B4 RID: 180
		private bool _usingCustomCredentials;

		// Token: 0x040000B5 RID: 181
		private Button _saveProfileButton;

		// Token: 0x040000B6 RID: 182
		private InheritanceControl _inheritSettings;

		// Token: 0x040000B7 RID: 183
		private int _globalStoreChangeId;

		// Token: 0x040000B8 RID: 184
		private int _fileStoreChangeId;
	}
}
