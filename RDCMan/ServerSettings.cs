using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000161 RID: 353
	public class ServerSettings : CommonNodeSettings
	{
		// Token: 0x06000931 RID: 2353 RVA: 0x00007C96 File Offset: 0x00005E96
		static ServerSettings()
		{
			typeof(ServerSettings).GetSettingProperties(out ServerSettings._settingProperties);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00007CAC File Offset: 0x00005EAC
		public ServerSettings() : base("Server Settings")
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00007CB9 File Offset: 0x00005EB9
		public StringSetting ServerName
		{
			get
			{
				return base.NodeName;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00007CC1 File Offset: 0x00005EC1
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00007CC9 File Offset: 0x00005EC9
		[Setting("displayName")]
		public StringSetting DisplayName { get; private set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00007CD2 File Offset: 0x00005ED2
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00007CDA File Offset: 0x00005EDA
		[Setting("connectionType")]
		public EnumSetting<ConnectionType> ConnectionType { get; private set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00007CE3 File Offset: 0x00005EE3
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00007CEB File Offset: 0x00005EEB
		[Setting("vmId")]
		public StringSetting VirtualMachineId { get; private set; }

		// Token: 0x0600093A RID: 2362 RVA: 0x00007CF4 File Offset: 0x00005EF4
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new ServerPropertiesTabPage(dialog, this);
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00007CFD File Offset: 0x00005EFD
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return ServerSettings._settingProperties;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000210E4 File Offset: 0x0001F2E4
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

		// Token: 0x0600093D RID: 2365 RVA: 0x00021170 File Offset: 0x0001F370
		protected override void Copy(RdcTreeNode node)
		{
			ServerBase serverBase = node as ServerBase;
			if (serverBase != null)
			{
				base.Copy(serverBase.Properties);
			}
		}

		// Token: 0x04000640 RID: 1600
		internal const string TabName = "Server Settings";

		// Token: 0x04000641 RID: 1601
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
