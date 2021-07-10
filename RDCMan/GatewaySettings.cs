using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200015C RID: 348
	public class GatewaySettings : LogonCredentials
	{
		// Token: 0x06000884 RID: 2180 RVA: 0x0000760D File Offset: 0x0000580D
		static GatewaySettings()
		{
			typeof(GatewaySettings).GetSettingProperties(out GatewaySettings._settingProperties);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00007623 File Offset: 0x00005823
		public GatewaySettings() : base("Gateway Settings", "gatewaySettings")
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00007635 File Offset: 0x00005835
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new GatewaySettingsTabPage(dialog, this);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0000763E File Offset: 0x0000583E
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GatewaySettings._settingProperties;
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00007645 File Offset: 0x00005845
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.GatewaySettings);
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00007653 File Offset: 0x00005853
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x0000765B File Offset: 0x0000585B
		[Setting("enabled")]
		public BoolSetting UseGatewayServer { get; private set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00007664 File Offset: 0x00005864
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x0000766C File Offset: 0x0000586C
		[Setting("hostName")]
		public StringSetting HostName { get; private set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00007675 File Offset: 0x00005875
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x0000767D File Offset: 0x0000587D
		[Setting("logonMethod", DefaultValue = RdpClient.GatewayLogonMethod.Any)]
		public EnumSetting<RdpClient.GatewayLogonMethod> LogonMethod { get; private set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00007686 File Offset: 0x00005886
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x0000768E File Offset: 0x0000588E
		[Setting("localBypass", DefaultValue = true)]
		public BoolSetting BypassGatewayForLocalAddresses { get; private set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00007697 File Offset: 0x00005897
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x0000769F File Offset: 0x0000589F
		[Setting("credSharing", DefaultValue = true)]
		public BoolSetting CredentialSharing { get; private set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x000076A8 File Offset: 0x000058A8
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x000076B0 File Offset: 0x000058B0
		[Setting("enableCredSspSupport", DefaultValue = true, IsObsolete = true)]
		public BoolSetting EnableCredentialSspSupport { get; private set; }

		// Token: 0x040005F3 RID: 1523
		public new const string TabName = "Gateway Settings";

		// Token: 0x040005F4 RID: 1524
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
