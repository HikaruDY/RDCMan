using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x02000190 RID: 400
	public class LoggingElement : ConfigurationElement
	{
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0000854F File Offset: 0x0000674F
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00008561 File Offset: 0x00006761
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

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00008574 File Offset: 0x00006774
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00008586 File Offset: 0x00006786
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

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00008594 File Offset: 0x00006794
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x000085A6 File Offset: 0x000067A6
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
