using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200015E RID: 350
	public class LocalResourcesSettings : SettingsGroup
	{
		// Token: 0x060008F8 RID: 2296 RVA: 0x00007A06 File Offset: 0x00005C06
		static LocalResourcesSettings()
		{
			typeof(LocalResourcesSettings).GetSettingProperties(out LocalResourcesSettings._settingProperties);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00007A1C File Offset: 0x00005C1C
		public LocalResourcesSettings() : base("Local Resources", "localResources")
		{
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00007A2E File Offset: 0x00005C2E
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new LocalResourcesTabPage(dialog, this);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00007A37 File Offset: 0x00005C37
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return LocalResourcesSettings._settingProperties;
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00007A3E File Offset: 0x00005C3E
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.LocalResourceSettings);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00007A4C File Offset: 0x00005C4C
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00007A54 File Offset: 0x00005C54
		[Setting("audioRedirection", DefaultValue = RdpClient.AudioCaptureRedirectionMode.DoNotRecord)]
		public EnumSetting<RdpClient.AudioRedirectionMode> AudioRedirectionMode { get; private set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00007A5D File Offset: 0x00005C5D
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00007A65 File Offset: 0x00005C65
		[Setting("audioRedirectionQuality", DefaultValue = RdpClient.AudioRedirectionQuality.Dynamic)]
		public EnumSetting<RdpClient.AudioRedirectionQuality> AudioRedirectionQuality { get; private set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00007A6E File Offset: 0x00005C6E
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00007A76 File Offset: 0x00005C76
		[Setting("audioCaptureRedirection", DefaultValue = RdpClient.AudioCaptureRedirectionMode.DoNotRecord)]
		public EnumSetting<RdpClient.AudioCaptureRedirectionMode> AudioCaptureRedirectionMode { get; private set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00007A7F File Offset: 0x00005C7F
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00007A87 File Offset: 0x00005C87
		[Setting("keyboardHook", DefaultValue = RdpClient.KeyboardHookMode.FullScreenClient)]
		public EnumSetting<RdpClient.KeyboardHookMode> KeyboardHookMode { get; private set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00007A90 File Offset: 0x00005C90
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x00007A98 File Offset: 0x00005C98
		[Setting("redirectClipboard", DefaultValue = true)]
		public BoolSetting RedirectClipboard { get; private set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x00007AA1 File Offset: 0x00005CA1
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x00007AA9 File Offset: 0x00005CA9
		[Setting("redirectDrives")]
		public BoolSetting RedirectDrives { get; private set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00007AB2 File Offset: 0x00005CB2
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x00007ABA File Offset: 0x00005CBA
		[Setting("redirectDrivesList")]
		public ListSetting<string> RedirectDrivesList { get; private set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00007AC3 File Offset: 0x00005CC3
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00007ACB File Offset: 0x00005CCB
		[Setting("redirectPrinters")]
		public BoolSetting RedirectPrinters { get; private set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x00007AD4 File Offset: 0x00005CD4
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00007ADC File Offset: 0x00005CDC
		[Setting("redirectPorts")]
		public BoolSetting RedirectPorts { get; private set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00007AE5 File Offset: 0x00005CE5
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00007AED File Offset: 0x00005CED
		[Setting("redirectSmartCards", DefaultValue = true)]
		public BoolSetting RedirectSmartCards { get; private set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00007AF6 File Offset: 0x00005CF6
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00007AFE File Offset: 0x00005CFE
		[Setting("redirectPnpDevices")]
		public BoolSetting RedirectPnpDevices { get; private set; }

		// Token: 0x0400062A RID: 1578
		internal const string TabName = "Local Resources";

		// Token: 0x0400062B RID: 1579
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
