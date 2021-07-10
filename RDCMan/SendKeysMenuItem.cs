using System;
using System.Text;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200013C RID: 316
	internal class SendKeysMenuItem : ToolStripMenuItem
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x0001EF30 File Offset: 0x0001D130
		public SendKeysMenuItem(string name, Keys[] keyCodes)
		{
			this.KeyCodes = keyCodes;
			StringBuilder stringBuilder = new StringBuilder();
			foreach (Keys keys in keyCodes)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append("+");
				}
				switch (keys)
				{
				case Keys.ShiftKey:
					stringBuilder.Append("Shift");
					break;
				case Keys.ControlKey:
					stringBuilder.Append("Control");
					break;
				case Keys.Menu:
					stringBuilder.Append("Alt");
					break;
				default:
					stringBuilder.Append(keys.ToString());
					break;
				}
			}
			if (name != null)
			{
				this.Text = name + " (" + stringBuilder.ToString() + ")";
				return;
			}
			this.Text = stringBuilder.ToString();
		}

		// Token: 0x04000585 RID: 1413
		public Keys[] KeyCodes;
	}
}
