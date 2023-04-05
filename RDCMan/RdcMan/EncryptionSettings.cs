using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000C5 RID: 197
	public class EncryptionSettings : SettingsGroup
	{
		// Token: 0x060006D8 RID: 1752 RVA: 0x00020B80 File Offset: 0x0001ED80
		static EncryptionSettings()
		{
			typeof(EncryptionSettings).GetSettingProperties(out EncryptionSettings._settingProperties);
			EncryptionSettings._settingProperties["CredentialName"].Attribute.DefaultValue = CredentialsUI.GetLoggedInUser();
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		public EncryptionSettings() : base("Encryption Settings", "encryptionSettings")
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new EncryptionSettingsTabPage(dialog, this);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00020BD4 File Offset: 0x0001EDD4
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return EncryptionSettings._settingProperties;
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00020BDC File Offset: 0x0001EDDC
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.EncryptionSettings);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00020BEC File Offset: 0x0001EDEC
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		[Setting("encryptionMethod", DefaultValue = RdcMan.EncryptionMethod.LogonCredentials)]
		public EnumSetting<EncryptionMethod> EncryptionMethod { get; private set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00020C00 File Offset: 0x0001EE00
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00020C08 File Offset: 0x0001EE08
		[Setting("credentialName")]
		public StringSetting CredentialName { get; private set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00020C14 File Offset: 0x0001EE14
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00020C1C File Offset: 0x0001EE1C
		[Setting("credentialData")]
		public StringSetting CredentialData { get; private set; }

		// Token: 0x040002CE RID: 718
		public const string TabName = "Encryption Settings";

		// Token: 0x040002CF RID: 719
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
