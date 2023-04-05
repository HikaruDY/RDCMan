using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000CE RID: 206
	public class SmartGroupSettings : GroupSettings
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x000218FC File Offset: 0x0001FAFC
		static SmartGroupSettings()
		{
			typeof(SmartGroupSettings).GetSettingProperties(out SmartGroupSettings._settingProperties);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00021914 File Offset: 0x0001FB14
		public SmartGroupSettings() : base("Smart Group Settings")
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00021924 File Offset: 0x0001FB24
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new SmartGroupPropertiesTabPage(dialog, this);
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00021930 File Offset: 0x0001FB30
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return SmartGroupSettings._settingProperties;
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00021938 File Offset: 0x0001FB38
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (string.IsNullOrEmpty(base.Comment.Value))
			{
				hashSet.Add(base.Comment);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0002197C File Offset: 0x0001FB7C
		protected override void Copy(RdcTreeNode node)
		{
		}

		// Token: 0x0400032B RID: 811
		internal new const string TabName = "Smart Group Settings";

		// Token: 0x0400032C RID: 812
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
