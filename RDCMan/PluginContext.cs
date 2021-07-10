using System;

namespace RdcMan
{
	// Token: 0x020000F0 RID: 240
	internal class PluginContext : IPluginContext
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00005A27 File Offset: 0x00003C27
		IMainForm IPluginContext.MainForm
		{
			get
			{
				return Program.TheForm;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00005A2E File Offset: 0x00003C2E
		IServerTree IPluginContext.Tree
		{
			get
			{
				return ServerTree.Instance;
			}
		}
	}
}
