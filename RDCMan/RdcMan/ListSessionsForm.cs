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
	internal partial class ListSessionsForm : Form
	{
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

		private void ListSessionsForm_Load(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(ListSessionsForm.OpenThreadProc), this);
		}

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

		private void ListSessionsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this._remoteSessions.CloseServer();
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			this.RefreshSessions();
		}

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

		private void ListSessionsForm_Resize(object sender, EventArgs e)
		{
			this.SessionListView.Width = this.RefreshButton.Right - this.SessionListView.Left;
		}

		private void SessionListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			this._sortOrder = new int[1];
			int num = 0;
			this._sortOrder[num++] = e.Column;
			this.SortListView();
		}

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

		private void ListSessionsForm_SizeChanged(object sender, EventArgs e)
		{
			int width = Math.Max(20, base.ClientRectangle.Width - this.SessionListView.Location.X * 2);
			int height = Math.Max(20, base.ClientRectangle.Height - this.SessionListView.Location.Y - 10);
			this.SessionListView.Size = new Size(width, height);
		}

		private readonly RemoteSessions _remoteSessions;

		private int[] _sortOrder = new int[1];

		private readonly object _queryLock = new object();

		private bool _areQuerying;
	}
}
