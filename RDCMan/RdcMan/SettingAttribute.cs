using System;

namespace RdcMan
{
	// Token: 0x020000E0 RID: 224
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public class SettingAttribute : Attribute
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x00022248 File Offset: 0x00020448
		public SettingAttribute(string xmlName)
		{
			this.XmlName = xmlName;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00022258 File Offset: 0x00020458
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00022260 File Offset: 0x00020460
		public string XmlName { get; set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0002226C File Offset: 0x0002046C
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00022274 File Offset: 0x00020474
		public object DefaultValue { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00022280 File Offset: 0x00020480
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00022288 File Offset: 0x00020488
		public bool IsObsolete { get; set; }
	}
}
