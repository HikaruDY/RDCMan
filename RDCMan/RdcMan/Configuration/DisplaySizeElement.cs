using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x020000EF RID: 239
	public class DisplaySizeElement : ConfigurationElement
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00023968 File Offset: 0x00021B68
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x0002397C File Offset: 0x00021B7C
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
