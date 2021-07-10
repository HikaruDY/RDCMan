using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200009F RID: 159
	internal partial class LongRunningActionForm : Form
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00003B08 File Offset: 0x00001D08
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003B10 File Offset: 0x00001D10
		public bool Done { get; protected set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00003B19 File Offset: 0x00001D19
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003B20 File Offset: 0x00001D20
		public static LongRunningActionForm Instance { get; private set; }

		// Token: 0x06000321 RID: 801 RVA: 0x00013A4C File Offset: 0x00011C4C
		private LongRunningActionForm()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			ProgressBar progressBar = new ProgressBar
			{
				Location = FormTools.NewLocation(0, 0),
				Size = new Size(450, 20),
				Style = ProgressBarStyle.Marquee
			};
			this._statusLabel = new Label
			{
				AutoEllipsis = true,
				Location = FormTools.NewLocation(0, 1),
				Size = progressBar.Size
			};
			base.ClientSize = new Size(466, this._statusLabel.Bottom + 16);
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(Program.TheForm.Left + (Program.TheForm.Width - base.Width) / 2, Program.TheForm.Top + (Program.TheForm.Height - base.Height) / 2);
			base.ControlBox = false;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Controls.AddRange(new Control[]
			{
				progressBar,
				this._statusLabel
			});
			base.FormClosing += this.FormClosingHandler;
			base.Shown += this.ShownHandler;
			this.ScaleAndLayout();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00013B9C File Offset: 0x00011D9C
		public static void PerformOperation(string title, bool showImmediately, Action action)
		{
			LongRunningActionForm form = new LongRunningActionForm
			{
				Text = title
			};
			try
			{
				Program.TheForm.Enabled = false;
				form._startTime = DateTime.Now;
				if (showImmediately)
				{
					form.MakeVisible();
				}
				LongRunningActionForm.Instance = form;
				action();
			}
			finally
			{
				if (form.Visible)
				{
					form.Done = true;
					form.Invoke(new MethodInvoker(delegate()
					{
						form.Close();
					}));
				}
				LongRunningActionForm.Instance = null;
				Program.TheForm.Enabled = true;
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00013C50 File Offset: 0x00011E50
		public void UpdateStatus(string statusText)
		{
			TimeSpan timeSpan = DateTime.Now.Subtract(this._startTime);
			if (!base.Visible && timeSpan.TotalSeconds >= 2.0)
			{
				this.MakeVisible();
			}
			if (base.Visible && timeSpan.TotalMilliseconds - this._lastUpdateInMilliseconds >= 25.0)
			{
				this._lastUpdateInMilliseconds = timeSpan.TotalMilliseconds;
				base.Invoke(new MethodInvoker(delegate()
				{
					this._statusLabel.Text = statusText;
				}));
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003B28 File Offset: 0x00001D28
		private void MakeVisible()
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				Application.Run(new ApplicationContext(this));
			});
			SpinWait.SpinUntil(() => base.Visible);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003B4D File Offset: 0x00001D4D
		private void ShownHandler(object sender, EventArgs e)
		{
			base.BringToFront();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00003B55 File Offset: 0x00001D55
		private void FormClosingHandler(object sender, FormClosingEventArgs e)
		{
			if (!this.Done && e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0400037F RID: 895
		private const int PopupDelayInSeconds = 2;

		// Token: 0x04000380 RID: 896
		private const int UpdateFrequencyInMilliseconds = 25;

		// Token: 0x04000381 RID: 897
		private readonly Label _statusLabel;

		// Token: 0x04000382 RID: 898
		private double _lastUpdateInMilliseconds;

		// Token: 0x04000383 RID: 899
		private DateTime _startTime;
	}
}
