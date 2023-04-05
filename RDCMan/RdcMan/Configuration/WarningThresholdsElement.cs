using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x020000ED RID: 237
	public class WarningThresholdsElement : ConfigurationElement
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x000238B4 File Offset: 0x00021AB4
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x000238C8 File Offset: 0x00021AC8
		[ConfigurationProperty("connect", DefaultValue = 10)]
		public int Connect
		{
			get
			{
				return (int)base["connect"];
			}
			set
			{
				base["connect"] = value;
			}
		}
	}
}
