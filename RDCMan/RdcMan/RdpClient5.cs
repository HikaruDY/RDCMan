using System;
using System.ComponentModel;
using System.Windows.Forms;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x020000AD RID: 173
	internal class RdpClient5 : AxMsRdpClient5, IRdpClient
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x0001DE28 File Offset: 0x0001C028
		public RdpClient5(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001DE58 File Offset: 0x0001C058
		protected override void WndProc(ref Message m)
		{
			if ((long)m.Msg == 33L && !base.ContainsFocus)
			{
				base.Focus();
			}
			base.WndProc(ref m);
		}
	}
}
