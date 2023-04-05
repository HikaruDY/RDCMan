using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000040 RID: 64
	internal partial class SelectServersDialogBase : RdcDialog
	{
		// Token: 0x0600018A RID: 394 RVA: 0x000095FC File Offset: 0x000077FC
		public SelectServersDialogBase(string dialogTitle, string acceptButtonText) : base(dialogTitle, acceptButtonText)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009608 File Offset: 0x00007808
		protected void AddLabel(string text, ref int rowIndex, ref int tabIndex)
		{
			Label label = new Label();
			int colIndex = 0;
			int num = rowIndex;
			rowIndex = num + 1;
			label.Location = FormTools.NewLocation(colIndex, num);
			label.Text = text;
			label.TextAlign = ContentAlignment.MiddleLeft;
			label.Size = new Size(500, 20);
			Label value = label;
			base.Controls.Add(value);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009664 File Offset: 0x00007864
		protected void AddListView(ref int rowIndex, ref int tabIndex)
		{
			RdcListView rdcListView = new RdcListView();
			rdcListView.CheckBoxes = true;
			rdcListView.FullRowSelect = true;
			int colIndex = 0;
			int num = rowIndex;
			rowIndex = num + 1;
			rdcListView.Location = FormTools.NewLocation(colIndex, num);
			rdcListView.MultiSelect = false;
			rdcListView.Size = new Size(500, 300);
			num = tabIndex;
			tabIndex = num + 1;
			rdcListView.TabIndex = num;
			rdcListView.View = View.Details;
			this.ListView = rdcListView;
			this.ListView.KeyDown += this.List_KeyDownHandler;
			this.ListView.MouseDoubleClick += this.List_MouseDoubleClick;
			this.ListView.ItemChecked += this.ListView_ItemChecked;
			this.ListView.Columns.AddRange(new ColumnHeader[]
			{
				new ColumnHeader
				{
					Text = string.Empty,
					Width = 22
				},
				new ColumnHeader
				{
					Text = "Server",
					Width = 130
				},
				new ColumnHeader
				{
					Text = "Group",
					Width = 349
				}
			});
			base.Controls.Add(this.ListView);
			if (RdcListView.SupportsHeaderCheckBoxes)
			{
				this.ListView.SetColumnHeaderToCheckBox(0);
				this.ListView.HeaderCheckBoxClick += this.ListView_HeaderCheckBoxClick;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000097C8 File Offset: 0x000079C8
		public void SuspendItemChecked()
		{
			Interlocked.Increment(ref this._suspendItemChecked);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000097D8 File Offset: 0x000079D8
		public void ResumeItemChecked()
		{
			if (Interlocked.Decrement(ref this._suspendItemChecked) == 0)
			{
				this.SetHeaderCheckFromItems();
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000097F0 File Offset: 0x000079F0
		public IEnumerable<ServerBase> SelectedServers
		{
			get
			{
				foreach (object obj in this.ListView.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (listViewItem.Checked)
					{
						yield return (ServerBase)listViewItem.Tag;
					}
				}
				IEnumerator enumerator = null;
				yield break;
				yield break;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009814 File Offset: 0x00007A14
		protected ListViewItem CreateListViewItem(ServerBase server)
		{
			return new ListViewItem(new string[]
			{
				"",
				server.DisplayName,
				server.Parent.FullPath
			})
			{
				Tag = server
			};
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00009858 File Offset: 0x00007A58
		public override void InitButtons()
		{
			base.InitButtons();
			if (!RdcListView.SupportsHeaderCheckBoxes)
			{
				Button button = new Button
				{
					Text = "Select &all",
					TabIndex = this._acceptButton.TabIndex - 1
				};
				button.Click += this.SelectAll_Click;
				button.Location = new Point(8, this._acceptButton.Location.Y);
				base.Controls.Add(button);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000098DC File Offset: 0x00007ADC
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000098E4 File Offset: 0x00007AE4
		private protected RdcListView ListView { protected get; private set; }

		// Token: 0x06000194 RID: 404 RVA: 0x000098F0 File Offset: 0x00007AF0
		private void List_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.OK();
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00009908 File Offset: 0x00007B08
		private void List_KeyDownHandler(object sender, KeyEventArgs e)
		{
			if (e.KeyData == (Keys)131137)
			{
				e.Handled = true;
				this.SelectAllItems(true);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00009928 File Offset: 0x00007B28
		private void SelectAll_Click(object sender, EventArgs e)
		{
			this.SelectAllItems(true);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009934 File Offset: 0x00007B34
		private void SelectAllItems(bool isChecked)
		{
			try
			{
				this.SuspendItemChecked();
				foreach (object obj in this.ListView.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					listViewItem.Checked = isChecked;
				}
			}
			finally
			{
				this.ResumeItemChecked();
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000099B4 File Offset: 0x00007BB4
		private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (this._suspendItemChecked == 0)
			{
				this.SetHeaderCheckFromItems();
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000099C8 File Offset: 0x00007BC8
		private void SetHeaderCheckFromItems()
		{
			bool isChecked = this.ListView.Items.OfType<ListViewItem>().All((ListViewItem i) => i.Checked);
			this.ListView.SetColumnHeaderChecked(0, isChecked);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009A20 File Offset: 0x00007C20
		private void ListView_HeaderCheckBoxClick(object sender, HeaderColumnClickEventArgs e)
		{
			this.SelectAllItems(e.IsChecked);
		}

		// Token: 0x040000F2 RID: 242
		protected const int DialogWidth = 500;

		// Token: 0x040000F3 RID: 243
		private int _suspendItemChecked;
	}
}
