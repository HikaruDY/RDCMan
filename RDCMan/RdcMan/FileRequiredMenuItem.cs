using System;

namespace RdcMan
{
	// Token: 0x02000096 RID: 150
	internal class FileRequiredMenuItem : RdcMenuItem
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x0001A548 File Offset: 0x00018748
		public FileRequiredMenuItem(string text, MenuNames name, Action clickDelegate) : base(text)
		{
			base.Name = name.ToString();
			this._clickDelegate = clickDelegate;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0001A56C File Offset: 0x0001876C
		public FileRequiredMenuItem(string text, MenuNames name, string shortcut, Action clickDelegate) : this(text, name, clickDelegate)
		{
			base.ShortcutKeyDisplayString = shortcut;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001A580 File Offset: 0x00018780
		public override void Update()
		{
			this.Enabled = ServerTree.Instance.AnyOpenedEditableFiles();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001A594 File Offset: 0x00018794
		protected override void OnClick()
		{
			this._clickDelegate();
		}

		// Token: 0x04000205 RID: 517
		private readonly Action _clickDelegate;
	}
}
