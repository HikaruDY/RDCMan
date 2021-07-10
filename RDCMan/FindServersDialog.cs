using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200006A RID: 106
	internal partial class FindServersDialog : SelectServersDialogBase
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0000EE7C File Offset: 0x0000D07C
		public FindServersDialog() : base("Find Servers", "Select")
		{
			int num = 0;
			int num2 = 0;
			base.AddLabel("Type to filter servers", ref num, ref num2);
			this._filterTextBox = FormTools.NewTextBox(0, num++, num2++);
			this._filterTextBox.Enabled = true;
			this._filterTextBox.Width = 500;
			this._filterTextBox.TextChanged += this.Filter_TextChanged;
			base.Controls.Add(this._filterTextBox);
			base.AddListView(ref num, ref num2);
			base.ListView.ContextMenuStrip = new ContextMenuStrip();
			base.ListView.ContextMenuStrip.Opening += new CancelEventHandler(this.ContextMenuPopup);
			this.InitButtons();
			this.ScaleAndLayout();
			this._previousFilterText = string.Empty;
			this.CollectServers();
			this.PopulateList();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000EF60 File Offset: 0x0000D160
		protected override void OnClosed(EventArgs e)
		{
			if (base.ListView.CheckedItems.Count == 0 && base.ListView.Items.Count > 0)
			{
				if (base.ListView.FocusedItem == null)
				{
					base.ListView.FocusedItem = base.ListView.Items[0];
				}
				base.ListView.FocusedItem.Checked = true;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000309B File Offset: 0x0000129B
		private void CollectServers()
		{
			this._servers = new List<Server>();
			ServerTree.Instance.Nodes.VisitNodes(delegate(RdcTreeNode node)
			{
				Server server = node as Server;
				if (server != null)
				{
					this._servers.Add(server);
				}
			});
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		private void PopulateList()
		{
			try
			{
				Regex regex = new Regex(this._filterTextBox.Text, RegexOptions.IgnoreCase | RegexOptions.Compiled);
				base.ListView.BeginUpdate();
				base.SuspendItemChecked();
				base.ListView.Items.Clear();
				foreach (Server server in this._servers)
				{
					if (regex.IsMatch(server.FullPath))
					{
						base.ListView.Items.Add(base.CreateListViewItem(server));
					}
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				base.ResumeItemChecked();
				base.ListView.EndUpdate();
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		private void FilterList()
		{
			try
			{
				Regex regex = new Regex(this._filterTextBox.Text, RegexOptions.IgnoreCase | RegexOptions.Compiled);
				int i = 0;
				while (i < base.ListView.Items.Count)
				{
					Server server = base.ListView.Items[i].Tag as Server;
					if (!regex.IsMatch(server.FullPath))
					{
						base.ListView.Items.RemoveAt(i);
					}
					else
					{
						i++;
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000F134 File Offset: 0x0000D334
		private void ContextMenuPopup(object menuSender, EventArgs args)
		{
			ContextMenuStrip contextMenuStrip = menuSender as ContextMenuStrip;
			List<ServerBase> selectedServers = base.SelectedServers.ToList<ServerBase>();
			if (selectedServers.Count == 0)
			{
				if (base.ListView.FocusedItem == null)
				{
					return;
				}
				selectedServers.Add(base.ListView.FocusedItem.Tag as ServerBase);
			}
			contextMenuStrip.Items.Clear();
			bool anyConnected;
			bool flag;
			NodeHelper.AnyOrAllConnected(selectedServers, out anyConnected, out flag);
			ToolStripMenuItem toolStripMenuItem = new DelegateMenuItem("&Connect", MenuNames.SessionConnect, delegate()
			{
				NodeHelper.ThrottledConnect(selectedServers);
				this.OK();
			});
			toolStripMenuItem.Enabled = !flag;
			contextMenuStrip.Items.Add(toolStripMenuItem);
			toolStripMenuItem = new DelegateMenuItem("R&econnect", MenuNames.SessionReconnect, delegate()
			{
				selectedServers.ForEach(delegate(ServerBase server)
				{
					server.Reconnect();
				});
				this.OK();
			});
			toolStripMenuItem.Enabled = anyConnected;
			contextMenuStrip.Items.Add(toolStripMenuItem);
			toolStripMenuItem = new DelegateMenuItem("&Disconnect", MenuNames.SessionDisconnect, delegate()
			{
				NodeHelper.ThrottledDisconnect(selectedServers);
				this.OK();
			});
			toolStripMenuItem.Enabled = anyConnected;
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add("-");
			toolStripMenuItem = new DelegateMenuItem("Log off", MenuNames.SessionLogOff, delegate()
			{
				selectedServers.ForEach(delegate(ServerBase server)
				{
					server.LogOff();
				});
				this.OK();
			});
			toolStripMenuItem.Enabled = (!Policies.DisableLogOff & anyConnected);
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add("-");
			toolStripMenuItem = new DelegateMenuItem("Remo&ve", MenuNames.EditRemove, delegate()
			{
				if (anyConnected && FormTools.YesNoDialog("There are active sessions. Are you sure?") != DialogResult.Yes)
				{
					return;
				}
				selectedServers.ForEach(delegate(ServerBase server)
				{
					ServerTree.Instance.ConfirmRemove(server, false);
				});
				this.Cancel();
			});
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add("-");
			contextMenuStrip.Items.Add(new DelegateMenuItem("Add to favorites", MenuNames.EditAddToFavorites, delegate()
			{
				selectedServers.ForEach(delegate(ServerBase server)
				{
					FavoritesGroup.Instance.AddReference(server);
				});
				this.OK();
			}));
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000030C3 File Offset: 0x000012C3
		private void Filter_TextChanged(object sender, EventArgs e)
		{
			if (this._filterTextBox.Text.StartsWith(this._previousFilterText))
			{
				this.FilterList();
			}
			else
			{
				this.PopulateList();
			}
			this._previousFilterText = this._filterTextBox.Text;
		}

		// Token: 0x040002F4 RID: 756
		private string _previousFilterText;

		// Token: 0x040002F5 RID: 757
		private List<Server> _servers;

		// Token: 0x040002F6 RID: 758
		private TextBox _filterTextBox;
	}
}
