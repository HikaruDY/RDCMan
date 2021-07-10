using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000157 RID: 343
	public class ConnectionSettings : SettingsGroup
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x00007401 File Offset: 0x00005601
		static ConnectionSettings()
		{
			typeof(ConnectionSettings).GetSettingProperties(out ConnectionSettings._settingProperties);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00007417 File Offset: 0x00005617
		public ConnectionSettings() : base("Connection Settings", "connectionSettings")
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00007429 File Offset: 0x00005629
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ConnectionSettingsTabPage(dialog, this);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00007432 File Offset: 0x00005632
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ConnectionSettings._settingProperties;
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00007439 File Offset: 0x00005639
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.ConnectionSettings);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00007447 File Offset: 0x00005647
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x0000744F File Offset: 0x0000564F
		[Setting("connectToConsole")]
		public BoolSetting ConnectToConsole { get; private set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00007458 File Offset: 0x00005658
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00007460 File Offset: 0x00005660
		[Setting("startProgram")]
		public StringSetting StartProgram { get; private set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00007469 File Offset: 0x00005669
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00007471 File Offset: 0x00005671
		[Setting("workingDir")]
		public StringSetting WorkingDir { get; private set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0000747A File Offset: 0x0000567A
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00007482 File Offset: 0x00005682
		[Setting("port", DefaultValue = 3389)]
		public IntSetting Port { get; private set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0000748B File Offset: 0x0000568B
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00007493 File Offset: 0x00005693
		[Setting("loadBalanceInfo")]
		public StringSetting LoadBalanceInfo { get; private set; }

		// Token: 0x040005DE RID: 1502
		internal const string TabName = "Connection Settings";

		// Token: 0x040005DF RID: 1503
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
