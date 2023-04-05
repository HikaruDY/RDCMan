using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000085 RID: 133
	public class ServerBox : Label
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x00017618 File Offset: 0x00015818
		public ServerBox(Server server)
		{
			this._server = server;
			this.BackColor = Color.White;
			this.BorderStyle = BorderStyle.FixedSingle;
			this.TextAlign = ContentAlignment.MiddleCenter;
			base.Hide();
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00017658 File Offset: 0x00015858
		public void SetText()
		{
			string text = this._server.GetConnectionStateText();
			if (this._server.IsClientUndocked)
			{
				text = text + Environment.NewLine + "{ Undocked }";
			}
			this.Text = text;
		}

		// Token: 0x040001E1 RID: 481
		private Server _server;
	}
}
