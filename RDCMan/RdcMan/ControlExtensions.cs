using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	public static class ControlExtensions
	{
		public static IEnumerable<Control> FlattenControls(this Control.ControlCollection controls)
		{
			foreach (object obj in controls)
			{
				Control c = (Control)obj;
				yield return c;
				if (c.Controls.Count > 0)
				{
					foreach (Control control in c.Controls.FlattenControls())
					{
						yield return control;
					}
					IEnumerator<Control> enumerator2 = null;
				}
				c = null;
			}
			IEnumerator enumerator = null;
			yield break;
			yield break;
		}
	}
}
