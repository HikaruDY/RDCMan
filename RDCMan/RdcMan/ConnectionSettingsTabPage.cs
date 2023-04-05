using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public class ConnectionSettingsTabPage : SettingsTabPage<ConnectionSettings>
	{
		public ConnectionSettingsTabPage(TabbedSettingsDialog dialog, ConnectionSettings settings) : base(dialog, settings)
		{
			int num = 0;
			int rowIndex = 0;
			base.CreateInheritanceControl(ref rowIndex, ref num);
			FormTools.AddCheckBox(this, "&Connect to console", settings.ConnectToConsole, 1, ref rowIndex, ref num);
			FormTools.AddLabeledTextBox(this, "&Start program:", settings.StartProgram, ref rowIndex, ref num);
			FormTools.AddLabeledTextBox(this, "&Working dir:", settings.WorkingDir, ref rowIndex, ref num);
			Label label = FormTools.NewLabel("Por&t:", 0, rowIndex);
			this._portUpDown = new NumericUpDown();
			((ISupportInitialize)this._portUpDown).BeginInit();
			this._portUpDown.Location = FormTools.NewLocation(1, rowIndex++);
			this._portUpDown.Size = new Size(160, 20);
			this._portUpDown.Minimum = 1m;
			this._portUpDown.Maximum = 65535m;
			this._portUpDown.KeyUp += delegate(object s, KeyEventArgs e)
			{
				this.UpdatePortDefaultLabel();
			};
			this._portUpDown.ValueChanged += delegate(object s, EventArgs e)
			{
				this.UpdatePortDefaultLabel();
			};
			this._portUpDown.TabIndex = num++;
			((ISupportInitialize)this._portUpDown).EndInit();
			this._portDefaultLabel = new Label();
			this._portDefaultLabel.Location = new Point(this._portUpDown.Location.X + this._portUpDown.Width, this._portUpDown.Location.Y - 1);
			this._portDefaultLabel.Size = new Size(140, 20);
			this._portDefaultLabel.TextAlign = ContentAlignment.MiddleLeft;
			FormTools.AddLabeledTextBox(this, "&Load balance config:", settings.LoadBalanceInfo, ref rowIndex, ref num);
			base.Controls.Add(new Control[]
			{
				label,
				this._portUpDown,
				this._portDefaultLabel
			});
		}

		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._portUpDown.Text = base.Settings.Port.Value.ToString();
		}

		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			base.Settings.Port.Value = (int)this._portUpDown.Value;
		}

		private void UpdatePortDefaultLabel()
		{
			this._portDefaultLabel.Text = ((this._portUpDown.Value == 3389m) ? "(default)" : string.Empty);
		}

		private Label _portDefaultLabel;

		private NumericUpDown _portUpDown;
	}
}
