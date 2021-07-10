using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x0200018F RID: 399
	public class WarningThresholdsElement : ConfigurationElement
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0000852A File Offset: 0x0000672A
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0000853C File Offset: 0x0000673C
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
