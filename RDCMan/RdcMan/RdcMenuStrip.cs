using System;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x020000A5 RID: 165
	public class RdcMenuStrip : MenuStrip
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001ACBC File Offset: 0x00018EBC
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0001ACC4 File Offset: 0x00018EC4
		public bool IsActive { get; private set; }

		// Token: 0x060005AC RID: 1452 RVA: 0x0001ACD0 File Offset: 0x00018ED0
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
