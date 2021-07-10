using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x02000191 RID: 401
	public class DisplaySizeElement : ConfigurationElement
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000085B9 File Offset: 0x000067B9
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x000085CB File Offset: 0x000067CB
		[ConfigurationProperty("size")]
		public string Size
		{
			get
			{
				return (string)base["size"];
			}
			set
			{
				base["size"] = value.ToString();
			}
		}
	}
}
