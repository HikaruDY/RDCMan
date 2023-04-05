using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000CB RID: 203
	public class ServerSettings : CommonNodeSettings
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x00021678 File Offset: 0x0001F878
		static ServerSettings()
		{
			typeof(ServerSettings).GetSettingProperties(out ServerSettings._settingProperties);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00021690 File Offset: 0x0001F890
		public ServerSettings() : base("Server Settings")
		{
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x000216A0 File Offset: 0x0001F8A0
		public StringSetting ServerName
		{
			get
			{
				return base.NodeName;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x000216A8 File Offset: 0x0001F8A8
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x000216B0 File Offset: 0x0001F8B0
		[Setting("displayName")]
		public StringSetting DisplayName { get; private set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x000216BC File Offset: 0x0001F8BC
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x000216C4 File Offset: 0x0001F8C4
		[Setting("connectionType")]
		public EnumSetting<ConnectionType> ConnectionType { get; private set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x000216D0 File Offset: 0x0001F8D0
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x000216D8 File Offset: 0x0001F8D8
		[Setting("vmId")]
		public StringSetting VirtualMachineId { get; private set; }

		// Token: 0x0600079B RID: 1947 RVA: 0x000216E4 File Offset: 0x0001F8E4
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ServerPropertiesTabPage(dialog, this);
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x000216F0 File Offset: 0x0001F8F0
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ServerSettings._settingProperties;
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000216F8 File Offset: 0x0001F8F8
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

		// Token: 0x0600079E RID: 1950 RVA: 0x00021794 File Offset: 0x0001F994
		protected override void Copy(RdcTreeNode node)
		{
			ServerBase serverBase = node as ServerBase;
			if (serverBase != null)
			{
				base.Copy(serverBase.Properties);
			}
		}

		// Token: 0x04000321 RID: 801
		internal const string TabName = "Server Settings";

		// Token: 0x04000322 RID: 802
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
