using System;

namespace RdcMan
{
	// Token: 0x02000043 RID: 67
	public class CredentialsProfile : ILogonCredentials, IDeferDecryption
	{
		// Token: 0x060000EB RID: 235 RVA: 0x000027DF File Offset: 0x000009DF
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

		// Token: 0x060000EC RID: 236 RVA: 0x00002818 File Offset: 0x00000A18
		public CredentialsProfile(string profileName, ProfileScope profileScope, string userName, PasswordSetting password, string domain)
		{
			this._profileName = profileName;
			this._profileScope = profileScope;
			this._userName = userName;
			this._password = password;
			this._domain = domain;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002845 File Offset: 0x00000A45
		public string ProfileName
		{
			get
			{
				return this._profileName;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000284D File Offset: 0x00000A4D
		public ProfileScope ProfileScope
		{
			get
			{
				return this._profileScope;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002855 File Offset: 0x00000A55
		public string UserName
		{
			get
			{
				return this._userName;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000285D File Offset: 0x00000A5D
		public PasswordSetting Password
		{
			get
			{
				return this._password;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002865 File Offset: 0x00000A65
		public string Domain
		{
			get
			{
				return this._domain;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000286D File Offset: 0x00000A6D
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000287A File Offset: 0x00000A7A
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

		// Token: 0x060000F4 RID: 244 RVA: 0x00002888 File Offset: 0x00000A88
		public void Decrypt(EncryptionSettings settings)
		{
			this._password.Decrypt(settings);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002896 File Offset: 0x00000A96
		public override string ToString()
		{
			return this.ProfileName;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000289E File Offset: 0x00000A9E
		public string QualifiedName
		{
			get
			{
				return LogonCredentials.ConstructQualifiedName(this);
			}
		}

		// Token: 0x0400027D RID: 637
		public const string CustomProfileName = "Custom";

		// Token: 0x0400027E RID: 638
		private readonly string _profileName;

		// Token: 0x0400027F RID: 639
		private readonly ProfileScope _profileScope;

		// Token: 0x04000280 RID: 640
		private string _userName;

		// Token: 0x04000281 RID: 641
		private PasswordSetting _password;

		// Token: 0x04000282 RID: 642
		private string _domain;
	}
}
