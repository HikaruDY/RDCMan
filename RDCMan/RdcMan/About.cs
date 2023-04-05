using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000014 RID: 20
	internal partial class About : Form
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002314 File Offset: 0x00000514
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

		// Token: 0x06000036 RID: 54 RVA: 0x000024F0 File Offset: 0x000006F0
		public About(bool isLarge)
		{
			this.InitializeComponent(isLarge);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002500 File Offset: 0x00000700
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.DrawIcon(Program.TheForm.Icon, 10, 10);
			base.OnPaint(e);
		}
	}
}
