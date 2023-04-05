using System;

namespace RdcMan
{
	public class QuickConnectTabPage : LogonCredentialsTabPage
	{
		public QuickConnectTabPage(TabbedSettingsDialog dialog, LogonCredentials settings) : base(dialog, settings)
		{
		}

		public RdcTextBox ServerNameTextBox { get; private set; }

		public void CreateControls(bool serverName, FileGroup fileGroup)
		{
			int num = 0;
			int num2 = 0;
			if (serverName)
			{
				this.ServerNameTextBox = FormTools.AddLabeledTextBox(this, "&Server name:", ref num2, ref num);
				this.ServerNameTextBox.Enabled = true;
			}
			this._credentialsUI = new CredentialsUI(base.InheritanceControl);
			this._credentialsUI.AddControlsToParent(this, LogonCredentialsDialogOptions.ShowProfiles, ref num2, ref num);
			this._credentialsUI.PopulateCredentialsProfiles(fileGroup);
		}

		public void OnShown()
		{
			if (this.ServerNameTextBox != null)
			{
				this.ServerNameTextBox.Focus();
				return;
			}
			this._credentialsUI.ProfileComboBox.Focus();
		}
	}
}
