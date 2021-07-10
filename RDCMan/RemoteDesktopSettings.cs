using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000165 RID: 357
	public class RemoteDesktopSettings : SettingsGroup
	{
		// Token: 0x06000955 RID: 2389 RVA: 0x000211D0 File Offset: 0x0001F3D0
		static RemoteDesktopSettings()
		{
			typeof(RemoteDesktopSettings).GetSettingProperties(out RemoteDesktopSettings._settingProperties);
			RemoteDesktopSettings._settingProperties["size"].Attribute.DefaultValue = new Size(1024, 768);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00007DC0 File Offset: 0x00005FC0
		public RemoteDesktopSettings() : base("Remote Desktop Settings", "remoteDesktop")
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00007DD2 File Offset: 0x00005FD2
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new RemoteDesktopTabPage(dialog, this);
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00007DDB File Offset: 0x00005FDB
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return RemoteDesktopSettings._settingProperties;
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00021220 File Offset: 0x0001F420
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (this.DesktopSizeSameAsClientAreaSize.Value || this.DesktopSizeFullScreen.Value)
			{
				hashSet.Add(this.DesktopSize);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00007DE2 File Offset: 0x00005FE2
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.RemoteDesktopSettings);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00007DF0 File Offset: 0x00005FF0
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00007DF8 File Offset: 0x00005FF8
		[Setting("size")]
		public SizeSetting DesktopSize { get; private set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00007E01 File Offset: 0x00006001
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00007E09 File Offset: 0x00006009
		[Setting("sameSizeAsClientArea")]
		public BoolSetting DesktopSizeSameAsClientAreaSize { get; private set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00007E12 File Offset: 0x00006012
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00007E1A File Offset: 0x0000601A
		[Setting("fullScreen", DefaultValue = true)]
		public BoolSetting DesktopSizeFullScreen { get; private set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00007E23 File Offset: 0x00006023
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00007E2B File Offset: 0x0000602B
		[Setting("colorDepth", DefaultValue = 24)]
		public IntSetting ColorDepth { get; private set; }

		// Token: 0x0400064C RID: 1612
		internal const string TabName = "Remote Desktop Settings";

		// Token: 0x0400064D RID: 1613
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
