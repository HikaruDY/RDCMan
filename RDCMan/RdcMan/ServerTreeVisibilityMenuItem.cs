using System;

namespace RdcMan
{
	// Token: 0x020000A4 RID: 164
	internal class ServerTreeVisibilityMenuItem : EnumMenuItem<ControlVisibility>
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x0001AC94 File Offset: 0x00018E94
		public ServerTreeVisibilityMenuItem(string text, ControlVisibility value) : base(text, value)
		{
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0001ACAC File Offset: 0x00018EAC
		protected override ControlVisibility Value
		{
			get
			{
				return Program.TheForm.ServerTreeVisibility;
			}
			set
			{
				Program.TheForm.ServerTreeVisibility = value;
			}
		}
	}
}
