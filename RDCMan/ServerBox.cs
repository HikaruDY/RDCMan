using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000E1 RID: 225
	public class ServerBox : Label
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x000055F9 File Offset: 0x000037F9
		public ServerBox(Server server)
		{
			this._server = server;
			this.BackColor = Color.White;
			this.BorderStyle = BorderStyle.FixedSingle;
			this.TextAlign = ContentAlignment.MiddleCenter;
			base.Hide();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001A3BC File Offset: 0x000185BC
		public void SetText()
		{
			string text = this._server.GetConnectionStateText();
			if (this._server.IsClientUndocked)
			{
				text = text + Environment.NewLine + "{ Undocked }";
			}
			this.Text = text;
		}

		// Token: 0x0400047F RID: 1151
		private Server _server;
	}
}
