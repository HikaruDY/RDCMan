using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200015F RID: 351
	public class LogonCredentials : SettingsGroup, ILogonCredentials
	{
		// Token: 0x06000913 RID: 2323 RVA: 0x0002101C File Offset: 0x0001F21C
		static LogonCredentials()
		{
			typeof(LogonCredentials).GetSettingProperties(out LogonCredentials._settingProperties);
			LogonCredentials._settingProperties["userName"].Attribute.DefaultValue = Environment.UserName;
			LogonCredentials._settingProperties["domain"].Attribute.DefaultValue = Environment.UserDomainName;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00007B07 File Offset: 0x00005D07
		public LogonCredentials() : this("Logon Credentials", "logonCredentials")
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00007B19 File Offset: 0x00005D19
		public LogonCredentials(string description, string xmlNodeName) : base(description, xmlNodeName)
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00007B23 File Offset: 0x00005D23
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new LogonCredentialsTabPage(dialog, this);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00007B2C File Offset: 0x00005D2C
		public bool DirectlyReferences(ILogonCredentials credentials)
		{
			return base.InheritSettingsType.Mode == InheritanceMode.None && this.ProfileName.Scope == credentials.ProfileScope && this.ProfileName.Value == credentials.ProfileName;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00007B67 File Offset: 0x00005D67
		public static bool IsCustomProfile(string profileName)
		{
			return string.Compare(profileName, "Custom", true) == 0;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00007B78 File Offset: 0x00005D78
		public static string ConstructQualifiedName(ILogonCredentials credentials)
		{
			if (LogonCredentials.IsCustomProfile(credentials.ProfileName))
			{
				return credentials.ProfileName;
			}
			return string.Format("{0} ({1})", credentials.ProfileName, credentials.ProfileScope);
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00007BA9 File Offset: 0x00005DA9
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return LogonCredentials._settingProperties;
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00021090 File Offset: 0x0001F290
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

		// Token: 0x0600091C RID: 2332 RVA: 0x00007BB0 File Offset: 0x00005DB0
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.LogonCredentials);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00007BBE File Offset: 0x00005DBE
		public void SetPassword(string clearTextPassword)
		{
			this.Password.SetPlainText(clearTextPassword);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00007BCC File Offset: 0x00005DCC
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00007BD4 File Offset: 0x00005DD4
		[Setting("profileName")]
		public ProfileSetting ProfileName { get; protected set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00007BDD File Offset: 0x00005DDD
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00007BE5 File Offset: 0x00005DE5
		[Setting("userName")]
		public StringSetting UserName { get; protected set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00007BEE File Offset: 0x00005DEE
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00007BF6 File Offset: 0x00005DF6
		[Setting("password")]
		internal PasswordSetting Password { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00007BFF File Offset: 0x00005DFF
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00007C07 File Offset: 0x00005E07
		[Setting("domain")]
		public StringSetting Domain { get; protected set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00007C10 File Offset: 0x00005E10
		string ILogonCredentials.ProfileName
		{
			get
			{
				return this.ProfileName.Value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00007C1D File Offset: 0x00005E1D
		ProfileScope ILogonCredentials.ProfileScope
		{
			get
			{
				return this.ProfileName.Scope;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00007C2A File Offset: 0x00005E2A
		string ILogonCredentials.UserName
		{
			get
			{
				return this.UserName.Value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00007C37 File Offset: 0x00005E37
		PasswordSetting ILogonCredentials.Password
		{
			get
			{
				return this.Password;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00007C3F File Offset: 0x00005E3F
		string ILogonCredentials.Domain
		{
			get
			{
				return this.Domain.Value;
			}
		}

		// Token: 0x04000637 RID: 1591
		internal const string TabName = "Logon Credentials";

		// Token: 0x04000638 RID: 1592
		public static readonly string GlobalStoreName = ProfileScope.Global.ToString();

		// Token: 0x04000639 RID: 1593
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
