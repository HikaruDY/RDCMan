using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	// Token: 0x02000192 RID: 402
	public class DisplaySizeElementCollection : ConfigurationElementCollection
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000044A3 File Offset: 0x000026A3
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.AddRemoveClearMap;
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000085DE File Offset: 0x000067DE
		public DisplaySizeElement GetDisplaySize(int index)
		{
			return base.BaseGet(index) as DisplaySizeElement;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000085EC File Offset: 0x000067EC
		protected override ConfigurationElement CreateNewElement()
		{
			return new DisplaySizeElement();
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000085F3 File Offset: 0x000067F3
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((DisplaySizeElement)element).Size;
		}
	}
}
