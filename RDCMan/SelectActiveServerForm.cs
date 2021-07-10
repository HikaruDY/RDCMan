using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000139 RID: 313
	internal partial class SelectActiveServerForm : RdcDialog
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00006E05 File Offset: 0x00005005
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00006E0D File Offset: 0x0000500D
		public SelectActiveServerForm.SelectedObject Selected { get; private set; }

		// Token: 0x060007B4 RID: 1972 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
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

		// Token: 0x060007B5 RID: 1973 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
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

		// Token: 0x060007B6 RID: 1974 RVA: 0x00006E16 File Offset: 0x00005016
		private void Button_KeyDown(object sender, KeyEventArgs e)
		{
			this.List_KeyDownHandler(sender, e);
			if (base.DialogResult == DialogResult.None)
			{
				e.Handled = false;
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0001EE3C File Offset: 0x0001D03C
		private void Button_Click(object sender, EventArgs e)
		{
			SelectActiveServerForm.SelectedObject o = (sender as Button).Tag as SelectActiveServerForm.SelectedObject;
			this.SelectObject(o);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0001EE64 File Offset: 0x0001D064
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

		// Token: 0x060007B9 RID: 1977 RVA: 0x00006E2F File Offset: 0x0000502F
		private void SelectObject(SelectActiveServerForm.SelectedObject o)
		{
			this.Selected = o;
			base.OK();
		}

		// Token: 0x0200013A RID: 314
		public enum Operation
		{
			// Token: 0x0400057F RID: 1407
			SelectServer,
			// Token: 0x04000580 RID: 1408
			SelectTree,
			// Token: 0x04000581 RID: 1409
			MinimizeWindow
		}

		// Token: 0x0200013B RID: 315
		public class SelectedObject
		{
			// Token: 0x04000582 RID: 1410
			public SelectActiveServerForm.Operation Operation;

			// Token: 0x04000583 RID: 1411
			public char Key;

			// Token: 0x04000584 RID: 1412
			public ServerBase Server;
		}
	}
}
