using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class ConnectServersDialog : SelectServersDialogBase
	{
		public ConnectServersDialog(IEnumerable<ServerBase> servers) : base("Connect Servers", "&Connect")
		{
			int num = 0;
			int num2 = 0;
			base.AddLabel("Select servers to be connected", ref num, ref num2);
			base.AddListView(ref num, ref num2);
			this.InitButtons();
			this.ScaleAndLayout();
			servers.ForEach(delegate(ServerBase server)
			{
				base.ListView.Items.Add(base.CreateListViewItem(server));
			});
			base.ListView.ItemChecked += this.ListView_ItemChecked;
			this._acceptButton.Enabled = false;
		}

		private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			this._acceptButton.Enabled = (base.ListView.CheckedItems.Count > 0);
		}
	}
}
