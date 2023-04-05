using System;
using System.Drawing;

namespace RdcMan
{
	// Token: 0x0200009A RID: 154
	internal class ClientSizeCheckedMenuItem : CheckedMenuItem
	{
		// Token: 0x06000582 RID: 1410 RVA: 0x0001A654 File Offset: 0x00018854
		public ClientSizeCheckedMenuItem(RdcBaseForm form, Size size) : base(size.ToFormattedString())
		{
			base.Tag = size;
			this._form = form;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001A678 File Offset: 0x00018878
		protected override void CheckChanged(bool isChecked)
		{
			Size clientSize = (Size)base.Tag;
			this._form.SetClientSize(clientSize);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001A6A4 File Offset: 0x000188A4
		public override void Update()
		{
			Size sz = (Size)base.Tag;
			Size clientSize = this._form.GetClientSize();
			base.Checked = (clientSize == sz);
		}

		// Token: 0x04000209 RID: 521
		private RdcBaseForm _form;
	}
}
