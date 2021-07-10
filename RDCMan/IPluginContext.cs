using System;

namespace RdcMan
{
	// Token: 0x02000096 RID: 150
	public interface IPluginContext
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002EC RID: 748
		IMainForm MainForm { get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002ED RID: 749
		IServerTree Tree { get; }
	}
}
