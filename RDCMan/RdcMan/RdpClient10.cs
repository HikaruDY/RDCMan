using System;
using System.ComponentModel;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x020000AC RID: 172
	internal class RdpClient10 : AxMsRdpClient10NotSafeForScripting, IRdpClient
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x0001DDF8 File Offset: 0x0001BFF8
		public RdpClient10(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}
	}
}
