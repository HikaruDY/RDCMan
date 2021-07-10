using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000078 RID: 120
	public class ConnectionSettingsTabPage : SettingsTabPage<ConnectionSettings>
	{
		// Token: 0x06000238 RID: 568 RVA: 0x000107D0 File Offset: 0x0000E9D0
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

		// Token: 0x06000239 RID: 569 RVA: 0x000109A4 File Offset: 0x0000EBA4
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._portUpDown.Text = base.Settings.Port.Value.ToString();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000033D5 File Offset: 0x000015D5
		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			base.Settings.Port.Value = (int)this._portUpDown.Value;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000033FD File Offset: 0x000015FD
		private void UpdatePortDefaultLabel()
		{
			this._portDefaultLabel.Text = ((this._portUpDown.Value == 3389m) ? "(default)" : string.Empty);
		}

		// Token: 0x04000320 RID: 800
		private Label _portDefaultLabel;

		// Token: 0x04000321 RID: 801
		private NumericUpDown _portUpDown;
	}
}
