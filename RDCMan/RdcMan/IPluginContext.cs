using System;

namespace RdcMan
{
	// Token: 0x02000060 RID: 96
	public interface IPluginContext
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600026F RID: 623
		IMainForm MainForm { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000270 RID: 624
		IServerTree Tree { get; }
	}
}
