using System;

namespace RdcMan
{
	// Token: 0x0200008E RID: 142
	public class SecuritySettingsTabPage : SettingsTabPage<SecuritySettings>
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00012150 File Offset: 0x00010350
		public SecuritySettingsTabPage(TabbedSettingsDialog dialog, SecuritySettings settings) : base(dialog, settings)
		{
			int num = 0;
			int num2 = 0;
			base.CreateInheritanceControl(ref num2, ref num);
			FormTools.AddLabeledEnumDropDown<RdpClient.AuthenticationLevel>(this, "&Authentication", settings.AuthenticationLevel, ref num2, ref num, new Func<RdpClient.AuthenticationLevel, string>(RdpClient.AuthenticationLevelToString));
		}
	}
}
