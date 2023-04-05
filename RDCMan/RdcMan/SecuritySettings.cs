using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000D0 RID: 208
	public class SecuritySettings : SettingsGroup
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x00021AAC File Offset: 0x0001FCAC
		static SecuritySettings()
		{
			typeof(SecuritySettings).GetSettingProperties(out SecuritySettings._settingProperties);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00021AC4 File Offset: 0x0001FCC4
		public SecuritySettings() : base("Security Settings", "securitySettings")
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00021AD8 File Offset: 0x0001FCD8
		public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
		{
			return new SecuritySettingsTabPage(dialog, this);
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00021AE4 File Offset: 0x0001FCE4
		protected override Dictionary<string, SettingProperty> SettingProperties
		{
			get
			{
				return SecuritySettings._settingProperties;
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00021AEC File Offset: 0x0001FCEC
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.SecuritySettings);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00021AFC File Offset: 0x0001FCFC
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00021B04 File Offset: 0x0001FD04
		[Setting("authentication", DefaultValue = RdpClient.AuthenticationLevel.Warn)]
		public EnumSetting<RdpClient.AuthenticationLevel> AuthenticationLevel { get; private set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00021B10 File Offset: 0x0001FD10
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00021B18 File Offset: 0x0001FD18
		[Setting("restrictedAdmin")]
		public BoolSetting RestrictedAdmin { get; private set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00021B24 File Offset: 0x0001FD24
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00021B2C File Offset: 0x0001FD2C
		[Setting("remoteGuard")]
		public BoolSetting RemoteGuard { get; private set; }

		// Token: 0x04000333 RID: 819
		internal const string TabName = "Security Settings";

		// Token: 0x04000334 RID: 820
		private static Dictionary<string, SettingProperty> _settingProperties;
	}
}
