using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x020000F0 RID: 240
	public class DisplaySizeElementCollection : ConfigurationElementCollection
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00023990 File Offset: 0x00021B90
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.AddRemoveClearMap;
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00023994 File Offset: 0x00021B94
		public DisplaySizeElement GetDisplaySize(int index)
		{
			return base.BaseGet(index) as DisplaySizeElement;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000239A4 File Offset: 0x00021BA4
		protected override ConfigurationElement CreateNewElement()
		{
			return new DisplaySizeElement();
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000239AC File Offset: 0x00021BAC
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((DisplaySizeElement)element).Size;
		}
	}
}
