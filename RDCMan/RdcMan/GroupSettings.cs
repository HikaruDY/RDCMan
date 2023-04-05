using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public class GroupSettings : CommonNodeSettings
	{
		static GroupSettings()
		{
			typeof(GroupSettings).GetSettingProperties(out GroupSettings._settingProperties);
		}

		public GroupSettings() : base("Group Settings")
		{
		}

		protected GroupSettings(string name) : base(name)
		{
		}

		public StringSetting GroupName
		{
			get
			{
				return base.NodeName;
			}
		}

		[Setting("expanded")]
		public BoolSetting Expanded { get; protected set; }

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new GroupPropertiesTabPage(dialog, this);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GroupSettings._settingProperties;
			}
		}

		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (string.IsNullOrEmpty(base.Comment.Value))
			{
				hashSet.Add(base.Comment);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		protected override void Copy(RdcTreeNode node)
		{
		}

		internal const string TabName = "Group Settings";

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
