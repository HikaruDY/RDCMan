using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x020000EC RID: 236
	public class ProgramUpdateElement : ConfigurationElement
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00023864 File Offset: 0x00021A64
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00023878 File Offset: 0x00021A78
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00023888 File Offset: 0x00021A88
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x0002389C File Offset: 0x00021A9C
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
