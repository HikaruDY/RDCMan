using System;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	public class SettingsTabPage : TabPage, ISettingsTabPage
	{
		InheritanceControl ISettingsTabPage.InheritanceControl
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		Control ISettingsTabPage.FocusControl
		{
			get
			{
				return this.FocusControl;
			}
		}

		void ISettingsTabPage.UpdateControls()
		{
			this.UpdateControls();
		}

		bool ISettingsTabPage.Validate()
		{
			string text = this.Text.Replace(" (!)", string.Empty);
			if (this.IsValid())
			{
				this.Text = text;
				return true;
			}
			this.Text = text + " (!)";
			return false;
		}

		void ISettingsTabPage.UpdateSettings()
		{
			this.UpdateSettings();
		}

		protected Control FocusControl { get; set; }

		protected virtual void UpdateControls()
		{
			foreach (ISettingControl settingControl in base.Controls.FlattenControls().OfType<ISettingControl>())
			{
				settingControl.UpdateControl();
			}
		}

		protected virtual bool IsValid()
		{
			RdcDialog rdcDialog = base.FindForm() as RdcDialog;
			return rdcDialog.ValidateControls(base.Controls.FlattenControls(), true);
		}

		protected virtual void UpdateSettings()
		{
			foreach (ISettingControl settingControl in base.Controls.FlattenControls().OfType<ISettingControl>())
			{
				settingControl.UpdateSetting();
			}
		}

		private const string InvalidSuffix = " (!)";
	}
}
