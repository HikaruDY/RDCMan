using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000116 RID: 278
	internal class ServerTreeLocationMenuItem : EnumMenuItem<DockStyle>
	{
		// Token: 0x06000701 RID: 1793 RVA: 0x000067A3 File Offset: 0x000049A3
		public ServerTreeLocationMenuItem(string text, DockStyle value) : base(text, value)
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x000067AD File Offset: 0x000049AD
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000067B9 File Offset: 0x000049B9
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
