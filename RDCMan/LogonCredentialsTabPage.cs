using System;

namespace RdcMan
{
	// Token: 0x0200007C RID: 124
	public class LogonCredentialsTabPage : CredentialsTabPage<LogonCredentials>
	{
		// Token: 0x06000245 RID: 581 RVA: 0x00003492 File Offset: 0x00001692
		public LogonCredentialsTabPage(TabbedSettingsDialog dialog, LogonCredentials settings) : base(dialog, settings)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00010AB8 File Offset: 0x0000ECB8
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
