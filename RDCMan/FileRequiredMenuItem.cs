using System;

namespace RdcMan
{
	// Token: 0x02000108 RID: 264
	internal class FileRequiredMenuItem : RdcMenuItem
	{
		// Token: 0x060006D0 RID: 1744 RVA: 0x00006438 File Offset: 0x00004638
		public FileRequiredMenuItem(string text, MenuNames name, Action clickDelegate) : base(text)
		{
			base.Name = name.ToString();
			this._clickDelegate = clickDelegate;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000645B File Offset: 0x0000465B
		public FileRequiredMenuItem(string text, MenuNames name, string shortcut, Action clickDelegate) : this(text, name, clickDelegate)
		{
			base.ShortcutKeyDisplayString = shortcut;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0000646E File Offset: 0x0000466E
		public override void Update()
		{
			this.Enabled = ServerTree.Instance.AnyOpenedEditableFiles();
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00006480 File Offset: 0x00004680
		protected override void OnClick()
		{
			this._clickDelegate();
		}

		// Token: 0x040004CB RID: 1227
		private readonly Action _clickDelegate;
	}
}
