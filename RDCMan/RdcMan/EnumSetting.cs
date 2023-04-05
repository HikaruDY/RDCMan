using System;
using System.Xml;

namespace RdcMan
{
	public class EnumSetting<TEnum> : Setting<TEnum> where TEnum : struct
	{
		public EnumSetting(object o) : base(o)
		{
		}

		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			int num;
			if (int.TryParse(xmlNode.InnerText, out num))
			{
				base.Value = (TEnum)((object)num);
				return;
			}
			bool flag;
			if (bool.TryParse(xmlNode.InnerText, out flag))
			{
				base.Value = (TEnum)((object)(flag ? 1 : 0));
				return;
			}
			base.Value = (TEnum)((object)Enum.Parse(typeof(TEnum), xmlNode.InnerText));
		}

		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			TEnum value = base.Value;
			tw.WriteString(value.ToString());
		}
	}
}
