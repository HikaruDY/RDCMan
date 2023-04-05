using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000A3 RID: 163
	internal class ServerTreeLocationMenuItem : EnumMenuItem<DockStyle>
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x0001AC6C File Offset: 0x00018E6C
		public ServerTreeLocationMenuItem(string text, DockStyle value) : base(text, value)
		{
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001AC78 File Offset: 0x00018E78
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0001AC84 File Offset: 0x00018E84
		protected override DockStyle Value
		{
			get
			{
				return Program.TheForm.ServerTreeLocation;
			}
			set
			{
				Program.TheForm.ServerTreeLocation = value;
			}
		}
	}
}
