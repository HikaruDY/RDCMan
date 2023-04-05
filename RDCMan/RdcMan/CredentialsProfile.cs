using System;

namespace RdcMan
{
	// Token: 0x02000028 RID: 40
	public class CredentialsProfile : ILogonCredentials, IDeferDecryption
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00005114 File Offset: 0x00003314
		public CredentialsProfile(string profileName, ProfileScope profileScope, string userName, string password, string domain)
		{
			this._profileName = profileName;
			this._profileScope = profileScope;
			this._userName = userName;
			this._password = new PasswordSetting(password)
			{
				IsDecrypted = true
			};
			this._domain = domain;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005150 File Offset: 0x00003350
		public CredentialsProfile(string profileName, ProfileScope profileScope, string userName, PasswordSetting password, string domain)
		{
			this._profileName = profileName;
			this._profileScope = profileScope;
			this._userName = userName;
			this._password = password;
			this._domain = domain;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00005180 File Offset: 0x00003380
		public string ProfileName
		{
			get
			{
				return this._profileName;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005188 File Offset: 0x00003388
		public ProfileScope ProfileScope
		{
			get
			{
				return this._profileScope;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005190 File Offset: 0x00003390
		public string UserName
		{
			get
			{
				return this._userName;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005198 File Offset: 0x00003398
		public PasswordSetting Password
		{
			get
			{
				return this._password;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000051A0 File Offset: 0x000033A0
		public string Domain
		{
			get
			{
				return this._domain;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000051A8 File Offset: 0x000033A8
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000051B8 File Offset: 0x000033B8
		public bool IsDecrypted
		{
			get
			{
				return this._password.IsDecrypted;
			}
			set
			{
				this._password.IsDecrypted = value;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000051C8 File Offset: 0x000033C8
		public void Decrypt(EncryptionSettings settings)
		{
			this._password.Decrypt(settings);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000051D8 File Offset: 0x000033D8
		public override string ToString()
		{
			return this.ProfileName;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000051E0 File Offset: 0x000033E0
		public string QualifiedName
		{
			get
			{
				return LogonCredentials.ConstructQualifiedName(this);
			}
		}

		// Token: 0x040000A2 RID: 162
		public const string CustomProfileName = "Custom";

		// Token: 0x040000A3 RID: 163
		private readonly string _profileName;

		// Token: 0x040000A4 RID: 164
		private readonly ProfileScope _profileScope;

		// Token: 0x040000A5 RID: 165
		private string _userName;

		// Token: 0x040000A6 RID: 166
		private PasswordSetting _password;

		// Token: 0x040000A7 RID: 167
		private string _domain;
	}
}
