using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	public class RemoteDesktopTabPage : SettingsTabPage<RemoteDesktopSettings>
	{
		public RemoteDesktopTabPage(TabbedSettingsDialog dialog, RemoteDesktopSettings settings) : base(dialog, settings)
		{
			int num = 0;
			int num2 = 0;
			base.CreateInheritanceControl(ref num2, ref num);
			ValueComboBox<int> previousGroupBox = FormTools.AddLabeledValueDropDown<int>(this, "Color Depth", settings.ColorDepth, ref num2, ref num, (int v) => v.ToString(), new int[]
			{
				8,
				15,
				16,
				24,
				32
			});
			RadioButton value = new RdcRadioButton
			{
				Setting = settings.DesktopSizeSameAsClientAreaSize,
				Size = new Size(140, 24),
				Text = "&Same as client area"
			};
			RadioButton value2 = new RdcRadioButton
			{
				Setting = settings.DesktopSizeFullScreen,
				Size = new Size(140, 24),
				Text = "&Full screen"
			};
			this._rdsCustomRadio = new RadioButton();
			this._rdsCustomButton = new Button();
			this._rdsCustomRadio.Size = new Size(72, 24);
			this._rdsCustomRadio.Text = "&Custom";
			this._rdsSizeGroup = new GroupBox();
			this._rdsSizeGroup.Controls.AddRange(FormTools.NewSizeRadios());
			this._rdsSizeGroup.Controls.Add(value);
			this._rdsSizeGroup.Controls.Add(value2);
			this._rdsSizeGroup.Controls.Add(this._rdsCustomRadio);
			this._rdsSizeGroup.Text = "Remote Desktop Size";
			FormTools.LayoutGroupBox(this._rdsSizeGroup, 2, previousGroupBox);
			this._rdsCustomButton.Location = new Point(this._rdsCustomRadio.Right + 10, this._rdsCustomRadio.Location.Y);
			this._rdsCustomButton.TabIndex = this._rdsCustomRadio.TabIndex + 1;
			this._rdsCustomButton.Click += this.CustomSizeClick;
			this._rdsCustomButton.Text = Program.TheForm.GetClientSize().ToFormattedString();
			this._rdsSizeGroup.Controls.Add(this._rdsCustomButton);
			base.Controls.Add(this._rdsSizeGroup);
		}

		protected override void UpdateControls()
		{
			base.UpdateControls();
			Size size = base.Settings.DesktopSize.Value;
			if (!base.Settings.DesktopSizeSameAsClientAreaSize.Value && !base.Settings.DesktopSizeFullScreen.Value)
			{
				RadioButton radioButton = this._rdsSizeGroup.Controls.OfType<RadioButton>().Where(delegate(RadioButton r)
				{
					Size? size = (Size?)r.Tag;
					Size size2 = size;
					return size != null && (size == null || size.GetValueOrDefault() == size2);
				}).FirstOrDefault<RadioButton>();
				if (radioButton != null)
				{
					radioButton.Checked = true;
				}
				else
				{
					this._rdsCustomRadio.Checked = true;
				}
			}
			this._rdsCustomButton.Text = size.ToFormattedString();
		}

		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			if (!base.Settings.DesktopSizeSameAsClientAreaSize.Value && !base.Settings.DesktopSizeFullScreen.Value)
			{
				string text = this._rdsCustomButton.Text;
				if (!this._rdsCustomRadio.Checked)
				{
					text = (from r in this._rdsSizeGroup.Controls.OfType<RadioButton>()
					where r.Checked
					select r).First<RadioButton>().Text;
				}
				base.Settings.DesktopSize.Value = SizeHelper.Parse(text);
			}
		}

		private void CustomSizeClick(object sender, EventArgs e)
		{
			Button button = sender as Button;
			RadioButton radioButton = button.Parent.GetNextControl(button, false) as RadioButton;
			radioButton.Checked = true;
			Size size = SizeHelper.Parse(button.Text);
			using (CustomSizeDialog customSizeDialog = new CustomSizeDialog(size))
			{
				if (customSizeDialog.ShowDialog() == DialogResult.OK)
				{
					button.Text = customSizeDialog.WidthText + SizeHelper.Separator + customSizeDialog.HeightText;
				}
			}
		}

		private readonly GroupBox _rdsSizeGroup;

		private readonly RadioButton _rdsCustomRadio;

		private readonly Button _rdsCustomButton;
	}
}
