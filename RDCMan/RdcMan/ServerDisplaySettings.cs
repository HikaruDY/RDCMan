using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000C3 RID: 195
	public class ServerDisplaySettings : CommonDisplaySettings
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x00020ADC File Offset: 0x0001ECDC
		static ServerDisplaySettings()
		{
			typeof(ServerDisplaySettings).GetSettingProperties(out ServerDisplaySettings._settingProperties);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00020AFC File Offset: 0x0001ECFC
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ServerDisplaySettingsTabPage(dialog, this);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00020B08 File Offset: 0x0001ED08
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ServerDisplaySettings._settingProperties;
			}
		}

		// Token: 0x040002C9 RID: 713
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
