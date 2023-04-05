using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000C7 RID: 199
	public sealed class GlobalSettings : SettingsGroup
	{
		// Token: 0x060006F4 RID: 1780 RVA: 0x00020CF0 File Offset: 0x0001EEF0
		static GlobalSettings()
		{
			typeof(GlobalSettings).GetSettingProperties(out GlobalSettings._settingProperties);
			GlobalSettings._settingProperties["ThumbnailSize"].Attribute.DefaultValue = new Size(160, 120);
			GlobalSettings._settingProperties["WindowPosition"].Attribute.DefaultValue = new Point(200, 200);
			GlobalSettings._settingProperties["WindowSize"].Attribute.DefaultValue = new Size(1273, 823);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00020D9C File Offset: 0x0001EF9C
		public GlobalSettings() : base("Preferences", "Settings")
		{
			base.InheritSettingsType.Mode = InheritanceMode.Disabled;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00020DBC File Offset: 0x0001EFBC
		public void TransferPreferences(Preferences prefs)
		{
			foreach (string name in GlobalSettings._settingProperties.Keys)
			{
				try
				{
					object transferValue = prefs.GetTransferValue(name);
					this.SetValue(name, transferValue);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00020E3C File Offset: 0x0001F03C
		public object GetValue(string name)
		{
			object value = GlobalSettings._settingProperties[name].Property.GetValue(this, null);
			return value.GetType().GetProperty("Value").GetValue(value, null);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00020E7C File Offset: 0x0001F07C
		public void SetValue(string name, object value)
		{
			object value2 = GlobalSettings._settingProperties[name].Property.GetValue(this, null);
			value2.GetType().GetProperty("Value").SetValue(value2, value, null);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00020EC0 File Offset: 0x0001F0C0
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteAttributeString("programVersion", Program.TheForm.VersionText);
			base.WriteSettings(tw, node);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GlobalSettings._settingProperties;
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00020EF0 File Offset: 0x0001F0F0
		protected override void Copy(RdcTreeNode node)
		{
			throw new InvalidOperationException("GlobalSettings should never be copied");
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00020EFC File Offset: 0x0001F0FC
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00020F04 File Offset: 0x0001F104
		[Setting("AutoSaveFiles")]
		public BoolSetting AutoSaveFiles { get; private set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00020F10 File Offset: 0x0001F110
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00020F18 File Offset: 0x0001F118
		[Setting("AutoSaveInterval", DefaultValue = 1)]
		public IntSetting AutoSaveInterval { get; private set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00020F24 File Offset: 0x0001F124
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00020F2C File Offset: 0x0001F12C
		[Setting("BuiltInGroups")]
		public XmlSetting BuiltInGroups { get; private set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00020F38 File Offset: 0x0001F138
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00020F40 File Offset: 0x0001F140
		[Setting("ConnectionBarState", DefaultValue = RdpClient.ConnectionBarState.Pinned)]
		public EnumSetting<RdpClient.ConnectionBarState> ConnectionBarState { get; private set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00020F4C File Offset: 0x0001F14C
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00020F54 File Offset: 0x0001F154
		[Setting("CredentialsProfiles")]
		public XmlSetting CredentialsProfiles { get; private set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00020F60 File Offset: 0x0001F160
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00020F68 File Offset: 0x0001F168
		[Setting("DefaultGroupSettings")]
		public XmlSetting DefaultGroupSettings { get; private set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00020F74 File Offset: 0x0001F174
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00020F7C File Offset: 0x0001F17C
		[Setting("DimNodesWhenInactive")]
		public BoolSetting DimNodesWhenInactive { get; private set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00020F88 File Offset: 0x0001F188
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00020F90 File Offset: 0x0001F190
		[Setting("EnablePanning")]
		public BoolSetting EnablePanning { get; private set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00020F9C File Offset: 0x0001F19C
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		[Setting("FilesToOpen")]
		public ListSetting<string> FilesToOpen { get; private set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00020FB0 File Offset: 0x0001F1B0
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		[Setting("FocusOnClick")]
		public BoolSetting FocusOnClick { get; private set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00020FC4 File Offset: 0x0001F1C4
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00020FCC File Offset: 0x0001F1CC
		[Setting("FullScreenWindowIsTopMost")]
		public BoolSetting FullScreenWindowIsTopMost { get; private set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00020FD8 File Offset: 0x0001F1D8
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00020FE0 File Offset: 0x0001F1E0
		[Setting("GroupSortOrder", DefaultValue = SortOrder.ByName)]
		public EnumSetting<SortOrder> GroupSortOrder { get; private set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00020FEC File Offset: 0x0001F1EC
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00020FF4 File Offset: 0x0001F1F4
		[Setting("HideMainMenu")]
		public BoolSetting HideMainMenu { get; private set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00021000 File Offset: 0x0001F200
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00021008 File Offset: 0x0001F208
		[Setting("HotKeyAltEsc", DefaultValue = Keys.Insert)]
		public EnumSetting<Keys> HotKeyAltEsc { get; private set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00021014 File Offset: 0x0001F214
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x0002101C File Offset: 0x0001F21C
		[Setting("HotKeyAltShiftTab", DefaultValue = Keys.Next)]
		public EnumSetting<Keys> HotKeyAltShiftTab { get; private set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00021028 File Offset: 0x0001F228
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00021030 File Offset: 0x0001F230
		[Setting("HotKeyAltSpace", DefaultValue = Keys.Delete)]
		public EnumSetting<Keys> HotKeyAltSpace { get; private set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x0002103C File Offset: 0x0001F23C
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00021044 File Offset: 0x0001F244
		[Setting("HotKeyAltTab", DefaultValue = Keys.Prior)]
		public EnumSetting<Keys> HotKeyAltTab { get; private set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00021050 File Offset: 0x0001F250
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00021058 File Offset: 0x0001F258
		[Setting("HotKeyCtrlAltDel", DefaultValue = Keys.End)]
		public EnumSetting<Keys> HotKeyCtrlAltDel { get; private set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00021064 File Offset: 0x0001F264
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x0002106C File Offset: 0x0001F26C
		[Setting("HotKeyCtrlEsc", DefaultValue = Keys.Home)]
		public EnumSetting<Keys> HotKeyCtrlEsc { get; private set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00021078 File Offset: 0x0001F278
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00021080 File Offset: 0x0001F280
		[Setting("HotKeyFocusReleaseLeft", DefaultValue = Keys.Left)]
		public EnumSetting<Keys> HotKeyFocusReleaseLeft { get; private set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x0002108C File Offset: 0x0001F28C
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00021094 File Offset: 0x0001F294
		[Setting("HotKeyFocusReleaseRight", DefaultValue = Keys.Right)]
		public EnumSetting<Keys> HotKeyFocusReleaseRight { get; private set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x000210A0 File Offset: 0x0001F2A0
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x000210A8 File Offset: 0x0001F2A8
		[Setting("HotKeyFullScreen", DefaultValue = Keys.Cancel)]
		public EnumSetting<Keys> HotKeyFullScreen { get; private set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x000210B4 File Offset: 0x0001F2B4
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x000210BC File Offset: 0x0001F2BC
		[Setting("LastUpdateCheckTimeUtc", DefaultValue = "2012-06-01 00:00:00Z")]
		public StringSetting LastUpdateCheckTimeUtc { get; private set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000210C8 File Offset: 0x0001F2C8
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x000210D0 File Offset: 0x0001F2D0
		[Setting("LockWindowSize")]
		public BoolSetting LockWindowSize { get; private set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x000210DC File Offset: 0x0001F2DC
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x000210E4 File Offset: 0x0001F2E4
		[Setting("PanningAcceleration", DefaultValue = 1)]
		public IntSetting PanningAcceleration { get; private set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x000210F0 File Offset: 0x0001F2F0
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x000210F8 File Offset: 0x0001F2F8
		[Setting("PerformanceFlags")]
		public IntSetting PerformanceFlags { get; private set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00021104 File Offset: 0x0001F304
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x0002110C File Offset: 0x0001F30C
		[Setting("PersistentBitmapCaching")]
		public BoolSetting PersistentBitmapCaching { get; private set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00021118 File Offset: 0x0001F318
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00021120 File Offset: 0x0001F320
		[Setting("PluginSettings")]
		public XmlSetting PluginSettings { get; private set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0002112C File Offset: 0x0001F32C
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00021134 File Offset: 0x0001F334
		[Setting("ReconnectOnStartup", DefaultValue = true)]
		public BoolSetting ReconnectOnStartup { get; private set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00021140 File Offset: 0x0001F340
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00021148 File Offset: 0x0001F348
		[Setting("ServerSortOrder", DefaultValue = SortOrder.ByStatus)]
		public EnumSetting<SortOrder> ServerSortOrder { get; private set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00021154 File Offset: 0x0001F354
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x0002115C File Offset: 0x0001F35C
		[Setting("ServerTreeAutoHidePopUpDelay")]
		public IntSetting ServerTreeAutoHidePopUpDelay { get; private set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00021168 File Offset: 0x0001F368
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00021170 File Offset: 0x0001F370
		[Setting("ServerTreeLocation", DefaultValue = DockStyle.Left)]
		public EnumSetting<DockStyle> ServerTreeLocation { get; private set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0002117C File Offset: 0x0001F37C
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00021184 File Offset: 0x0001F384
		[Setting("ServerTreeVisibility", DefaultValue = ControlVisibility.Dock)]
		public EnumSetting<ControlVisibility> ServerTreeVisibility { get; private set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00021190 File Offset: 0x0001F390
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00021198 File Offset: 0x0001F398
		[Setting("ServerTreeWidth", DefaultValue = 200)]
		public IntSetting ServerTreeWidth { get; private set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x000211A4 File Offset: 0x0001F3A4
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x000211AC File Offset: 0x0001F3AC
		[Setting("ShowConnectedGroup")]
		public BoolSetting ShowConnectedGroup { get; private set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x000211B8 File Offset: 0x0001F3B8
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x000211C0 File Offset: 0x0001F3C0
		[Setting("ShowFavoritesGroup")]
		public BoolSetting ShowFavoritesGroup { get; private set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x000211CC File Offset: 0x0001F3CC
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x000211D4 File Offset: 0x0001F3D4
		[Setting("ShowRecentlyUsedGroup")]
		public BoolSetting ShowRecentlyUsedGroup { get; private set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x000211E0 File Offset: 0x0001F3E0
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x000211E8 File Offset: 0x0001F3E8
		[Setting("ShowReconnectGroup")]
		public BoolSetting ShowReconnectGroup { get; private set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x000211F4 File Offset: 0x0001F3F4
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x000211FC File Offset: 0x0001F3FC
		[Setting("SmartSizeUndockedWindows", IsObsolete = true)]
		public BoolSetting SmartSizeUndockedWindows { get; private set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00021208 File Offset: 0x0001F408
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00021210 File Offset: 0x0001F410
		[Setting("ThumbnailPercentage", DefaultValue = 15)]
		public IntSetting ThumbnailPercentage { get; private set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0002121C File Offset: 0x0001F41C
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00021224 File Offset: 0x0001F424
		[Setting("ThumbnailSize")]
		public SizeSetting ThumbnailSize { get; private set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00021230 File Offset: 0x0001F430
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00021238 File Offset: 0x0001F438
		[Setting("ThumbnailSizeIsInPixels", DefaultValue = true)]
		public BoolSetting ThumbnailSizeIsInPixels { get; private set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00021244 File Offset: 0x0001F444
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x0002124C File Offset: 0x0001F44C
		[Setting("UseMultipleMonitors")]
		public BoolSetting UseMultipleMonitors { get; private set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00021258 File Offset: 0x0001F458
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00021260 File Offset: 0x0001F460
		[Setting("WindowIsMaximized")]
		public BoolSetting WindowIsMaximized { get; private set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0002126C File Offset: 0x0001F46C
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00021274 File Offset: 0x0001F474
		[Setting("WindowPosition")]
		public PointSetting WindowPosition { get; private set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00021280 File Offset: 0x0001F480
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00021288 File Offset: 0x0001F488
		[Setting("WindowSize")]
		public SizeSetting WindowSize { get; private set; }

		// Token: 0x040002DB RID: 731
		public const string TabName = "Preferences";

		// Token: 0x040002DC RID: 732
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
