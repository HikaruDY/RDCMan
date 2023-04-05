using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200009B RID: 155
	internal class CustomClientSizeCheckedMenuItem : CheckedMenuItem
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x0001A6DC File Offset: 0x000188DC
		public CustomClientSizeCheckedMenuItem(RdcBaseForm form, string text) : base(text)
		{
			this._baseText = this.Text;
			this._form = form;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0001A6F8 File Offset: 0x000188F8
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

		// Token: 0x06000587 RID: 1415 RVA: 0x0001A76C File Offset: 0x0001896C
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

		// Token: 0x0400020A RID: 522
		private RdcBaseForm _form;

		// Token: 0x0400020B RID: 523
		private string _baseText;
	}
}
