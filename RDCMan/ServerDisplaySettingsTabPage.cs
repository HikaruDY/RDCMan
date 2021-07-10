using System;

namespace RdcMan
{
	// Token: 0x0200007F RID: 127
	public class ServerDisplaySettingsTabPage : DisplaySettingsTabPage<ServerDisplaySettings>
	{
		// Token: 0x0600024F RID: 591 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		public ServerDisplaySettingsTabPage(TabbedSettingsDialog dialog, ServerDisplaySettings settings) : base(dialog, settings)
		{
			int num;
			int num2;
			base.Create(out num, out num2);
		}
	}
}
