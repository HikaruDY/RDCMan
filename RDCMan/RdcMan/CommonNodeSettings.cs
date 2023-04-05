using System;

namespace RdcMan
{
	// Token: 0x020000CA RID: 202
	public abstract class CommonNodeSettings : SettingsGroup
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x00021624 File Offset: 0x0001F824
		protected CommonNodeSettings(string name) : base(name, "properties")
		{
			base.InheritSettingsType.Mode = InheritanceMode.Disabled;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00021640 File Offset: 0x0001F840
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.Properties);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00021650 File Offset: 0x0001F850
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00021658 File Offset: 0x0001F858
		[Setting("name")]
		protected StringSetting NodeName { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00021664 File Offset: 0x0001F864
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0002166C File Offset: 0x0001F86C
		[Setting("comment")]
		public StringSetting Comment { get; protected set; }
	}
}
