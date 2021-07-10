using System;
using System.ComponentModel;
using System.Windows.Forms;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x02000133 RID: 307
	internal class RdpClient6 : AxMsRdpClient6NotSafeForScripting, IRdpClient
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00006D0F File Offset: 0x00004F0F
		public RdpClient6(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00006CEB File Offset: 0x00004EEB
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
