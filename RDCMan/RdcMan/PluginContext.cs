using System;

namespace RdcMan
{
	internal class PluginContext : IPluginContext
	{
		IMainForm IPluginContext.MainForm
		{
			get
			{
				return Program.TheForm;
			}
		}

		IServerTree IPluginContext.Tree
		{
			get
			{
				return ServerTree.Instance;
			}
		}
	}
}
