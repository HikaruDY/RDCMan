using System;

namespace RdcMan
{
	// Token: 0x020000D3 RID: 211
	public abstract class Setting<T> : BaseSetting<T>
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x00021BB4 File Offset: 0x0001FDB4
		protected Setting(object o) : base(o)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00021BC0 File Offset: 0x0001FDC0
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00021BC8 File Offset: 0x0001FDC8
		public new T Value
		{
			get
			{
				return this.Value;
			}
			set
			{
				this.Value = value;
			}
		}
	}
}
