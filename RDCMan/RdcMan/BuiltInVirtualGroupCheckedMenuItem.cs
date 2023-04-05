using System;

namespace RdcMan
{
	// Token: 0x02000099 RID: 153
	internal class BuiltInVirtualGroupCheckedMenuItem : CheckedMenuItem
	{
		// Token: 0x0600057F RID: 1407 RVA: 0x0001A618 File Offset: 0x00018818
		public BuiltInVirtualGroupCheckedMenuItem(IBuiltInVirtualGroup group) : base(group.Text)
		{
			this._group = group;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001A630 File Offset: 0x00018830
		protected override void CheckChanged(bool isChecked)
		{
			this._group.IsInTree = isChecked;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001A640 File Offset: 0x00018840
		public override void Update()
		{
			base.Checked = this._group.IsInTree;
		}

		// Token: 0x04000208 RID: 520
		private IBuiltInVirtualGroup _group;
	}
}
