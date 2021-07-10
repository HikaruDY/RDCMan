using System;

namespace RdcMan
{
	// Token: 0x0200010A RID: 266
	internal class DelegateCheckedMenuItem : CheckedMenuItem
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x0000649E File Offset: 0x0000469E
		public DelegateCheckedMenuItem(string text, MenuNames name, Func<bool> initDelegate, Action<bool> changedDelegate) : base(text)
		{
			base.Name = name.ToString();
			this._initDelegate = initDelegate;
			this._changedDelegate = changedDelegate;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000064C9 File Offset: 0x000046C9
		protected sealed override void CheckChanged(bool isChecked)
		{
			this._changedDelegate(isChecked);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000064D7 File Offset: 0x000046D7
		public sealed override void Update()
		{
			base.Checked = this._initDelegate();
		}

		// Token: 0x040004CC RID: 1228
		private readonly Func<bool> _initDelegate;

		// Token: 0x040004CD RID: 1229
		private readonly Action<bool> _changedDelegate;
	}
}
