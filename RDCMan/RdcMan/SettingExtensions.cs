using System;
using System.Collections.Generic;
using System.Reflection;

namespace RdcMan
{
	// Token: 0x020000E2 RID: 226
	public static class SettingExtensions
	{
		// Token: 0x0600080F RID: 2063 RVA: 0x0002229C File Offset: 0x0002049C
		public static void GetSettingProperties(this Type type, out Dictionary<string, SettingProperty> settingProperties)
		{
			settingProperties = new Dictionary<string, SettingProperty>(StringComparer.OrdinalIgnoreCase);
			foreach (PropertyInfo propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				object[] customAttributes = propertyInfo.GetCustomAttributes(typeof(SettingAttribute), false);
				if (customAttributes.Length == 1)
				{
					SettingAttribute settingAttribute = (SettingAttribute)customAttributes[0];
					settingProperties[settingAttribute.XmlName] = new SettingProperty
					{
						Property = propertyInfo,
						Attribute = settingAttribute
					};
				}
			}
		}
	}
}
