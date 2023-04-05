using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	public class GroupDisplaySettings : CommonDisplaySettings
	{
		static GroupDisplaySettings()
		{
			typeof(GroupDisplaySettings).GetSettingProperties(out GroupDisplaySettings._settingProperties);
		}

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new GroupDisplaySettingsTabPage(dialog, this);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GroupDisplaySettings._settingProperties;
			}
		}

		[Setting("liveThumbnailUpdates", DefaultValue = true)]
		public BoolSetting SessionThumbnailPreview { get; protected set; }

		[Setting("allowThumbnailSessionInteraction")]
		public BoolSetting AllowThumbnailSessionInteraction { get; protected set; }

		[Setting("showDisconnectedThumbnails", DefaultValue = true)]
		public BoolSetting ShowDisconnectedThumbnails { get; protected set; }

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
