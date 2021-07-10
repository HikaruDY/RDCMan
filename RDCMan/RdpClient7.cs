using System;
using System.ComponentModel;
using System.Windows.Forms;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x02000134 RID: 308
	internal class RdpClient7 : AxMsRdpClient7NotSafeForScripting, IRdpClient
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x00006D30 File Offset: 0x00004F30
		public RdpClient7(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00006CEB File Offset: 0x00004EEB
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
