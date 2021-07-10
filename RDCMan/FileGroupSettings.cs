using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000163 RID: 355
	public class FileGroupSettings : GroupSettings
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x00007D51 File Offset: 0x00005F51
		static FileGroupSettings()
		{
			typeof(FileGroupSettings).GetSettingProperties(out FileGroupSettings._settingProperties);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00007D67 File Offset: 0x00005F67
		public FileGroupSettings() : base("File Settings")
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00007D74 File Offset: 0x00005F74
		protected FileGroupSettings(string name) : base(name)
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00007D7D File Offset: 0x00005F7D
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new FileGroupPropertiesTabPage(dialog, this);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00007D86 File Offset: 0x00005F86
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return FileGroupSettings._settingProperties;
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00021194 File Offset: 0x0001F394
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (string.IsNullOrEmpty(base.Comment.Value))
			{
				hashSet.Add(base.Comment);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002EFA File Offset: 0x000010FA
		protected override void Copy(RdcTreeNode node)
		{
		}

		// Token: 0x04000648 RID: 1608
		internal new const string TabName = "File Settings";

		// Token: 0x04000649 RID: 1609
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
