using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200008F RID: 143
	[SettingsProvider(typeof(RdcSettingsProvider))]
	public sealed partial class Preferences : ApplicationSettingsBase
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00018A74 File Offset: 0x00016C74
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00018A88 File Offset: 0x00016C88
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool AutoSaveFiles
		{
			get
			{
				return (bool)this["AutoSaveFiles"];
			}
			set
			{
				this["AutoSaveFiles"] = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00018A9C File Offset: 0x00016C9C
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00018AB0 File Offset: 0x00016CB0
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int AutoSaveInterval
		{
			get
			{
				return (int)this["AutoSaveInterval"];
			}
			set
			{
				this["AutoSaveInterval"] = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00018AC4 File Offset: 0x00016CC4
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00018AD8 File Offset: 0x00016CD8
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool ShowConnectedGroup
		{
			get
			{
				return (bool)this["ShowConnectedGroup"];
			}
			set
			{
				this["ShowConnectedGroup"] = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00018AEC File Offset: 0x00016CEC
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00018B00 File Offset: 0x00016D00
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool ShowFavoritesGroup
		{
			get
			{
				return (bool)this["ShowFavoritesGroup"];
			}
			set
			{
				this["ShowFavoritesGroup"] = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00018B14 File Offset: 0x00016D14
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00018B28 File Offset: 0x00016D28
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool ShowReconnectGroup
		{
			get
			{
				return (bool)this["ShowReconnectGroup"];
			}
			set
			{
				this["ShowReconnectGroup"] = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00018B3C File Offset: 0x00016D3C
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00018B50 File Offset: 0x00016D50
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool ShowRecentlyUsedGroup
		{
			get
			{
				return (bool)this["ShowRecentlyUsedGroup"];
			}
			set
			{
				this["ShowRecentlyUsedGroup"] = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00018BD0 File Offset: 0x00016DD0
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00018BE4 File Offset: 0x00016DE4
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool FocusOnClick
		{
			get
			{
				return (bool)this["FocusOnClick"];
			}
			set
			{
				this["FocusOnClick"] = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00018BF8 File Offset: 0x00016DF8
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00018C0C File Offset: 0x00016E0C
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool DimNodesWhenInactive
		{
			get
			{
				return (bool)this["DimNodesWhenInactive"];
			}
			set
			{
				this["DimNodesWhenInactive"] = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00018C20 File Offset: 0x00016E20
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00018C34 File Offset: 0x00016E34
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool FullScreenWindowIsTopMost
		{
			get
			{
				return (bool)this["FullScreenWindowIsTopMost"];
			}
			set
			{
				this["FullScreenWindowIsTopMost"] = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00018C48 File Offset: 0x00016E48
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00018C5C File Offset: 0x00016E5C
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool UseMultipleMonitors
		{
			get
			{
				return (bool)this["UseMultipleMonitors"];
			}
			set
			{
				this["UseMultipleMonitors"] = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00018C70 File Offset: 0x00016E70
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00018C84 File Offset: 0x00016E84
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool EnablePanning
		{
			get
			{
				return (bool)this["EnablePanning"];
			}
			set
			{
				this["EnablePanning"] = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00018C98 File Offset: 0x00016E98
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00018CAC File Offset: 0x00016EAC
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		public int PanningAcceleration
		{
			get
			{
				return (int)this["PanningAcceleration"];
			}
			set
			{
				this["PanningAcceleration"] = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00018CC0 File Offset: 0x00016EC0
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00018CD4 File Offset: 0x00016ED4
		[UserScopedSetting]
		[DefaultSettingValue("ByName")]
		public SortOrder GroupSortOrder
		{
			get
			{
				return (SortOrder)this["GroupSortOrder"];
			}
			set
			{
				this["GroupSortOrder"] = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00018CE8 File Offset: 0x00016EE8
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00018CFC File Offset: 0x00016EFC
		[UserScopedSetting]
		[DefaultSettingValue("ByStatus")]
		public SortOrder ServerSortOrder
		{
			get
			{
				return (SortOrder)this["ServerSortOrder"];
			}
			set
			{
				this["ServerSortOrder"] = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00018D10 File Offset: 0x00016F10
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00018D24 File Offset: 0x00016F24
		[UserScopedSetting]
		[DefaultSettingValue("Dock")]
		public ControlVisibility ServerTreeVisibility
		{
			get
			{
				return (ControlVisibility)this["ServerTreeVisibility"];
			}
			set
			{
				this["ServerTreeVisibility"] = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00018D38 File Offset: 0x00016F38
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00018D4C File Offset: 0x00016F4C
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int ServerTreeAutoHidePopUpDelay
		{
			get
			{
				return (int)this["ServerTreeAutoHidePopUpDelay"];
			}
			set
			{
				this["ServerTreeAutoHidePopUpDelay"] = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00018D60 File Offset: 0x00016F60
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00018D74 File Offset: 0x00016F74
		[UserScopedSetting]
		[DefaultSettingValue("Left")]
		public DockStyle ServerTreeLocation
		{
			get
			{
				return (DockStyle)this["ServerTreeLocation"];
			}
			set
			{
				this["ServerTreeLocation"] = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00018D88 File Offset: 0x00016F88
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00018D9C File Offset: 0x00016F9C
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool ThumbnailSizeIsInPixels
		{
			get
			{
				return (bool)this["ThumbnailSizeIsInPixels"];
			}
			set
			{
				this["ThumbnailSizeIsInPixels"] = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00018DB0 File Offset: 0x00016FB0
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00018DC4 File Offset: 0x00016FC4
		[UserScopedSetting]
		[DefaultSettingValue("160, 120")]
		public Size ThumbnailSize
		{
			get
			{
				return (Size)this["ThumbnailSize"];
			}
			set
			{
				this["ThumbnailSize"] = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00018DD8 File Offset: 0x00016FD8
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00018DEC File Offset: 0x00016FEC
		[UserScopedSetting]
		[DefaultSettingValue("15")]
		public int ThumbnailPercentage
		{
			get
			{
				return (int)this["ThumbnailPercentage"];
			}
			set
			{
				this["ThumbnailPercentage"] = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00018E24 File Offset: 0x00017024
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00018E38 File Offset: 0x00017038
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int PerformanceFlags
		{
			get
			{
				return (int)this["PerformanceFlags"];
			}
			set
			{
				this["PerformanceFlags"] = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00018E4C File Offset: 0x0001704C
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00018E60 File Offset: 0x00017060
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool PersistentBitmapCaching
		{
			get
			{
				return (bool)this["PersistentBitmapCaching"];
			}
			set
			{
				this["PersistentBitmapCaching"] = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00018E74 File Offset: 0x00017074
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00018E88 File Offset: 0x00017088
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool WindowIsMaximized
		{
			get
			{
				return (bool)this["WindowIsMaximized"];
			}
			set
			{
				this["WindowIsMaximized"] = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00018E9C File Offset: 0x0001709C
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00018EB0 File Offset: 0x000170B0
		[UserScopedSetting]
		[DefaultSettingValue("200, 200")]
		public Point WindowPosition
		{
			get
			{
				return (Point)this["WindowPosition"];
			}
			set
			{
				this["WindowPosition"] = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00018EC4 File Offset: 0x000170C4
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00018ED8 File Offset: 0x000170D8
		[UserScopedSetting]
		[DefaultSettingValue("200")]
		public int ServerTreeWidth
		{
			get
			{
				return (int)this["ServerTreeWidth"];
			}
			set
			{
				this["ServerTreeWidth"] = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00018EEC File Offset: 0x000170EC
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00018F00 File Offset: 0x00017100
		[UserScopedSetting]
		[DefaultSettingValue("Pinned")]
		public RdpClient.ConnectionBarState ConnectionBarState
		{
			get
			{
				return (RdpClient.ConnectionBarState)this["ConnectionBarState"];
			}
			set
			{
				this["ConnectionBarState"] = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00018F14 File Offset: 0x00017114
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00018F28 File Offset: 0x00017128
		[UserScopedSetting]
		[DefaultSettingValue("1273, 823")]
		public Size WindowSize
		{
			get
			{
				return (Size)this["WindowSize"];
			}
			set
			{
				this["WindowSize"] = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00018F3C File Offset: 0x0001713C
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00018F50 File Offset: 0x00017150
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool LockWindowSize
		{
			get
			{
				return (bool)this["LockWindowSize"];
			}
			set
			{
				this["LockWindowSize"] = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00018F64 File Offset: 0x00017164
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00018F78 File Offset: 0x00017178
		[UserScopedSetting]
		[DefaultSettingValue("Insert")]
		public Keys HotKeyAltEsc
		{
			get
			{
				return (Keys)this["HotKeyAltEsc"];
			}
			set
			{
				this["HotKeyAltEsc"] = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00018F8C File Offset: 0x0001718C
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00018FA0 File Offset: 0x000171A0
		[UserScopedSetting]
		[DefaultSettingValue("Home")]
		public Keys HotKeyCtrlEsc
		{
			get
			{
				return (Keys)this["HotKeyCtrlEsc"];
			}
			set
			{
				this["HotKeyCtrlEsc"] = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00018FB4 File Offset: 0x000171B4
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00018FC8 File Offset: 0x000171C8
		[UserScopedSetting]
		[DefaultSettingValue("PageUp")]
		public Keys HotKeyAltTab
		{
			get
			{
				return (Keys)this["HotKeyAltTab"];
			}
			set
			{
				this["HotKeyAltTab"] = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00018FDC File Offset: 0x000171DC
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00018FF0 File Offset: 0x000171F0
		[UserScopedSetting]
		[DefaultSettingValue("PageDown")]
		public Keys HotKeyAltShiftTab
		{
			get
			{
				return (Keys)this["HotKeyAltShiftTab"];
			}
			set
			{
				this["HotKeyAltShiftTab"] = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00019004 File Offset: 0x00017204
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00019018 File Offset: 0x00017218
		[UserScopedSetting]
		[DefaultSettingValue("Delete")]
		public Keys HotKeyAltSpace
		{
			get
			{
				return (Keys)this["HotKeyAltSpace"];
			}
			set
			{
				this["HotKeyAltSpace"] = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001902C File Offset: 0x0001722C
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00019040 File Offset: 0x00017240
		[UserScopedSetting]
		[DefaultSettingValue("End")]
		public Keys HotKeyCtrlAltDel
		{
			get
			{
				return (Keys)this["HotKeyCtrlAltDel"];
			}
			set
			{
				this["HotKeyCtrlAltDel"] = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00019054 File Offset: 0x00017254
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00019068 File Offset: 0x00017268
		[UserScopedSetting]
		[DefaultSettingValue("Cancel")]
		public Keys HotKeyFullScreen
		{
			get
			{
				return (Keys)this["HotKeyFullScreen"];
			}
			set
			{
				this["HotKeyFullScreen"] = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001907C File Offset: 0x0001727C
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00019090 File Offset: 0x00017290
		[UserScopedSetting]
		[DefaultSettingValue("Left")]
		public Keys HotKeyFocusReleaseLeft
		{
			get
			{
				return (Keys)this["HotKeyFocusReleaseLeft"];
			}
			set
			{
				this["HotKeyFocusReleaseLeft"] = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x000190A4 File Offset: 0x000172A4
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x000190B8 File Offset: 0x000172B8
		[UserScopedSetting]
		[DefaultSettingValue("Right")]
		public Keys HotKeyFocusReleaseRight
		{
			get
			{
				return (Keys)this["HotKeyFocusReleaseRight"];
			}
			set
			{
				this["HotKeyFocusReleaseRight"] = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x000190CC File Offset: 0x000172CC
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x000190E0 File Offset: 0x000172E0
		[UserScopedSetting]
		[DefaultSettingValue("2012-06-01 00:00:00Z")]
		public string LastUpdateCheckTimeUtc
		{
			get
			{
				return (string)this["LastUpdateCheckTimeUtc"];
			}
			set
			{
				this["LastUpdateCheckTimeUtc"] = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x000190F0 File Offset: 0x000172F0
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00019104 File Offset: 0x00017304
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool HideMainMenu
		{
			get
			{
				return (bool)this["HideMainMenu"];
			}
			set
			{
				this["HideMainMenu"] = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00019118 File Offset: 0x00017318
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0001912C File Offset: 0x0001732C
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool ReconnectOnStartup
		{
			get
			{
				return (bool)this["ReconnectOnStartup"];
			}
			set
			{
				this["ReconnectOnStartup"] = value;
			}
		}
	}
}
