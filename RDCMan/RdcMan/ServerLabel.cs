using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	internal class ServerLabel : Button
	{
		public new static int Height { get; private set; }

		public ServerBase AssociatedNode { get; private set; }

		public Server Server { get; private set; }

		public int ThumbnailIndex { get; set; }

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

		public void CopyServerData()
		{
			this.Text = this.Server.DisplayName;
		}

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

		protected override void OnGotFocus(EventArgs e)
		{
			this.UpdateVisual();
		}

		protected override void OnLostFocus(EventArgs e)
		{
			Program.TheForm.RecordLastFocusedServerLabel(this);
			this.UpdateVisual();
		}

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

		private static ContextMenuStrip _menu = new ContextMenuStrip();
	}
}
