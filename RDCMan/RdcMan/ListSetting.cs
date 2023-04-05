using System;
using System.Collections.Generic;
using System.Xml;

namespace RdcMan
{
	public class ListSetting<T> : Setting<List<T>> where T : class
	{
		public ListSetting(object o) : base(o)
		{
			if (base.Value == null)
			{
				base.Value = new List<T>();
			}
		}

		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			List<T> list = new List<T>();
			foreach (object obj in xmlNode.ChildNodes)
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				if (xmlNode2.Name != "item")
				{
					throw new Exception();
				}
				list.Add(xmlNode2.InnerText as T);
			}
			base.Value = list;
		}

		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			foreach (T t in base.Value)
			{
				tw.WriteElementString("item", t.ToString());
			}
		}

		private const string XmlNodeName = "item";
	}
}
