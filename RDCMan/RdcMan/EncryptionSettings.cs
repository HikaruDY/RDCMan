using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	public class EncryptionSettings : SettingsGroup
	{
		static EncryptionSettings()
		{
			typeof(EncryptionSettings).GetSettingProperties(out EncryptionSettings._settingProperties);
			EncryptionSettings._settingProperties["CredentialName"].Attribute.DefaultValue = CredentialsUI.GetLoggedInUser();
		}

		public EncryptionSettings() : base("Encryption Settings", "encryptionSettings")
		{
		}

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new EncryptionSettingsTabPage(dialog, this);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return EncryptionSettings._settingProperties;
			}
		}

		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.EncryptionSettings);
		}

		[Setting("encryptionMethod", DefaultValue = RdcMan.EncryptionMethod.PlainText)]
		public EnumSetting<EncryptionMethod> EncryptionMethod { get; private set; }

		[Setting("credentialName")]
		public StringSetting CredentialName { get; private set; }

		[Setting("credentialData")]
		public StringSetting CredentialData { get; private set; }

		public const string TabName = "Encryption Settings";

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
