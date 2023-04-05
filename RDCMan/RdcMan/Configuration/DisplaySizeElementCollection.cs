using System;
using System.Configuration;

namespace RdcMan.Configuration
{
	public class DisplaySizeElementCollection : ConfigurationElementCollection
	{
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.AddRemoveClearMap;
			}
		}

		public DisplaySizeElement GetDisplaySize(int index)
		{
			return base.BaseGet(index) as DisplaySizeElement;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new DisplaySizeElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((DisplaySizeElement)element).Size;
		}
	}
}
