using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000A2 RID: 162
	public interface IMainForm
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600032D RID: 813
		MenuStrip MainMenuStrip { get; }

		// Token: 0x0600032E RID: 814
		bool RegisterShortcut(Keys shortcutKey, Action action);
	}
}
