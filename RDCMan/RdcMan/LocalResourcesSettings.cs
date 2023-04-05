using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000C8 RID: 200
	public class LocalResourcesSettings : SettingsGroup
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00021294 File Offset: 0x0001F494
		static LocalResourcesSettings()
		{
			typeof(LocalResourcesSettings).GetSettingProperties(out LocalResourcesSettings._settingProperties);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000212AC File Offset: 0x0001F4AC
		public LocalResourcesSettings() : base("Local Resources", "localResources")
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000212C0 File Offset: 0x0001F4C0
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new LocalResourcesTabPage(dialog, this);
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x000212CC File Offset: 0x0001F4CC
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return LocalResourcesSettings._settingProperties;
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000212D4 File Offset: 0x0001F4D4
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.LocalResourceSettings);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x000212E4 File Offset: 0x0001F4E4
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x000212EC File Offset: 0x0001F4EC
		[Setting("audioRedirection", DefaultValue = RdpClient.AudioCaptureRedirectionMode.DoNotRecord)]
		public EnumSetting<RdpClient.AudioRedirectionMode> AudioRedirectionMode { get; private set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000212F8 File Offset: 0x0001F4F8
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00021300 File Offset: 0x0001F500
		[Setting("audioRedirectionQuality", DefaultValue = RdpClient.AudioRedirectionQuality.Dynamic)]
		public EnumSetting<RdpClient.AudioRedirectionQuality> AudioRedirectionQuality { get; private set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0002130C File Offset: 0x0001F50C
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00021314 File Offset: 0x0001F514
		[Setting("audioCaptureRedirection", DefaultValue = RdpClient.AudioCaptureRedirectionMode.DoNotRecord)]
		public EnumSetting<RdpClient.AudioCaptureRedirectionMode> AudioCaptureRedirectionMode { get; private set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00021320 File Offset: 0x0001F520
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00021328 File Offset: 0x0001F528
		[Setting("keyboardHook", DefaultValue = RdpClient.KeyboardHookMode.FullScreenClient)]
		public EnumSetting<RdpClient.KeyboardHookMode> KeyboardHookMode { get; private set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00021334 File Offset: 0x0001F534
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x0002133C File Offset: 0x0001F53C
		[Setting("redirectClipboard", DefaultValue = true)]
		public BoolSetting RedirectClipboard { get; private set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00021348 File Offset: 0x0001F548
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00021350 File Offset: 0x0001F550
		[Setting("redirectDrives")]
		public BoolSetting RedirectDrives { get; private set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0002135C File Offset: 0x0001F55C
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00021364 File Offset: 0x0001F564
		[Setting("redirectDrivesList")]
		public ListSetting<string> RedirectDrivesList { get; private set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00021370 File Offset: 0x0001F570
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00021378 File Offset: 0x0001F578
		[Setting("redirectPrinters")]
		public BoolSetting RedirectPrinters { get; private set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00021384 File Offset: 0x0001F584
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0002138C File Offset: 0x0001F58C
		[Setting("redirectPorts")]
		public BoolSetting RedirectPorts { get; private set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00021398 File Offset: 0x0001F598
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000213A0 File Offset: 0x0001F5A0
		[Setting("redirectSmartCards", DefaultValue = true)]
		public BoolSetting RedirectSmartCards { get; private set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000213AC File Offset: 0x0001F5AC
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x000213B4 File Offset: 0x0001F5B4
		[Setting("redirectPnpDevices")]
		public BoolSetting RedirectPnpDevices { get; private set; }

		// Token: 0x0400030B RID: 779
		internal const string TabName = "Local Resources";

		// Token: 0x0400030C RID: 780
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
