using System;
using System.Drawing;

namespace RdcMan
{
	internal class ClientSizeCheckedMenuItem : CheckedMenuItem
	{
		public ClientSizeCheckedMenuItem(RdcBaseForm form, Size size) : base(size.ToFormattedString())
		{
			base.Tag = size;
			this._form = form;
		}

		protected override void CheckChanged(bool isChecked)
		{
			Size clientSize = (Size)base.Tag;
			this._form.SetClientSize(clientSize);
		}

		public override void Update()
		{
			Size sz = (Size)base.Tag;
			Size clientSize = this._form.GetClientSize();
			base.Checked = (clientSize == sz);
		}

		private RdcBaseForm _form;
	}
}
