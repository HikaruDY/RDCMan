using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000067 RID: 103
	internal partial class SelectServersDialogBase : RdcDialog
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00002F93 File Offset: 0x00001193
		public SelectServersDialogBase(string dialogTitle, string acceptButtonText) : base(dialogTitle, acceptButtonText)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
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

		// Token: 0x060001C6 RID: 454 RVA: 0x0000EA50 File Offset: 0x0000CC50
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

		// Token: 0x060001C7 RID: 455 RVA: 0x00002F9D File Offset: 0x0000119D
		public void SuspendItemChecked()
		{
			Interlocked.Increment(ref this._suspendItemChecked);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002FAB File Offset: 0x000011AB
		public void ResumeItemChecked()
		{
			if (Interlocked.Decrement(ref this._suspendItemChecked) == 0)
			{
				this.SetHeaderCheckFromItems();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000EBAC File Offset: 0x0000CDAC
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

		// Token: 0x060001CA RID: 458 RVA: 0x00002FC0 File Offset: 0x000011C0
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

		// Token: 0x060001CB RID: 459 RVA: 0x0000EBCC File Offset: 0x0000CDCC
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002FF3 File Offset: 0x000011F3
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002FFB File Offset: 0x000011FB
		protected RdcListView ListView { protected get; private set; }

		// Token: 0x060001CE RID: 462 RVA: 0x00003004 File Offset: 0x00001204
		private void List_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.OK();
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00003019 File Offset: 0x00001219
		private void List_KeyDownHandler(object sender, KeyEventArgs e)
		{
			if (e.KeyData == (Keys)131137)
			{
				e.Handled = true;
				this.SelectAllItems(true);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00003036 File Offset: 0x00001236
		private void SelectAll_Click(object sender, EventArgs e)
		{
			this.SelectAllItems(true);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000EC48 File Offset: 0x0000CE48
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

		// Token: 0x060001D2 RID: 466 RVA: 0x0000303F File Offset: 0x0000123F
		private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (this._suspendItemChecked == 0)
			{
				this.SetHeaderCheckFromItems();
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000ECC0 File Offset: 0x0000CEC0
		private void SetHeaderCheckFromItems()
		{
			bool isChecked = this.ListView.Items.OfType<ListViewItem>().All((ListViewItem i) => i.Checked);
			this.ListView.SetColumnHeaderChecked(0, isChecked);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000304F File Offset: 0x0000124F
		private void ListView_HeaderCheckBoxClick(object sender, HeaderColumnClickEventArgs e)
		{
			this.SelectAllItems(e.IsChecked);
		}

		// Token: 0x040002EA RID: 746
		protected const int DialogWidth = 500;

		// Token: 0x040002EB RID: 747
		private int _suspendItemChecked;
	}
}
