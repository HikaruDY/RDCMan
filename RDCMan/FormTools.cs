using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200008F RID: 143
	public static class FormTools
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x00003765 File Offset: 0x00001965
		public static int XPos(int colIndex)
		{
			return 8 + 148 * colIndex;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00003770 File Offset: 0x00001970
		public static int YPos(int rowIndex)
		{
			return 16 + 24 * rowIndex;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003779 File Offset: 0x00001979
		public static int YPosNoMargin(int rowIndex)
		{
			return 24 * rowIndex;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000377F File Offset: 0x0000197F
		public static Point TopLeftLocation()
		{
			return new Point(4, 22);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003789 File Offset: 0x00001989
		public static Point NewLocation(int colIndex, int rowIndex)
		{
			return new Point(FormTools.XPos(colIndex), FormTools.YPos(rowIndex));
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000379C File Offset: 0x0000199C
		public static Point NewUngroupedLocation(int colIndex, int rowIndex)
		{
			return new Point(16 + 140 * colIndex, FormTools.YPos(rowIndex));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00012198 File Offset: 0x00010398
		public static Label NewLabel(string text, int colIndex, int rowIndex)
		{
			return new Label
			{
				Location = FormTools.NewLocation(colIndex, rowIndex),
				Text = text,
				TextAlign = ContentAlignment.MiddleLeft,
				Size = new Size(140, 20)
			};
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000121DC File Offset: 0x000103DC
		public static RdcTextBox NewTextBox(int colIndex, int rowIndex, int tabIndex)
		{
			return new RdcTextBox
			{
				Enabled = false,
				Location = FormTools.NewLocation(colIndex, rowIndex),
				Size = new Size(340, 20),
				TabIndex = tabIndex
			};
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00012220 File Offset: 0x00010420
		public static RdcTextBox NewTextBox(int colIndex, int rowIndex, int tabIndex, int height)
		{
			return new RdcTextBox
			{
				Location = FormTools.NewLocation(colIndex, rowIndex),
				Size = new Size(340, 20 * height),
				TabIndex = tabIndex,
				Multiline = true,
				AcceptsReturn = true,
				ScrollBars = ScrollBars.Vertical
			};
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00012274 File Offset: 0x00010474
		public static RdcTextBox AddLabeledTextBox(Control parent, string text, ref int rowIndex, ref int tabIndex)
		{
			Label value = FormTools.NewLabel(text, 0, rowIndex);
			int colIndex = 1;
			int num = rowIndex;
			rowIndex = num + 1;
			int rowIndex2 = num;
			num = tabIndex;
			tabIndex = num + 1;
			RdcTextBox rdcTextBox = FormTools.NewTextBox(colIndex, rowIndex2, num);
			parent.Controls.Add(value);
			parent.Controls.Add(rdcTextBox);
			return rdcTextBox;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000122C0 File Offset: 0x000104C0
		public static RdcTextBox AddLabeledTextBox(Control parent, string text, StringSetting setting, ref int rowIndex, ref int tabIndex)
		{
			RdcTextBox rdcTextBox = FormTools.AddLabeledTextBox(parent, text, ref rowIndex, ref tabIndex);
			rdcTextBox.Setting = setting;
			return rdcTextBox;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000037B3 File Offset: 0x000019B3
		public static RdcCheckBox NewCheckBox(string text, int colIndex, int rowIndex, int tabIndex)
		{
			return FormTools.NewCheckBox(text, colIndex, rowIndex, tabIndex, 340);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000122E0 File Offset: 0x000104E0
		public static RdcCheckBox NewCheckBox(string text, int colIndex, int rowIndex, int tabIndex, int width)
		{
			return new RdcCheckBox
			{
				Location = FormTools.NewLocation(colIndex, rowIndex),
				Size = new Size(width, 20),
				TabIndex = tabIndex,
				Text = text
			};
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00012320 File Offset: 0x00010520
		public static RdcCheckBox AddCheckBox(Control parent, string text, BoolSetting setting, int colIndex, ref int rowIndex, ref int tabIndex)
		{
			RdcCheckBox rdcCheckBox = new RdcCheckBox();
			rdcCheckBox.Setting = setting;
			int num = rowIndex;
			rowIndex = num + 1;
			rdcCheckBox.Location = FormTools.NewLocation(colIndex, num);
			rdcCheckBox.Size = new Size(340, 20);
			num = tabIndex;
			tabIndex = num + 1;
			rdcCheckBox.TabIndex = num;
			rdcCheckBox.Text = text;
			RdcCheckBox rdcCheckBox2 = rdcCheckBox;
			parent.Controls.Add(rdcCheckBox2);
			return rdcCheckBox2;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000037C3 File Offset: 0x000019C3
		public static ValueComboBox<TEnum> AddLabeledEnumDropDown<TEnum>(Control parent, string text, ref int rowIndex, ref int tabIndex, Func<TEnum, string> toString) where TEnum : struct
		{
			return FormTools.AddLabeledValueDropDown<TEnum>(parent, text, ref rowIndex, ref tabIndex, toString, Helpers.EnumValues<TEnum>());
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00012388 File Offset: 0x00010588
		public static ValueComboBox<TValue> AddLabeledValueDropDown<TValue>(Control parent, string text, ref int rowIndex, ref int tabIndex, Func<TValue, string> toString, IEnumerable<TValue> values)
		{
			Label value = FormTools.NewLabel(text, 0, rowIndex);
			ValueComboBox<TValue> valueComboBox = new ValueComboBox<TValue>(values, toString);
			ComboBox comboBox = valueComboBox;
			int colIndex = 1;
			int num = rowIndex;
			rowIndex = num + 1;
			int rowIndex2 = num;
			num = tabIndex;
			tabIndex = num + 1;
			FormTools.SetDropDownProperties(comboBox, colIndex, rowIndex2, num);
			parent.Controls.Add(value);
			parent.Controls.Add(valueComboBox);
			return valueComboBox;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000123DC File Offset: 0x000105DC
		public static ValueComboBox<TValue> AddLabeledValueDropDown<TValue>(Control parent, string text, Setting<TValue> setting, ref int rowIndex, ref int tabIndex, Func<TValue, string> toString, IEnumerable<TValue> values)
		{
			Label value = FormTools.NewLabel(text, 0, rowIndex);
			ValueComboBox<TValue> valueComboBox = new ValueComboBox<TValue>(setting, values, toString);
			ComboBox comboBox = valueComboBox;
			int colIndex = 1;
			int num = rowIndex;
			rowIndex = num + 1;
			int rowIndex2 = num;
			num = tabIndex;
			tabIndex = num + 1;
			FormTools.SetDropDownProperties(comboBox, colIndex, rowIndex2, num);
			parent.Controls.Add(value);
			parent.Controls.Add(valueComboBox);
			return valueComboBox;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00012434 File Offset: 0x00010634
		public static ValueComboBox<TEnum> AddLabeledEnumDropDown<TEnum>(Control parent, string text, EnumSetting<TEnum> setting, ref int rowIndex, ref int tabIndex, Func<TEnum, string> toString) where TEnum : struct
		{
			Label value = FormTools.NewLabel(text, 0, rowIndex);
			ValueComboBox<TEnum> valueComboBox = new ValueComboBox<TEnum>(setting, Helpers.EnumValues<TEnum>(), toString);
			ComboBox comboBox = valueComboBox;
			int colIndex = 1;
			int num = rowIndex;
			rowIndex = num + 1;
			int rowIndex2 = num;
			num = tabIndex;
			tabIndex = num + 1;
			FormTools.SetDropDownProperties(comboBox, colIndex, rowIndex2, num);
			parent.Controls.Add(value);
			parent.Controls.Add(valueComboBox);
			return valueComboBox;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000037D5 File Offset: 0x000019D5
		private static void SetDropDownProperties(ComboBox comboBox, int colIndex, int rowIndex, int tabIndex)
		{
			comboBox.Location = FormTools.NewLocation(colIndex, rowIndex);
			comboBox.Size = new Size(340, 20);
			comboBox.TabIndex = tabIndex;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000037FD File Offset: 0x000019FD
		public static void LayoutGroupBox(GroupBox groupBox, int numCols, Control previousGroupBox)
		{
			FormTools.LayoutGroupBox(groupBox, numCols, previousGroupBox, 0, 0);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00012490 File Offset: 0x00010690
		public static void LayoutGroupBox(GroupBox groupBox, int numCols, Control previousControl, int rowIndex, int tabIndex)
		{
			int num = 0;
			foreach (object obj in groupBox.Controls)
			{
				Control control = (Control)obj;
				if (num == 1 && control.Width == 340)
				{
					control.Width -= 8;
				}
				control.Location = FormTools.NewLocation(num++, rowIndex);
				control.TabIndex = tabIndex;
				tabIndex += 2;
				if (!(control is Label))
				{
					control.TabStop = true;
				}
				if (num == numCols)
				{
					num = 0;
					rowIndex++;
				}
			}
			groupBox.SizeAndLocate(previousControl);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00012544 File Offset: 0x00010744
		public static void AddControlsAndSizeGroup(this GroupBox groupBox, params Control[] controls)
		{
			groupBox.Controls.AddRange(controls);
			foreach (object obj in groupBox.Controls)
			{
				Control control = (Control)obj;
				if (control.Width == 340)
				{
					control.Width -= 8;
				}
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000125C0 File Offset: 0x000107C0
		public static void SizeAndLocate(this GroupBox groupBox, Control previousControl)
		{
			int num = 8;
			if (previousControl != null)
			{
				groupBox.TabIndex = previousControl.TabIndex + 1;
				num += previousControl.Bottom;
			}
			else
			{
				groupBox.TabIndex = 1;
			}
			groupBox.Location = new Point(8, num);
			FormTools.ResizeGroupBox(groupBox);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00012608 File Offset: 0x00010808
		public static void ResizeGroupBox(GroupBox groupBox)
		{
			int num = FormTools.ComputeControlHeightFromChildren(groupBox);
			groupBox.Size = new Size(496, num + 8);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00012630 File Offset: 0x00010830
		public static TabPage NewTabPage(string name)
		{
			TabPage tabPage = new TabPage
			{
				Location = FormTools.TopLeftLocation(),
				Size = new Size(512, 334),
				Text = name
			};
			tabPage.SuspendLayout();
			return tabPage;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00012674 File Offset: 0x00010874
		public static TabPage NewTabPage(this TabControl parent, string name)
		{
			TabPage tabPage = FormTools.NewTabPage(name);
			parent.Controls.Add(tabPage);
			return tabPage;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00012698 File Offset: 0x00010898
		public static Control[] NewSizeRadios()
		{
			Control[] array = new Control[SizeHelper.StockSizes.Length];
			int num = 0;
			foreach (Size size in SizeHelper.StockSizes)
			{
				array[num++] = new RadioButton
				{
					Tag = size,
					Text = size.ToFormattedString()
				};
			}
			return array;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000126F8 File Offset: 0x000108F8
		public static void AddButtonsAndSizeForm(Form form, Button okButton, Button cancelButton)
		{
			int num = 0;
			int num2 = 0;
			foreach (object obj in form.Controls)
			{
				Control control = (Control)obj;
				num = Math.Max(num, control.Right);
				num2 = Math.Max(num2, control.Bottom);
			}
			num += 8;
			cancelButton.Location = new Point(num - cancelButton.Width - 8 - 1, num2 + 16);
			okButton.Location = new Point(cancelButton.Location.X - okButton.Width - 8, cancelButton.Location.Y);
			form.AcceptButton = okButton;
			form.CancelButton = cancelButton;
			form.Controls.Add(cancelButton);
			form.Controls.Add(okButton);
			form.ClientSize = new Size(num, okButton.Location.Y + okButton.Height + 16);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00012808 File Offset: 0x00010A08
		public static int ComputeControlHeightFromChildren(Control control)
		{
			int num = 0;
			foreach (object obj in control.Controls)
			{
				Control control2 = (Control)obj;
				num = Math.Max(num, control2.Bottom);
			}
			return num;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00003809 File Offset: 0x00001A09
		public static void ErrorDialog(string text)
		{
			MessageBox.Show(Program.TheForm, text, "RDCMan Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000381F File Offset: 0x00001A1F
		public static void InformationDialog(string text)
		{
			MessageBox.Show(Program.TheForm, text, "RDCMan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003835 File Offset: 0x00001A35
		public static DialogResult ExclamationDialog(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(Program.TheForm, text, "RDCMan", buttons, MessageBoxIcon.Exclamation);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000384A File Offset: 0x00001A4A
		public static DialogResult YesNoDialog(string text)
		{
			return FormTools.YesNoDialog(Program.TheForm, text, MessageBoxDefaultButton.Button2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000385C File Offset: 0x00001A5C
		public static DialogResult YesNoDialog(string text, MessageBoxDefaultButton defaultButton)
		{
			return FormTools.YesNoDialog(Program.TheForm, text, defaultButton);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000386A File Offset: 0x00001A6A
		public static DialogResult YesNoDialog(Form owner, string text)
		{
			return FormTools.YesNoDialog(owner, text, MessageBoxDefaultButton.Button2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003878 File Offset: 0x00001A78
		public static DialogResult YesNoDialog(Form owner, string text, MessageBoxDefaultButton defaultButton)
		{
			return MessageBox.Show(owner, text, "RDCMan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000388A File Offset: 0x00001A8A
		public static DialogResult YesNoCancelDialog(string text)
		{
			return FormTools.YesNoCancelDialog(text, MessageBoxDefaultButton.Button2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003897 File Offset: 0x00001A97
		public static DialogResult YesNoCancelDialog(string text, MessageBoxDefaultButton defaultButton)
		{
			return MessageBox.Show(Program.TheForm, text, "RDCMan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, defaultButton);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000038AD File Offset: 0x00001AAD
		public static void ScaleAndLayout(this Form form)
		{
			form.PerformAutoScale();
			form.ResumeLayout(false);
			form.PerformLayout();
		}

		// Token: 0x0400034F RID: 847
		public const int TabControlWidth = 520;

		// Token: 0x04000350 RID: 848
		public const int TabControlHeight = 350;

		// Token: 0x04000351 RID: 849
		public const int ControlHeight = 20;

		// Token: 0x04000352 RID: 850
		public const int VerticalSpace = 4;

		// Token: 0x04000353 RID: 851
		public const int HorizontalMargin = 8;

		// Token: 0x04000354 RID: 852
		public const int TopMargin = 16;

		// Token: 0x04000355 RID: 853
		public const int BottomMargin = 16;

		// Token: 0x04000356 RID: 854
		public const int Indent = 24;

		// Token: 0x04000357 RID: 855
		public const int TabPageWidth = 512;

		// Token: 0x04000358 RID: 856
		public const int TabPageHeight = 334;

		// Token: 0x04000359 RID: 857
		public const int TabPageInternalVerticalSpace = 8;

		// Token: 0x0400035A RID: 858
		public const int TabPageControlWidth = 480;

		// Token: 0x0400035B RID: 859
		public const int TabPageControlHeight = 302;

		// Token: 0x0400035C RID: 860
		public const int LabelWidth = 140;

		// Token: 0x0400035D RID: 861
		public const int TextBoxWidth = 340;

		// Token: 0x0400035E RID: 862
		public const int DropDownWidth = 340;

		// Token: 0x0400035F RID: 863
		public const int GroupBoxWidth = 496;
	}
}
