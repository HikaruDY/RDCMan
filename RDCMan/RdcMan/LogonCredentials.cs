using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public class LogonCredentials : SettingsGroup, ILogonCredentials
	{
		static LogonCredentials()
		{
			typeof(LogonCredentials).GetSettingProperties(out LogonCredentials._settingProperties);
			LogonCredentials._settingProperties["userName"].Attribute.DefaultValue = Environment.UserName;
			LogonCredentials._settingProperties["domain"].Attribute.DefaultValue = Environment.UserDomainName;
		}

		public LogonCredentials() : this("Logon Credentials", "logonCredentials")
		{
		}

		public LogonCredentials(string description, string xmlNodeName) : base(description, xmlNodeName)
		{
		}

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new LogonCredentialsTabPage(dialog, this);
		}

		public bool DirectlyReferences(ILogonCredentials credentials)
		{
			return base.InheritSettingsType.Mode == InheritanceMode.None && this.ProfileName.Scope == credentials.ProfileScope && this.ProfileName.Value == credentials.ProfileName;
		}

		public static bool IsCustomProfile(string profileName)
		{
			return string.Compare(profileName, "Custom", true) == 0;
		}

		public static string ConstructQualifiedName(ILogonCredentials credentials)
		{
			if (LogonCredentials.IsCustomProfile(credentials.ProfileName))
			{
				return credentials.ProfileName;
			}
			return string.Format("{0} ({1})", credentials.ProfileName, credentials.ProfileScope);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return LogonCredentials._settingProperties;
			}
		}

		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (this.ProfileName.Scope != ProfileScope.Local)
			{
				hashSet.Add(this.UserName);
				hashSet.Add(this.Password);
				hashSet.Add(this.Domain);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.LogonCredentials);
		}

		public void SetPassword(string clearTextPassword)
		{
			this.Password.SetPlainText(clearTextPassword);
		}

		[Setting("profileName")]
		public ProfileSetting ProfileName { get; protected set; }

		[Setting("userName")]
		public StringSetting UserName { get; protected set; }

		[Setting("password")]
		internal PasswordSetting Password { get; set; }

		[Setting("domain")]
		public StringSetting Domain { get; protected set; }

		string ILogonCredentials.ProfileName
		{
			get
			{
				return this.ProfileName.Value;
			}
		}

		ProfileScope ILogonCredentials.ProfileScope
		{
			get
			{
				return this.ProfileName.Scope;
			}
		}

		string ILogonCredentials.UserName
		{
			get
			{
				return this.UserName.Value;
			}
		}

		PasswordSetting ILogonCredentials.Password
		{
			get
			{
				return this.Password;
			}
		}

		string ILogonCredentials.Domain
		{
			get
			{
				return this.Domain.Value;
			}
		}

		internal const string TabName = "Logon Credentials";

		public static readonly string GlobalStoreName = ProfileScope.Global.ToString();

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
