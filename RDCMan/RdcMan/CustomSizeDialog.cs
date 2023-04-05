using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000033 RID: 51
	public partial class CustomSizeDialog : RdcDialog
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000067C0 File Offset: 0x000049C0
		public CustomSizeDialog(Size size) : base("Custom Size", "OK")
		{
			this.InitComp();
			this._widthTextBox.Text = size.Width.ToString();
			this._heightTextBox.Text = size.Height.ToString();
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000681C File Offset: 0x00004A1C
		public string WidthText
		{
			get
			{
				return this._widthTextBox.Text;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000682C File Offset: 0x00004A2C
		public string HeightText
		{
			get
			{
				return this._heightTextBox.Text;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000683C File Offset: 0x00004A3C
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

		// Token: 0x06000131 RID: 305 RVA: 0x00006AC8 File Offset: 0x00004CC8
		private void fourThreeButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 3 / 4;
			this._heightTextBox.Text = num2.ToString();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006B04 File Offset: 0x00004D04
		private void sixteenNineButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 9 / 16;
			this._heightTextBox.Text = num2.ToString();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006B40 File Offset: 0x00004D40
		private void sixteenTenButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 10 / 16;
			this._heightTextBox.Text = num2.ToString();
		}

		// Token: 0x040000C7 RID: 199
		private NumericTextBox _widthTextBox;

		// Token: 0x040000C8 RID: 200
		private NumericTextBox _heightTextBox;

		// Token: 0x040000C9 RID: 201
		private Button _fourThreeButton;

		// Token: 0x040000CA RID: 202
		private Button _sixteenNineButton;

		// Token: 0x040000CB RID: 203
		private Button _sixteenTenButton;
	}
}
