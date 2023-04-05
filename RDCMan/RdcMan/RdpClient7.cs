using System;
using System.ComponentModel;
using System.Windows.Forms;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x020000AF RID: 175
	internal class RdpClient7 : AxMsRdpClient7NotSafeForScripting, IRdpClient
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		public RdpClient7(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001DF10 File Offset: 0x0001C110
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
