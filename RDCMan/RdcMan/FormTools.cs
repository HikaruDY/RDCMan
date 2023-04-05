using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200005B RID: 91
	public static class FormTools
	{
		// Token: 0x06000230 RID: 560 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		public static int XPos(int colIndex)
		{
			return 8 + 148 * colIndex;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		public static int YPos(int rowIndex)
		{
			return 16 + 24 * rowIndex;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000D2CC File Offset: 0x0000B4CC
		public static int YPosNoMargin(int rowIndex)
		{
			return 24 * rowIndex;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		public static Point TopLeftLocation()
		{
			return new Point(4, 22);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		public static Point NewLocation(int colIndex, int rowIndex)
		{
			return new Point(FormTools.XPos(colIndex), FormTools.YPos(rowIndex));
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
		public static Point NewUngroupedLocation(int colIndex, int rowIndex)
		{
			return new Point(16 + 140 * colIndex, FormTools.YPos(rowIndex));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000D30C File Offset: 0x0000B50C
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

		// Token: 0x06000237 RID: 567 RVA: 0x0000D354 File Offset: 0x0000B554
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

		// Token: 0x06000238 RID: 568 RVA: 0x0000D39C File Offset: 0x0000B59C
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

		// Token: 0x06000239 RID: 569 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
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

		// Token: 0x0600023A RID: 570 RVA: 0x0000D444 File Offset: 0x0000B644
		public static RdcTextBox AddLabeledTextBox(Control parent, string text, StringSetting setting, ref int rowIndex, ref int tabIndex)
		{
			RdcTextBox rdcTextBox = FormTools.AddLabeledTextBox(parent, text, ref rowIndex, ref tabIndex);
			rdcTextBox.Setting = setting;
			return rdcTextBox;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000D468 File Offset: 0x0000B668
		public static RdcCheckBox NewCheckBox(string text, int colIndex, int rowIndex, int tabIndex)
		{
			return FormTools.NewCheckBox(text, colIndex, rowIndex, tabIndex, 340);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000D478 File Offset: 0x0000B678
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

		// Token: 0x0600023D RID: 573 RVA: 0x0000D4BC File Offset: 0x0000B6BC
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

		// Token: 0x0600023E RID: 574 RVA: 0x0000D528 File Offset: 0x0000B728
		public static ValueComboBox<TEnum> AddLabeledEnumDropDown<TEnum>(Control parent, string text, ref int rowIndex, ref int tabIndex, Func<TEnum, string> toString) where TEnum : struct
		{
			return FormTools.AddLabeledValueDropDown<TEnum>(parent, text, ref rowIndex, ref tabIndex, toString, Helpers.EnumValues<TEnum>());
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000D53C File Offset: 0x0000B73C
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

		// Token: 0x06000240 RID: 576 RVA: 0x0000D594 File Offset: 0x0000B794
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

		// Token: 0x06000241 RID: 577 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
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

		// Token: 0x06000242 RID: 578 RVA: 0x0000D650 File Offset: 0x0000B850
		private static void SetDropDownProperties(ComboBox comboBox, int colIndex, int rowIndex, int tabIndex)
		{
			comboBox.Location = FormTools.NewLocation(colIndex, rowIndex);
			comboBox.Size = new Size(340, 20);
			comboBox.TabIndex = tabIndex;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000D678 File Offset: 0x0000B878
		public static void LayoutGroupBox(GroupBox groupBox, int numCols, Control previousGroupBox)
		{
			FormTools.LayoutGroupBox(groupBox, numCols, previousGroupBox, 0, 0);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000D684 File Offset: 0x0000B884
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

		// Token: 0x06000245 RID: 581 RVA: 0x0000D74C File Offset: 0x0000B94C
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

		// Token: 0x06000246 RID: 582 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
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

		// Token: 0x06000247 RID: 583 RVA: 0x0000D824 File Offset: 0x0000BA24
		public static void ResizeGroupBox(GroupBox groupBox)
		{
			int num = FormTools.ComputeControlHeightFromChildren(groupBox);
			groupBox.Size = new Size(496, num + 8);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000D850 File Offset: 0x0000BA50
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

		// Token: 0x06000249 RID: 585 RVA: 0x0000D898 File Offset: 0x0000BA98
		public static TabPage NewTabPage(this TabControl parent, string name)
		{
			TabPage tabPage = FormTools.NewTabPage(name);
			parent.Controls.Add(tabPage);
			return tabPage;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
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

		// Token: 0x0600024B RID: 587 RVA: 0x0000D928 File Offset: 0x0000BB28
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

		// Token: 0x0600024C RID: 588 RVA: 0x0000DA40 File Offset: 0x0000BC40
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

		// Token: 0x0600024D RID: 589 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		public static void ErrorDialog(string text)
		{
			MessageBox.Show(Program.TheForm, text, "RDCMan Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
		public static void InformationDialog(string text)
		{
			MessageBox.Show(Program.TheForm, text, "RDCMan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000DADC File Offset: 0x0000BCDC
		public static DialogResult ExclamationDialog(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(Program.TheForm, text, "RDCMan", buttons, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		public static DialogResult YesNoDialog(string text)
		{
			return FormTools.YesNoDialog(Program.TheForm, text, MessageBoxDefaultButton.Button2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000DB08 File Offset: 0x0000BD08
		public static DialogResult YesNoDialog(string text, MessageBoxDefaultButton defaultButton)
		{
			return FormTools.YesNoDialog(Program.TheForm, text, defaultButton);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000DB18 File Offset: 0x0000BD18
		public static DialogResult YesNoDialog(Form owner, string text)
		{
			return FormTools.YesNoDialog(owner, text, MessageBoxDefaultButton.Button2);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000DB28 File Offset: 0x0000BD28
		public static DialogResult YesNoDialog(Form owner, string text, MessageBoxDefaultButton defaultButton)
		{
			return MessageBox.Show(owner, text, "RDCMan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000DB3C File Offset: 0x0000BD3C
		public static DialogResult YesNoCancelDialog(string text)
		{
			return FormTools.YesNoCancelDialog(text, MessageBoxDefaultButton.Button2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000DB4C File Offset: 0x0000BD4C
		public static DialogResult YesNoCancelDialog(string text, MessageBoxDefaultButton defaultButton)
		{
			return MessageBox.Show(Program.TheForm, text, "RDCMan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, defaultButton);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000DB64 File Offset: 0x0000BD64
		public static void ScaleAndLayout(this Form form)
		{
			form.PerformAutoScale();
			form.ResumeLayout(false);
			form.PerformLayout();
		}

		// Token: 0x0400012F RID: 303
		public const int TabControlWidth = 520;

		// Token: 0x04000130 RID: 304
		public const int TabControlHeight = 350;

		// Token: 0x04000131 RID: 305
		public const int ControlHeight = 20;

		// Token: 0x04000132 RID: 306
		public const int VerticalSpace = 4;

		// Token: 0x04000133 RID: 307
		public const int HorizontalMargin = 8;

		// Token: 0x04000134 RID: 308
		public const int TopMargin = 16;

		// Token: 0x04000135 RID: 309
		public const int BottomMargin = 16;

		// Token: 0x04000136 RID: 310
		public const int Indent = 24;

		// Token: 0x04000137 RID: 311
		public const int TabPageWidth = 512;

		// Token: 0x04000138 RID: 312
		public const int TabPageHeight = 334;

		// Token: 0x04000139 RID: 313
		public const int TabPageInternalVerticalSpace = 8;

		// Token: 0x0400013A RID: 314
		public const int TabPageControlWidth = 480;

		// Token: 0x0400013B RID: 315
		public const int TabPageControlHeight = 302;

		// Token: 0x0400013C RID: 316
		public const int LabelWidth = 140;

		// Token: 0x0400013D RID: 317
		public const int TextBoxWidth = 340;

		// Token: 0x0400013E RID: 318
		public const int DropDownWidth = 340;

		// Token: 0x0400013F RID: 319
		public const int GroupBoxWidth = 496;
	}
}
