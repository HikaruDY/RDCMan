using System;

namespace RdcMan
{
	// Token: 0x02000117 RID: 279
	internal class ServerTreeVisibilityMenuItem : EnumMenuItem<ControlVisibility>
	{
		// Token: 0x06000704 RID: 1796 RVA: 0x000067C6 File Offset: 0x000049C6
		public ServerTreeVisibilityMenuItem(string text, ControlVisibility value) : base(text, value)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x000067D0 File Offset: 0x000049D0
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x000067DC File Offset: 0x000049DC
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
