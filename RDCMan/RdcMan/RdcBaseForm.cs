using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	public abstract partial class RdcBaseForm : Form
	{
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

		public bool IsActive
		{
			get
			{
				return Form.ActiveForm == this;
			}
		}

		public abstract void SetClientSize(Size size);

		public abstract Size GetClientSize();

		public void SetMainMenuVisibility()
		{
			this.SetMainMenuVisibility(!Program.Preferences.HideMainMenu);
		}

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

		public virtual bool SwitchFullScreenClient(Server newServer)
		{
			return false;
		}

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

		protected override void OnLeave(EventArgs e)
		{
			if (Program.Preferences.HideMainMenu && this._menuPanel.Height > 0)
			{
				User.SendMessage(this._menuStrip.Handle, 16U, IntPtr.Zero, IntPtr.Zero);
			}
			base.OnLeave(e);
		}

		protected abstract void UpdateMainMenu();

		protected abstract void LayoutContent();

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

		protected override bool ProcessKeyPreview(ref Message m)
		{
			if (Program.Preferences.HideMainMenu && m.WParam == (IntPtr)18 && (long)m.Msg == 261L)
			{
				this.SetMainMenuVisibility(this._menuPanel.Height == 0);
			}
			return base.ProcessKeyPreview(ref m);
		}

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

		protected override void OnDeactivate(EventArgs e)
		{
			base.OnDeactivate(e);
			this.SetMainMenuVisibility();
		}

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

		private IntPtr NCButtonDownLParam;

		private const bool WindowedFullScreen = false;

		private Rectangle _savedBounds;

		private FormBorderStyle _savedBorderStyle;

		protected RdcMenuStrip _menuStrip;

		protected Panel _menuPanel;

		private class DrawingControl
		{
			public static void SuspendDrawing(Control parent)
			{
				User.SendMessage(parent.Handle, 11U, (IntPtr)0, (IntPtr)0);
			}

			public static void ResumeDrawing(Control parent)
			{
				User.SendMessage(parent.Handle, 11U, (IntPtr)1, (IntPtr)0);
				parent.Refresh();
			}
		}
	}
}
