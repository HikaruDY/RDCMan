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
	[SettingsProvider(typeof(RdcSettingsProvider))]
	public sealed partial class Preferences : ApplicationSettingsBase
	{
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
