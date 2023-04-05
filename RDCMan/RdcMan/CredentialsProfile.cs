using System;

namespace RdcMan
{
	public class CredentialsProfile : ILogonCredentials, IDeferDecryption
	{
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

		public CredentialsProfile(string profileName, ProfileScope profileScope, string userName, PasswordSetting password, string domain)
		{
			this._profileName = profileName;
			this._profileScope = profileScope;
			this._userName = userName;
			this._password = password;
			this._domain = domain;
		}

		public string ProfileName
		{
			get
			{
				return this._profileName;
			}
		}

		public ProfileScope ProfileScope
		{
			get
			{
				return this._profileScope;
			}
		}

		public string UserName
		{
			get
			{
				return this._userName;
			}
		}

		public PasswordSetting Password
		{
			get
			{
				return this._password;
			}
		}

		public string Domain
		{
			get
			{
				return this._domain;
			}
		}

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

		public void Decrypt(EncryptionSettings settings)
		{
			this._password.Decrypt(settings);
		}

		public override string ToString()
		{
			return this.ProfileName;
		}

		public string QualifiedName
		{
			get
			{
				return LogonCredentials.ConstructQualifiedName(this);
			}
		}

		public const string CustomProfileName = "Custom";

		private readonly string _profileName;

		private readonly ProfileScope _profileScope;

		private string _userName;

		private PasswordSetting _password;

		private string _domain;
	}
}
