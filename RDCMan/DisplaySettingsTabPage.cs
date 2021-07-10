using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200007E RID: 126
	public abstract class DisplaySettingsTabPage<TSettingsGroup> : SettingsTabPage<TSettingsGroup> where TSettingsGroup : CommonDisplaySettings
	{
		// Token: 0x0600024D RID: 589 RVA: 0x0000343A File Offset: 0x0000163A
		protected DisplaySettingsTabPage(TabbedSettingsDialog dialog, TSettingsGroup settings) : base(dialog, settings)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00010B78 File Offset: 0x0000ED78
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
			string text = "Scale docked remote desktop to fit window";
			int colIndex2 = 0;
			num = rowIndex;
			rowIndex = num + 1;
			int rowIndex2 = num;
			num = tabIndex;
			tabIndex = num + 1;
			RdcCheckBox rdcCheckBox = FormTools.NewCheckBox(text, colIndex2, rowIndex2, num);
			rdcCheckBox.Setting = base.Settings.SmartSizeDockedWindow;
			string text2 = "Scale undocked remote desktop to fit window";
			int colIndex3 = 0;
			num = rowIndex;
			rowIndex = num + 1;
			int rowIndex3 = num;
			num = tabIndex;
			tabIndex = num + 1;
			RdcCheckBox rdcCheckBox2 = FormTools.NewCheckBox(text2, colIndex3, rowIndex3, num);
			rdcCheckBox2.Setting = base.Settings.SmartSizeUndockedWindow;
			base.Controls.Add(new Control[]
			{
				label,
				rdcNumericUpDown,
				rdcCheckBox,
				rdcCheckBox2
			});
		}
	}
}
