using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200015D RID: 349
	public sealed class GlobalSettings : SettingsGroup
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x00020E84 File Offset: 0x0001F084
		static GlobalSettings()
		{
			typeof(GlobalSettings).GetSettingProperties(out GlobalSettings._settingProperties);
			GlobalSettings._settingProperties["ThumbnailSize"].Attribute.DefaultValue = new Size(160, 120);
			GlobalSettings._settingProperties["WindowPosition"].Attribute.DefaultValue = new Point(200, 200);
			GlobalSettings._settingProperties["WindowSize"].Attribute.DefaultValue = new Size(1273, 823);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000076B9 File Offset: 0x000058B9
		public GlobalSettings() : base("Preferences", "Settings")
		{
			base.InheritSettingsType.Mode = InheritanceMode.Disabled;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00020F2C File Offset: 0x0001F12C
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

		// Token: 0x06000898 RID: 2200 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		public object GetValue(string name)
		{
			object value = GlobalSettings._settingProperties[name].Property.GetValue(this, null);
			return value.GetType().GetProperty("Value").GetValue(value, null);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00020FDC File Offset: 0x0001F1DC
		public void SetValue(string name, object value)
		{
			object value2 = GlobalSettings._settingProperties[name].Property.GetValue(this, null);
			value2.GetType().GetProperty("Value").SetValue(value2, value, null);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000358A File Offset: 0x0000178A
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000076D7 File Offset: 0x000058D7
		protected override void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteAttributeString("programVersion", Program.TheForm.VersionText);
			base.WriteSettings(tw, node);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x000076F6 File Offset: 0x000058F6
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return GlobalSettings._settingProperties;
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000076FD File Offset: 0x000058FD
		protected override void Copy(RdcTreeNode node)
		{
			throw new InvalidOperationException("GlobalSettings should never be copied");
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00007709 File Offset: 0x00005909
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00007711 File Offset: 0x00005911
		[Setting("AutoSaveFiles")]
		public BoolSetting AutoSaveFiles { get; private set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0000771A File Offset: 0x0000591A
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00007722 File Offset: 0x00005922
		[Setting("AutoSaveInterval", DefaultValue = 1)]
		public IntSetting AutoSaveInterval { get; private set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0000772B File Offset: 0x0000592B
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00007733 File Offset: 0x00005933
		[Setting("BuiltInGroups")]
		public XmlSetting BuiltInGroups { get; private set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0000773C File Offset: 0x0000593C
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00007744 File Offset: 0x00005944
		[Setting("ConnectionBarState", DefaultValue = RdpClient.ConnectionBarState.Pinned)]
		public EnumSetting<RdpClient.ConnectionBarState> ConnectionBarState { get; private set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0000774D File Offset: 0x0000594D
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00007755 File Offset: 0x00005955
		[Setting("CredentialsProfiles")]
		public XmlSetting CredentialsProfiles { get; private set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0000775E File Offset: 0x0000595E
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00007766 File Offset: 0x00005966
		[Setting("DefaultGroupSettings")]
		public XmlSetting DefaultGroupSettings { get; private set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0000776F File Offset: 0x0000596F
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00007777 File Offset: 0x00005977
		[Setting("DimNodesWhenInactive")]
		public BoolSetting DimNodesWhenInactive { get; private set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00007780 File Offset: 0x00005980
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00007788 File Offset: 0x00005988
		[Setting("EnablePanning")]
		public BoolSetting EnablePanning { get; private set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00007791 File Offset: 0x00005991
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00007799 File Offset: 0x00005999
		[Setting("FilesToOpen")]
		public ListSetting<string> FilesToOpen { get; private set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000077A2 File Offset: 0x000059A2
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x000077AA File Offset: 0x000059AA
		[Setting("FocusOnClick")]
		public BoolSetting FocusOnClick { get; private set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000077B3 File Offset: 0x000059B3
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x000077BB File Offset: 0x000059BB
		[Setting("FullScreenWindowIsTopMost")]
		public BoolSetting FullScreenWindowIsTopMost { get; private set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000077C4 File Offset: 0x000059C4
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000077CC File Offset: 0x000059CC
		[Setting("GroupSortOrder", DefaultValue = SortOrder.ByName)]
		public EnumSetting<SortOrder> GroupSortOrder { get; private set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000077D5 File Offset: 0x000059D5
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000077DD File Offset: 0x000059DD
		[Setting("HideMainMenu")]
		public BoolSetting HideMainMenu { get; private set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x000077E6 File Offset: 0x000059E6
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x000077EE File Offset: 0x000059EE
		[Setting("HotKeyAltEsc", DefaultValue = Keys.Insert)]
		public EnumSetting<Keys> HotKeyAltEsc { get; private set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x000077F7 File Offset: 0x000059F7
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x000077FF File Offset: 0x000059FF
		[Setting("HotKeyAltShiftTab", DefaultValue = Keys.Next)]
		public EnumSetting<Keys> HotKeyAltShiftTab { get; private set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00007808 File Offset: 0x00005A08
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00007810 File Offset: 0x00005A10
		[Setting("HotKeyAltSpace", DefaultValue = Keys.Delete)]
		public EnumSetting<Keys> HotKeyAltSpace { get; private set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00007819 File Offset: 0x00005A19
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00007821 File Offset: 0x00005A21
		[Setting("HotKeyAltTab", DefaultValue = Keys.Prior)]
		public EnumSetting<Keys> HotKeyAltTab { get; private set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0000782A File Offset: 0x00005A2A
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00007832 File Offset: 0x00005A32
		[Setting("HotKeyCtrlAltDel", DefaultValue = Keys.End)]
		public EnumSetting<Keys> HotKeyCtrlAltDel { get; private set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0000783B File Offset: 0x00005A3B
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00007843 File Offset: 0x00005A43
		[Setting("HotKeyCtrlEsc", DefaultValue = Keys.Home)]
		public EnumSetting<Keys> HotKeyCtrlEsc { get; private set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0000784C File Offset: 0x00005A4C
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00007854 File Offset: 0x00005A54
		[Setting("HotKeyFocusReleaseLeft", DefaultValue = Keys.Left)]
		public EnumSetting<Keys> HotKeyFocusReleaseLeft { get; private set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0000785D File Offset: 0x00005A5D
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00007865 File Offset: 0x00005A65
		[Setting("HotKeyFocusReleaseRight", DefaultValue = Keys.Right)]
		public EnumSetting<Keys> HotKeyFocusReleaseRight { get; private set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0000786E File Offset: 0x00005A6E
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00007876 File Offset: 0x00005A76
		[Setting("HotKeyFullScreen", DefaultValue = Keys.Cancel)]
		public EnumSetting<Keys> HotKeyFullScreen { get; private set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0000787F File Offset: 0x00005A7F
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00007887 File Offset: 0x00005A87
		[Setting("LastUpdateCheckTimeUtc", DefaultValue = "2012-06-01 00:00:00Z")]
		public StringSetting LastUpdateCheckTimeUtc { get; private set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00007890 File Offset: 0x00005A90
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00007898 File Offset: 0x00005A98
		[Setting("LockWindowSize")]
		public BoolSetting LockWindowSize { get; private set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x000078A1 File Offset: 0x00005AA1
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x000078A9 File Offset: 0x00005AA9
		[Setting("PanningAcceleration", DefaultValue = 1)]
		public IntSetting PanningAcceleration { get; private set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000078B2 File Offset: 0x00005AB2
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x000078BA File Offset: 0x00005ABA
		[Setting("PerformanceFlags")]
		public IntSetting PerformanceFlags { get; private set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x000078C3 File Offset: 0x00005AC3
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x000078CB File Offset: 0x00005ACB
		[Setting("PluginSettings")]
		public XmlSetting PluginSettings { get; private set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000078D4 File Offset: 0x00005AD4
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x000078DC File Offset: 0x00005ADC
		[Setting("ReconnectOnStartup", DefaultValue = true)]
		public BoolSetting ReconnectOnStartup { get; private set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000078E5 File Offset: 0x00005AE5
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x000078ED File Offset: 0x00005AED
		[Setting("ServerSortOrder", DefaultValue = SortOrder.ByStatus)]
		public EnumSetting<SortOrder> ServerSortOrder { get; private set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000078F6 File Offset: 0x00005AF6
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000078FE File Offset: 0x00005AFE
		[Setting("ServerTreeAutoHidePopUpDelay")]
		public IntSetting ServerTreeAutoHidePopUpDelay { get; private set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00007907 File Offset: 0x00005B07
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x0000790F File Offset: 0x00005B0F
		[Setting("ServerTreeLocation", DefaultValue = DockStyle.Left)]
		public EnumSetting<DockStyle> ServerTreeLocation { get; private set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00007918 File Offset: 0x00005B18
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00007920 File Offset: 0x00005B20
		[Setting("ServerTreeVisibility", DefaultValue = ControlVisibility.Dock)]
		public EnumSetting<ControlVisibility> ServerTreeVisibility { get; private set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00007929 File Offset: 0x00005B29
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00007931 File Offset: 0x00005B31
		[Setting("ServerTreeWidth", DefaultValue = 200)]
		public IntSetting ServerTreeWidth { get; private set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0000793A File Offset: 0x00005B3A
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00007942 File Offset: 0x00005B42
		[Setting("ShowConnectedGroup")]
		public BoolSetting ShowConnectedGroup { get; private set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0000794B File Offset: 0x00005B4B
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00007953 File Offset: 0x00005B53
		[Setting("ShowFavoritesGroup")]
		public BoolSetting ShowFavoritesGroup { get; private set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0000795C File Offset: 0x00005B5C
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00007964 File Offset: 0x00005B64
		[Setting("ShowRecentlyUsedGroup")]
		public BoolSetting ShowRecentlyUsedGroup { get; private set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0000796D File Offset: 0x00005B6D
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00007975 File Offset: 0x00005B75
		[Setting("ShowReconnectGroup")]
		public BoolSetting ShowReconnectGroup { get; private set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0000797E File Offset: 0x00005B7E
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00007986 File Offset: 0x00005B86
		[Setting("SmartSizeUndockedWindows", IsObsolete = true)]
		public BoolSetting SmartSizeUndockedWindows { get; private set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0000798F File Offset: 0x00005B8F
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00007997 File Offset: 0x00005B97
		[Setting("ThumbnailPercentage", DefaultValue = 15)]
		public IntSetting ThumbnailPercentage { get; private set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x000079A0 File Offset: 0x00005BA0
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x000079A8 File Offset: 0x00005BA8
		[Setting("ThumbnailSize")]
		public SizeSetting ThumbnailSize { get; private set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x000079B1 File Offset: 0x00005BB1
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x000079B9 File Offset: 0x00005BB9
		[Setting("ThumbnailSizeIsInPixels", DefaultValue = true)]
		public BoolSetting ThumbnailSizeIsInPixels { get; private set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x000079C2 File Offset: 0x00005BC2
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x000079CA File Offset: 0x00005BCA
		[Setting("UseMultipleMonitors")]
		public BoolSetting UseMultipleMonitors { get; private set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000079D3 File Offset: 0x00005BD3
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x000079DB File Offset: 0x00005BDB
		[Setting("WindowIsMaximized")]
		public BoolSetting WindowIsMaximized { get; private set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000079E4 File Offset: 0x00005BE4
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x000079EC File Offset: 0x00005BEC
		[Setting("WindowPosition")]
		public PointSetting WindowPosition { get; private set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x000079F5 File Offset: 0x00005BF5
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x000079FD File Offset: 0x00005BFD
		[Setting("WindowSize")]
		public SizeSetting WindowSize { get; private set; }

		// Token: 0x040005FB RID: 1531
		public const string TabName = "Preferences";

		// Token: 0x040005FC RID: 1532
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
