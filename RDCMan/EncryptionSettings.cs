using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200015B RID: 347
	public class EncryptionSettings : SettingsGroup
	{
		// Token: 0x06000879 RID: 2169 RVA: 0x00007576 File Offset: 0x00005776
		static EncryptionSettings()
		{
			typeof(EncryptionSettings).GetSettingProperties(out EncryptionSettings._settingProperties);
			EncryptionSettings._settingProperties["CredentialName"].Attribute.DefaultValue = CredentialsUI.GetLoggedInUser();
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000075AA File Offset: 0x000057AA
		public EncryptionSettings() : base("Encryption Settings", "encryptionSettings")
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000075BC File Offset: 0x000057BC
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new EncryptionSettingsTabPage(dialog, this);
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000075C5 File Offset: 0x000057C5
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return EncryptionSettings._settingProperties;
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000075CC File Offset: 0x000057CC
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.EncryptionSettings);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000075DA File Offset: 0x000057DA
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x000075E2 File Offset: 0x000057E2
		[Setting("encryptionMethod", DefaultValue = RdcMan.EncryptionMethod.LogonCredentials)]
		public EnumSetting<EncryptionMethod> EncryptionMethod { get; private set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000075EB File Offset: 0x000057EB
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x000075F3 File Offset: 0x000057F3
		[Setting("credentialName")]
		public StringSetting CredentialName { get; private set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x000075FC File Offset: 0x000057FC
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x00007604 File Offset: 0x00005804
		[Setting("credentialData")]
		public StringSetting CredentialData { get; private set; }

		// Token: 0x040005EE RID: 1518
		public const string TabName = "Encryption Settings";

		// Token: 0x040005EF RID: 1519
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
