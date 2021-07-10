using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x0200018E RID: 398
	public class ProgramUpdateElement : ConfigurationElement
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x000084E2 File Offset: 0x000066E2
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x000084F4 File Offset: 0x000066F4
		[ConfigurationProperty("versionPath")]
		public string VersionPath
		{
			get
			{
				return (string)base["versionPath"];
			}
			set
			{
				base["versionPath"] = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00008502 File Offset: 0x00006702
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00008514 File Offset: 0x00006714
		[ConfigurationProperty("updateUrl")]
		public string UpdateUrl
		{
			get
			{
				return (string)base["updateUrl"];
			}
			set
			{
				base["updateUrl"] = value;
			}
		}
	}
}
