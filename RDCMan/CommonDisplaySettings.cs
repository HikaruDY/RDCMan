using System;

namespace RdcMan
{
	// Token: 0x02000158 RID: 344
	public abstract class CommonDisplaySettings : SettingsGroup
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x0000749C File Offset: 0x0000569C
		protected CommonDisplaySettings() : base("Display Settings", "displaySettings")
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000074AE File Offset: 0x000056AE
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.DisplaySettings);
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000074BC File Offset: 0x000056BC
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x000074C4 File Offset: 0x000056C4
		[Setting("thumbnailScale", DefaultValue = 1)]
		public IntSetting ThumbnailScale { get; protected set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000074CD File Offset: 0x000056CD
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x000074D5 File Offset: 0x000056D5
		[Setting("smartSizeDockedWindows")]
		public BoolSetting SmartSizeDockedWindow { get; protected set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x000074DE File Offset: 0x000056DE
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x000074E6 File Offset: 0x000056E6
		[Setting("smartSizeUndockedWindows")]
		public BoolSetting SmartSizeUndockedWindow { get; protected set; }

		// Token: 0x040005E5 RID: 1509
		public const string TabName = "Display Settings";
	}
}
