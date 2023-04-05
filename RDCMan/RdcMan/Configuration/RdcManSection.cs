using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	public class RdcManSection : ConfigurationSection
	{
		[ConfigurationProperty("displaySizes", IsDefaultCollection = false)]
		public DisplaySizeElementCollection DisplaySizes
		{
			get
			{
				return (DisplaySizeElementCollection)base["displaySizes"];
			}
		}

		[ConfigurationProperty("programUpdate")]
		public ProgramUpdateElement ProgramUpdate
		{
			get
			{
				return (ProgramUpdateElement)base["programUpdate"];
			}
		}

		[ConfigurationProperty("warningThresholds")]
		public WarningThresholdsElement WarningThresholds
		{
			get
			{
				return (WarningThresholdsElement)base["warningThresholds"];
			}
		}

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
