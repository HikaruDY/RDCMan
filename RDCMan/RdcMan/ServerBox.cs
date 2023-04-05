using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public class ServerBox : Label
	{
		public ServerBox(Server server)
		{
			this._server = server;
			this.BackColor = Color.White;
			this.BorderStyle = BorderStyle.FixedSingle;
			this.TextAlign = ContentAlignment.MiddleCenter;
			base.Hide();
		}

		public void SetText()
		{
			string text = this._server.GetConnectionStateText();
			if (this._server.IsClientUndocked)
			{
				text = text + Environment.NewLine + "{ Undocked }";
			}
			this.Text = text;
		}

		private Server _server;
	}
}
