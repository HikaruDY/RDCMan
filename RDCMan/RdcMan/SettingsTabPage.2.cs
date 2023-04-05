using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public abstract class SettingsTabPage<TSettingsGroup> : SettingsTabPage, ISettingsTabPage where TSettingsGroup : SettingsGroup
	{
		protected SettingsTabPage(TabbedSettingsDialog dialog, TSettingsGroup settingsGroup) : this(dialog, settingsGroup, settingsGroup.Name)
		{
		}

		protected SettingsTabPage(TabbedSettingsDialog dialog, TSettingsGroup settingsGroup, string name)
		{
			this.Dialog = dialog;
			this.Settings = settingsGroup;
			base.Location = FormTools.TopLeftLocation();
			base.Size = new Size(512, 334);
			this.Text = name;
		}

		private protected InheritanceControl InheritanceControl { protected get; private set; }

		private protected TSettingsGroup Settings { protected get; private set; }

		private protected TabbedSettingsDialog Dialog { protected get; private set; }

		protected void CreateInheritanceControl(ref int rowIndex, ref int tabIndex)
		{
			if (this.Settings.InheritSettingsType.Mode == InheritanceMode.Disabled)
			{
				return;
			}
			this.InheritanceControl = new InheritanceControl(this.Dialog, this.Settings.Name);
			this.InheritanceControl.Create(this, ref rowIndex, ref tabIndex);
		}

		InheritanceControl ISettingsTabPage.InheritanceControl
		{
			get
			{
				return this.InheritanceControl;
			}
		}

		void ISettingsTabPage.UpdateControls()
		{
			this.UpdateControls();
		}

		void ISettingsTabPage.UpdateSettings()
		{
			this.UpdateSettings();
		}

		protected override void UpdateControls()
		{
			if (this.InheritanceControl != null)
			{
				this.InheritanceControl.UpdateControlsFromSettings(this.Settings.InheritSettingsType);
			}
			else
			{
				foreach (Control control in base.Controls.FlattenControls())
				{
					control.Enabled = true;
				}
			}
			base.UpdateControls();
		}

		protected override void UpdateSettings()
		{
			if (this.InheritanceControl != null)
			{
				this.Settings.InheritSettingsType.Mode = this.InheritanceControl.GetInheritanceMode();
			}
			base.UpdateSettings();
		}
	}
}
