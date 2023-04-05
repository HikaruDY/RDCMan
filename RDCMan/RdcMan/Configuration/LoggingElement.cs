using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x020000EE RID: 238
	public class LoggingElement : ConfigurationElement
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x000238E4 File Offset: 0x00021AE4
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x000238F8 File Offset: 0x00021AF8
		[ConfigurationProperty("enabled")]
		public bool Enabled
		{
			get
			{
				return (bool)base["enabled"];
			}
			set
			{
				base["enabled"] = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0002390C File Offset: 0x00021B0C
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00023920 File Offset: 0x00021B20
		[ConfigurationProperty("path")]
		public string Path
		{
			get
			{
				return (string)base["path"];
			}
			set
			{
				base["path"] = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00023930 File Offset: 0x00021B30
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00023944 File Offset: 0x00021B44
		[ConfigurationProperty("maximumNumberOfFiles", DefaultValue = 5)]
		public int MaximumNumberOfFiles
		{
			get
			{
				return (int)base["maximumNumberOfFiles"];
			}
			set
			{
				base["maximumNumberOfFiles"] = value;
			}
		}
	}
}
