using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public abstract class DisplaySettingsTabPage<TSettingsGroup> : SettingsTabPage<TSettingsGroup> where TSettingsGroup : CommonDisplaySettings
	{
		protected DisplaySettingsTabPage(TabbedSettingsDialog dialog, TSettingsGroup settings) : base(dialog, settings)
		{
		}

		protected void Create(out int rowIndex, out int tabIndex)
		{
			tabIndex = 0;
			rowIndex = 0;
			base.CreateInheritanceControl(ref rowIndex, ref tabIndex);
			Label label = FormTools.NewLabel("&Thumbnail scale:", 0, rowIndex);
			label.Size = new Size(140, 20);
			RdcNumericUpDown rdcNumericUpDown = new RdcNumericUpDown();
			Control control = rdcNumericUpDown;
			int colIndex = 1;
			int num = rowIndex;
			rowIndex = num + 1;
			control.Location = FormTools.NewLocation(colIndex, num);
			rdcNumericUpDown.Location = new Point(rdcNumericUpDown.Location.X, rdcNumericUpDown.Location.Y + 2);
			rdcNumericUpDown.Minimum = 1m;
			rdcNumericUpDown.Maximum = 9m;
			rdcNumericUpDown.Setting = base.Settings.ThumbnailScale;
			rdcNumericUpDown.Size = new Size(40, 20);
			Control control2 = rdcNumericUpDown;
			num = tabIndex;
			tabIndex = num + 1;
			control2.TabIndex = num;
			FormTools.AddLabeledEnumDropDown<RdpClient.SmartSizeMethod>(this, "&Docked RD scaling", base.Settings.SmartSizeDockedWindow, ref rowIndex, ref tabIndex, new Func<RdpClient.SmartSizeMethod, string>(RdpClient.SmartSizeMethodToString));
			FormTools.AddLabeledEnumDropDown<RdpClient.SmartSizeMethod>(this, "&Undocked RD scaling", base.Settings.SmartSizeUndockedWindow, ref rowIndex, ref tabIndex, new Func<RdpClient.SmartSizeMethod, string>(RdpClient.SmartSizeMethodToString));
			base.Controls.Add(new Control[]
			{
				label,
				rdcNumericUpDown
			});
		}
	}
}
