using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public class ServerSettings : CommonNodeSettings
	{
		static ServerSettings()
		{
			typeof(ServerSettings).GetSettingProperties(out ServerSettings._settingProperties);
		}

		public ServerSettings() : base("Server Settings")
		{
		}

		public StringSetting ServerName
		{
			get
			{
				return base.NodeName;
			}
		}

		[Setting("displayName")]
		public StringSetting DisplayName { get; private set; }

		[Setting("connectionType")]
		public EnumSetting<ConnectionType> ConnectionType { get; private set; }

		[Setting("vmId")]
		public StringSetting VirtualMachineId { get; private set; }

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ServerPropertiesTabPage(dialog, this);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ServerSettings._settingProperties;
			}
		}

		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (this.ConnectionType.Value == RdcMan.ConnectionType.Normal)
			{
				hashSet.Add(this.ConnectionType);
				hashSet.Add(this.VirtualMachineId);
			}
			if (this.ServerName.Value.Equals(this.DisplayName.Value))
			{
				hashSet.Add(this.DisplayName);
			}
			if (string.IsNullOrEmpty(base.Comment.Value))
			{
				hashSet.Add(base.Comment);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		protected override void Copy(RdcTreeNode node)
		{
			ServerBase serverBase = node as ServerBase;
			if (serverBase != null)
			{
				base.Copy(serverBase.Properties);
			}
		}

		internal const string TabName = "Server Settings";

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
