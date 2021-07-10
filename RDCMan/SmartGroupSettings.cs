using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000164 RID: 356
	public class SmartGroupSettings : GroupSettings
	{
		// Token: 0x0600094F RID: 2383 RVA: 0x00007D8D File Offset: 0x00005F8D
		static SmartGroupSettings()
		{
			typeof(SmartGroupSettings).GetSettingProperties(out SmartGroupSettings._settingProperties);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public SmartGroupSettings() : base("Smart Group Settings")
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00007DB0 File Offset: 0x00005FB0
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new SmartGroupPropertiesTabPage(dialog, this);
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00007DB9 File Offset: 0x00005FB9
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return SmartGroupSettings._settingProperties;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00021194 File Offset: 0x0001F394
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (string.IsNullOrEmpty(base.Comment.Value))
			{
				hashSet.Add(base.Comment);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002EFA File Offset: 0x000010FA
		protected override void Copy(RdcTreeNode node)
		{
		}

		// Token: 0x0400064A RID: 1610
		internal new const string TabName = "Smart Group Settings";

		// Token: 0x0400064B RID: 1611
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
