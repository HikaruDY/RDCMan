using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000C9 RID: 201
	public class LogonCredentials : SettingsGroup, ILogonCredentials
	{
		// Token: 0x06000774 RID: 1908 RVA: 0x000213C0 File Offset: 0x0001F5C0
		static LogonCredentials()
		{
			typeof(LogonCredentials).GetSettingProperties(out LogonCredentials._settingProperties);
			LogonCredentials._settingProperties["userName"].Attribute.DefaultValue = Environment.UserName;
			LogonCredentials._settingProperties["domain"].Attribute.DefaultValue = Environment.UserDomainName;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00021438 File Offset: 0x0001F638
		public LogonCredentials() : this("Logon Credentials", "logonCredentials")
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0002144C File Offset: 0x0001F64C
		public LogonCredentials(string description, string xmlNodeName) : base(description, xmlNodeName)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00021458 File Offset: 0x0001F658
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new LogonCredentialsTabPage(dialog, this);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00021464 File Offset: 0x0001F664
		public bool DirectlyReferences(ILogonCredentials credentials)
		{
			return base.InheritSettingsType.Mode == InheritanceMode.None && this.ProfileName.Scope == credentials.ProfileScope && this.ProfileName.Value == credentials.ProfileName;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000214B4 File Offset: 0x0001F6B4
		public static bool IsCustomProfile(string profileName)
		{
			return string.Compare(profileName, "Custom", true) == 0;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000214C8 File Offset: 0x0001F6C8
		public static string ConstructQualifiedName(ILogonCredentials credentials)
		{
			if (LogonCredentials.IsCustomProfile(credentials.ProfileName))
			{
				return credentials.ProfileName;
			}
			return string.Format("{0} ({1})", credentials.ProfileName, credentials.ProfileScope);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x0002150C File Offset: 0x0001F70C
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return LogonCredentials._settingProperties;
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00021514 File Offset: 0x0001F714
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

		// Token: 0x0600077D RID: 1917 RVA: 0x0002156C File Offset: 0x0001F76C
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.LogonCredentials);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0002157C File Offset: 0x0001F77C
		public void SetPassword(string clearTextPassword)
		{
			this.Password.SetPlainText(clearTextPassword);
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0002158C File Offset: 0x0001F78C
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00021594 File Offset: 0x0001F794
		[Setting("profileName")]
		public ProfileSetting ProfileName { get; protected set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000215A0 File Offset: 0x0001F7A0
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x000215A8 File Offset: 0x0001F7A8
		[Setting("userName")]
		public StringSetting UserName { get; protected set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000215B4 File Offset: 0x0001F7B4
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x000215BC File Offset: 0x0001F7BC
		[Setting("password")]
		internal PasswordSetting Password { get; set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000215C8 File Offset: 0x0001F7C8
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x000215D0 File Offset: 0x0001F7D0
		[Setting("domain")]
		public StringSetting Domain { get; protected set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000215DC File Offset: 0x0001F7DC
		string ILogonCredentials.ProfileName
		{
			get
			{
				return this.ProfileName.Value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x000215EC File Offset: 0x0001F7EC
		ProfileScope ILogonCredentials.ProfileScope
		{
			get
			{
				return this.ProfileName.Scope;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x000215FC File Offset: 0x0001F7FC
		string ILogonCredentials.UserName
		{
			get
			{
				return this.UserName.Value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0002160C File Offset: 0x0001F80C
		PasswordSetting ILogonCredentials.Password
		{
			get
			{
				return this.Password;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00021614 File Offset: 0x0001F814
		string ILogonCredentials.Domain
		{
			get
			{
				return this.Domain.Value;
			}
		}

		// Token: 0x04000318 RID: 792
		internal const string TabName = "Logon Credentials";

		// Token: 0x04000319 RID: 793
		public static readonly string GlobalStoreName = ProfileScope.Global.ToString();

		// Token: 0x0400031A RID: 794
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
