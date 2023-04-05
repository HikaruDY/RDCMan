using System;
using System.ComponentModel;
using System.Windows.Forms;
using AxMSTSCLib;

namespace RdcMan
{
	// Token: 0x020000AE RID: 174
	internal class RdpClient6 : AxMsRdpClient6NotSafeForScripting, IRdpClient
	{
		// Token: 0x06000630 RID: 1584 RVA: 0x0001DE84 File Offset: 0x0001C084
		public RdpClient6(MainForm form)
		{
			((ISupportInitialize)this).BeginInit();
			base.Hide();
			form.AddToClientPanel(this);
			((ISupportInitialize)this).EndInit();
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001DEB4 File Offset: 0x0001C0B4
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
