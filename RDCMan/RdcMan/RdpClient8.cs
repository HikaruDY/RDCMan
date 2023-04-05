using System;
using System.ComponentModel;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x020000B0 RID: 176
	internal class RdpClient8 : AxMsRdpClient8NotSafeForScripting, IRdpClient
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x0001DF3C File Offset: 0x0001C13C
		public RdpClient8(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}
	}
}
