using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000159 RID: 345
	public class ServerDisplaySettings : CommonDisplaySettings
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x000074EF File Offset: 0x000056EF
		static ServerDisplaySettings()
		{
			typeof(ServerDisplaySettings).GetSettingProperties(out ServerDisplaySettings._settingProperties);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0000750D File Offset: 0x0000570D
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ServerDisplaySettingsTabPage(dialog, this);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00007516 File Offset: 0x00005716
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ServerDisplaySettings._settingProperties;
			}
		}

		// Token: 0x040005E9 RID: 1513
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
