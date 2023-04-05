using System;

namespace RdcMan
{
	// Token: 0x020000C2 RID: 194
	public abstract class CommonDisplaySettings : SettingsGroup
	{
		// Token: 0x060006C2 RID: 1730 RVA: 0x00020A7C File Offset: 0x0001EC7C
		protected CommonDisplaySettings() : base("Display Settings", "displaySettings")
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00020A90 File Offset: 0x0001EC90
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.DisplaySettings);
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00020AA0 File Offset: 0x0001ECA0
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		[Setting("thumbnailScale", DefaultValue = 1)]
		public IntSetting ThumbnailScale { get; protected set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00020AB4 File Offset: 0x0001ECB4
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00020ABC File Offset: 0x0001ECBC
		[Setting("smartSizeDockedWindows", DefaultValue = RdpClient.SmartSizeMethod.None)]
		public EnumSetting<RdpClient.SmartSizeMethod> SmartSizeDockedWindow { get; protected set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00020AC8 File Offset: 0x0001ECC8
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00020AD0 File Offset: 0x0001ECD0
		[Setting("smartSizeUndockedWindows", DefaultValue = RdpClient.SmartSizeMethod.None)]
		public EnumSetting<RdpClient.SmartSizeMethod> SmartSizeUndockedWindow { get; protected set; }

		// Token: 0x040002C5 RID: 709
		public const string TabName = "Display Settings";
	}
}
