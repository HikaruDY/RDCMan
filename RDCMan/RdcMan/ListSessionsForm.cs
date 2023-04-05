using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x02000062 RID: 98
	internal partial class ListSessionsForm : Form
	{
		// Token: 0x0600027A RID: 634 RVA: 0x0000E304 File Offset: 0x0000C504
		public ListSessionsForm(ServerBase server)
		{
			this.InitializeComponent();
			this._remoteSessions = new RemoteSessions(server);
			this._areQuerying = true;
			this.Text = server.ServerName + " Sessions";
			ContextMenu contextMenu = new ContextMenu();
			contextMenu.Popup += this.OnContextMenu;
			this.SessionListView.ContextMenu = contextMenu;
			base.StartPosition = FormStartPosition.Manual;
			base.Location = Program.TheForm.Location;
			base.Location.Offset(100, 100);
			base.Icon = Program.TheForm.Icon;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		private ListViewItem GetSelection()
		{
			ListView sessionListView = this.SessionListView;
			if (sessionListView.SelectedItems.Count != 1)
			{
				return null;
			}
			IEnumerator enumerator = sessionListView.SelectedItems.GetEnumerator();
			enumerator.MoveNext();
			return enumerator.Current as ListViewItem;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000E40C File Offset: 0x0000C60C
		private void ListSessionsForm_Load(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(ListSessionsForm.OpenThreadProc), this);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000E424 File Offset: 0x0000C624
		private static void OpenThreadProc(object o)
		{
			ListSessionsForm form = o as ListSessionsForm;
			if (!form._remoteSessions.OpenServer())
			{
				form.Invoke(new MethodInvoker(delegate()
				{
					form.StatusLabel.Text = "Unable to access remote sessions";
				}));
				return;
			}
			ListSessionsForm.QuerySessions(form);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000E480 File Offset: 0x0000C680
		private static void QuerySessions(object o)
		{
			ListSessionsForm form = o as ListSessionsForm;
			if (form.IsDisposed)
			{
				return;
			}
			form.Invoke(new MethodInvoker(delegate()
			{
				form.SessionListView.BeginUpdate();
				form.SessionListView.Items.Clear();
			}));
			IList<RemoteSessionInfo> list = form._remoteSessions.QuerySessions();
			if (list == null)
			{
				form.Invoke(new MethodInvoker(delegate()
				{
					form.StatusLabel.Text = "Unable to enumerate remote sessions";
				}));
				return;
			}
			foreach (RemoteSessionInfo remoteSessionInfo in list)
			{
				Wts.ConnectstateClass state = remoteSessionInfo.State;
				string text;
				if (remoteSessionInfo.DomainName.Length > 0)
				{
					text = remoteSessionInfo.DomainName + "\\" + remoteSessionInfo.UserName;
				}
				else
				{
					text = remoteSessionInfo.UserName;
				}
				ListViewItem value = new ListViewItem
				{
					Text = remoteSessionInfo.SessionId.ToString()
				};
				value.SubItems.Add(state.ToString());
				value.SubItems.Add(text);
				value.SubItems.Add(remoteSessionInfo.ClientName);
				form.Invoke(new MethodInvoker(delegate()
				{
					form.SessionListView.Items.Add(value);
				}));
			}
			form.Invoke(new MethodInvoker(delegate()
			{
				int count = form.SessionListView.Items.Count;
				string text2 = count.ToString() + " session";
				if (count != 1)
				{
					text2 += "s";
				}
				form.StatusLabel.Text = text2;
				form.SortListView();
				form.SessionListView.EndUpdate();
				form._areQuerying = false;
			}));
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000E624 File Offset: 0x0000C824
		private void ListSessionsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this._remoteSessions.CloseServer();
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000E634 File Offset: 0x0000C834
		private void RefreshButton_Click(object sender, EventArgs e)
		{
			this.RefreshSessions();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000E63C File Offset: 0x0000C83C
		private void RefreshSessions()
		{
			object queryLock = this._queryLock;
			lock (queryLock)
			{
				if (this._areQuerying)
				{
					return;
				}
				this._areQuerying = true;
			}
			this.StatusLabel.Text = "Refreshing...";
			ThreadPool.QueueUserWorkItem(new WaitCallback(ListSessionsForm.QuerySessions), this);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		private void OnContextMenu(object sender, EventArgs e)
		{
			ContextMenu contextMenu = sender as ContextMenu;
			ListViewItem selection = this.GetSelection();
			if (selection == null)
			{
				return;
			}
			contextMenu.MenuItems.Clear();
			string text = selection.SubItems[1].Text;
			Wts.ConnectstateClass connectstateClass;
			if (!(text == "Active") && !(text == "Connected"))
			{
				if (!(text == "Disconnected"))
				{
					connectstateClass = Wts.ConnectstateClass.ConnectQuery;
				}
				else
				{
					connectstateClass = Wts.ConnectstateClass.Disconnected;
				}
			}
			else
			{
				connectstateClass = Wts.ConnectstateClass.Connected;
			}
			MenuItem menuItem = new MenuItem("&Disconnect", new EventHandler(this.DisconnectSession))
			{
				Enabled = (connectstateClass == Wts.ConnectstateClass.Connected)
			};
			contextMenu.MenuItems.Add(menuItem);
			contextMenu.MenuItems.Add("-");
			menuItem = new MenuItem("&Log off", new EventHandler(this.LogOffSession));
			contextMenu.MenuItems.Add(menuItem);
			menuItem.Enabled = !Policies.DisableLogOff;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
		private void DisconnectSession(object sender, EventArgs e)
		{
			ListViewItem selection = this.GetSelection();
			int id;
			if (!int.TryParse(selection.SubItems[0].Text, out id))
			{
				return;
			}
			this._remoteSessions.DisconnectSession(id);
			this.RefreshSessions();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000E804 File Offset: 0x0000CA04
		private void LogOffSession(object sender, EventArgs e)
		{
			ListViewItem selection = this.GetSelection();
			int id;
			if (!int.TryParse(selection.SubItems[0].Text, out id))
			{
				return;
			}
			this._remoteSessions.LogOffSession(id);
			this.RefreshSessions();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000E850 File Offset: 0x0000CA50
		private void ListSessionsForm_Resize(object sender, EventArgs e)
		{
			this.SessionListView.Width = this.RefreshButton.Right - this.SessionListView.Left;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000E874 File Offset: 0x0000CA74
		private void SessionListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			this._sortOrder = new int[1];
			int num = 0;
			this._sortOrder[num++] = e.Column;
			this.SortListView();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000E8AC File Offset: 0x0000CAAC
		private void SortListView()
		{
			ArrayList arrayList = new ArrayList(this.SessionListView.Items.Count);
			foreach (object obj in this.SessionListView.Items)
			{
				ListViewItem value = (ListViewItem)obj;
				arrayList.Add(value);
			}
			arrayList.Sort(new SessionListSortComparer(this._sortOrder));
			this.SessionListView.Items.Clear();
			foreach (object obj2 in arrayList)
			{
				ListViewItem value2 = (ListViewItem)obj2;
				this.SessionListView.Items.Add(value2);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
		private void ListSessionsForm_SizeChanged(object sender, EventArgs e)
		{
			int width = Math.Max(20, base.ClientRectangle.Width - this.SessionListView.Location.X * 2);
			int height = Math.Max(20, base.ClientRectangle.Height - this.SessionListView.Location.Y - 10);
			this.SessionListView.Size = new Size(width, height);
		}

		// Token: 0x0400014C RID: 332
		private readonly RemoteSessions _remoteSessions;

		// Token: 0x0400014D RID: 333
		private int[] _sortOrder = new int[1];

		// Token: 0x0400014E RID: 334
		private readonly object _queryLock = new object();

		// Token: 0x0400014F RID: 335
		private bool _areQuerying;
	}
}
