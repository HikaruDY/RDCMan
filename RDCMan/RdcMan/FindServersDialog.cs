using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000041 RID: 65
	internal partial class FindServersDialog : SelectServersDialogBase
	{
		// Token: 0x0600019B RID: 411 RVA: 0x00009A30 File Offset: 0x00007C30
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

		// Token: 0x0600019C RID: 412 RVA: 0x00009B18 File Offset: 0x00007D18
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

		// Token: 0x0600019D RID: 413 RVA: 0x00009B94 File Offset: 0x00007D94
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

		// Token: 0x0600019E RID: 414 RVA: 0x00009BBC File Offset: 0x00007DBC
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

		// Token: 0x0600019F RID: 415 RVA: 0x00009CA0 File Offset: 0x00007EA0
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

		// Token: 0x060001A0 RID: 416 RVA: 0x00009D3C File Offset: 0x00007F3C
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

		// Token: 0x060001A1 RID: 417 RVA: 0x00009F24 File Offset: 0x00008124
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

		// Token: 0x040000F5 RID: 245
		private string _previousFilterText;

		// Token: 0x040000F6 RID: 246
		private List<Server> _servers;

		// Token: 0x040000F7 RID: 247
		private TextBox _filterTextBox;
	}
}
