using System;

namespace RdcMan
{
	internal class FileRequiredMenuItem : RdcMenuItem
	{
		public FileRequiredMenuItem(string text, MenuNames name, Action clickDelegate) : base(text)
		{
			base.Name = name.ToString();
			this._clickDelegate = clickDelegate;
		}

		public FileRequiredMenuItem(string text, MenuNames name, string shortcut, Action clickDelegate) : this(text, name, clickDelegate)
		{
			base.ShortcutKeyDisplayString = shortcut;
		}

		public override void Update()
		{
			this.Enabled = ServerTree.Instance.AnyOpenedEditableFiles();
		}

		protected override void OnClick()
		{
			this._clickDelegate();
		}

		private readonly Action _clickDelegate;
	}
}
