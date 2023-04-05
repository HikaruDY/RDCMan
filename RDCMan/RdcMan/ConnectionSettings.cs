using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	public class ConnectionSettings : SettingsGroup
	{
		static ConnectionSettings()
		{
			typeof(ConnectionSettings).GetSettingProperties(out ConnectionSettings._settingProperties);
		}

		public ConnectionSettings() : base("Connection Settings", "connectionSettings")
		{
		}

		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ConnectionSettingsTabPage(dialog, this);
		}

		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ConnectionSettings._settingProperties;
			}
		}

		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.ConnectionSettings);
		}

		[Setting("connectToConsole")]
		public BoolSetting ConnectToConsole { get; private set; }

		[Setting("startProgram")]
		public StringSetting StartProgram { get; private set; }

		[Setting("workingDir")]
		public StringSetting WorkingDir { get; private set; }

		[Setting("port", DefaultValue = 3389)]
		public IntSetting Port { get; private set; }

		[Setting("loadBalanceInfo")]
		public StringSetting LoadBalanceInfo { get; private set; }

		internal const string TabName = "Connection Settings";

		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
