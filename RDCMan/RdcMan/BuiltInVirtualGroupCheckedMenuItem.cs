using System;

namespace RdcMan
{
	internal class BuiltInVirtualGroupCheckedMenuItem : CheckedMenuItem
	{
		public BuiltInVirtualGroupCheckedMenuItem(IBuiltInVirtualGroup group) : base(group.Text)
		{
			this._group = group;
		}

		protected override void CheckChanged(bool isChecked)
		{
			this._group.IsInTree = isChecked;
		}

		public override void Update()
		{
			base.Checked = this._group.IsInTree;
		}

		private IBuiltInVirtualGroup _group;
	}
}
