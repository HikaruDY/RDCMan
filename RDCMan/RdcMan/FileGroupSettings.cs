using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000CD RID: 205
	public class FileGroupSettings : GroupSettings
	{
		// Token: 0x060007A9 RID: 1961 RVA: 0x0002186C File Offset: 0x0001FA6C
		static FileGroupSettings()
		{
			typeof(FileGroupSettings).GetSettingProperties(out FileGroupSettings._settingProperties);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00021884 File Offset: 0x0001FA84
		public FileGroupSettings() : base("File Settings")
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00021894 File Offset: 0x0001FA94
		protected FileGroupSettings(string name) : base(name)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000218A0 File Offset: 0x0001FAA0
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new FileGroupPropertiesTabPage(dialog, this);
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000218AC File Offset: 0x0001FAAC
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return FileGroupSettings._settingProperties;
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000218B4 File Offset: 0x0001FAB4
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (string.IsNullOrEmpty(base.Comment.Value))
			{
				hashSet.Add(base.Comment);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000218F8 File Offset: 0x0001FAF8
		protected override void Copy(RdcTreeNode node)
		{
		}

		// Token: 0x04000329 RID: 809
		internal new const string TabName = "File Settings";

		// Token: 0x0400032A RID: 810
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
