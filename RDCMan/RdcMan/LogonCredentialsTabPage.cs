using System;

namespace RdcMan
{
	public class LogonCredentialsTabPage : CredentialsTabPage<LogonCredentials>
	{
		public LogonCredentialsTabPage(TabbedSettingsDialog dialog, LogonCredentials settings) : base(dialog, settings)
		{
		}

		public void CreateControls(LogonCredentialsDialogOptions options)
		{
			int num = 0;
			int num2 = 0;
			if ((options & LogonCredentialsDialogOptions.AllowInheritance) != LogonCredentialsDialogOptions.None)
			{
				base.CreateInheritanceControl(ref num2, ref num);
				base.InheritanceControl.EnabledChanged += delegate(bool enabled)
				{
					this._credentialsUI.EnableDisableControls(enabled);
				};
			}
			this._credentialsUI = new CredentialsUI(base.InheritanceControl);
			this._credentialsUI.AddControlsToParent(this, options, ref num2, ref num);
		}
	}
}
