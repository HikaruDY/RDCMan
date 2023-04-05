using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	public class SecuritySettings : SettingsGroup
	{
		static SecuritySettings()
		{
			typeof(SecuritySettings).GetSettingProperties(out SecuritySettings._settingProperties);
		}

		public SecuritySettings() : base("Security Settings", "securitySettings")
		{
		}

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new SecuritySettingsTabPage(dialog, this);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return SecuritySettings._settingProperties;
			}
		}

		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.SecuritySettings);
		}

		[Setting("authentication", DefaultValue = RdpClient.AuthenticationLevel.Warn)]
		public EnumSetting<RdpClient.AuthenticationLevel> AuthenticationLevel { get; private set; }

		[Setting("restrictedAdmin")]
		public BoolSetting RestrictedAdmin { get; private set; }

		[Setting("remoteGuard")]
		public BoolSetting RemoteGuard { get; private set; }

		internal const string TabName = "Security Settings";

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
