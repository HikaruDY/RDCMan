using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000141 RID: 321
	public interface IUndockedServerForm
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060007BF RID: 1983
		MenuStrip MainMenuStrip { get; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060007C0 RID: 1984
		ServerBase Server { get; }
	}
}
