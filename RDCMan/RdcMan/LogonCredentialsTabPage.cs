using System;

namespace RdcMan
{
	// Token: 0x0200004C RID: 76
	public class LogonCredentialsTabPage : CredentialsTabPage<LogonCredentials>
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x0000B764 File Offset: 0x00009964
		public LogonCredentialsTabPage(TabbedSettingsDialog dialog, LogonCredentials settings) : base(dialog, settings)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000B770 File Offset: 0x00009970
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
