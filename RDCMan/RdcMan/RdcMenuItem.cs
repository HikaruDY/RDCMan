﻿using System;
using System.Windows.Forms;

namespace RdcMan
{
	internal abstract class RdcMenuItem : ToolStripMenuItem
	{
		protected RdcMenuItem()
		{
		}

		protected RdcMenuItem(string text) : this()
		{
			this.Text = text;
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			this.OnClick();
		}

		public abstract void Update();

		protected abstract void OnClick();
	}
}
