using System;

namespace RdcMan
{
	// Token: 0x02000176 RID: 374
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public class SettingAttribute : Attribute
	{
		// Token: 0x060009A2 RID: 2466 RVA: 0x00008134 File Offset: 0x00006334
		public SettingAttribute(string xmlName)
		{
			this.XmlName = xmlName;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00008143 File Offset: 0x00006343
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x0000814B File Offset: 0x0000634B
		public string XmlName { get; set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00008154 File Offset: 0x00006354
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x0000815C File Offset: 0x0000635C
		public object DefaultValue { get; set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00008165 File Offset: 0x00006365
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x0000816D File Offset: 0x0000636D
		public bool IsObsolete { get; set; }
	}
}
