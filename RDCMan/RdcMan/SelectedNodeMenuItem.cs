using System;

namespace RdcMan
{
	// Token: 0x0200009C RID: 156
	internal class SelectedNodeMenuItem<T> : RdcMenuItem where T : RdcTreeNode
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x0001A7F8 File Offset: 0x000189F8
		public SelectedNodeMenuItem(string text, MenuNames name, Action<T> action) : base(text)
		{
			base.Name = name.ToString();
			this._action = action;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001A81C File Offset: 0x00018A1C
		public SelectedNodeMenuItem(string text, MenuNames name, string shortcut, Action<T> action) : this(text, name, action)
		{
			base.ShortcutKeyDisplayString = shortcut;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001A830 File Offset: 0x00018A30
		public override void Update()
		{
			this.Enabled = (Program.TheForm.GetSelectedNode() is T);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0001A84C File Offset: 0x00018A4C
		protected override void OnClick()
		{
			this._action(Program.TheForm.GetSelectedNode() as T);
		}

		// Token: 0x0400020C RID: 524
		private readonly Action<T> _action;
	}
}
