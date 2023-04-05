using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000048 RID: 72
	public class ConnectionSettingsTabPage : SettingsTabPage<ConnectionSettings>
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0000B384 File Offset: 0x00009584
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

		// Token: 0x060001CD RID: 461 RVA: 0x0000B55C File Offset: 0x0000975C
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._portUpDown.Text = base.Settings.Port.Value.ToString();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000B598 File Offset: 0x00009798
		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			base.Settings.Port.Value = (int)this._portUpDown.Value;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000B5D0 File Offset: 0x000097D0
		private void UpdatePortDefaultLabel()
		{
			this._portDefaultLabel.Text = ((this._portUpDown.Value == 3389m) ? "(default)" : string.Empty);
		}

		// Token: 0x04000108 RID: 264
		private Label _portDefaultLabel;

		// Token: 0x04000109 RID: 265
		private NumericUpDown _portUpDown;
	}
}
