using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000B8 RID: 184
	public interface IUndockedServerForm
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000649 RID: 1609
		MenuStrip MainMenuStrip { get; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600064A RID: 1610
		ServerBase Server { get; }
	}
}
