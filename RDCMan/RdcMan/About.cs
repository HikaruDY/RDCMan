using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	internal partial class About : Form
	{
		private void InitializeComponent(bool isLarge)
		{
			int num = isLarge ? 400 : 400;
			int num2 = num - 26;
			Label value = new Label
			{
				Location = new Point(53, 13),
				AutoSize = true,
				Text = "{0} v{1}".InvariantFormat(new object[]
				{
					Program.TheForm.DescriptionText,
					Program.TheForm.VersionText
				})
			};
			Label value2 = new Label
			{
				Location = new Point(53, 29),
				Width = num2 - 140,
				AutoSize = true,
				Text = "Copyright © 2023 Microsoft. By Julian Burger"
			};
			LinkLabel linkLabel = new LinkLabel
			{
				Location = new Point(53, 45),
				AutoSize = true,
				Text = "Sysinternals - www.sysinternals.com"
			};
			linkLabel.LinkClicked += delegate(object sender, LinkLabelLinkClickedEventArgs args)
			{
				Process.Start("https://www.sysinternals.com");
			};
			Button button = new Button
			{
				TabIndex = 1,
				Text = "OK"
			};
			button.Location = new Point(num2 - button.Width + 16, 13);
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.ClientSize = new Size(num, 76);
			base.Controls.Add(value);
			base.Controls.Add(value2);
			base.Controls.Add(linkLabel);
			base.Controls.Add(button);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.AcceptButton = button;
			base.CancelButton = button;
			this.Text = "About Remote Desktop Connection Manager";
			base.StartPosition = FormStartPosition.CenterParent;
			this.ScaleAndLayout();
			base.ActiveControl = button;
		}

		public About(bool isLarge)
		{
			this.InitializeComponent(isLarge);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.DrawIcon(Program.TheForm.Icon, 10, 10);
			base.OnPaint(e);
		}
	}
}
