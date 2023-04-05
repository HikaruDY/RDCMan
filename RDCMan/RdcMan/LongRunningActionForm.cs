using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000065 RID: 101
	internal partial class LongRunningActionForm : Form
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000EF98 File Offset: 0x0000D198
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		public bool Done { get; protected set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		public static LongRunningActionForm Instance { get; private set; }

		// Token: 0x06000298 RID: 664 RVA: 0x0000EFBC File Offset: 0x0000D1BC
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

		// Token: 0x06000299 RID: 665 RVA: 0x0000F110 File Offset: 0x0000D310
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

		// Token: 0x0600029A RID: 666 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
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

		// Token: 0x0600029B RID: 667 RVA: 0x0000F278 File Offset: 0x0000D478
		private void MakeVisible()
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				Application.Run(new ApplicationContext(this));
			});
			SpinWait.SpinUntil(() => base.Visible);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		private void ShownHandler(object sender, EventArgs e)
		{
			base.BringToFront();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
		private void FormClosingHandler(object sender, FormClosingEventArgs e)
		{
			if (!this.Done && e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x04000156 RID: 342
		private const int PopupDelayInSeconds = 2;

		// Token: 0x04000157 RID: 343
		private const int UpdateFrequencyInMilliseconds = 25;

		// Token: 0x04000158 RID: 344
		private readonly Label _statusLabel;

		// Token: 0x04000159 RID: 345
		private double _lastUpdateInMilliseconds;

		// Token: 0x0400015A RID: 346
		private DateTime _startTime;
	}
}
