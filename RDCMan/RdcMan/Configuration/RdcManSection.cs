using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x020000EB RID: 235
	public class RdcManSection : ConfigurationSection
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00023814 File Offset: 0x00021A14
		[ConfigurationProperty("displaySizes", IsDefaultCollection = false)]
		public DisplaySizeElementCollection DisplaySizes
		{
			get
			{
				return (DisplaySizeElementCollection)base["displaySizes"];
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00023828 File Offset: 0x00021A28
		[ConfigurationProperty("programUpdate")]
		public ProgramUpdateElement ProgramUpdate
		{
			get
			{
				return (ProgramUpdateElement)base["programUpdate"];
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0002383C File Offset: 0x00021A3C
		[ConfigurationProperty("warningThresholds")]
		public WarningThresholdsElement WarningThresholds
		{
			get
			{
				return (WarningThresholdsElement)base["warningThresholds"];
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00023850 File Offset: 0x00021A50
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
