using System;

namespace RdcMan
{
	internal class SelectedNodeMenuItem : SelectedNodeMenuItem<RdcTreeNode>
	{
		public SelectedNodeMenuItem(string text, MenuNames name, Action<RdcTreeNode> action) : base(text, name, action)
		{
		}

		public SelectedNodeMenuItem(string text, MenuNames name, string shortcut, Action<RdcTreeNode> action) : base(text, name, shortcut, action)
		{
		}
	}
}
