using System;
using System.ComponentModel;
using System.Windows.Forms;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x02000132 RID: 306
	internal class RdpClient5 : AxMsRdpClient5, IRdpClient
	{
		// Token: 0x060007A4 RID: 1956 RVA: 0x00006CCA File Offset: 0x00004ECA
		public RdpClient5(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00006CEB File Offset: 0x00004EEB
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
