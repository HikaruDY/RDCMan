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
	// Token: 0x020000F2 RID: 242
	[SettingsProvider(typeof(RdcSettingsProvider))]
	public sealed partial class Preferences : ApplicationSettingsBase
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00005ADF File Offset: 0x00003CDF
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00005AF1 File Offset: 0x00003CF1
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00005B04 File Offset: 0x00003D04
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00005B16 File Offset: 0x00003D16
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00005B29 File Offset: 0x00003D29
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00005B3B File Offset: 0x00003D3B
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00005B4E File Offset: 0x00003D4E
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00005B60 File Offset: 0x00003D60
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00005B73 File Offset: 0x00003D73
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00005B85 File Offset: 0x00003D85
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00005B98 File Offset: 0x00003D98
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00005BAA File Offset: 0x00003DAA
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00005C1D File Offset: 0x00003E1D
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00005C2F File Offset: 0x00003E2F
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00005C42 File Offset: 0x00003E42
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00005C54 File Offset: 0x00003E54
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00005C67 File Offset: 0x00003E67
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005C79 File Offset: 0x00003E79
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00005C8C File Offset: 0x00003E8C
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00005C9E File Offset: 0x00003E9E
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00005CB1 File Offset: 0x00003EB1
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00005CC3 File Offset: 0x00003EC3
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00005CD6 File Offset: 0x00003ED6
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00005CE8 File Offset: 0x00003EE8
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

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00005CFB File Offset: 0x00003EFB
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00005D0D File Offset: 0x00003F0D
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00005D20 File Offset: 0x00003F20
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00005D32 File Offset: 0x00003F32
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00005D45 File Offset: 0x00003F45
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00005D57 File Offset: 0x00003F57
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00005D6A File Offset: 0x00003F6A
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00005D7C File Offset: 0x00003F7C
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00005D8F File Offset: 0x00003F8F
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00005DA1 File Offset: 0x00003FA1
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00005DB4 File Offset: 0x00003FB4
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00005DC6 File Offset: 0x00003FC6
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00005DD9 File Offset: 0x00003FD9
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00005DEB File Offset: 0x00003FEB
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00005DFE File Offset: 0x00003FFE
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00005E10 File Offset: 0x00004010
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00005E43 File Offset: 0x00004043
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00005E55 File Offset: 0x00004055
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00005E68 File Offset: 0x00004068
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00005E7A File Offset: 0x0000407A
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00005E8D File Offset: 0x0000408D
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00005E9F File Offset: 0x0000409F
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00005EB2 File Offset: 0x000040B2
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00005EC4 File Offset: 0x000040C4
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00005ED7 File Offset: 0x000040D7
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00005EE9 File Offset: 0x000040E9
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00005EFC File Offset: 0x000040FC
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00005F0E File Offset: 0x0000410E
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00005F21 File Offset: 0x00004121
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005F33 File Offset: 0x00004133
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00005F46 File Offset: 0x00004146
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005F58 File Offset: 0x00004158
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00005F6B File Offset: 0x0000416B
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00005F7D File Offset: 0x0000417D
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00005F90 File Offset: 0x00004190
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00005FA2 File Offset: 0x000041A2
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00005FB5 File Offset: 0x000041B5
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00005FC7 File Offset: 0x000041C7
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00005FDA File Offset: 0x000041DA
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00005FEC File Offset: 0x000041EC
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00005FFF File Offset: 0x000041FF
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00006011 File Offset: 0x00004211
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00006024 File Offset: 0x00004224
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00006036 File Offset: 0x00004236
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00006049 File Offset: 0x00004249
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x0000605B File Offset: 0x0000425B
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0000606E File Offset: 0x0000426E
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00006080 File Offset: 0x00004280
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

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00006093 File Offset: 0x00004293
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x000060A5 File Offset: 0x000042A5
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000060B3 File Offset: 0x000042B3
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x000060C5 File Offset: 0x000042C5
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x000060D8 File Offset: 0x000042D8
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x000060EA File Offset: 0x000042EA
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
