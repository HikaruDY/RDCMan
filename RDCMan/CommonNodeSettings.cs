using System;

namespace RdcMan
{
	// Token: 0x02000160 RID: 352
	public abstract class CommonNodeSettings : SettingsGroup
	{
		// Token: 0x0600092B RID: 2347 RVA: 0x00007C4C File Offset: 0x00005E4C
		protected CommonNodeSettings(string name) : base(name, "properties")
		{
			base.InheritSettingsType.Mode = InheritanceMode.Disabled;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00007C66 File Offset: 0x00005E66
		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.Properties);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00007C74 File Offset: 0x00005E74
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00007C7C File Offset: 0x00005E7C
		[Setting("name")]
		protected StringSetting NodeName { get; set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00007C85 File Offset: 0x00005E85
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00007C8D File Offset: 0x00005E8D
		[Setting("comment")]
		public StringSetting Comment { get; protected set; }
	}
}
