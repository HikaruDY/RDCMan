using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000162 RID: 354
	public class GroupSettings : CommonNodeSettings
	{
		// Token: 0x0600093E RID: 2366 RVA: 0x00007D04 File Offset: 0x00005F04
		static GroupSettings()
		{
			typeof(GroupSettings).GetSettingProperties(out GroupSettings._settingProperties);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00007D1A File Offset: 0x00005F1A
		public GroupSettings() : base("Group Settings")
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00007D27 File Offset: 0x00005F27
		protected GroupSettings(string name) : base(name)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00007CB9 File Offset: 0x00005EB9
		public StringSetting GroupName
		{
			get
			{
				return base.NodeName;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00007D30 File Offset: 0x00005F30
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00007D38 File Offset: 0x00005F38
		[Setting("expanded")]
		public BoolSetting Expanded { get; protected set; }

		// Token: 0x06000944 RID: 2372 RVA: 0x00007D41 File Offset: 0x00005F41
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new GroupPropertiesTabPage(dialog, this);
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00007D4A File Offset: 0x00005F4A
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GroupSettings._settingProperties;
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00021194 File Offset: 0x0001F394
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (string.IsNullOrEmpty(base.Comment.Value))
			{
				hashSet.Add(base.Comment);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002EFA File Offset: 0x000010FA
		protected override void Copy(RdcTreeNode node)
		{
		}

		// Token: 0x04000645 RID: 1605
		internal const string TabName = "Group Settings";

		// Token: 0x04000646 RID: 1606
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
