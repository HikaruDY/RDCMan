using System;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x02000118 RID: 280
	public class RdcMenuStrip : MenuStrip
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000067E9 File Offset: 0x000049E9
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x000067F1 File Offset: 0x000049F1
		public bool IsActive { get; private set; }

		// Token: 0x06000709 RID: 1801 RVA: 0x000067FA File Offset: 0x000049FA
		public RdcMenuStrip()
		{
			base.MenuActivate += delegate(object s, EventArgs e)
			{
				this.IsActive = true;
			};
			base.MenuDeactivate += delegate(object s, EventArgs e)
			{
				this.IsActive = false;
				if (Program.Preferences.HideMainMenu)
				{
					bool flag = ((int)User.GetAsyncKeyState(164) & 32768) != 0;
					bool flag2 = ((int)User.GetAsyncKeyState(165) & 32768) != 0;
					if (!flag && !flag2)
					{
						((RdcBaseForm)base.FindForm()).SetMainMenuVisibility(false);
					}
				}
			};
		}
	}
}
