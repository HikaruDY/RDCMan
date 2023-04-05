using System;

namespace RdcMan
{
	public class SecuritySettingsTabPage : SettingsTabPage<SecuritySettings>
	{
		public SecuritySettingsTabPage(TabbedSettingsDialog dialog, SecuritySettings settings) : base(dialog, settings)
		{
			int num = 0;
			int rowIndex = 0;
			base.CreateInheritanceControl(ref rowIndex, ref num);
			FormTools.AddLabeledEnumDropDown<RdpClient.AuthenticationLevel>(this, "&Authentication", settings.AuthenticationLevel, ref rowIndex, ref num, new Func<RdpClient.AuthenticationLevel, string>(RdpClient.AuthenticationLevelToString));
			base.Controls.Add(FormTools.NewLabel("Redirect protection", 0, rowIndex));
			RdcCheckBox restrictedAdmin = FormTools.AddCheckBox(this, "&Restricted Admin", settings.RestrictedAdmin, 1, ref rowIndex, ref num);
			RdcCheckBox remoteGuard = FormTools.AddCheckBox(this, "Remote Credential &Guard", settings.RemoteGuard, 1, ref rowIndex, ref num);
			restrictedAdmin.CheckedChanged += delegate(object sender, EventArgs args)
			{
				if (restrictedAdmin.Checked)
				{
					remoteGuard.Checked = false;
				}
			};
			remoteGuard.CheckedChanged += delegate(object sender, EventArgs args)
			{
				if (remoteGuard.Checked)
				{
					restrictedAdmin.Checked = false;
				}
			};
		}
	}
}
