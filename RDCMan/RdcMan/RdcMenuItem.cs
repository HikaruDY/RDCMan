using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000095 RID: 149
	internal abstract class RdcMenuItem : ToolStripMenuItem
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x0001A520 File Offset: 0x00018720
		protected RdcMenuItem()
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001A528 File Offset: 0x00018728
		protected RdcMenuItem(string text) : this()
		{
			this.Text = text;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001A538 File Offset: 0x00018738
		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			this.OnClick();
		}

		// Token: 0x06000573 RID: 1395
		public abstract void Update();

		// Token: 0x06000574 RID: 1396
		protected abstract void OnClick();
	}
}
