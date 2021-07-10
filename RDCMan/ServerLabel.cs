using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000144 RID: 324
	internal class ServerLabel : Button
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0000703A File Offset: 0x0000523A
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00007041 File Offset: 0x00005241
		public new static int Height { get; private set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00007049 File Offset: 0x00005249
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00007051 File Offset: 0x00005251
		public ServerBase AssociatedNode { get; private set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0000705A File Offset: 0x0000525A
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00007062 File Offset: 0x00005262
		public Server Server { get; private set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0000706B File Offset: 0x0000526B
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00007073 File Offset: 0x00005273
		public int ThumbnailIndex { get; set; }

		// Token: 0x060007ED RID: 2029 RVA: 0x0001F84C File Offset: 0x0001DA4C
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

		// Token: 0x060007EE RID: 2030 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
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

		// Token: 0x060007EF RID: 2031 RVA: 0x0000707C File Offset: 0x0000527C
		public void CopyServerData()
		{
			this.Text = this.Server.DisplayName;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0001F920 File Offset: 0x0001DB20
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

		// Token: 0x060007F1 RID: 2033 RVA: 0x0001F974 File Offset: 0x0001DB74
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

		// Token: 0x060007F2 RID: 2034 RVA: 0x0000708F File Offset: 0x0000528F
		protected override void OnGotFocus(EventArgs e)
		{
			this.UpdateVisual();
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00007097 File Offset: 0x00005297
		protected override void OnLostFocus(EventArgs e)
		{
			Program.TheForm.RecordLastFocusedServerLabel(this);
			this.UpdateVisual();
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000070AA File Offset: 0x000052AA
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

		// Token: 0x0400059B RID: 1435
		private static ContextMenuStrip _menu = new ContextMenuStrip();
	}
}
