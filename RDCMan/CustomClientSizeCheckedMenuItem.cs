using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200010D RID: 269
	internal class CustomClientSizeCheckedMenuItem : CheckedMenuItem
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x00006541 File Offset: 0x00004741
		public CustomClientSizeCheckedMenuItem(RdcBaseForm form, string text) : base(text)
		{
			this._baseText = this.Text;
			this._form = form;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001C5F4 File Offset: 0x0001A7F4
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

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001C65C File Offset: 0x0001A85C
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

		// Token: 0x040004D0 RID: 1232
		private RdcBaseForm _form;

		// Token: 0x040004D1 RID: 1233
		private string _baseText;
	}
}
