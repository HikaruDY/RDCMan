using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class LongRunningActionForm : Form
	{
		public bool Done { get; protected set; }

		public static LongRunningActionForm Instance { get; private set; }

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

		private void MakeVisible()
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				Application.Run(new ApplicationContext(this));
			});
			SpinWait.SpinUntil(() => base.Visible);
		}

		private void ShownHandler(object sender, EventArgs e)
		{
			base.BringToFront();
		}

		private void FormClosingHandler(object sender, FormClosingEventArgs e)
		{
			if (!this.Done && e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
			}
		}

		private const int PopupDelayInSeconds = 2;

		private const int UpdateFrequencyInMilliseconds = 25;

		private readonly Label _statusLabel;

		private double _lastUpdateInMilliseconds;

		private DateTime _startTime;
	}
}
