using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x02000092 RID: 146
	public abstract partial class RdcBaseForm : Form
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x00019E88 File Offset: 0x00018088
		protected RdcBaseForm()
		{
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			this._menuPanel = new Panel
			{
				Dock = DockStyle.None
			};
			this._menuStrip = new RdcMenuStrip
			{
				BackColor = Color.FromKnownColor(KnownColor.Control),
				ForeColor = Color.FromKnownColor(KnownColor.ControlText),
				Visible = true
			};
			this._menuStrip.MenuActivate += delegate(object s, EventArgs e)
			{
				this.SetMainMenuVisibility(true);
				this.UpdateMainMenu();
			};
			this._menuPanel.Controls.Add(this._menuStrip);
			base.Controls.Add(this._menuPanel);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00019F38 File Offset: 0x00018138
		public bool IsActive
		{
			get
			{
				return Form.ActiveForm == this;
			}
		}

		// Token: 0x0600055C RID: 1372
		public abstract void SetClientSize(Size size);

		// Token: 0x0600055D RID: 1373
		public abstract Size GetClientSize();

		// Token: 0x0600055E RID: 1374 RVA: 0x00019F44 File Offset: 0x00018144
		public void SetMainMenuVisibility()
		{
			this.SetMainMenuVisibility(!Program.Preferences.HideMainMenu);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00019F5C File Offset: 0x0001815C
		public bool SetMainMenuVisibility(bool show)
		{
			int num = show ? this._menuStrip.Height : 0;
			if (this._menuPanel.Height != num)
			{
				this._menuPanel.Height = num;
				this.LayoutContent();
			}
			return show;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00019FAC File Offset: 0x000181AC
		public virtual void GoFullScreenClient(Server server, bool isTopMostWindow)
		{
			RdpClient client = server.Client;
			Rectangle bounds = Screen.GetBounds(client.Control);
			if (Program.Preferences.UseMultipleMonitors && (bounds.Height < client.MsRdpClient.DesktopHeight || bounds.Width < client.MsRdpClient.DesktopWidth))
			{
				int num = 0;
				int num2 = 65535;
				foreach (Screen screen in Screen.AllScreens)
				{
					num += screen.Bounds.Width;
					num2 = Math.Min(screen.Bounds.Height, num2);
				}
				num = Math.Min(num, RdpClient.MaxDesktopWidth);
				num2 = Math.Min(num2, RdpClient.MaxDesktopHeight);
				bounds = new Rectangle(0, 0, num, num2);
			}
			this._savedBounds = base.Bounds;
			this._savedBorderStyle = base.FormBorderStyle;
			RdcBaseForm.DrawingControl.SuspendDrawing(this);
			base.SuspendLayout();
			base.FormBorderStyle = FormBorderStyle.None;
			this.SetMainMenuVisibility(false);
			base.SetBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
			server.SetClientSizeProperties();
			client.Control.Bounds = new Rectangle(0, 0, base.Width, base.Height);
			base.ResumeLayout();
			base.TopMost = isTopMostWindow;
			client.Control.Show();
			RdcBaseForm.DrawingControl.ResumeDrawing(this);
			base.BringToFront();
			base.Activate();
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001A130 File Offset: 0x00018330
		public virtual bool SwitchFullScreenClient(Server newServer)
		{
			return false;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001A134 File Offset: 0x00018334
		public virtual void LeaveFullScreenClient(Server server)
		{
			RdcBaseForm.DrawingControl.SuspendDrawing(this);
			base.SuspendLayout();
			base.FormBorderStyle = this._savedBorderStyle;
			this.SetMainMenuVisibility();
			base.Bounds = this._savedBounds;
			base.ResumeLayout();
			base.TopMost = false;
			RdcBaseForm.DrawingControl.ResumeDrawing(this);
			server.SetClientSizeProperties();
			base.Activate();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0001A190 File Offset: 0x00018390
		protected override void OnLeave(EventArgs e)
		{
			if (Program.Preferences.HideMainMenu && this._menuPanel.Height > 0)
			{
				User.SendMessage(this._menuStrip.Handle, 16U, IntPtr.Zero, IntPtr.Zero);
			}
			base.OnLeave(e);
		}

		// Token: 0x06000564 RID: 1380
		protected abstract void UpdateMainMenu();

		// Token: 0x06000565 RID: 1381
		protected abstract void LayoutContent();

		// Token: 0x06000566 RID: 1382 RVA: 0x0001A1E8 File Offset: 0x000183E8
		protected void UpdateMenuItems(ToolStripItemCollection items)
		{
			foreach (object obj in items)
			{
				ToolStripItem toolStripItem = (ToolStripItem)obj;
				if (toolStripItem is RdcMenuItem)
				{
					(toolStripItem as RdcMenuItem).Update();
				}
				ToolStripMenuItem toolStripMenuItem = toolStripItem as ToolStripMenuItem;
				if (toolStripMenuItem != null && toolStripMenuItem.DropDownItems != null)
				{
					this.UpdateMenuItems(toolStripMenuItem.DropDownItems);
				}
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001A278 File Offset: 0x00018478
		protected override bool ProcessKeyPreview(ref Message m)
		{
			if (Program.Preferences.HideMainMenu && m.WParam == (IntPtr)18 && (long)m.Msg == 261L)
			{
				this.SetMainMenuVisibility(this._menuPanel.Height == 0);
			}
			return base.ProcessKeyPreview(ref m);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001A2E0 File Offset: 0x000184E0
		private void SetNonClientTracking(int hoverMilliseconds)
		{
			Structs.TRACKMOUSEEVENT trackmouseevent = new Structs.TRACKMOUSEEVENT(17U, base.Handle, (uint)hoverMilliseconds);
			if (hoverMilliseconds < 0)
			{
				trackmouseevent.dwFlags |= 2147483648U;
			}
			bool flag = User.TrackMouseEvent(ref trackmouseevent);
			int lastWin32Error = Marshal.GetLastWin32Error();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0001A328 File Offset: 0x00018528
		protected override void OnDeactivate(EventArgs e)
		{
			base.OnDeactivate(e);
			this.SetMainMenuVisibility();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001A338 File Offset: 0x00018538
		protected override void WndProc(ref Message m)
		{
			uint msg = (uint)m.Msg;
			if (msg <= 160U)
			{
				if (msg != 33U)
				{
					if (msg == 160U)
					{
						this.SetNonClientTracking(100);
					}
				}
				else if (Program.Preferences.HideMainMenu)
				{
					this.SetMainMenuVisibility();
				}
			}
			else if (msg != 161U)
			{
				if (msg != 672U)
				{
					if (msg == 674U)
					{
						this.SetNonClientTracking(-1);
					}
				}
				else if (this.IsActive && Program.Preferences.HideMainMenu && m.WParam.ToInt32() == 2 && m.LParam == this.NCButtonDownLParam && ((int)User.GetAsyncKeyState(1) & 32768) == 0)
				{
					this.SetMainMenuVisibility(this._menuPanel.Height == 0);
					this.SetNonClientTracking(-1);
					this.NCButtonDownLParam = IntPtr.Zero;
					return;
				}
			}
			else
			{
				this.NCButtonDownLParam = m.LParam;
				this.SetNonClientTracking(100);
			}
			base.WndProc(ref m);
		}

		// Token: 0x040001FF RID: 511
		private IntPtr NCButtonDownLParam;

		// Token: 0x04000200 RID: 512
		private const bool WindowedFullScreen = false;

		// Token: 0x04000201 RID: 513
		private Rectangle _savedBounds;

		// Token: 0x04000202 RID: 514
		private FormBorderStyle _savedBorderStyle;

		// Token: 0x04000203 RID: 515
		protected RdcMenuStrip _menuStrip;

		// Token: 0x04000204 RID: 516
		protected Panel _menuPanel;

		// Token: 0x02000288 RID: 648
		private class DrawingControl
		{
			// Token: 0x06005702 RID: 22274 RVA: 0x0005EF18 File Offset: 0x0005D118
			public static void SuspendDrawing(Control parent)
			{
				User.SendMessage(parent.Handle, 11U, (IntPtr)0, (IntPtr)0);
			}

			// Token: 0x06005703 RID: 22275 RVA: 0x0005EF34 File Offset: 0x0005D134
			public static void ResumeDrawing(Control parent)
			{
				User.SendMessage(parent.Handle, 11U, (IntPtr)1, (IntPtr)0);
				parent.Refresh();
			}
		}
	}
}
