using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	internal class CustomClientSizeCheckedMenuItem : CheckedMenuItem
	{
		public CustomClientSizeCheckedMenuItem(RdcBaseForm form, string text) : base(text)
		{
			this._baseText = this.Text;
			this._form = form;
		}

		protected override void CheckChanged(bool isChecked)
		{
			Size clientSize = this._form.GetClientSize();
			using (CustomSizeDialog customSizeDialog = new CustomSizeDialog(clientSize))
			{
				if (customSizeDialog.ShowDialog() == DialogResult.OK)
				{
					Size clientSize2 = SizeHelper.FromString(customSizeDialog.WidthText, customSizeDialog.HeightText);
					this._form.SetClientSize(clientSize2);
				}
			}
		}

		public override void Update()
		{
			Size clientSize = this._form.GetClientSize();
			bool flag = SizeHelper.StockSizes.All((Size size) => size != clientSize);
			base.Checked = flag;
			string str = this._baseText;
			if (flag)
			{
				str += " ({0})".InvariantFormat(new object[]
				{
					clientSize.ToFormattedString()
				});
			}
			this.Text = str + "...";
		}

		private RdcBaseForm _form;

		private string _baseText;
	}
}
