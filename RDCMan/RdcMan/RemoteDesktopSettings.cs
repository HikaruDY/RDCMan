using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000CF RID: 207
	public class RemoteDesktopSettings : SettingsGroup
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x00021980 File Offset: 0x0001FB80
		static RemoteDesktopSettings()
		{
			typeof(RemoteDesktopSettings).GetSettingProperties(out RemoteDesktopSettings._settingProperties);
			RemoteDesktopSettings._settingProperties["size"].Attribute.DefaultValue = new Size(1024, 768);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000219D4 File Offset: 0x0001FBD4
		public RemoteDesktopSettings() : base("Remote Desktop Settings", "remoteDesktop")
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000219E8 File Offset: 0x0001FBE8
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new RemoteDesktopTabPage(dialog, this);
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x000219F4 File Offset: 0x0001FBF4
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return RemoteDesktopSettings._settingProperties;
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000219FC File Offset: 0x0001FBFC
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			HashSet<ISetting> hashSet = new HashSet<ISetting>();
			if (this.DesktopSizeSameAsClientAreaSize.Value || this.DesktopSizeFullScreen.Value)
			{
				hashSet.Add(this.DesktopSize);
			}
			base.WriteSettings(tw, node, hashSet);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00021A4C File Offset: 0x0001FC4C
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.RemoteDesktopSettings);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00021A5C File Offset: 0x0001FC5C
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00021A64 File Offset: 0x0001FC64
		[Setting("size")]
		public SizeSetting DesktopSize { get; private set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00021A70 File Offset: 0x0001FC70
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00021A78 File Offset: 0x0001FC78
		[Setting("sameSizeAsClientArea")]
		public BoolSetting DesktopSizeSameAsClientAreaSize { get; private set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00021A84 File Offset: 0x0001FC84
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00021A8C File Offset: 0x0001FC8C
		[Setting("fullScreen", DefaultValue = true)]
		public BoolSetting DesktopSizeFullScreen { get; private set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00021A98 File Offset: 0x0001FC98
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00021AA0 File Offset: 0x0001FCA0
		[Setting("colorDepth", DefaultValue = 24)]
		public IntSetting ColorDepth { get; private set; }

		// Token: 0x0400032D RID: 813
		internal const string TabName = "Remote Desktop Settings";

		// Token: 0x0400032E RID: 814
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
