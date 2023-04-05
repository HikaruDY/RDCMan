using System;

namespace RdcMan
{
	internal class DelegateCheckedMenuItem : CheckedMenuItem
	{
		public DelegateCheckedMenuItem(string text, MenuNames name, Func<bool> initDelegate, Action<bool> changedDelegate) : base(text)
		{
			base.Name = name.ToString();
			this._initDelegate = initDelegate;
			this._changedDelegate = changedDelegate;
		}

		protected sealed override void CheckChanged(bool isChecked)
		{
			this._changedDelegate(isChecked);
		}

		public sealed override void Update()
		{
			base.Checked = this._initDelegate();
		}

		private readonly Func<bool> _initDelegate;

		private readonly Action<bool> _changedDelegate;
	}
}
