﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public class FileGroupSettings : GroupSettings
	{
		static FileGroupSettings()
		{
			typeof(FileGroupSettings).GetSettingProperties(out FileGroupSettings._settingProperties);
		}

		public FileGroupSettings() : base("File Settings")
		{
		}

		protected FileGroupSettings(string name) : base(name)
		{
		}

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new FileGroupPropertiesTabPage(dialog, this);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return FileGroupSettings._settingProperties;
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

		internal new const string TabName = "File Settings";

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
