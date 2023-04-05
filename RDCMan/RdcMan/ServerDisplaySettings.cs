using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	public class ServerDisplaySettings : CommonDisplaySettings
	{
		static ServerDisplaySettings()
		{
			typeof(ServerDisplaySettings).GetSettingProperties(out ServerDisplaySettings._settingProperties);
		}

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ServerDisplaySettingsTabPage(dialog, this);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ServerDisplaySettings._settingProperties;
			}
		}

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
