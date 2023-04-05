using System;

namespace RdcMan
{
	internal class SelectedNodeMenuItem<T> : RdcMenuItem where T : RdcTreeNode
	{
		public SelectedNodeMenuItem(string text, MenuNames name, Action<T> action) : base(text)
		{
			base.Name = name.ToString();
			this._action = action;
		}

		public SelectedNodeMenuItem(string text, MenuNames name, string shortcut, Action<T> action) : this(text, name, action)
		{
			base.ShortcutKeyDisplayString = shortcut;
		}

		public override void Update()
		{
			this.Enabled = (Program.TheForm.GetSelectedNode() is T);
		}

		protected override void OnClick()
		{
			this._action(Program.TheForm.GetSelectedNode() as T);
		}

		private readonly Action<T> _action;
	}
}
