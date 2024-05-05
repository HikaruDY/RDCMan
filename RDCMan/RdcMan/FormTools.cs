﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public static class FormTools
	{
		public static int XPos(int colIndex)
		{
			return 8 + 148 * colIndex;
		}

		public static int YPos(int rowIndex)
		{
			return 16 + 24 * rowIndex;
		}

		public static int YPosNoMargin(int rowIndex)
		{
			return 24 * rowIndex;
		}

		public static Point TopLeftLocation()
		{
			return new Point(4, 22);
		}

		public static Point NewLocation(int colIndex, int rowIndex)
		{
			return new Point(FormTools.XPos(colIndex), FormTools.YPos(rowIndex));
		}

		public static Point NewUngroupedLocation(int colIndex, int rowIndex)
		{
			return new Point(16 + 140 * colIndex, FormTools.YPos(rowIndex));
		}

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

		public static RdcTextBox AddLabeledTextBox(Control parent, string text, StringSetting setting, ref int rowIndex, ref int tabIndex)
		{
			RdcTextBox rdcTextBox = FormTools.AddLabeledTextBox(parent, text, ref rowIndex, ref tabIndex);
			rdcTextBox.Setting = setting;
			return rdcTextBox;
		}

		public static RdcCheckBox NewCheckBox(string text, int colIndex, int rowIndex, int tabIndex)
		{
			return FormTools.NewCheckBox(text, colIndex, rowIndex, tabIndex, 340);
		}

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

		public static ValueComboBox<TEnum> AddLabeledEnumDropDown<TEnum>(Control parent, string text, ref int rowIndex, ref int tabIndex, Func<TEnum, string> toString) where TEnum : struct
		{
			return FormTools.AddLabeledValueDropDown<TEnum>(parent, text, ref rowIndex, ref tabIndex, toString, Helpers.EnumValues<TEnum>());
		}

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

		private static void SetDropDownProperties(ComboBox comboBox, int colIndex, int rowIndex, int tabIndex)
		{
			comboBox.Location = FormTools.NewLocation(colIndex, rowIndex);
			comboBox.Size = new Size(340, 20);
			comboBox.TabIndex = tabIndex;
		}

		public static void LayoutGroupBox(GroupBox groupBox, int numCols, Control previousGroupBox)
		{
			FormTools.LayoutGroupBox(groupBox, numCols, previousGroupBox, 0, 0);
		}

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

		public static void ResizeGroupBox(GroupBox groupBox)
		{
			int num = FormTools.ComputeControlHeightFromChildren(groupBox);
			groupBox.Size = new Size(496, num + 8);
		}

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

		public static TabPage NewTabPage(this TabControl parent, string name)
		{
			TabPage tabPage = FormTools.NewTabPage(name);
			parent.Controls.Add(tabPage);
			return tabPage;
		}

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

		public static void ErrorDialog(string text)
		{
			MessageBox.Show(Program.TheForm, text, "RDCMan Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		public static void InformationDialog(string text)
		{
			MessageBox.Show(Program.TheForm, text, "RDCMan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		public static DialogResult ExclamationDialog(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(Program.TheForm, text, "RDCMan", buttons, MessageBoxIcon.Exclamation);
		}

		public static DialogResult YesNoDialog(string text)
		{
			return FormTools.YesNoDialog(Program.TheForm, text, MessageBoxDefaultButton.Button2);
		}

		public static DialogResult YesNoDialog(string text, MessageBoxDefaultButton defaultButton)
		{
			return FormTools.YesNoDialog(Program.TheForm, text, defaultButton);
		}

		public static DialogResult YesNoDialog(Form owner, string text)
		{
			return FormTools.YesNoDialog(owner, text, MessageBoxDefaultButton.Button2);
		}

		public static DialogResult YesNoDialog(Form owner, string text, MessageBoxDefaultButton defaultButton)
		{
			return MessageBox.Show(owner, text, "RDCMan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);
		}

		public static DialogResult YesNoCancelDialog(string text)
		{
			return FormTools.YesNoCancelDialog(text, MessageBoxDefaultButton.Button2);
		}

		public static DialogResult YesNoCancelDialog(string text, MessageBoxDefaultButton defaultButton)
		{
			return MessageBox.Show(Program.TheForm, text, "RDCMan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, defaultButton);
		}

		public static void ScaleAndLayout(this Form form)
		{
			form.PerformAutoScale();
			form.ResumeLayout(false);
			form.PerformLayout();
		}

		public const int TabControlWidth = 520;

		public const int TabControlHeight = 350;

		public const int ControlHeight = 20;

		public const int VerticalSpace = 4;

		public const int HorizontalMargin = 8;

		public const int TopMargin = 16;

		public const int BottomMargin = 16;

		public const int Indent = 24;

		public const int TabPageWidth = 512;

		public const int TabPageHeight = 334;

		public const int TabPageInternalVerticalSpace = 8;

		public const int TabPageControlWidth = 480;

		public const int TabPageControlHeight = 302;

		public const int LabelWidth = 140;

		public const int TextBoxWidth = 340;

		public const int DropDownWidth = 340;

		public const int GroupBoxWidth = 496;
	}
}
