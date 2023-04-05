using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000066 RID: 102
	public interface IMainForm
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002A0 RID: 672
		MenuStrip MainMenuStrip { get; }

		// Token: 0x060002A1 RID: 673
		bool RegisterShortcut(Keys shortcutKey, Action action);
	}
}
