using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x02000102 RID: 258
	public abstract partial class RdcBaseForm : Form
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x0001C048 File Offset: 0x0001A248
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00006326 File Offset: 0x00004526
		public bool IsActive
		{
			get
			{
				return Form.ActiveForm == this;
			}
		}

		// Token: 0x060006B2 RID: 1714
		public abstract void SetClientSize(Size size);

		// Token: 0x060006B3 RID: 1715
		public abstract Size GetClientSize();

		// Token: 0x060006B4 RID: 1716 RVA: 0x00006330 File Offset: 0x00004530
		public void SetMainMenuVisibility()
		{
			this.SetMainMenuVisibility(!Program.Preferences.HideMainMenu);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
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

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001C134 File Offset: 0x0001A334
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

		// Token: 0x060006B7 RID: 1719 RVA: 0x00004460 File Offset: 0x00002660
		public virtual bool SwitchFullScreenClient(Server newServer)
		{
			return false;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
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

		// Token: 0x060006B9 RID: 1721 RVA: 0x00006346 File Offset: 0x00004546
		protected override void OnLeave(EventArgs e)
		{
			if (Program.Preferences.HideMainMenu && this._menuPanel.Height > 0)
			{
				User.SendMessage(this._menuStrip.Handle, 16u, IntPtr.Zero, IntPtr.Zero);
			}
			base.OnLeave(e);
		}

		// Token: 0x060006BA RID: 1722
		protected abstract void UpdateMainMenu();

		// Token: 0x060006BB RID: 1723
		protected abstract void LayoutContent();

		// Token: 0x060006BC RID: 1724 RVA: 0x0001C2FC File Offset: 0x0001A4FC
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

		// Token: 0x060006BD RID: 1725 RVA: 0x0001C37C File Offset: 0x0001A57C
		protected override bool ProcessKeyPreview(ref Message m)
		{
			if (Program.Preferences.HideMainMenu && m.WParam == (IntPtr)18 && (long)m.Msg == 261L)
			{
				this.SetMainMenuVisibility(this._menuPanel.Height == 0);
			}
			return base.ProcessKeyPreview(ref m);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
		private void SetNonClientTracking(int hoverMilliseconds)
		{
			Structs.TRACKMOUSEEVENT trackmouseevent = new Structs.TRACKMOUSEEVENT(17u, base.Handle, (uint)hoverMilliseconds);
			if (hoverMilliseconds < 0)
			{
				trackmouseevent.dwFlags |= 2147483648u;
			}
			bool flag = User.TrackMouseEvent(ref trackmouseevent);
			int lastWin32Error = Marshal.GetLastWin32Error();
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00006386 File Offset: 0x00004586
		protected override void OnDeactivate(EventArgs e)
		{
			base.OnDeactivate(e);
			this.SetMainMenuVisibility();
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001C414 File Offset: 0x0001A614
		protected override void WndProc(ref Message m)
		{
			uint msg = (uint)m.Msg;
			if (msg <= 160u)
			{
				if (msg != 33u)
				{
					if (msg == 160u)
					{
						this.SetNonClientTracking(100);
					}
				}
				else if (Program.Preferences.HideMainMenu)
				{
					this.SetMainMenuVisibility();
				}
			}
			else if (msg != 161u)
			{
				if (msg != 672u)
				{
					if (msg == 674u)
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

		// Token: 0x040004C4 RID: 1220
		private IntPtr NCButtonDownLParam;

		// Token: 0x040004C5 RID: 1221
		private const bool WindowedFullScreen = false;

		// Token: 0x040004C6 RID: 1222
		private Rectangle _savedBounds;

		// Token: 0x040004C7 RID: 1223
		private FormBorderStyle _savedBorderStyle;

		// Token: 0x040004C8 RID: 1224
		protected RdcMenuStrip _menuStrip;

		// Token: 0x040004C9 RID: 1225
		protected Panel _menuPanel;

		// Token: 0x02000103 RID: 259
		private class DrawingControl
		{
			// Token: 0x060006C2 RID: 1730 RVA: 0x000063A5 File Offset: 0x000045A5
			public static void SuspendDrawing(Control parent)
			{
				User.SendMessage(parent.Handle, 11u, (IntPtr)0, (IntPtr)0);
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x000063C1 File Offset: 0x000045C1
			public static void ResumeDrawing(Control parent)
			{
				User.SendMessage(parent.Handle, 11u, (IntPtr)1, (IntPtr)0);
				parent.Refresh();
			}
		}
	}
}
