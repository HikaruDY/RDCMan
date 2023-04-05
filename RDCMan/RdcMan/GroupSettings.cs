using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000CC RID: 204
	public class GroupSettings : CommonNodeSettings
	{
		// Token: 0x0600079F RID: 1951 RVA: 0x000217C0 File Offset: 0x0001F9C0
		static GroupSettings()
		{
			typeof(GroupSettings).GetSettingProperties(out GroupSettings._settingProperties);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000217D8 File Offset: 0x0001F9D8
		public GroupSettings() : base("Group Settings")
		{
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000217E8 File Offset: 0x0001F9E8
		protected GroupSettings(string name) : base(name)
		{
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x000217F4 File Offset: 0x0001F9F4
		public StringSetting GroupName
		{
			get
			{
				return base.NodeName;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x000217FC File Offset: 0x0001F9FC
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00021804 File Offset: 0x0001FA04
		[Setting("expanded")]
		public BoolSetting Expanded { get; protected set; }

		// Token: 0x060007A5 RID: 1957 RVA: 0x00021810 File Offset: 0x0001FA10
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new GroupPropertiesTabPage(dialog, this);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0002181C File Offset: 0x0001FA1C
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GroupSettings._settingProperties;
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00021824 File Offset: 0x0001FA24
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (string.IsNullOrEmpty(base.Comment.Value))
			{
				hashSet.Add(base.Comment);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00021868 File Offset: 0x0001FA68
		protected override void Copy(RdcTreeNode node)
		{
		}

		// Token: 0x04000326 RID: 806
		internal const string TabName = "Group Settings";

		// Token: 0x04000327 RID: 807
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
