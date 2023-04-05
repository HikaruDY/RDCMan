using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class SelectServersDialogBase : RdcDialog
	{
		public SelectServersDialogBase(string dialogTitle, string acceptButtonText) : base(dialogTitle, acceptButtonText)
		{
		}

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

		public void SuspendItemChecked()
		{
			Interlocked.Increment(ref this._suspendItemChecked);
		}

		public void ResumeItemChecked()
		{
			if (Interlocked.Decrement(ref this._suspendItemChecked) == 0)
			{
				this.SetHeaderCheckFromItems();
			}
		}

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

		private protected RdcListView ListView { protected get; private set; }

		private void List_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.OK();
			}
		}

		private void List_KeyDownHandler(object sender, KeyEventArgs e)
		{
			if (e.KeyData == (Keys)131137)
			{
				e.Handled = true;
				this.SelectAllItems(true);
			}
		}

		private void SelectAll_Click(object sender, EventArgs e)
		{
			this.SelectAllItems(true);
		}

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

		private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (this._suspendItemChecked == 0)
			{
				this.SetHeaderCheckFromItems();
			}
		}

		private void SetHeaderCheckFromItems()
		{
			bool isChecked = this.ListView.Items.OfType<ListViewItem>().All((ListViewItem i) => i.Checked);
			this.ListView.SetColumnHeaderChecked(0, isChecked);
		}

		private void ListView_HeaderCheckBoxClick(object sender, HeaderColumnClickEventArgs e)
		{
			this.SelectAllItems(e.IsChecked);
		}

		protected const int DialogWidth = 500;

		private int _suspendItemChecked;
	}
}
