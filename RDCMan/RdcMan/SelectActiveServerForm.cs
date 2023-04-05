using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class SelectActiveServerForm : RdcDialog
	{
		public SelectActiveServerForm.SelectedObject Selected { get; private set; }

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

		private void Button_KeyDown(object sender, KeyEventArgs e)
		{
			this.List_KeyDownHandler(sender, e);
			if (base.DialogResult == DialogResult.None)
			{
				e.Handled = false;
			}
		}

		private void Button_Click(object sender, EventArgs e)
		{
			SelectActiveServerForm.SelectedObject o = (sender as Button).Tag as SelectActiveServerForm.SelectedObject;
			this.SelectObject(o);
		}

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

		private void SelectObject(SelectActiveServerForm.SelectedObject o)
		{
			this.Selected = o;
			base.OK();
		}

		public enum Operation
		{
			SelectServer,
			SelectTree,
			MinimizeWindow
		}

		public class SelectedObject
		{
			public SelectActiveServerForm.Operation Operation;

			public char Key;

			public ServerBase Server;
		}
	}
}
