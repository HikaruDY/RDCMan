using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000051 RID: 81
	public partial class CustomSizeDialog : RdcDialog
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0000C090 File Offset: 0x0000A290
		public CustomSizeDialog(Size size) : base("Custom Size", "OK")
		{
			this.InitComp();
			this._widthTextBox.Text = size.Width.ToString();
			this._heightTextBox.Text = size.Height.ToString();
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002B47 File Offset: 0x00000D47
		public string WidthText
		{
			get
			{
				return this._widthTextBox.Text;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002B54 File Offset: 0x00000D54
		public string HeightText
		{
			get
			{
				return this._heightTextBox.Text;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		private void InitComp()
		{
			Label label = new Label();
			Label label2 = new Label();
			this._fourThreeButton = new Button();
			this._sixteenNineButton = new Button();
			this._sixteenTenButton = new Button();
			int num = 0;
			label.Location = new Point(8, 8);
			label.Size = new Size(50, 23);
			label.Text = "&Width:";
			label.TextAlign = ContentAlignment.MiddleLeft;
			label2.Location = new Point(8, 40);
			label2.Size = new Size(50, 23);
			label2.Text = "&Height:";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			this._widthTextBox = new NumericTextBox(1, int.MaxValue, "Width must be at least 1 pixel");
			this._widthTextBox.Location = new Point(72, 8);
			this._widthTextBox.Size = new Size(75, 20);
			this._widthTextBox.TabIndex = num++;
			this._heightTextBox = new NumericTextBox(1, int.MaxValue, "Height must be at least 1 pixel");
			this._heightTextBox.Location = new Point(72, 40);
			this._heightTextBox.Size = new Size(75, 20);
			this._heightTextBox.TabIndex = num++;
			this._fourThreeButton.Location = new Point(160, 8);
			this._fourThreeButton.TabIndex = num++;
			this._fourThreeButton.Text = "&4 x 3";
			this._fourThreeButton.Click += this.fourThreeButton_Click;
			this._sixteenNineButton.Location = new Point(160, 40);
			this._sixteenNineButton.TabIndex = num++;
			this._sixteenNineButton.Text = "1&6 x 9";
			this._sixteenNineButton.Click += this.sixteenNineButton_Click;
			this._sixteenTenButton.Location = new Point(160, 72);
			this._sixteenTenButton.TabIndex = num++;
			this._sixteenTenButton.Text = "16 x 1&0";
			this._sixteenTenButton.Click += this.sixteenTenButton_Click;
			base.ClientSize = new Size(238, 143);
			base.Controls.Add(new Control[]
			{
				this._sixteenTenButton,
				this._sixteenNineButton,
				this._fourThreeButton,
				label,
				this._widthTextBox,
				label2,
				this._heightTextBox
			});
			this.InitButtons();
			this.ScaleAndLayout();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000C370 File Offset: 0x0000A570
		private void fourThreeButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 3 / 4;
			this._heightTextBox.Text = num2.ToString();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		private void sixteenNineButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 9 / 16;
			this._heightTextBox.Text = num2.ToString();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000C3E0 File Offset: 0x0000A5E0
		private void sixteenTenButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 10 / 16;
			this._heightTextBox.Text = num2.ToString();
		}

		// Token: 0x040002AB RID: 683
		private NumericTextBox _widthTextBox;

		// Token: 0x040002AC RID: 684
		private NumericTextBox _heightTextBox;

		// Token: 0x040002AD RID: 685
		private Button _fourThreeButton;

		// Token: 0x040002AE RID: 686
		private Button _sixteenNineButton;

		// Token: 0x040002AF RID: 687
		private Button _sixteenTenButton;
	}
}
