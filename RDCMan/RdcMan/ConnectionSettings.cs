using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000C1 RID: 193
	public class ConnectionSettings : SettingsGroup
	{
		// Token: 0x060006B3 RID: 1715 RVA: 0x000209C8 File Offset: 0x0001EBC8
		static ConnectionSettings()
		{
			typeof(ConnectionSettings).GetSettingProperties(out ConnectionSettings._settingProperties);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000209E0 File Offset: 0x0001EBE0
		public ConnectionSettings() : base("Connection Settings", "connectionSettings")
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000209F4 File Offset: 0x0001EBF4
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ConnectionSettingsTabPage(dialog, this);
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00020A00 File Offset: 0x0001EC00
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ConnectionSettings._settingProperties;
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00020A08 File Offset: 0x0001EC08
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.ConnectionSettings);
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00020A18 File Offset: 0x0001EC18
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00020A20 File Offset: 0x0001EC20
		[Setting("connectToConsole")]
		public BoolSetting ConnectToConsole { get; private set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00020A2C File Offset: 0x0001EC2C
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x00020A34 File Offset: 0x0001EC34
		[Setting("startProgram")]
		public StringSetting StartProgram { get; private set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00020A40 File Offset: 0x0001EC40
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00020A48 File Offset: 0x0001EC48
		[Setting("workingDir")]
		public StringSetting WorkingDir { get; private set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00020A54 File Offset: 0x0001EC54
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00020A5C File Offset: 0x0001EC5C
		[Setting("port", DefaultValue = 3389)]
		public IntSetting Port { get; private set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00020A68 File Offset: 0x0001EC68
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00020A70 File Offset: 0x0001EC70
		[Setting("loadBalanceInfo")]
		public StringSetting LoadBalanceInfo { get; private set; }

		// Token: 0x040002BE RID: 702
		internal const string TabName = "Connection Settings";

		// Token: 0x040002BF RID: 703
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
