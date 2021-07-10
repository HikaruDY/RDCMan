using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200006D RID: 109
	internal partial class ConnectServersDialog : SelectServersDialogBase
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x0000F38C File Offset: 0x0000D58C
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

		// Token: 0x060001F7 RID: 503 RVA: 0x00003209 File Offset: 0x00001409
		private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			this._acceptButton.Enabled = (base.ListView.CheckedItems.Count > 0);
		}
	}
}
