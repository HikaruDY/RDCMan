using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200003C RID: 60
	public static class ControlExtensions
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x000025F3 File Offset: 0x000007F3
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
