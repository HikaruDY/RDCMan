using System;
using System.ComponentModel;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x02000135 RID: 309
	internal class RdpClient8 : AxMsRdpClient8NotSafeForScripting, IRdpClient
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00006D51 File Offset: 0x00004F51
		public RdpClient8(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}
	}
}
