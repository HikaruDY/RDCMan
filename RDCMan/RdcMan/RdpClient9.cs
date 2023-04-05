using System;
using System.ComponentModel;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x020000B1 RID: 177
	internal class RdpClient9 : AxMsRdpClient9NotSafeForScripting, IRdpClient
	{
		// Token: 0x06000635 RID: 1589 RVA: 0x0001DF6C File Offset: 0x0001C16C
		public RdpClient9(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}
	}
}
