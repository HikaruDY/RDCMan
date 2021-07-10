using System;

namespace RdcMan
{
	// Token: 0x0200010B RID: 267
	internal class BuiltInVirtualGroupCheckedMenuItem : CheckedMenuItem
	{
		// Token: 0x060006DA RID: 1754 RVA: 0x000064EA File Offset: 0x000046EA
		public BuiltInVirtualGroupCheckedMenuItem(IBuiltInVirtualGroup group) : base(group.Text)
		{
			this._group = group;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000064FF File Offset: 0x000046FF
		protected override void CheckChanged(bool isChecked)
		{
			this._group.IsInTree = isChecked;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0000650D File Offset: 0x0000470D
		public override void Update()
		{
			base.Checked = this._group.IsInTree;
		}

		// Token: 0x040004CE RID: 1230
		private IBuiltInVirtualGroup _group;
	}
}
