using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000C4 RID: 196
	public class GroupDisplaySettings : CommonDisplaySettings
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x00020B10 File Offset: 0x0001ED10
		static GroupDisplaySettings()
		{
			typeof(GroupDisplaySettings).GetSettingProperties(out GroupDisplaySettings._settingProperties);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00020B30 File Offset: 0x0001ED30
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new GroupDisplaySettingsTabPage(dialog, this);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00020B3C File Offset: 0x0001ED3C
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GroupDisplaySettings._settingProperties;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00020B44 File Offset: 0x0001ED44
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00020B4C File Offset: 0x0001ED4C
		[Setting("liveThumbnailUpdates", DefaultValue = true)]
		public BoolSetting SessionThumbnailPreview { get; protected set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00020B58 File Offset: 0x0001ED58
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00020B60 File Offset: 0x0001ED60
		[Setting("allowThumbnailSessionInteraction")]
		public BoolSetting AllowThumbnailSessionInteraction { get; protected set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00020B6C File Offset: 0x0001ED6C
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00020B74 File Offset: 0x0001ED74
		[Setting("showDisconnectedThumbnails", DefaultValue = true)]
		public BoolSetting ShowDisconnectedThumbnails { get; protected set; }

		// Token: 0x040002CA RID: 714
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
