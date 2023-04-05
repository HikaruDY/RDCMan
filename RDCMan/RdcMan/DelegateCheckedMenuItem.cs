using System;

namespace RdcMan
{
	// Token: 0x02000098 RID: 152
	internal class DelegateCheckedMenuItem : CheckedMenuItem
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x0001A5C8 File Offset: 0x000187C8
		public DelegateCheckedMenuItem(string text, MenuNames name, Func<bool> initDelegate, Action<bool> changedDelegate) : base(text)
		{
			base.Name = name.ToString();
			this._initDelegate = initDelegate;
			this._changedDelegate = changedDelegate;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0001A5F4 File Offset: 0x000187F4
		protected sealed override void CheckChanged(bool isChecked)
		{
			this._changedDelegate(isChecked);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001A604 File Offset: 0x00018804
		public sealed override void Update()
		{
			base.Checked = this._initDelegate();
		}

		// Token: 0x04000206 RID: 518
		private readonly Func<bool> _initDelegate;

		// Token: 0x04000207 RID: 519
		private readonly Action<bool> _changedDelegate;
	}
}
