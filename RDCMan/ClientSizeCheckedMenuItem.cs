using System;
using System.Drawing;

namespace RdcMan
{
	// Token: 0x0200010C RID: 268
	internal class ClientSizeCheckedMenuItem : CheckedMenuItem
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x00006520 File Offset: 0x00004720
		public ClientSizeCheckedMenuItem(RdcBaseForm form, Size size) : base(size.ToFormattedString())
		{
			base.Tag = size;
			this._form = form;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0001C598 File Offset: 0x0001A798
		protected override void CheckChanged(bool isChecked)
		{
			Size clientSize = (Size)base.Tag;
			this._form.SetClientSize(clientSize);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		public override void Update()
		{
			Size sz = (Size)base.Tag;
			Size clientSize = this._form.GetClientSize();
			base.Checked = (clientSize == sz);
		}

		// Token: 0x040004CF RID: 1231
		private RdcBaseForm _form;
	}
}
