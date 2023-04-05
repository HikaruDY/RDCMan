using System;

namespace RdcMan
{
	public class ServerDisplaySettingsTabPage : DisplaySettingsTabPage<ServerDisplaySettings>
	{
		public ServerDisplaySettingsTabPage(TabbedSettingsDialog dialog, ServerDisplaySettings settings) : base(dialog, settings)
		{
			int num;
			int num2;
			base.Create(out num, out num2);
		}
	}
}
