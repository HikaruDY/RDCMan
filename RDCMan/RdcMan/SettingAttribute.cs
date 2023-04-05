using System;

namespace RdcMan
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public class SettingAttribute : Attribute
	{
		public SettingAttribute(string xmlName)
		{
			this.XmlName = xmlName;
		}

		public string XmlName { get; set; }

		public object DefaultValue { get; set; }

		public bool IsObsolete { get; set; }
	}
}
