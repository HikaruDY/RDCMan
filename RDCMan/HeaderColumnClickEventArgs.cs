using System;

namespace RdcMan
{
	// Token: 0x02000039 RID: 57
	public class HeaderColumnClickEventArgs : EventArgs
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002574 File Offset: 0x00000774
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000257C File Offset: 0x0000077C
		public int Column { get; private set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002585 File Offset: 0x00000785
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000258D File Offset: 0x0000078D
		public bool IsChecked { get; private set; }

		// Token: 0x060000B2 RID: 178 RVA: 0x00002596 File Offset: 0x00000796
		public HeaderColumnClickEventArgs(int column, bool isChecked)
		{
			this.Column = column;
			this.IsChecked = isChecked;
		}
	}
}
