using System;

namespace RdcMan
{
	// Token: 0x0200001F RID: 31
	public class HeaderColumnClickEventArgs : EventArgs
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004BB4 File Offset: 0x00002DB4
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00004BBC File Offset: 0x00002DBC
		public int Column { get; private set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004BC8 File Offset: 0x00002DC8
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00004BD0 File Offset: 0x00002DD0
		public bool IsChecked { get; private set; }

		// Token: 0x060000A4 RID: 164 RVA: 0x00004BDC File Offset: 0x00002DDC
		public HeaderColumnClickEventArgs(int column, bool isChecked)
		{
			this.Column = column;
			this.IsChecked = isChecked;
		}
	}
}
