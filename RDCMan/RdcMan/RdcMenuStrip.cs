using System;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	public class RdcMenuStrip : MenuStrip
	{
		public bool IsActive { get; private set; }

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
