using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000166 RID: 358
	public class SecuritySettings : SettingsGroup
	{
		// Token: 0x06000963 RID: 2403 RVA: 0x00007E34 File Offset: 0x00006034
		static SecuritySettings()
		{
			typeof(SecuritySettings).GetSettingProperties(out SecuritySettings._settingProperties);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00007E4A File Offset: 0x0000604A
		public SecuritySettings() : base("Security Settings", "securitySettings")
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00007E5C File Offset: 0x0000605C
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new SecuritySettingsTabPage(dialog, this);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00007E65 File Offset: 0x00006065
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return SecuritySettings._settingProperties;
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00007E6C File Offset: 0x0000606C
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.SecuritySettings);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00007E7A File Offset: 0x0000607A
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00007E82 File Offset: 0x00006082
		[Setting("authentication", DefaultValue = RdpClient.AuthenticationLevel.Warn)]
		public EnumSetting<RdpClient.AuthenticationLevel> AuthenticationLevel { get; private set; }

		// Token: 0x04000652 RID: 1618
		internal const string TabName = "Security Settings";

		// Token: 0x04000653 RID: 1619
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
