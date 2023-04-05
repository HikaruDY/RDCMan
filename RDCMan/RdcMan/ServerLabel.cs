using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000BA RID: 186
	internal class ServerLabel : Button
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0001F0F4 File Offset: 0x0001D2F4
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x0001F0FC File Offset: 0x0001D2FC
		public new static int Height { get; private set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001F104 File Offset: 0x0001D304
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x0001F10C File Offset: 0x0001D30C
		public ServerBase AssociatedNode { get; private set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001F118 File Offset: 0x0001D318
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x0001F120 File Offset: 0x0001D320
		public Server Server { get; private set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001F12C File Offset: 0x0001D32C
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x0001F134 File Offset: 0x0001D334
		public int ThumbnailIndex { get; set; }

		// Token: 0x06000670 RID: 1648 RVA: 0x0001F140 File Offset: 0x0001D340
		static ServerLabel()
		{
			ServerLabel._menu.Opening += ServerLabel.MenuPopup;
			Button button = new Button
			{
				FlatStyle = FlatStyle.Flat,
				Font = new Font(ServerTree.Instance.Font, FontStyle.Bold)
			};
			ServerLabel.Height = button.Height;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001F1A0 File Offset: 0x0001D3A0
		public ServerLabel(ServerBase node)
		{
			this.AssociatedNode = node;
			this.Server = node.ServerNode;
			base.Enabled = true;
			base.TabStop = true;
			this.ContextMenuStrip = ServerLabel._menu;
			this.TextAlign = ContentAlignment.MiddleCenter;
			base.FlatStyle = FlatStyle.Flat;
			this.Font = new Font(ServerTree.Instance.Font, FontStyle.Bold);
			base.Hide();
			this.CopyServerData();
			this.UpdateVisual();
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001F21C File Offset: 0x0001D41C
		public void CopyServerData()
		{
			this.Text = this.Server.DisplayName;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001F230 File Offset: 0x0001D430
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (e.Clicks == 1)
				{
					base.Focus();
					return;
				}
				ServerTree.Instance.SelectedNode = this.AssociatedNode;
				this.Server.Connect();
				this.Server.Focus();
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001F28C File Offset: 0x0001D48C
		private static void MenuPopup(object sender, CancelEventArgs e)
		{
			ServerLabel._menu.Items.Clear();
			ServerLabel serverLabel = (sender as ContextMenuStrip).SourceControl as ServerLabel;
			ServerBase server = serverLabel.AssociatedNode;
			MenuHelper.AddSessionMenuItems(ServerLabel._menu, server);
			ServerLabel._menu.Items.Add("-");
			ServerLabel._menu.Items.Add(new DelegateMenuItem("E&xpand", MenuNames.SessionExpand, delegate()
			{
				ServerTree.Instance.SelectedNode = server;
				if (server.IsConnected)
				{
					server.Focus();
				}
			}));
			MenuHelper.AddDockingMenuItems(ServerLabel._menu, server);
			ServerLabel._menu.Items.Add("-");
			MenuHelper.AddMaintenanceMenuItems(ServerLabel._menu, server);
			Program.PluginAction(delegate(IPlugin p)
			{
				p.OnContextMenu(ServerLabel._menu, server);
			});
			e.Cancel = false;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001F36C File Offset: 0x0001D56C
		protected override void OnGotFocus(EventArgs e)
		{
			this.UpdateVisual();
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001F374 File Offset: 0x0001D574
		protected override void OnLostFocus(EventArgs e)
		{
			Program.TheForm.RecordLastFocusedServerLabel(this);
			this.UpdateVisual();
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001F388 File Offset: 0x0001D588
		protected void UpdateVisual()
		{
			if (this.Focused)
			{
				this.ForeColor = SystemColors.ActiveCaptionText;
				this.BackColor = SystemColors.ActiveCaption;
				return;
			}
			this.ForeColor = SystemColors.InactiveCaptionText;
			this.BackColor = SystemColors.InactiveCaption;
		}

		// Token: 0x0400028E RID: 654
		private static ContextMenuStrip _menu = new ContextMenuStrip();
	}
}
