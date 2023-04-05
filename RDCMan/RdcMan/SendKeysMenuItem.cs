using System;
using System.Text;
using System.Windows.Forms;

namespace RdcMan
{
	internal class SendKeysMenuItem : ToolStripMenuItem
	{
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

		public Keys[] KeyCodes;
	}
}
