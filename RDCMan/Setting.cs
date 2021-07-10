using System;

namespace RdcMan
{
	// Token: 0x02000169 RID: 361
	public abstract class Setting<T> : BaseSetting<T>
	{
		// Token: 0x06000972 RID: 2418 RVA: 0x00007ECA File Offset: 0x000060CA
		protected Setting(object o) : base(o)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00007ED3 File Offset: 0x000060D3
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00007EDB File Offset: 0x000060DB
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
