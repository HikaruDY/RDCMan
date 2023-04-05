using System;

namespace RdcMan
{
	// Token: 0x0200004F RID: 79
	public class ServerDisplaySettingsTabPage : DisplaySettingsTabPage<ServerDisplaySettings>
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public ServerDisplaySettingsTabPage(TabbedSettingsDialog dialog, ServerDisplaySettings settings) : base(dialog, settings)
		{
			int num;
			int num2;
			base.Create(out num, out num2);
		}
	}
}
