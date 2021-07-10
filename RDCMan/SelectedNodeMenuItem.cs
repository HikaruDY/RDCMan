using System;

namespace RdcMan
{
	// Token: 0x0200010F RID: 271
	internal class SelectedNodeMenuItem<T> : RdcMenuItem where T : RdcTreeNode
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x0000656B File Offset: 0x0000476B
		public SelectedNodeMenuItem(string text, MenuNames name, Action<T> action) : base(text)
		{
			base.Name = name.ToString();
			this._action = action;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000658E File Offset: 0x0000478E
		public SelectedNodeMenuItem(string text, MenuNames name, string shortcut, Action<T> action) : this(text, name, action)
		{
			base.ShortcutKeyDisplayString = shortcut;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000065A1 File Offset: 0x000047A1
		public override void Update()
		{
			this.Enabled = (Program.TheForm.GetSelectedNode() is T);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000065BB File Offset: 0x000047BB
		protected override void OnClick()
		{
			this._action(Program.TheForm.GetSelectedNode() as T);
		}

		// Token: 0x040004D3 RID: 1235
		private readonly Action<T> _action;
	}
}
