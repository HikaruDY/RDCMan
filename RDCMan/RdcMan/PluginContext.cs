using System;

namespace RdcMan
{
	// Token: 0x0200008D RID: 141
	internal class PluginContext : IPluginContext
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x000180C4 File Offset: 0x000162C4
		IMainForm IPluginContext.MainForm
		{
			get
			{
				return Program.TheForm;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x000180CC File Offset: 0x000162CC
		IServerTree IPluginContext.Tree
		{
			get
			{
				return ServerTree.Instance;
			}
		}
	}
}
