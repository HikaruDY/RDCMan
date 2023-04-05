using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000B5 RID: 181
	internal partial class SelectActiveServerForm : RdcDialog
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
		public SelectActiveServerForm.SelectedObject Selected { get; private set; }

		// Token: 0x0600063F RID: 1599 RVA: 0x0001E1BC File Offset: 0x0001C3BC
		public SelectActiveServerForm(IEnumerable<ServerBase> servers) : base("Select server", null)
		{
			this.BackColor = Color.White;
			base.ClientSize = new Size(304, FormTools.YPos(7));
			int num = 0;
			foreach (ServerBase serverBase in servers.Take(10))
			{
				char key = (num == 9) ? '0' : ((char)(49 + num));
				this.AddButton(num / 5, num % 5, key, serverBase.DisplayName, SelectActiveServerForm.Operation.SelectServer, serverBase);
				num++;
			}
			num += num % 2;
			int rowIndex = (num < 10) ? (num % 5) : 5;
			this.AddButton(0, rowIndex, 'T', "Server Tree", SelectActiveServerForm.Operation.SelectTree, null);
			this.AddButton(1, rowIndex, 'N', "Minimize RDCMan", SelectActiveServerForm.Operation.MinimizeWindow, null);
			base.KeyDown += this.List_KeyDownHandler;
			this.ScaleAndLayout();
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001E2C0 File Offset: 0x0001C4C0
		private void AddButton(int colIndex, int rowIndex, char key, string text, SelectActiveServerForm.Operation operation, ServerBase server)
		{
			Button button = new Button
			{
				Location = FormTools.NewLocation(colIndex, rowIndex),
				FlatStyle = FlatStyle.Flat,
				Text = string.Format("{0} - {1}", key, text),
				Tag = new SelectActiveServerForm.SelectedObject
				{
					Key = key,
					Operation = operation,
					Server = server
				}
			};
			button.Width = 140;
			button.Click += this.Button_Click;
			button.KeyDown += this.Button_KeyDown;
			base.Controls.Add(button);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001E360 File Offset: 0x0001C560
		private void Button_KeyDown(object sender, KeyEventArgs e)
		{
			this.List_KeyDownHandler(sender, e);
			if (base.DialogResult == DialogResult.None)
			{
				e.Handled = false;
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001E37C File Offset: 0x0001C57C
		private void Button_Click(object sender, EventArgs e)
		{
			SelectActiveServerForm.SelectedObject o = (sender as Button).Tag as SelectActiveServerForm.SelectedObject;
			this.SelectObject(o);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		private void List_KeyDownHandler(object sender, KeyEventArgs e)
		{
			char c = (char)e.KeyData;
			if (e.KeyData >= Keys.NumPad0 && e.KeyData <= Keys.NumPad9)
			{
				c = (char)(e.KeyData - Keys.NumPad0 + 48);
			}
			if (c >= 'a' && c <= 'z')
			{
				c = c - 'a' + 'A';
			}
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				SelectActiveServerForm.SelectedObject selectedObject = control.Tag as SelectActiveServerForm.SelectedObject;
				if (selectedObject != null && selectedObject.Key == c)
				{
					this.SelectObject(selectedObject);
					break;
				}
			}
			if (e.KeyData == Keys.Escape)
			{
				base.Cancel();
			}
			e.Handled = true;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001E494 File Offset: 0x0001C694
		private void SelectObject(SelectActiveServerForm.SelectedObject o)
		{
			this.Selected = o;
			base.OK();
		}

		// Token: 0x0200029F RID: 671
		public enum Operation
		{
			// Token: 0x04000B22 RID: 2850
			SelectServer,
			// Token: 0x04000B23 RID: 2851
			SelectTree,
			// Token: 0x04000B24 RID: 2852
			MinimizeWindow
		}

		// Token: 0x020002A0 RID: 672
		public class SelectedObject
		{
			// Token: 0x04000B25 RID: 2853
			public SelectActiveServerForm.Operation Operation;

			// Token: 0x04000B26 RID: 2854
			public char Key;

			// Token: 0x04000B27 RID: 2855
			public ServerBase Server;
		}
	}
}
