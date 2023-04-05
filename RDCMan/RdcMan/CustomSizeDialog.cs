using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public partial class CustomSizeDialog : RdcDialog
	{
		public CustomSizeDialog(Size size) : base("Custom Size", "OK")
		{
			this.InitComp();
			this._widthTextBox.Text = size.Width.ToString();
			this._heightTextBox.Text = size.Height.ToString();
		}

		public string WidthText
		{
			get
			{
				return this._widthTextBox.Text;
			}
		}

		public string HeightText
		{
			get
			{
				return this._heightTextBox.Text;
			}
		}

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

		private void fourThreeButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 3 / 4;
			this._heightTextBox.Text = num2.ToString();
		}

		private void sixteenNineButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 9 / 16;
			this._heightTextBox.Text = num2.ToString();
		}

		private void sixteenTenButton_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this._widthTextBox.Text);
			int num2 = num * 10 / 16;
			this._heightTextBox.Text = num2.ToString();
		}

		private NumericTextBox _widthTextBox;

		private NumericTextBox _heightTextBox;

		private Button _fourThreeButton;

		private Button _sixteenNineButton;

		private Button _sixteenTenButton;
	}
}
