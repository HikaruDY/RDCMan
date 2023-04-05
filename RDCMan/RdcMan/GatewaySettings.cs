using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000C6 RID: 198
	public class GatewaySettings : LogonCredentials
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x00020C28 File Offset: 0x0001EE28
		static GatewaySettings()
		{
			typeof(GatewaySettings).GetSettingProperties(out GatewaySettings._settingProperties);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00020C40 File Offset: 0x0001EE40
		public GatewaySettings() : base("Gateway Settings", "gatewaySettings")
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00020C54 File Offset: 0x0001EE54
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new GatewaySettingsTabPage(dialog, this);
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00020C60 File Offset: 0x0001EE60
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GatewaySettings._settingProperties;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00020C68 File Offset: 0x0001EE68
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.GatewaySettings);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00020C78 File Offset: 0x0001EE78
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00020C80 File Offset: 0x0001EE80
		[Setting("enabled")]
		public BoolSetting UseGatewayServer { get; private set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00020C8C File Offset: 0x0001EE8C
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00020C94 File Offset: 0x0001EE94
		[Setting("hostName")]
		public StringSetting HostName { get; private set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00020CA8 File Offset: 0x0001EEA8
		[Setting("logonMethod", DefaultValue = RdpClient.GatewayLogonMethod.Any)]
		public EnumSetting<RdpClient.GatewayLogonMethod> LogonMethod { get; private set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00020CB4 File Offset: 0x0001EEB4
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00020CBC File Offset: 0x0001EEBC
		[Setting("localBypass", DefaultValue = true)]
		public BoolSetting BypassGatewayForLocalAddresses { get; private set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00020CD0 File Offset: 0x0001EED0
		[Setting("credSharing", DefaultValue = true)]
		public BoolSetting CredentialSharing { get; private set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00020CDC File Offset: 0x0001EEDC
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00020CE4 File Offset: 0x0001EEE4
		[Setting("enableCredSspSupport", DefaultValue = true, IsObsolete = true)]
		public BoolSetting EnableCredentialSspSupport { get; private set; }

		// Token: 0x040002D3 RID: 723
		public new const string TabName = "Gateway Settings";

		// Token: 0x040002D4 RID: 724
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
