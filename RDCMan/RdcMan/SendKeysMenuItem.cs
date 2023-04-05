using System;
using System.Text;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000B6 RID: 182
	internal class SendKeysMenuItem : ToolStripMenuItem
	{
		// Token: 0x06000645 RID: 1605 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
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

		// Token: 0x0400027F RID: 639
		public Keys[] KeyCodes;
	}
}
