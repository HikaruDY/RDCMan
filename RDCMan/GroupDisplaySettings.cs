using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200015A RID: 346
	public class GroupDisplaySettings : CommonDisplaySettings
	{
		// Token: 0x0600086F RID: 2159 RVA: 0x0000751D File Offset: 0x0000571D
		static GroupDisplaySettings()
		{
			typeof(GroupDisplaySettings).GetSettingProperties(out GroupDisplaySettings._settingProperties);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00007533 File Offset: 0x00005733
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new GroupDisplaySettingsTabPage(dialog, this);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0000753C File Offset: 0x0000573C
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GroupDisplaySettings._settingProperties;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00007543 File Offset: 0x00005743
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x0000754B File Offset: 0x0000574B
		[Setting("liveThumbnailUpdates", DefaultValue = true)]
		public BoolSetting SessionThumbnailPreview { get; protected set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00007554 File Offset: 0x00005754
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x0000755C File Offset: 0x0000575C
		[Setting("allowThumbnailSessionInteraction")]
		public BoolSetting AllowThumbnailSessionInteraction { get; protected set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00007565 File Offset: 0x00005765
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0000756D File Offset: 0x0000576D
		[Setting("showDisconnectedThumbnails", DefaultValue = true)]
		public BoolSetting ShowDisconnectedThumbnails { get; protected set; }

		// Token: 0x040005EA RID: 1514
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
