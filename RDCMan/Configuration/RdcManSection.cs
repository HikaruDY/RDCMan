using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x0200018D RID: 397
	public class RdcManSection : ConfigurationSection
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0000849A File Offset: 0x0000669A
		[ConfigurationProperty("displaySizes", IsDefaultCollection = false)]
		public DisplaySizeElementCollection DisplaySizes
		{
			get
			{
				return (DisplaySizeElementCollection)base["displaySizes"];
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000084AC File Offset: 0x000066AC
		[ConfigurationProperty("programUpdate")]
		public ProgramUpdateElement ProgramUpdate
		{
			get
			{
				return (ProgramUpdateElement)base["programUpdate"];
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x000084BE File Offset: 0x000066BE
		[ConfigurationProperty("warningThresholds")]
		public WarningThresholdsElement WarningThresholds
		{
			get
			{
				return (WarningThresholdsElement)base["warningThresholds"];
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000084D0 File Offset: 0x000066D0
		[ConfigurationProperty("logging")]
		public LoggingElement Logging
		{
			get
			{
				return (LoggingElement)base["logging"];
			}
		}
	}
}
